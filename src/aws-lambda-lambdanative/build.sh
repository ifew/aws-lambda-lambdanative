#!/bin/bash

dotnet publish -r linux-x64 -c Release
cp bin/Release/netcoreapp2.2/linux-x64/native/* bootstrap
# zip package.zip bootstrap
# aws s3 cp package.zip s3://<bucket>/package.zip