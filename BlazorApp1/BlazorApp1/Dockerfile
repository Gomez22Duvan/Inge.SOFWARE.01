# Use the official .NET SDK image as the base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory
WORKDIR /app

# Copy the project file and restore dependencies
COPY src/BlazorApp1/*.csproj ./src/BlazorApp1/
RUN dotnet restore ./src/BlazorApp1/BlazorApp1.csproj

# Copy the rest of the application files
COPY . .

# Build the application
RUN dotnet publish ./src/BlazorApp1/BlazorApp1.csproj -c Release -o out

# Use the official .NET runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory
WORKDIR /app

# Copy the built application from the build stage
COPY --from=build /app/out .

# Specify the command to run the application
ENTRYPOINT ["dotnet", "BlazorApp1.dll"]