@echo off
echo PRESS ANY KEY TO INSTALL TO LOCAL NUGET FEED
echo Remember to generate the up-to-date package.
pause
c:\exe\nuget add .\Cadmus.Mat.Bricks\bin\Debug\Cadmus.Mat.Bricks.4.0.0.nupkg -source C:\Projects\_NuGet
c:\exe\nuget add .\Cadmus.Refs.Bricks\bin\Debug\Cadmus.Refs.Bricks.4.0.0.nupkg -source C:\Projects\_NuGet
pause
