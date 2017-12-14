pipeline {
  agent any
  stages {
    stage('Message') {
      steps {
        echo 'Building Software'
        bat(script: 'dir', returnStatus: true, returnStdout: true)
      }
    }
    stage('Build') {
      steps {
        bat(script: "\"${tool 'MSBuild'}\\msbuild.exe\" \"JenkinsPipelineTest.sln\" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}", returnStatus: true, returnStdout: true)
      }
    }
    stage('Archive') {
      steps {
        archiveArtifacts 'JenkinsPipelineTest\\bin'
      }
    }
  }
}