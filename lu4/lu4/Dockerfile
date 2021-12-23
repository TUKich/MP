FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lu4/lu4.csproj", "lu4/"]
RUN dotnet restore "lu4/lu4.csproj"
COPY . .
WORKDIR "/src/lu4"
RUN dotnet build "lu4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lu4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lu4.dll"]
