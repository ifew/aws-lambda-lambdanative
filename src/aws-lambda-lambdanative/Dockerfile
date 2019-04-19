# docker build -t lambdanative .
# docker run --rm -v $(pwd)/output:/app/out lambdanative

FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app
COPY . ./
RUN apt-get update && apt-get install clang-3.9 libcurl4-openssl-dev zlib1g-dev libkrb5-dev -y
ENTRYPOINT ["dotnet", "publish", "-c", "Release", "-o", "out", "-r", "linux-x64"]
