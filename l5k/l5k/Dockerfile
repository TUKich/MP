FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l5k/l5k.csproj", "l5k/"]
RUN dotnet restore "l5k/l5k.csproj"
COPY . .
WORKDIR "/src/l5k"
RUN dotnet build "l5k.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l5k.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l5k.dll"]
