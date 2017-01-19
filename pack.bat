@echo off
cd .nuget
nuget update /self
NuGet.exe pack FontAwesomeNet.nuspec
cd ..