# AWS Lambda Net Core 2 by using CoreRT

Example for optimize cold start with Lambda Native

## Dependency

- https://github.com/dotnet/corert
- https://github.com/ifew/lambda-native/

## Step to implement

### 1. Add package LambdaNative

```bash
dotnet add package LambdaNative
```

### 2. Create file nuget.config and add nuget.org v3

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
 <packageSources>
    <clear />
    <add key="dotnet-core" value="https://dotnet.myget.org/F/dotnet-core/api/v3/index.json" />
    <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
 </packageSources>
</configuration>
```

### 3. Add package Microsoft.DotNet.ILCompiler

```bash
dotnet add package Microsoft.DotNet.ILCompiler -v 1.0.0-alpha-*
```

### 4. Add project type in .csproj

```cs
<PropertyGroup>
  <TargetFramework>netcoreapp2.1</TargetFramework>
  <OutputType>Exe</OutputType>
</PropertyGroup>
```

### 5. Build exe file with docker linix environment

```bash
docker build -t lambdanative .
docker run --rm lambdanative -v /Users/chitpong/Sourcecode/aws-lambda-lambdanative/src/aws-lambda-lambdanative/output:/output -e ASPNETCORE_ENVIRONMENT=Development lambdanative
```