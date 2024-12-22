# Use .NET SDK image for both build and runtime stages to ensure tools are available
FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

# Copy the project files and restore dependencies
COPY *.csproj .
RUN dotnet restore

# Copy the rest of the application files and publish the application
COPY . .
RUN dotnet publish -c Release -o out

# Set the working directory to the output folder
WORKDIR /app/out

# Install dotnet-ef tool in the runtime stage
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

# Set the environment variable to Development
ENV ASPNETCORE_ENVIRONMENT=Development

# Expose the application port
EXPOSE 8080

# Start the application
CMD ["dotnet", "PartnerPlatesBackend.dll"]
