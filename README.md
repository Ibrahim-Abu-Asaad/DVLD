<!-- # 🚗 Driving & Vehicle Licensing Department System

A complete system for managing driving licenses, vehicle registrations, and all department operations with a clean and modern interface.

---

### 📊 Project Status
- **Status:** `In Progress` ⏳
  
---

### 🛠️ Tech Stack
- **Language:** C# (CSharp)
- **Framework:** .NET Framework
- **UI Library:** SunnyUI
- **Database:** Microsoft SQL Server
- **Architecture:** 3-Tier Architecture (UI, BLL, DAL) (User Interface, Business Logic Layer, Data Access Layer).

---
-->
# 🚗 DVLD – Driving & Vehicle License Department

A desktop-based **Driving & Vehicle License Management System (DVLD)** developed as a full real-world project using **C# and .NET**.

The system simulates the workflow of a driving license department, including people management, user management, license applications, driving tests, license issuance, renewal, replacement, detention, release, and international driving licenses.

> 📌 **Project Status:** Completed as part of my backend/software development learning journey.

---

## 📌 About the Project

**DVLD (Driving & Vehicle License Department)** is a comprehensive desktop application designed to manage the process of issuing and managing driving licenses.

The project covers the complete lifecycle of a driving license application:

**Application → Scheduling Tests → Taking Tests → Issuing License → Renewal / Replacement → License Management**

The system also provides administrative functionality for managing users, people, application types, test types, license classes, and detained licenses.

This project was developed while studying the **Programming Advices** C#/.NET learning path and was built to practice real-world software development concepts.

---

## ✨ Main Features

### 👤 People Management

* Add new people
* Update person information
* Delete people
* Search by national number
* View detailed person information
* Manage countries/nationalities
* Store personal information and profile images
* Prevent duplicate people using the national number

### 👨‍💼 User Management

* User login
* Add and edit users
* Change passwords
* Freeze user accounts
* Manage user information
* Assign permissions
* Track the user responsible for system operations

### 📝 Applications Management

The system supports several types of applications:

* 🪪 First-time local driving license
* 🔄 Retake failed tests
* ♻️ License renewal
* 📄 Replacement for lost license
* 📄 Replacement for damaged license
* 🔒 Release detained license
* 🌍 International driving license

### 🧪 Driving Tests

The system manages the different stages of driving tests:

* 👁️ Vision Test
* 📚 Theory Test
* 🚗 Practical Driving Test
* Schedule test appointments
* Record test results
* Support failed-test retakes
* Prevent invalid test scheduling

### 🪪 License Management

* Issue a driving license for the first time
* Renew existing licenses
* Replace lost licenses
* Replace damaged licenses
* View driver licenses
* View license history
* Issue international driving licenses
* Detain licenses
* Release detained licenses

### ⚙️ System Administration

* Manage application types
* Manage test types
* Manage license classes
* Configure license fees
* Configure minimum ages
* Configure license validity periods
* Track system operations with user and date information

---

## 🏗️ Architecture

The project follows a **3-Layer Architecture** to separate responsibilities and make the application easier to maintain.

```text
┌──────────────────────────────┐
│       Presentation Layer     │
│        Windows Forms         │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│       Business Layer         │
│       Business Logic         │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│       Data Access Layer      │
│      Database Operations     │
└──────────────┬───────────────┘
               │
               ▼
┌──────────────────────────────┐
│          SQL Server          │
└──────────────────────────────┘
```

### Why this architecture?

Separating the application into layers helps keep:

* UI code separate from business logic
* Business rules independent from database operations
* Database access organized
* The project easier to maintain and extend

---

## 🛠️ Technologies & Tools

### Programming

* **C#**
* **.NET**
* **Windows Forms**

### Database

* **Microsoft SQL Server**
* **SQL**
* Relational Database Design

### Development Tools

* Visual Studio
* SQL Server Management Studio 19
* UI Sunny Library (Chinese Library)
* Git
* GitHub
  
---

## 🗄️ Database

The system uses a relational SQL Server database to store and manage the application's data.

The database contains entities related to:

* People
* Countries
* Users
* Applications
* Application Types
* License Classes
* Test Types
* Test Appointments
* Tests
* Drivers
* Licenses
* International Licenses
* Detained Licenses
* Local Driving License Applications

The project also includes relationships between these entities to represent the real-world workflow of a driving license management system.

---

## 🔄 Application Workflow

A typical local driving license application follows this workflow:

```text
Create Person
     ↓
Create Application
     ↓
Select License Class
     ↓
Schedule Vision Test
     ↓
Take Vision Test
     ↓
Schedule Theory Test
     ↓
Take Theory Test
     ↓
Schedule Practical Test
     ↓
Take Practical Test
     ↓
Pass All Tests
     ↓
Issue Driving License
```

If an applicant fails a test, the system allows the test to be scheduled again according to the application's rules.

---

## 🚀 Future Improvements

Possible future improvements include:

* [ ] Improve UI/UX
* [ ] Add more advanced reporting
* [ ] Add additional validation
* [ ] Improve error handling
* [ ] Improve security
* [ ] Add more detailed audit logging
* [ ] Migrate the system to a web-based architecture using ASP.NET Core

---

## 👨‍💻 Author

**Ibrahim Abu-Asaad**

IT Student — Faculty of Informatics Engineering
Latakia University 🇸🇾

**Backend Developer in Progress**

Interested in building software systems using **C#, .NET, databases, and backend technologies**.

---

## 📌 Note

This project was developed for **educational and learning purposes** as part of my journey toward becoming a professional software/backend developer.

The project requirements are based on the DVLD project specification used during my learning path.

---

⭐ If you find this project useful or interesting, feel free to explore the source code.
