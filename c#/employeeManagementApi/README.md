# Employee Management API

## Description

The **Employee Management API** is a web-based application developed using .NET and Entity Framework Core. It enables users to manage employee records, including creating, reading, updating, and deleting employees. Additionally, the API maintains logs of all changes made to employee records for auditing purposes. The API is designed to facilitate efficient management of employee data within organizations.

## Interaction with the API

Interact with the API using **Swagger**. After running the application, navigate to `/swagger` in your browser to access the Swagger UI, where you can explore and test all available endpoints interactively.

## Database

This application uses a **Supabase PostgreSQL** database to store employee and log data. Ensure that your connection string is configured properly in the `.env` file, and migrations are applied to update the database schema. The schema used for this project is `hr_system`.

## Model Schemas

### Employee

```json
{
  "id": 0,
  "name": "string",
  "address": "string",
  "extension": "string",
  "workEmail": "string",
  "department": "string",
  "salary": 0.00,
  "hireDate": "2022-06-08T01:31:07.056Z"
}
```

### Employee Log

```json
{
  "id": 0,
  "partitionKey": "string",
  "rowKey": "string",
  "timestamp": "2022-06-08T01:31:07.056Z",
  "actionType": "Created | Updated | Deleted",
  "name": "string",
  "address": "string",
  "extension": "string",
  "workEmail": "string",
  "department": "string",
  "salary": 0.00,
  "hireDate": "2022-06-08T01:31:07.056Z"
}
```

### Logs

Logs are automatically created when any employee data is modified.