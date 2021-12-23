FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l6E/l6E.csproj", "l6E/"]
RUN dotnet restore "l6E/l6E.csproj"
COPY . .
WORKDIR "/src/l6E"
RUN dotnet build "l6E.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l6E.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l6E.dll"]
