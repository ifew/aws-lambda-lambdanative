# AWS Lambda Net Core 2 by using CoreRT

Example for optimize cold start with Lambda Native

## Dependency

- https://github.com/dotnet/corert
- https://github.com/ifew/lambda-native/

## Step to setup

### Build file and packing to output/package.zip

```bash
sh build.sh
```

### upload to aws s3

```bash
cd output
aws s3 cp package.zip s3://backend-layer [--profile AWS-PROFILE-NAME]
```

### go to lambda page and upload via s3 url