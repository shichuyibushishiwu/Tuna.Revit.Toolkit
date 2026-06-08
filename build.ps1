param(
    [Parameter(Position = 0)]
    [int]$RevitVersion
)

$ErrorActionPreference = "Stop"
$rootDir = $PSScriptRoot
$nupkgsDir = Join-Path $rootDir "nupkgs"

Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "   Tuna.Revit.Toolkit Dev Build Script" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan

# 1. Prepare nupkgs directory
Write-Host "`n[1/7] Preparing nupkgs directory..." -ForegroundColor Green
if (!(Test-Path $nupkgsDir)) { 
    New-Item -ItemType Directory -Path $nupkgsDir | Out-Null 
}
# Remove old packages to avoid confusion
Get-ChildItem -Path $nupkgsDir -Filter "*.nupkg" | Remove-Item -Force -ErrorAction SilentlyContinue

# 2. Pack Runtime
Write-Host "`n[2/7] Packing Tuna.Runtime..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Runtime/Tuna.Runtime.csproj" -c Release
if ($LASTEXITCODE -ne 0) { throw "Failed to build Tuna.Runtime" }
dotnet pack "$rootDir/src/Tuna.Runtime/Tuna.Runtime.csproj" -c Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Runtime" }

# 3. Pack Extensions (Multiple Revit versions)
$extensionsProject = "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj"
$revitVersions = if ($PSBoundParameters.ContainsKey("RevitVersion")) {
    if ($RevitVersion -lt 16 -or $RevitVersion -gt 26) {
        throw "Invalid RevitVersion: $RevitVersion. Allowed range: 16..27"
    }
    @($RevitVersion)
} else {
    16..26
}
foreach ($revitVersion in $revitVersions) {
    $configuration = "Rvt_${revitVersion}_Release"
    Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt $revitVersion)..." -ForegroundColor Green
    dotnet build $extensionsProject -c $configuration
    if ($LASTEXITCODE -ne 0) { throw "Failed to build Tuna.Revit.Extensions ($configuration)" }
    dotnet pack $extensionsProject -c $configuration --no-build -o $nupkgsDir
    if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions ($configuration)" }
}

# 4. Pack Infrastructure
Write-Host "`n[4/7] Packing Tuna.Revit.Infrastructure..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Infrastructure/Tuna.Revit.Infrastructure.csproj" -c Release
if ($LASTEXITCODE -ne 0) { throw "Failed to build Tuna.Revit.Infrastructure" }
dotnet pack "$rootDir/src/Tuna.Revit.Infrastructure/Tuna.Revit.Infrastructure.csproj" -c Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Infrastructure" }

# 5. Pack Template
Write-Host "`n[5/7] Packing Tuna.Revit.Application.Template..." -ForegroundColor Green
dotnet pack "$rootDir/template/pack/Tuna.Revit.Application.Template.csproj" -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Application.Template" }

# 6. Test Build Content Project (Validation)
Write-Host "`n[6/7] Validating Template Content Project..." -ForegroundColor Green
# Restore using local source
dotnet restore "$rootDir/template/content/Tuna.Revit.Template/Tuna.Revit.Template.csproj" -p:Configuration=Rvt_24_Debug --no-cache -s $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to restore Template Content Project" }

dotnet build "$rootDir/template/content/Tuna.Revit.Template/Tuna.Revit.Template.csproj" -c Rvt_24_Debug --no-restore
if ($LASTEXITCODE -ne 0) { throw "Failed to build Template Content Project" }

# 7. Reinstall Template
Write-Host "`n[7/7] Reinstalling Template..." -ForegroundColor Green
$templatePackage = Get-ChildItem -Path $nupkgsDir -Filter "Tuna.Revit.Application.Template.*.nupkg" | Select-Object -First 1

if ($templatePackage) {
    # Uninstall if exists (allow failure if not found)
    Write-Host "Uninstalling old version (if any)..." -ForegroundColor Gray
    try {
        $proc = Start-Process -FilePath "dotnet" -ArgumentList "new", "uninstall", "Tuna.Revit.Application.Template" -PassThru -NoNewWindow -Wait
    } catch {
        # Ignore errors during uninstall
    }
    
    # Install new version
    Write-Host "Installing new version..." -ForegroundColor Cyan
    dotnet new install $templatePackage.FullName
} else {
    Write-Warning "Template package not found!"
}

Write-Host "`n==========================================" -ForegroundColor Cyan
Write-Host "   Build & Install Succeeded!" -ForegroundColor Cyan
Write-Host "==========================================" -ForegroundColor Cyan
Write-Host "Local NuGet Source: $nupkgsDir"
Write-Host "Try creating a project: dotnet new tuna-revit-app -n MyTestApp"
