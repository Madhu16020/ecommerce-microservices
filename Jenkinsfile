pipeline {
    agent any

    stages {

        stage('Build Docker Image') {
            steps {
                sh 'docker build --no-cache -t productservice ./ProductService'
            }
        }

        stage('Stop Old Container') {
            steps {
                sh '''
                docker stop productservice || true
                docker rm productservice || true
                '''
            }
        }

        stage('Run New Container') {
            steps {
                sh '''
                docker run -d \
                --name productservice \
                --restart always \
                -p 5001:8080 \
                productservice
                '''
            }
        }
    }
}
