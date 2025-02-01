# Base runtime image
FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy project files and restore dependencies
COPY ["FirstMapper/FirstMapper.csproj", "FirstMapper/"]
COPY ["FirstMapper.Tests/FirstMapper.Tests.csproj", "FirstMapper.Tests/"]
RUN dotnet restore "FirstMapper/FirstMapper.csproj"
RUN dotnet restore "FirstMapper.Tests/FirstMapper.Tests.csproj"

# Copy everything and build the solution
COPY . .
WORKDIR "/src/FirstMapper"
RUN dotnet build "FirstMapper.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish application
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FirstMapper.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Test stage (optional)
FROM build AS test
WORKDIR /src/FirstMapper.Tests
CMD ["dotnet", "test", "--logger:console"]

# Final runtime stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FirstMapper.dll"]
