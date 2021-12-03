# Nuget restore
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY *.csproj
RUN dotnet restore
COPY . .

# testing
FROM build AS testing
WORKDIR /src
RUN dotnet build
WORKDIR /src
RUN dotnet test

# publish
FROM build AS publish
WORKDIR /src
RUN dotnet publish -c Release -o /src/publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "Colors.API.dll"]
# heroku uses the following
CMD ASPNETCORE_URLS=http://*:$PORT dotnet FPLForecaster.dll