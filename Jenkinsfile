pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
				dotnetRestore project: 'formula_proj.csproj', workDirectory: './formula/formula_proj/'
			}
		}
		stage('Build') {
            steps {
                dotnetBuild project: 'formula_proj.csproj', workDirectory: './formula/formula_proj/' 
            }
        }
		stage('Test') {
            steps {
                sh '''mv $( dotnet test --collect:"XPlat Code Coverage" -o TestResults ./formula/formula.sln | grep cobertura.xml ) ./formula/formula_tests/lastlog.cobertura.xml'''
            }
        }
		stage('Publish') {
            steps {
                cobertura autoUpdateHealth: false, autoUpdateStability: false, coberturaReportFile: '**/lastlog.cobertura.xml', conditionalCoverageTargets: '70, 0, 0', failUnhealthy: false, failUnstable: false, lineCoverageTargets: '80, 0, 0', maxNumberOfBuilds: 0, methodCoverageTargets: '80, 0, 0', onlyStable: false, sourceEncoding: 'ASCII', zoomCoverageChart: false
            }
        }
	}
}

