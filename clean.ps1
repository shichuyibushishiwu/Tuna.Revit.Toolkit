Param(
    [string]$RootDir = $PSScriptRoot
)

$ErrorActionPreference = "Stop"

function Remove-DirectorySafely {
    <#
    .SYNOPSIS
    删除指定目录（若存在），并忽略锁定/权限错误
    .PARAMETER Path
    目标目录路径
    .OUTPUTS
    [bool] 是否成功删除或不存在
    #>
    Param(
        [Parameter(Mandatory=$true)][string]$Path
    )
    if (-not (Test-Path -LiteralPath $Path -PathType Container)) {
        return $true
    }
    try {
        Remove-Item -LiteralPath $Path -Recurse -Force -ErrorAction Stop
        return $true
    } catch {
        Write-Warning ("Failed to delete: {0} -> {1}" -f $Path, $_.Exception.Message)
        return $false
    }
}

function Clean-BinObj {
    <#
    .SYNOPSIS
    递归清理指定根目录下所有项目的 bin 与 obj 目录
    .PARAMETER Root
    清理的根目录
    .OUTPUTS
    无
    #>
    Param(
        [Parameter(Mandatory=$true)][string]$Root
    )
    Write-Host "==========================================" -ForegroundColor Cyan
    Write-Host "   Clean bin/obj Directories" -ForegroundColor Cyan
    Write-Host "==========================================" -ForegroundColor Cyan
    Write-Host ("Root: {0}" -f (Resolve-Path $Root))

    $targets = @('bin','obj')
    $found = Get-ChildItem -Path $Root -Recurse -Directory -ErrorAction SilentlyContinue |
        Where-Object { $targets -contains $_.Name }

    $total = ($found | Measure-Object).Count
    Write-Host ("Found {0} directories" -f $total) -ForegroundColor Green

    $success = 0
    $failed = 0
    foreach ($dir in $found) {
        $ok = Remove-DirectorySafely -Path $dir.FullName
        if ($ok) { $success++ } else { $failed++ }
    }

    Write-Host ("Deleted: {0}, Failed: {1}" -f $success, $failed) -ForegroundColor Green
    if ($failed -gt 0) {
        Write-Warning "Some directories could not be deleted. Close any processes locking files and retry."
    }
}

Clean-BinObj -Root $RootDir

