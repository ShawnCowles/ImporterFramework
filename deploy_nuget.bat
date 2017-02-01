call "C:\Program Files (x86)\Microsoft Visual Studio 14.0\VC\vcvarsall.bat" x86_amd64

cd src\ImporterFramework

nuget pack ImporterFramework.csproj -Symbols -Build -Properties Configuration=Release;Platform=AnyCpu

nuget push *.nupkg -Source https://www.nuget.org/api/v2/package

del *.nupkg

echo "Deployment Complete"