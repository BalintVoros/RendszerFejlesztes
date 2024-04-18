#!/bin/sh

# Function to check if MySQL service is running
check_mysql() {
    if ! pgrep mysqld >/dev/null; then
        echo "MySQL is not running. Please start MySQL service and try again."
        exit 1
    fi
}

# Function to create database and import SQL file
create_database() {
    DB_NAME="my_database"
    DB_USER="root"
    DB_PASS="admin123"
    SQL_FILE="SQL/Cars.sql"

    # Create database
    mysql -u"$DB_USER" -p"$DB_PASS" -e "CREATE DATABASE IF NOT EXISTS $DB_NAME;"

    # Import SQL file
    mysql -u"$DB_USER" -p"$DB_PASS" -D "$DB_NAME" < "$SQL_FILE"

    echo "Database created and SQL file imported successfully."
}

# Function to start backend server
start_backend() {
    echo "Backend server starting..."
    cd Car_Rental/Backend
    mvn package
    java -jar target/rent-a-car-spring-0.0.1-SNAPSHOT.jar &
    BACKEND_PID=$!
    echo "Backend server started successfully with PID: $BACKEND_PID"
}

# Function to start frontend server
start_frontend() {
    echo "Frontend server starting..."
    cd ../../Frontend
    npm install
    ng serve &
    echo "Frontend server started successfully."
}

# Function to shut down servers gracefully
shutdown_servers() {
    echo "Shutting down servers..."
    kill $BACKEND_PID $FRONTEND_PID
    echo "Servers shut down successfully."
    exit 0
}

# Function to open browser to specific URL with a delay
open_browser() {
    echo "Opening browser to http://localhost:4200/login after 5 seconds..."
    sleep 5
    open "http://localhost:4200/login"
}

# Main script

# Trap Ctrl+C signal to call shutdown_servers function
trap shutdown_servers SIGINT

check_mysql
create_database
start_backend

# Prompt user to shut down backend before starting frontend
read -p "Backend server started. Press any key to start frontend build and open browser..."

# Assuming the user is ready to start frontend, we proceed with starting it
start_frontend

# Open browser to specified URL with delay
open_browser
