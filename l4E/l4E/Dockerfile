FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l4E/l4E.csproj", "l4E/"]
RUN dotnet restore "l4E/l4E.csproj"
COPY . .
WORKDIR "/src/l4E"
RUN dotnet build "l4E.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l4E.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l4E.dll"]
