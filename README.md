# .Net-SQLite-database-API
API developed in C# .NET with an SQLite database

## Overview

This project is a Todo API developed in C# using the .NET framework. It utilizes an SQLite database to manage user data and store todo information. The API is built on top of the Microsoft ASP.NET Core framework and provides endpoints for managing users (admins) and todo items.

## Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/) - The project was developed using Visual Studio.
- [Microsoft.AspNetCore.Cors](https://www.nuget.org/packages/Microsoft.AspNetCore.Cors) - Package for enabling Cross-Origin Resource Sharing (CORS).
- [Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) - Package for Entity Framework Core.
- [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite) - SQLite database provider for Entity Framework Core.
- [Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer) - SQL Server database provider for Entity Framework Core.
- [Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools) - Package containing tools for Entity Framework Core.

## Getting Started

1. Clone the repository to your local machine.

```bash
git clone https://github.com/your-username/todo-api.git
```

2. Open the project in Visual Studio.

3. Run the project, and the Swagger UI will pop up.

## Database Configuration

The API uses Entity Framework Core to interact with the database. The database configuration can be found in the `appsettings.json` file.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=sqlite.db"
  },
  // ... other configurations
}
```

In this example, the SQLite database is named `sqlite.db`. You can modify the connection string to use a different database or server.

## Endpoints

### Users (Admins)

- `GET /api/users`: Get a list of all users (admins).
- `GET /api/users/{id}`: Get details of a specific user by ID.
- `POST /api/users`: Create a new user (admin).


### Todo

- `GET /api/todo`: Get a list of all todo items.
- `GET /api/todo/{id}`: Get details of a specific todo item by ID.
- `POST /api/todo`: Create a new todo item.
- `PUT /api/todo/{id}`: Update details of a specific todo item by ID.
- `DELETE /api/todo/{id}`: Delete a todo item by ID.

## Testing

The Swagger UI provides an interactive interface for testing the API. You can access it by running the project and navigating to `/swagger` in your web browser.

## License

This project is licensed under the [MIT License](LICENSE).
