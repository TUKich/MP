FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab6/lab6.csproj", "lab6/"]
RUN dotnet restore "lab6/lab6.csproj"
COPY . .
WORKDIR "/src/lab6"
RUN dotnet build "lab6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab6.dll"]
