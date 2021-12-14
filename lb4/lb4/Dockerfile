FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lb4/lb4.csproj", "lb4/"]
RUN dotnet restore "lb4/lb4.csproj"
COPY . .
WORKDIR "/src/lb4"
RUN dotnet build "lb4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lb4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lb4.dll"]
