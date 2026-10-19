$ErrorActionPreference = 'Stop'
$cscPath = Join-Path $env:WINDIR 'Microsoft.NET\Framework64\v4.0.30319\csc.exe'
if (!(Test-Path -LiteralPath $cscPath)) {
    $cscPath = Join-Path $env:WINDIR 'Microsoft.NET\Framework\v4.0.30319\csc.exe'
}
$testDirectory = Join-Path ([System.IO.Path]::GetTempPath()) ([Guid]::NewGuid().ToString())
New-Item -ItemType Directory -Path $testDirectory | Out-Null
$executable = Join-Path $testDirectory 'MapaCsvTests.exe'
try {
    & $cscPath /nologo "/out:$executable" (Join-Path $PSScriptRoot '..\MapaCsv.cs') (Join-Path $PSScriptRoot 'MapaCsvTests.cs')
    if ($LASTEXITCODE -ne 0) { throw 'Falha ao compilar testes.' }
    & $executable
    if ($LASTEXITCODE -ne 0) { throw 'Testes falharam.' }
} finally {
    Remove-Item -LiteralPath $executable -Force -ErrorAction SilentlyContinue
    Remove-Item -LiteralPath $testDirectory -ErrorAction SilentlyContinue
}

