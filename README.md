# DVLD (Driving & Vehicle License Department) Management System 🚗

## 📖 About The Project
The DVLD system is a comprehensive, desktop-based application designed to digitize and streamline the operations of a driving license department. Built as an advanced educational project, it simulates a real-world enterprise environment by managing the complete lifecycle of drivers, applications, tests, and licenses. It ensures safer, faster, and more reliable processing for complex operations like issuing licenses, scheduling test prerequisites, and handling license detainment.

## 🏗️ Architecture
This project was built from the ground up using a strict **N-Tier (3-Tier) Architecture** to ensure clean separation of concerns, scalability, and maintainability:
* **Presentation Layer:** A responsive, modular Windows Forms UI heavily utilizing custom `UserControls` for seamless data sharing across screens.
* **Business Logic Layer (BLL):** Handles all core application rules, dynamic fee calculations, and prerequisite validations.
* **Data Access Layer (DAL):** Manages secure database connectivity and CRUD operations.

## ✨ Key Features
* **Advanced Test Scheduling & Tracking:** Automated logic to track vision, written, and practical tests. The system dynamically validates passed test counts and automatically handles "Retake Application" logic and fees.
* **Modular UI Design:** Built with highly reusable components (User Controls). For example, a single `PersonInfoCard` or `LicenseHistoryViewer` can be called and interacted with from anywhere in the application.
* **Complete License Lifecycle:** Full capability to Issue (First Time, Renew, Replace for Lost/Damaged), Suspend, and Revoke local and international driving licenses.
* **Detain & Release System:** A robust financial and legal tracking system to detain licenses, calculate fines, and process release payments securely.
* **Application Management:** Centralized dashboards to track the exact status (New, Completed, Cancelled) of various service applications.

## 🛠️ Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET
* **IDE:** Visual Studio

## 🚀 Getting Started
To get a local copy up and running, follow these simple steps.

### Prerequisites
* Visual Studio (2019 or newer recommended)
* Microsoft SQL Server (Express or Developer edition)

### Installation
```sh
   git clone [https://github.com/AnasAburshaid/DVLD-Project.git](https://github.com/AnasAburshaid/DVLD-Project.git)

   
1. Clone the repository:
```sh
   git clone [https://github.com/AnasAburshaid/DVLD-Project.git](https://github.com/AnasAburshaid/DVLD-Project.git)
