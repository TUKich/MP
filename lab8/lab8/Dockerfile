FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab8/lab8.csproj", "lab8/"]
RUN dotnet restore "lab8/lab8.csproj"
COPY . .
WORKDIR "/src/lab8"
RUN dotnet build "lab8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab8.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab8.dll"]
