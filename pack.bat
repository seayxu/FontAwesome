@echo off
cd .nuget
@rem NuGet.exe update /self
NuGet.exe pack FontAwesomeNet.nuspec
cd ..