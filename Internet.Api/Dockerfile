#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

RUN apt-get update && apt-get install -y supervisor

COPY ["Internet.Api/Internet.Api.csproj", "Internet.Api/"]
RUN dotnet restore "Internet.Api/Internet.Api.csproj"
COPY . .
WORKDIR "/src/Internet.Api"
RUN dotnet build "Internet.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Internet.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Internet.Api.dll"]