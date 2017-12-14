pipeline {
  agent any
  stages {
    stage('Message') {
      steps {
        echo 'Building Software'
        bat 'dir'
      }
    }
    stage('Build') {
      steps {
        bat 'nuget.exe restore JenkinsPipelineTest.sln'
        bat "\"${tool 'MSBuild'}\\msbuild.exe\" \"JenkinsPipelineTest.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
      }
    }
    stage('Archive') {
      parallel {
        stage('Archive') {
          steps {
            archiveArtifacts 'JenkinsPipelineTest\\bin\\Release\\*'
          }
        }
        stage('List Directory') {
          steps {
            bat 'dir /s /b'
          }
        }
      }
    }
  }
}