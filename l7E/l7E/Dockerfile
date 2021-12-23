FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l7E/l7E.csproj", "l7E/"]
RUN dotnet restore "l7E/l7E.csproj"
COPY . .
WORKDIR "/src/l7E"
RUN dotnet build "l7E.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l7E.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l7E.dll"]
