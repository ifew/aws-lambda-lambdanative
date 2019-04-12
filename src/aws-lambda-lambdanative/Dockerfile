FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app
COPY . ./

RUN apt-get update && apt-get install clang-3.9 libcurl4-openssl-dev zlib1g-dev libkrb5-dev -y

RUN dotnet publish -c Release -o out -r linux-x64

FROM microsoft/dotnet:2.2-sdk
WORKDIR /app
COPY --from=build-env /app/out ./
RUN mkdir /output
RUN cp bin/Release/netcoreapp2.2/linux-x64/native/* output/bootstrap
#ENTRYPOINT ["sh", "build.sh"]