# PartnerPlates 

**Note**: This project is currently under development and is not ready for production use. It is a project developed with the objective of enhancing my knowledge regarding .NET and React, while acquiring hands-on experience with docker and docker-compose.

## Overview 
PartnerPlates is a web application enabling companies to manage employee lunch benefits. The project consists of two main components: 
- **Backend**: Developed with .NET
- **Frontend**: Developed with React

## Technologies Used 
- .NET for the backend
- React for the frontend
- Docker and Docker Compose for containerization and orchestration

## Getting Started

### Prerequisites 
- Docker and Docker Compose
- .NET SDK
- Node.js and npm

### Setup Instructions 

1. **Clone the Repository**:

Using the command line or GitHub Desktop, clone the repository.

```git clone https://github.com/alanrychert/Partner-Plates.git cd partnerplates```

2. **Define the environment variables**:

Create a .env file in the root directory with the necessary environment variables that will be used for the configuration of the docker-compose postgresql database. Example:

```
POSTGRES_USER=your_docker-compose_postgres_user 
POSTGRES_PASSWORD=your_docker-compose_postgres_password
POSTGRES_DB=your_docker-compose_postgres_db
```

3. **Define Backend Configuration**:

Create `appsettings.json` and `appsettings.Development.json` files in the `partnerplatesbackend` directory with the necessary configuration settings. When using Docker Compose, the values related to the database credentials will be replaced with those specified in the `.env` file. Example `appsettings.json`:

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=db;Database=your_postgres_db;Username=your_postgres_user;Password=your_postgres_password"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  }
}
```

4. **Build and Run the Application**:

Use Docker Compose to build and run the application.

```
docker-compose up --build
```

## Project structure
- partnerplates/partnerplatesbackend: Backend developed with .NET (includes dockerfile)
- partnerplates/partner-plates-frontend: Frontend developed with React (includes dockerfile)
- .env: Environment variables for Docker Compose
- docker-compose.yml: Docker Compose configuration
- PartnerPlates.sln: Solution file for the .NET project
