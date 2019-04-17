#!/bin/bash

dotnet publish -r linux-x64 -c Release
cp bin/Release/netcoreapp2.2/linux-x64/native/* output/bootstrap
zip output/package.zip output/bootstrap
aws s3 cp output/package.zip s3://backend-layer
