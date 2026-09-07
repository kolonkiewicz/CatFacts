# Cat Facts

ASP.NET Core MVC application that retrieves random cat facts from the Cat Facts API.

## Features

- Fetch random cat facts from catfact.ninja
- Store facts in SQL Server
- Append fetched facts to a local TXT file
- Browse fact history
- Search and filter facts
- Pagination
- Fact details
- Statistics

## Technologies

- C#
- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- REST API

## Run

Configure the SQL Server connection string in appsettings.json, then run:

dotnet ef database update

dotnet run
