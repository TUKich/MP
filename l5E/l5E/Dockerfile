FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l5E/l5E.csproj", "l5E/"]
RUN dotnet restore "l5E/l5E.csproj"
COPY . .
WORKDIR "/src/l5E"
RUN dotnet build "l5E.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l5E.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l5E.dll"]
