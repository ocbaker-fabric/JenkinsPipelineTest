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
		bat 'nuget restore JenkinsPipelineTest.sln'
        bat "\"${tool 'MSBuild'}\\msbuild.exe\" \"JenkinsPipelineTest.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
      }
    }
    stage('Archive') {
      steps {
        archiveArtifacts 'JenkinsPipelineTest\\bin'
      }
    }
  }
}