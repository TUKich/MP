FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l6u/l6u.csproj", "l6u/"]
RUN dotnet restore "l6u/l6u.csproj"
COPY . .
WORKDIR "/src/l6u"
RUN dotnet build "l6u.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l6u.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l6u.dll"]
