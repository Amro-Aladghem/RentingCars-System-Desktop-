# Renting Cars System - Desktop Application

A comprehensive desktop application for managing car rental operations, built with C# and SQL Server.

## 💡 Idea

This project is a desktop-based car rental management system designed to streamline rental operations. It provides a complete solution for managing vehicles, customers, reservations, and rental transactions with an intuitive user interface and robust database backend.

## 🏗️ Project Structure

```
RentingCars-System-Desktop-/
├── Database/
│   └── RetainCarsProject.bak (Database backup file)
├── Source Code/
│   ├── clsBusiness/        (Business logic layer)
│   ├── clsData/            (Data access layer)
│   ├── Forms/              (User interface forms)
│   └── Program.cs          (Application entry point)
├── Properties/
├── bin/                    (Compiled output)
└── obj/                    (Intermediate build files)
```

## 📋 Overview

The Renting Cars System consists of the following key components:

- **Business Logic Layer**: Handles core rental operations and business rules
- **Data Access Layer**: Manages database communication and queries
- **User Interface**: Windows Forms-based interface for easy interaction
- **Database**: SQL Server backend for persistent data storage

Key Features:
- Vehicle inventory management
- Customer profile management
- Reservation and booking system
- Rental tracking and payment processing
- Comprehensive reporting capabilities

## 📋 Setup Instructions

### 1. Database Setup

After downloading the project zip file, restore the SQL Server database using the provided backup file:

```sql
RESTORE DATABASE [RetainCarsProject]
FROM DISK = 'C:\MyDatabase.bak'
```

**Note:** Replace the disk path with the actual location of your backup file. It's recommended to place the backup on your C: drive before restoration.

### 2. Database Connection Configuration

Before running the application, configure your SQL Server connection string with your database credentials:

**Connection String Setup:**

![Please check this Picture](https://github.com/user-attachments/assets/dd144ff4-f529-43c2-a317-fc6ab4ca2845)

### 3. Database Schema

Review the database structure and relationships:

![DESKTOP-IK9MONC RetainCarsProject - Diagram_Base_ - Microsoft SQL Server Management Studio 16_09_2024 05_47_04 م](https://github.com/user-attachments/assets/94a15043-e108-4b3b-a9a8-9804ceb75ec5)

## ▶️ Running the Application

Once the database is restored and connection settings are configured, you can run the application.

---

## 📝 Notes

- Ensure SQL Server is running before launching the application
- Verify the connection string matches your SQL Server instance and credentials
- The backup file path must be adjusted according to your file system setup
