# Course Management System API
<img width="1918" height="908" alt="image" src="https://github.com/user-attachments/assets/969e6eb9-db79-4489-8445-d6a997e18daa" />

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
<img width="917" height="420" alt="image" src="https://github.com/user-attachments/assets/65a4f227-b6d6-4a30-bcff-de4e8d26f57c" />



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
* <img width="1866" height="888" alt="image" src="https://github.com/user-attachments/assets/958c7667-610e-4ed9-8de0-025841247d67" />


### Students

* GET /api/Students
* <img width="1870" height="903" alt="image" src="https://github.com/user-attachments/assets/6d686b10-1ce8-4ad4-8f7b-8fe7b2df68a9" />

* GET /api/Students/{id}
<img width="1851" height="846" alt="image" src="https://github.com/user-attachments/assets/e5d8cddb-51b8-4b06-a259-2c5461299c70" />

* POST /api/Students
* <img width="1882" height="898" alt="image" src="https://github.com/user-attachments/assets/4369239a-572b-4ea8-a9c6-b76daab17751" />

* PUT /api/Students/{id}
* <img width="1796" height="776" alt="image" src="https://github.com/user-attachments/assets/bc55d9d8-81c9-43ba-819e-8dbd459f9b2a" />

* DELETE /api/Students/{id}
* <img width="1840" height="876" alt="image" src="https://github.com/user-attachments/assets/aaf4a73f-2d9a-4609-9ea2-8462097fe417" />


### Courses
* GET /api/Courses
<img width="1886" height="891" alt="image" src="https://github.com/user-attachments/assets/c3e66440-b0ee-4290-85a7-bf47bd8bff4e" />

* POST /api/Courses

* GET /api/Courses/{id}
* PUT /api/Courses/{id}
* DELETE /api/Courses/{id}

### Instructors

* GET /api/Instructors
<img width="1876" height="786" alt="image" src="https://github.com/user-attachments/assets/8b429f9e-f0b4-41e2-99e1-f32ee0389fb9" />

* POST /api/Instructors
<img width="1848" height="861" alt="image" src="https://github.com/user-attachments/assets/7f8c6fca-392c-4b37-ab97-0c92f2f2acae" />

* GET /api/Instructors/{id}
<img width="1840" height="737" alt="image" src="https://github.com/user-attachments/assets/63fb40c0-9d30-451d-8351-4717965b3315" />

* PUT/api/Instructors/{id}
<img width="1840" height="822" alt="image" src="https://github.com/user-attachments/assets/889d6693-9c4d-4902-8a99-658ded6dc6dc" />

* DELETE /api/Instructors/{id}
<img width="1896" height="888" alt="image" src="https://github.com/user-attachments/assets/e7fbe686-379b-48c6-a5d8-0c38e131fb17" />


### Enrollments

* GET /api/Enrollments
* POST /api/Enrollments
* DELETE /api/Enrollments/{studentId}/{courseId}
