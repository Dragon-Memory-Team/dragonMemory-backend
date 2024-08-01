# Build Stage

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
#....
COPY ["Backend/*.csproj", "./"]
RUN dotnet restore
COPY . .

RUN dotnet publish -c release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "Backend.dll"]

# Serve Stage