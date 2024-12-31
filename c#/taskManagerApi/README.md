# Task Manager API

## Description

The **Task Manager API** is a web-based application developed using .NET and Entity Framework Core. It enables users to create, read, update, and delete tasks, facilitating efficient organization and management of daily activities. The API offers various endpoints for comprehensive CRUD operations, ensuring seamless interaction with task data.

## Interaction with the API

Interact with the API using **Swagger**. After running the application, navigate to /swagger in your browser to access the Swagger UI, where you can explore and test all available endpoints interactively.

## Database

This application uses a **local PostgreSQL** database to store task data. Make sure PostgreSQL is installed and properly configured on your machine. Be sure to apply the migrations to update the database schema.

## Model Schema

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
