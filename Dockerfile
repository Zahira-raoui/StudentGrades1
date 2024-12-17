# Utiliser une image de base contenant .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

# Définir le répertoire de travail
WORKDIR /app

# Copier les fichiers de l'application dans l'image Docker
COPY . ./

# Restaurer les dépendances
RUN dotnet restore

# Construire l'application
RUN dotnet build --configuration Release

# Publier l'application
RUN dotnet publish --configuration Release --output /app/publish

# Utiliser une image d'exécution de .NET
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base

# Définir le répertoire de travail pour l'exécution
WORKDIR /app

# Copier les fichiers publiés dans le conteneur
COPY --from=build /app/publish .

# Définir le point d'entrée de l'application
ENTRYPOINT ["dotnet", "StudentGrades.dll"]
