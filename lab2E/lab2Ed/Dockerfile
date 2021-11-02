FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["lab2Ed/lab2Ed.csproj", "lab2Ed/"]
RUN dotnet restore "lab2Ed/lab2Ed.csproj"
COPY . .
WORKDIR "/src/lab2Ed"
RUN dotnet build "lab2Ed.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lab2Ed.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lab2Ed.dll"]
