@echo off
echo BUILD Packages
del .\Cadmus.Mat.Bricks\bin\Debug\*.*nupkg
del .\Cadmus.Refs.Bricks\bin\Debug\*.*nupkg

cd .\Cadmus.Mat.Bricks
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

cd .\Cadmus.Refs.Bricks
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

pause
