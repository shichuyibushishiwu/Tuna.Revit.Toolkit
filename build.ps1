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
# Build first to ensure binaries exist, then pack without build
Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 16)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_16_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_16_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 17)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_17_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_17_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 18)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_18_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_18_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 19)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_19_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_19_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 20)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_20_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_20_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 21)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_21_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_21_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 22)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_22_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_22_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 23)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_23_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_23_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 24)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_24_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_24_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 25)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_25_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_25_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

Write-Host "`n[3/7] Packing Tuna.Revit.Extensions (Rvt 26)..." -ForegroundColor Green
dotnet build "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_26_Release
dotnet pack "$rootDir/src/Tuna.Revit.Extensions/Tuna.Revit.Extensions.csproj" -c Rvt_26_Release --no-build -o $nupkgsDir
if ($LASTEXITCODE -ne 0) { throw "Failed to pack Tuna.Revit.Extensions" }

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
