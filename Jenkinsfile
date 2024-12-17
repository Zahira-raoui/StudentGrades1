pipeline {
    agent any

    environment {
        DOCKER_IMAGE = "demoapp:latest"
    }

    stages {
        stage('Clone repository') {
            steps {
                echo "Clonage du code source depuis Git"
                git branch: 'master', url: 'https://github.com/Zahira-raoui/StudentGrades1'
            }
        }

        stage('Build application') {
            steps {
                echo "Compilation de l'application"
                sh 'dotnet restore'
                sh 'dotnet build --configuration Release'
            }
        }

        stage('Run Unit Tests') {
            steps {
                echo "Exécution des tests unitaires"
                sh 'dotnet test --configuration Release --no-build'
            }
        }

        stage('Dockerize Application') {
            steps {
                echo "Création de l'image Docker"
                sh '''
                docker build -t $DOCKER_IMAGE .
                docker images
                '''
            }
        }
    }

    post {
        success {
            echo "Pipeline terminé avec succès !"
        }
        failure {
            echo "Pipeline échoué. Vérifiez les logs."
        }
    }
}
