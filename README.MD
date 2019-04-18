# AWS Lambda Net Core 2 by using CoreRT

Example for optimize cold start with Lambda Native

## Dependency

- https://github.com/dotnet/corert
- https://github.com/ifew/lambda-native/

## Step to setup

### Run Unit test

```bash
cd test/aws-lambda-lambdanative.Tests
dotnet test
```

### Build file and packing to output/package.zip

```bash
sh build.sh
```

### Upload to aws s3

```bash
cd output
aws s3 cp package.zip s3://backend-layer [--profile AWS-PROFILE-NAME]
```

### Go to lambda page and choose upload via s3 url, runtime: custom, handler: up to you

![Setting](lambdabative-lambdapage-setting.png)

### Try to test

![Testing](lambdabative-lambdapage-test.png)

### Test Result

![Testing](lambdabative-lambdapage-test-result.png)