# getting started

install dot.net and use ASP.NET Core Web API 

```powershell
   winget install Microsoft.DotNet.SDK.8
   
   # dotnet add package Microsoft.EntityFrameworkCore
```

test build and run

```powershell
   cd src/backend
   dotnet build
   dotnet run
```

Database

```powershell
   choco install sqlite
   # cd src/backend/
   # dotnet add package Microsoft.EntityFrameworkCore.Sqlite
```





