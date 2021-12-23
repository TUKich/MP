FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["l5u/l5u.csproj", "l5u/"]
RUN dotnet restore "l5u/l5u.csproj"
COPY . .
WORKDIR "/src/l5u"
RUN dotnet build "l5u.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "l5u.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "l5u.dll"]
