# Çalışma zamanı için resmi ASP.NET 8 imajı
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build ve publish için SDK imajı
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Proje dosyasını kopyala ve restore yap
COPY ["Ravioli.csproj", "./"]
RUN dotnet restore "Ravioli.csproj"

# Geri kalan dosyaları kopyala ve build et
COPY . .
RUN dotnet build "Ravioli.csproj" -c Release -o /app/build

# Publish aşaması
FROM build AS publish
RUN dotnet publish "Ravioli.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final imaj
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ravioli.dll"]
