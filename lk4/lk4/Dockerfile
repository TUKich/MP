FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lk4/lk4.csproj", "lk4/"]
RUN dotnet restore "lk4/lk4.csproj"
COPY . .
WORKDIR "/src/lk4"
RUN dotnet build "lk4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lk4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lk4.dll"]
