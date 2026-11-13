# Veracode Demo Application

This is an ASP.NET Core demo application that showcases various helper classes and services.

## Structure

The application includes the following helper classes:

- **APIHelper.cs** - Handles API calls and HTTP operations
- **EncryptionHelper.cs** - Provides token generation using encryption
- **HTMLHelper.cs** - Generates HTML responses
- **LogHelper.cs** - Handles file logging operations
- **NavigationHelper.cs** - Manages URL redirects
- **OrderHelper.cs** - Manages order-related operations
- **ProcessAutoTask.cs** - Handles system process execution
- **QuoteDataAccess.cs** - Accesses quote data from database
- **HomeController.cs** - Main API controller exposing endpoints

## Building

```bash
dotnet build
```

## Running

```bash
dotnet run
```

The application will start on `https://localhost:5001` (HTTPS) or `http://localhost:5000` (HTTP).

## API Endpoints

- `GET /api/home/status` - Check application status
- `GET /api/home/generate-token?clientId=<id>` - Generate an encrypted token
- `GET /api/home/api-response?url=<url>` - Get response from an API URL

## Requirements

- .NET 8.0 SDK or later
- SQL Server (for database operations)
