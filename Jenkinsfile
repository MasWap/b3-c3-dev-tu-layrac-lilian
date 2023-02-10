pipeline {
    agent any
    stages {
        stage('Checkout') {
            steps {
                checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[url: 'https://github.com/MasWap/b3-c3-dev-tu-layrac-lilian/.git']]])
            }
        }
        stage('Build') {
            steps {
                sh 'dotnet build'
            }
        }
        stage('Test') {
            steps {
                sh 'dotnet test'
            }
        }
        stage('Publish') {
            steps {
                sh 'dotnet publish -c Release -o publish'
            }
        }
    }
}
