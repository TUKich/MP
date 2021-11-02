FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["mp3s/mp3s.csproj", "mp3s/"]
RUN dotnet restore "mp3s/mp3s.csproj"
COPY . .
WORKDIR "/src/mp3s"
RUN dotnet build "mp3s.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "mp3s.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "mp3s.dll"]
