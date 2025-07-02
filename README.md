This is a RESTful Web API built using ASP.NET Core, Entity Framework Core, and CORS support. It handles patient data operations in the Pill-eHealth system.

Key Features:
GET all patients
Returns a list of all patients in the system.

GET patient by ID or MSISDN
Fetches individual patient records by unique system ID or mobile number.

POST new patient
Adds a new patient record to the database.

PUT update patient
Updates existing patient data.

DELETE patient
Deletes a patient by their system-assigned ID.

Technologies Used:
ASP.NET Core Web API (Microsoft.AspNetCore.Mvc)

Entity Framework Core (Microsoft.EntityFrameworkCore)

DTO pattern for clean data handling

CORS configuration for cross-origin API access

Async database operations for performance
