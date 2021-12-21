FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab5/lab5.csproj", "lab5/"]
RUN dotnet restore "lab5/lab5.csproj"
COPY . .
WORKDIR "/src/lab5"
RUN dotnet build "lab5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab5.dll"]
