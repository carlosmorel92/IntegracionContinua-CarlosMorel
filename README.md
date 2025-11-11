# Implementación del Proceso de Integración Continua

**Alumno:** Carlos Alfredo Morel (2023-1869)  
**Asignatura:** Electiva 2  
**Profesor:** Francis Ramirez  
**Fecha de entrega:** 2025-11-10

## Descripción
Implementación completa de un pipeline de Integración Continua con GitHub Actions para compilar y ejecutar pruebas unitarias de un proyecto .NET (xUnit).

## Estructura del repositorio
- `.github/workflows/dotnet-ci.yml` - Workflow de CI (restaurar, compilar, test y subir resultados)
- `sample_solution/` - Solución de ejemplo (.sln), proyecto y pruebas

## Cómo probar localmente
```bash
cd sample_solution
dotnet restore SampleCiSolution.sln
dotnet build SampleCiSolution.sln -c Release
dotnet test tests/Project.Tests/Project.Tests.csproj --logger "trx;LogFileName=TestResults.trx" --results-directory ./TestResults
```

## Cómo usar en GitHub
1. Sube todo el contenido de este repositorio a GitHub.
2. Asegúrate de que el archivo `.github/workflows/dotnet-ci.yml` esté en la raíz del repositorio.
3. Crea una rama `feature/mi-cambio` y abre un Pull Request hacia `develop` (o `qa`/`master`). El workflow se ejecutará automáticamente.
4. Los artefactos de prueba (TRX) quedarán disponibles en la pestaña **Actions > Run > Artifacts**.
