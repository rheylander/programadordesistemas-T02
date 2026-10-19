param([string]$ApplicationPath = (Join-Path $PSScriptRoot '..\bin\Release\MapaDeAssentos.exe'))
$ErrorActionPreference = 'Stop'
$ApplicationPath = (Resolve-Path -LiteralPath $ApplicationPath).Path
$cscPath = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
$testDirectory = Join-Path ([System.IO.Path]::GetTempPath()) ([Guid]::NewGuid().ToString())
New-Item -ItemType Directory -Path $testDirectory | Out-Null
$executable = Join-Path $testDirectory 'MapaFormTests.exe'
$applicationCopy = Join-Path $testDirectory 'MapaDeAssentos.exe'
try {
    Copy-Item -LiteralPath $ApplicationPath -Destination $applicationCopy
    & $cscPath /nologo /platform:anycpu /r:System.Windows.Forms.dll /r:System.Drawing.dll "/r:$applicationCopy" "/out:$executable" (Join-Path $PSScriptRoot 'MapaFormTests.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Falha ao compilar testes do formulario.' }
    & $executable
    if ($LASTEXITCODE -ne 0) { throw 'Testes do formulario falharam.' }
} finally {
    Remove-Item -LiteralPath $executable -Force -ErrorAction SilentlyContinue
    Remove-Item -LiteralPath $applicationCopy -Force -ErrorAction SilentlyContinue
    Remove-Item -LiteralPath $testDirectory -ErrorAction SilentlyContinue
}
