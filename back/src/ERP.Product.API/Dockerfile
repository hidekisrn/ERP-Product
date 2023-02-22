#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ERP.Product.API/ERP.Product.API.csproj", "src/ERP.Product.API/"]
COPY ["src/ERP.Product.Infrastructure/ERP.Product.Infrastructure.csproj", "src/ERP.Product.Infrastructure/"]
COPY ["src/ERP.Product.Domain/ERP.Product.Domain.csproj", "src/ERP.Product.Domain/"]
RUN dotnet restore "src/ERP.Product.API/ERP.Product.API.csproj"
COPY . .
WORKDIR "/src/src/ERP.Product.API"
RUN dotnet build "ERP.Product.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ERP.Product.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ERP.Product.API.dll"]
