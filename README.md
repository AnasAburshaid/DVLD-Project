# 🚗 DVLD (Driving & Vehicle License Department) Management System

## 📖 About the Project

DVLD is a comprehensive desktop-based application designed to digitize and streamline the operations of a driving license department.

Built as an advanced educational project, it simulates a real-world enterprise environment by managing the complete lifecycle of drivers, applications, tests, and licenses. The system provides safer, faster, and more reliable processing for complex operations such as license issuance, test scheduling, prerequisite validation, and license detainment management.

---

## 🏗️ Architecture

This project follows a strict **N-Tier (3-Tier) Architecture** to ensure scalability, maintainability, and clear separation of concerns.

### 🎨 Presentation Layer

* Responsive Windows Forms user interface.
* Modular design based on reusable `UserControls`.
* Efficient navigation and data sharing across application screens.

### ⚙️ Business Logic Layer (BLL)

* Implements core business rules.
* Handles prerequisite validations.
* Manages application workflows and fee calculations.

### 🗄️ Data Access Layer (DAL)

* Provides secure database connectivity.
* Handles all CRUD operations.
* Acts as the communication layer between the application and database.

---

## ✨ Key Features

### 📝 Advanced Test Scheduling & Tracking

* Tracks vision, written, and practical driving tests.
* Automatically validates test requirements.
* Handles retake applications and associated fees.

### 🧩 Modular UI Design

* Built using reusable User Controls.
* Components such as `PersonInfoCard` and `LicenseHistoryViewer` can be used throughout the application.

### 🪪 Complete License Lifecycle Management

* Issue new licenses.
* Renew existing licenses.
* Replace lost licenses.
* Replace damaged licenses.
* Manage local and international driving licenses.

### 🚔 Detain & Release System

* Detain licenses when required.
* Calculate fines automatically.
* Process release payments securely.

### 📂 Application Management

* Centralized management of service applications.
* Track application statuses:

  * New
  * Completed
  * Cancelled

---

## 🛠️ Tech Stack

| Technology  | Description                    |
| ----------- | ------------------------------ |
| Language    | C#                             |
| Framework   | .NET Framework (Windows Forms) |
| Database    | Microsoft SQL Server           |
| Data Access | ADO.NET                        |
| IDE         | Visual Studio                  |

---

## 🚀 Getting Started

Follow these steps to run the project locally.

### Prerequisites

* Visual Studio 2019 or later
* Microsoft SQL Server (Express or Developer Edition)

### Installation

#### 1️⃣ Clone the Repository

```bash
git clone https://github.com/AnasAburshaid/DVLD-Project.git
```

#### 2️⃣ Setup the Database

* Open **Microsoft SQL Server Management Studio (SSMS)**.
* Execute `DVLD_Database_Script.sql`.
* This will create the database schema and seed the initial data.

#### 3️⃣ Configure the Connection String

* Open the project in Visual Studio.
* Navigate to `DVLD_DAL`.
* Locate `ConnectionSettings.cs` or `App.config`.
* Update the SQL Server instance name to match your environment.

#### 4️⃣ Build and Run

* Press `Ctrl + Shift + B` to build the solution.
* Press `F5` to run the application.

---

# 📸 Screenshots

## 🔐 Login Screen

<img src="https://github.com/user-attachments/assets/22863804-f350-44b4-b945-e7ff3539ec72" width="100%">

---

## 📋 Applications Dashboard

<img src="https://github.com/user-attachments/assets/8511d9d6-879f-45fe-bc78-69f308ebd89d" width="100%">

---

## 📝 Test Scheduling & Appointments

<img src="https://github.com/user-attachments/assets/36e02206-fb68-4163-8dc5-124085c83ab0" width="100%">

---

## 👤 License History & Person Information

<img src="https://github.com/user-attachments/assets/fa404bb9-b72b-46a7-a4c9-13f3b4e089a9" width="100%">

---

## 🔄 License Replacement System

<img src="https://github.com/user-attachments/assets/50d3974c-a797-4dc2-867a-cc900f1b8188" width="100%">

---

## 🚔 Detain Management

<img src="https://github.com/user-attachments/assets/72aab6eb-ee7a-4b72-8eb4-d5b8bcf5f478" width="100%">

---

# 👨‍💻 Author

### Anas Amjad Aburshaid

**Software Engineering Graduate**

### Connect with Me

* LinkedIn: https://www.linkedin.com/in/anas-aburshaid-950192367/
* GitHub: https://github.com/AnasAburshaid
