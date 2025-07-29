# Pill-eHealth Patient API

This is a RESTful Web API built with **ASP.NET Core** and **Entity Framework Core**, designed to manage patient records in the Pill-eHealth system. The API supports essential CRUD operations, follows the DTO pattern for data transfer, and includes CORS configuration for cross-origin access.

## Key Features

- **GET** `/patients`  
  Retrieves a list of all patients in the system.

- **GET** `/patients/{id}` or `/patients/by-msisdn/{msisdn}`  
  Fetches a patient by their system-assigned ID or mobile number (MSISDN).

- **POST** `/patients`  
  Adds a new patient record.

- **PUT** `/patients/{id}`  
  Updates an existing patient’s information.

- **DELETE** `/patients/{id}`  
  Deletes a patient using their system ID.

## Technologies Used

- **ASP.NET Core Web API** (`Microsoft.AspNetCore.Mvc`)
- **Entity Framework Core** (`Microsoft.EntityFrameworkCore`)
- **Data Transfer Objects (DTOs)** for structured data handling
- **CORS Configuration** to allow secure cross-origin API requests
- **Asynchronous operations** for efficient database access

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/your-repo-name.git
