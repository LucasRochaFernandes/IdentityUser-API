
# ASP .NET Project with Identity Implementation

## Overview

This project uses **ASP.NET Core** to implement user authentication and authorization with **Identity**. Authentication is based on **JWT tokens**, securing routes and ensuring application safety.

---

## Features

- User registration and authentication with **ASP.NET Identity**.
- Generation of **JWT tokens** to secure routes.
- Integration with PostgreSQL database via **Entity Framework Core**.

---

## Project Structure

- **Controllers**: Controllers responsible for API endpoints (e.g., `UserController.cs`).
- **Services**: Contains the authentication logic (`LogInService.cs`) and user registration logic (`RegisterUserService.cs`).
- **Database**: Manages entities and the database context (`ApplicationDbContext.cs`).
- **Docker**: `docker-compose.yml` file to create the PostgreSQL container.

---

## Technologies

- **ASP.NET Core**
- **Entity Framework Core**
- **ASP.NET Identity**
- **JWT (JSON Web Token)**
- **PostgreSQL**
- **Docker**

---

## Setup and Execution

1. **Database**: Run the command below to create the PostgreSQL container:
   ```bash
   docker-compose up -d
   ```
2. **Configuration**: Update the **Connection String** in `appsettings.json` with the container details.
3. **Migrations**: Apply migrations:
   ```bash
   dotnet ef database update
   ```
4. **Start the API**: Run the application:
   ```bash
   dotnet run
   ```

---

## Testing the API

- **User Registration**: `POST /api/user/register`
- **Login**: `POST /api/user/login`
  - Generates a **JWT token** for access to protected routes.
- Use tools like **Postman** or the `IdentityUser.Api.http` file to test.

---

## Future Improvements

- Integration with external providers (Google, Facebook).
- Advanced authorization policies and specific user roles.

---
