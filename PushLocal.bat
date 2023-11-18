@echo off
echo PRESS ANY KEY TO INSTALL TO LOCAL NUGET FEED
echo Remember to generate the up-to-date package.
c:\exe\nuget add .\Cadmus.Mat.Bricks\bin\Debug\Cadmus.Mat.Bricks.5.0.0.nupkg -source C:\Projects\_NuGet
c:\exe\nuget add .\Cadmus.Refs.Bricks\bin\Debug\Cadmus.Refs.Bricks.5.0.0.nupkg -source C:\Projects\_NuGet
pause
