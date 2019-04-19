#!/bin/bash

#
# SHOULD BUILD IMAGE BEFORE
# docker build -t lambdanative .
#

rm -f bootstrap
rm -f package.zip
docker run --rm -v $(pwd)/output:/app/out lambdanative
cd output
cp aws-lambda-lambdanative bootstrap
zip package.zip bootstrap