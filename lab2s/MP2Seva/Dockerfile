FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MP2Seva/MP2Seva.csproj", "MP2Seva/"]
RUN dotnet restore "MP2Seva/MP2Seva.csproj"
COPY . .
WORKDIR "/src/MP2Seva"
RUN dotnet build "MP2Seva.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MP2Seva.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MP2Seva.dll"]
