@echo off
echo BUILD Packages
del .\Cadmus.Refs.Bricks\bin\Debug\*.*nupkg

cd .\Cadmus.Refs.Bricks
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

pause
