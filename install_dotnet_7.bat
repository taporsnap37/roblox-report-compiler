@echo off

echo Installing .NET 7.0.5...

REM Download the .NET 7 installer for 64-bit
curl -sSL https://download.visualstudio.microsoft.com/download/pr/89a2923a-18df-4dce-b069-51e687b04a53/9db4348b561703e622de7f03b1f11e93/dotnet-sdk-7.0.203-win-x64.exe -o dotnet-sdk-7.0.203-win-x64.exe

REM Install .NET 7
start /wait dotnet-sdk-7.0.203-win-x64.exe /install /quiet /norestart

REM Verify that .NET 7 was installed successfully
dotnet --version | findstr 7.0

if %errorlevel% neq 0 (
    echo Error: .NET 7 installation failed.
) else (
    echo .NET 7 installed successfully.
)

REM Remove the installer file
del dotnet-sdk-7.0.203-win-x64.exe

echo Download complete!
pause