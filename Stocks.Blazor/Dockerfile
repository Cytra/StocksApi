#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Stocks.Blazor/Stocks.Blazor.csproj", "Stocks.Blazor/"]
COPY ["Stocks.Model/Stocks.Model.csproj", "Stocks.Model/"]
COPY ["Stocks.Core/Stocks.Core.csproj", "Stocks.Core/"]
COPY ["Stocks.Data/Stocks.Data.csproj", "Stocks.Data/"]
RUN dotnet restore "Stocks.Blazor/Stocks.Blazor.csproj"
COPY . .
WORKDIR "/src/Stocks.Blazor"
RUN dotnet build "Stocks.Blazor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Stocks.Blazor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Stocks.Blazor.dll"]