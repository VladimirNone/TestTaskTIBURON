
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestTaskTIBURON/*.csproj", "TestTaskTIBURON/"]
RUN dotnet restore "TestTaskTIBURON/TestTaskTIBURON.csproj"
COPY . .
WORKDIR "/src/TestTaskTIBURON"
RUN dotnet build "TestTaskTIBURON.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestTaskTIBURON.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestTaskTIBURON.dll"]