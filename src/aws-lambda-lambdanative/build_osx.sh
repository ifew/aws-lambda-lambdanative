#!/bin/bash

dotnet publish -r osx-x64 -c Release
cp bin/Release/netcoreapp2.2/linux-x64/native/* output/bootstrap
cd output
zip package.zip bootstrap