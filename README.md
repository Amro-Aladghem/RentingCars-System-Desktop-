# Renting Cars System - Desktop Application

A comprehensive desktop application for managing car rental operations, built with C# and SQL Server.

## ⚠️ Known Issues

- **clsBusiness class** has incorrect syntax and requires corrections

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
