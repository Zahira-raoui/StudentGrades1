# Utiliser l'image officielle avec le SDK .NET 8.0
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Définir le répertoire de travail
WORKDIR /app

# Copier les fichiers du projet
COPY . ./

# Restaurer les dépendances
RUN dotnet restore

# Construire l'application en mode Release
RUN dotnet build --configuration Release --no-restore

# Publier l'application
RUN dotnet publish --configuration Release --output out

# Utiliser une image runtime pour exécuter l'application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Définir le point d'entrée
ENTRYPOINT ["dotnet", "StudentGrades.dll"]
