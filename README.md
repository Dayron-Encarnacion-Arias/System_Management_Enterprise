# Enterprise Management System

A Windows desktop application built with C# and Windows Forms
for managing business records through a SQL Server database.

The project includes interfaces for users, roles, customers,
products, reports, and audit records.

## Features

- Login workflow backed by SQL Server stored procedures.
- Shared session information for the authenticated user.
- Role and permission lookup.
- User and role management.
- Customer and product management.
- Search and data maintenance interfaces.
- Reporting and audit log screens.
- Database access through ADO.NET and stored procedures.

## Tech Stack

- C#
- .NET Framework 4.8
- Windows Forms
- SQL Server
- ADO.NET / System.Data.SqlClient

## Code Organization

The application groups code into forms, data access,
authentication services, and models.

```text
SistemaGestionEmpresarial/
├── Data/          # SQL Server connection and query helpers
├── Formularios/   # Windows Forms screens
├── Modelos/       # Application models
├── Servicios/     # Authentication and permission services
├── Properties/    # Application resources and settings
├── Program.cs     # Application entry point
└── SesionGlobal.cs
```

Forms use database helpers to load and update records.
Authentication services call stored procedures to validate
credentials and retrieve role information.

## Requirements

- Windows
- Visual Studio with .NET desktop development support
- .NET Framework 4.8 targeting pack
- SQL Server
- The application's database schema and stored procedures

## Setup

1. Clone the repository:

```bash
git clone https://github.com/Dayron-Encarnacion-Arias/System_Management_Enterprise.git
cd System_Management_Enterprise
```

2. Open the solution in a compatible version of Visual Studio.
   Alternatively, open the project file directly:

```text
SistemaGestionEmpresarial/SistemaGestionEmpresarial.csproj
```

3. Restore NuGet packages.

4. Provision the SQL Server database with the required tables,
   stored procedures, roles, and initial user data.

5. Configure the connection string in:

```text
SistemaGestionEmpresarial/Data/ConexionBD.cs
```

The current configuration targets a local SQL Server instance
using Windows authentication:

```text
Server=.;Database=GestionEmpresarial;Integrated Security=true;
```

6. Build and run the application.

## Database Setup Status

The repository currently does not include the SQL scripts needed
to recreate the application's database.

Creating an empty database is not sufficient to run the application.
It requires the expected tables and stored procedures, including
authentication and permission procedures such as:

- `sp_ValidarUsuario`
- `sp_ObtenerPermisosPorRol`
- `sp_RegistrarLoginAuditoria`

A complete database setup script and sample data are needed
to make installation reproducible.

## Implementation Highlights

- Built desktop interfaces for business data management.
- Integrated SQL Server queries and stored procedure calls.
- Organized authentication logic into a dedicated service.
- Represented authenticated user information with an application model.
- Maintained user session information across application screens.

## Possible Improvements

- Include database creation scripts and sample data.
- Move the connection string into application configuration.
- Add automated tests.
- Further separate form logic from database operations.
- Add screenshots and a short demonstration video.

## Author

Dayron Encarnación Arias
