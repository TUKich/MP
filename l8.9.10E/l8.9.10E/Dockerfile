FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l8.9.10E/l8.9.10E.csproj", "l8.9.10E/"]
RUN dotnet restore "l8.9.10E/l8.9.10E.csproj"
COPY . .
WORKDIR "/src/l8.9.10E"
RUN dotnet build "l8.9.10E.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l8.9.10E.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l8.9.10E.dll"]
