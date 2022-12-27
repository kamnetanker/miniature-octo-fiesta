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
                publishCoverage adapters: [cobertura('./formula/formula_tests/lastlog.cobertura.xml')], checksName: '', sourceFileResolver: sourceFiles('NEVER_STORE')
            }
        }
	}
}

