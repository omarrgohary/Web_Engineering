# Course Management System API

## Description

This project is a secure ASP.NET Core Web API for managing students, instructors, courses, and enrollments.
It implements authentication, authorization, DTO validation, and optimized database queries using Entity Framework Core with MySQL.

---

## Technologies Used

### 1. ASP.NET Core Web API

Framework used to build RESTful APIs.

### 2. Entity Framework Core

ORM used to interact with the database using C# instead of SQL.

### 3. MySQL

Relational database used to store application data.

### 4. Pomelo.EntityFrameworkCore.MySql

Provider used to connect EF Core with MySQL.

### 5. JWT Authentication

Used to securely authenticate users using tokens.

### 6. Swagger (OpenAPI)

Used to document and test API endpoints.

### 7. BCrypt

Used to hash passwords securely before storing them.

---

## How to Run the Project

1. Open the project in Visual Studio
2. Create a MySQL database:

   ```
   CREATE DATABASE course_management_db;
   ```
3. Update connection string in `appsettings.json`
4. Run:

   ```
   Add-Migration InitialCreate
   Update-Database
   ```
5. Run the project
6. Open Swagger:

   ```
   https://localhost:7089/swagger
   ```

---

## Authentication

* Login using:

  ```
  POST /api/Auth/login
  ```
* Example:

  ```json
  {
    "email": "admin@test.com",
    "password": "Admin123"
  }
  ```
* Copy the token and use:

  ```
  Authorization: Bearer TOKEN
  ```

---

## Why HTTP-Only Cookies Are Used

HTTP-only cookies are commonly used because they cannot be accessed by JavaScript.
This protects authentication tokens from XSS (Cross-Site Scripting) attacks, making them more secure than storing tokens in local storage.

---

## Example Admin Account

* Email: [admin@test.com](mailto:admin@test.com)
* Password: Admin123

---

## API Endpoints

### Auth

* POST /api/Auth/login

### Students

* GET /api/Students
* POST /api/Students
* PUT /api/Students/{id}
* DELETE /api/Students/{id}

### Courses

* GET /api/Courses
* POST /api/Courses

### Instructors

* GET /api/Instructors
* POST /api/Instructors

### Enrollments

* GET /api/Enrollments
* POST /api/Enrollments
