FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["POC.CP.WebApi/POC.CP.WebApi.csproj", "POC.CP.WebApi/"]
RUN dotnet restore "POC.CP.WebApi/POC.CP.WebApi.csproj"
COPY . .
WORKDIR "/src/POC.CP.WebApi"
RUN dotnet build "POC.CP.WebApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "POC.CP.WebApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "POC.CP.WebApi.dll"]