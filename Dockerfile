# 멀티 스테이지를 통해 빌드와, 실행을 분리 함.
# builds our image using dotnet's sdk
#FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /source
COPY ./ ./webapp
WORKDIR /source/webapp
RUN dotnet restore
RUN dotnet publish -c release -o ./app "ErpBackend/ErpBackend.csproj" --no-restore 

# runs it using aspnet runtime
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
# FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
# WORKDIR /app
# COPY --from=build ./app ./
# EXPOSE 80
# ENTRYPOINT ["dotnet", "erp-system-backend.dll"]
