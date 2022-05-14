#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TelGuide.Guide/TelGuide.Guide.csproj", "TelGuide.Guide/"]
COPY ["TelGuide.Contracts/TelGuide.Contracts.csproj", "TelGuide.Contracts/"]
RUN dotnet restore "TelGuide.Guide/TelGuide.Guide.csproj"
COPY . .
WORKDIR "/src/TelGuide.Guide"
RUN dotnet build "TelGuide.Guide.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TelGuide.Guide.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TelGuide.Guide.dll"]