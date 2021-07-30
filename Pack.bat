@echo off
echo BUILD Packages
del .\Cadmus.Prosopa.Bricks\bin\Debug\*.*nupkg
del .\Cadmus.Refs.Bricks\bin\Debug\*.*nupkg

cd .\Cadmus.Refs.Bricks
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

cd .\Cadmus.Prosopa.Bricks
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

pause
