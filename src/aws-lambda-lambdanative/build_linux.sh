#!/bin/bash

#
# SHOULD BUILD IMAGE BEFORE
# docker build -t lambdanative:test .
#

rm -f $(pwd)/bootstrap
rm -f $(pwd)/package.zip
docker run --rm -v $(pwd):/app lambdanative
cp bin/Release/netcoreapp2.2/linux-x64/native/aws-lambda-lambdanative bootstrap
zip package.zip bootstrap
# aws s3 cp package.zip s3://backend-layer [--profile [PROFILE-NAME]]]