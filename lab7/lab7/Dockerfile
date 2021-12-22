FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab7/lab7.csproj", "lab7/"]
RUN dotnet restore "lab7/lab7.csproj"
COPY . .
WORKDIR "/src/lab7"
RUN dotnet build "lab7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab7.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab7.dll"]
