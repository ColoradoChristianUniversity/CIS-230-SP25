@echo off
cls
del *.nupkg
nuget pack template.nuspec -NoDefaultExcludes -Exclude *.nupkg 