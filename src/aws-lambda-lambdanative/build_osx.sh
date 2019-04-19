#!/bin/bash

#
# FOR TESTING BUILD, CAN'T USE DEPLOYMENT
# BECAUSE OSX BINARY NOT COMPLATIBLE FOR AWS LAMBDA
#

rm -f $(pwd)/bootstrap
rm -f $(pwd)/package.zip
dotnet publish -r osx-x64 -c Release
cp bin/Release/netcoreapp2.2/osx-x64/native/aws-lambda-lambdanative bootstrap
zip package.zip bootstrap