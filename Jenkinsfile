dotnetRestore project: 'formula_proj.csproj', workDirectory: './formula/formula_proj/'
dotnetBuild project: 'formula_proj.csproj', workDirectory: './formula/formula_proj/'
sh '''mv $( dotnet test --collect:"XPlat Code Coverage" -o TestResults ./formula/formula.sln | grep cobertura.xml ) ./formula/formula_tests/lastlog.cobertura.xml
'''
publishCoverage adapters: [cobertura('./formula/formula_tests/lastlog.cobertura.xml')], checksName: '', sourceFileResolver: sourceFiles('NEVER_STORE')