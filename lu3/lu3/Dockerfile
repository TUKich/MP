FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lu3/lu3.csproj", "lu3/"]
RUN dotnet restore "lu3/lu3.csproj"
COPY . .
WORKDIR "/src/lu3"
RUN dotnet build "lu3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lu3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lu3.dll"]
