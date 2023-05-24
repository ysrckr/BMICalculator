FROM mcr.microsoft.com/dotnet/runtime:6.0.16-alpine3.17 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0.408-alpine3.17 AS build
WORKDIR /src
COPY ["BMICalculator.Console/BMICalculator.Console.csproj", "BMICalculator.Console/"]
RUN dotnet restore "BMICalculator.Console/BMICalculator.Console.csproj"
COPY . .
WORKDIR "/src/BMICalculator.Console"
RUN dotnet build "BMICalculator.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BMICalculator.Console.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BMICalculator.Console.dll"]
