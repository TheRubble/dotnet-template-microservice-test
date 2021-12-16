FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY Barney.Microservice.csproj /src/Barney.Microservice.csproj
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /pub

FROM base AS final
WORKDIR /app
COPY --from=build /pub .
ENTRYPOINT ["dotnet", "Barney.Microservice.dll"]