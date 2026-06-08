param(
    [string]$SkillRoot = (Split-Path -Parent (Split-Path -Parent $MyInvocation.MyCommand.Path))
)

$required = @(
    "SKILL.md",
    "metadata.yaml",
    "examples",
    "templates",
    "scripts",
    "resources"
)

$missing = @()
foreach ($item in $required) {
    $path = Join-Path $SkillRoot $item
    if (-not (Test-Path $path)) { $missing += $item }
}

if ($missing.Count -gt 0) {
    Write-Host "Missing:" ($missing -join ", ")
    exit 1
}

Write-Host "OK"
