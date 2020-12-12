pipeline{
    agent any
    
    environment {
        dotnet ='C:\\Program Files (x86)\\dotnet\\'
        }
     
  stages {
    stage('Restore packages') {
        steps {
            bat "dotnet restore Solution1.sln"
        }
     }
    stage('Clean') {
        steps {
            bat "dotnet clean Solution1.sln"
        }
     }
    stage('Build') {
        steps {
            bat "dotnet build Solution1.sln --configuration Release"
        }
     }
    stage('Test') {
        steps {
           echo "Testing.."
        }
     }
  }
  
  
 }
