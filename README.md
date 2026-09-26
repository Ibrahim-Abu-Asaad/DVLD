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
# 🚗 DVLD - Driving & Vehicle License Department Management System

A comprehensive Desktop Application designed to handle operations for a Driving & Vehicle License Department (DVLD). The system automates application processing, multi-stage testing schedules, license issuance, renewals, replacements, detentions, and international licensing.

---

## 📌 Project Overview

**DVLD System** provides end-to-end digital handling of driving license procedures. Built with a 3-Tier Architecture, it manages client records, tracks multi-stage driving exams (Vision, Written, Street), enforces age and class eligibility rules, handles fees, and manages international license workflows.

---

## ✨ Key Features

### 👤 Person & User Management
* **Person Directory:** Centralized registry tied to National IDs to prevent duplicate entity profiles.
* **User Accounts & RBAC:** Complete user account management with custom login authorization, status control (active/deactive), and password management.
* **Reusable UI Components:** Uses custom User Controls (`PersonCard`, `PersonCardWithFilter`, `UserCard`) for consistent UI behavior across forms.

### 📝 Application & Service Processing
* **Application Lifecycle:** Full tracking of application status (`New`, `Cancelled`, `Completed`).
* **Services Handled:**
  * First-time Local Driving License Application
  * Retake Test Application
  * Driving License Renewal
  * Replacement for Lost or Damaged License
  * License Detention & Release
  * International Driving License Application

### 🧪 Multi-Stage Testing Pipeline
Enforces strict sequential exam requirements before license eligibility:
1. **Vision Test:** Evaluates initial medical/visual fitness.
2. **Written (Theoretical) Test:** Records theoretical traffic rules exam scores.
3. **Street (Practical) Test:** Evaluates practical driving capabilities.
* Integrates automated retake rules with extra fee tracking for failed attempts.

### 💳 License Management
* **7 License Classes:** Enforces minimum age constraints, validity periods (5–10 years), and custom class fees across all 7 categories (Motorcycles, Passenger Cars, Commercial, Agricultural, Heavy Trucks, etc.).
* **Driver Records:** Automatic promotion of applicant to registered `Driver` upon first successful license issuance.
* **License Actions:**
  * **Renewals:** Enforces vision re-tests and old license turnover.
  * **Replacements:** Handles lost/damaged requests with active status validation.
  * **Detain & Release System:** Allows authorized staff to detain licenses, assess fines, and release them upon fee settlement.
  * **International Licenses:** Validates existing Class 3 licenses to issue active international permits.

### 🛠️ System Administration
* **Dynamic Fee Management:** Adjust prices for Application Types, Test Types, and License Classes on the fly.
* **Audit Logging:** Logs user activity and timestamps across critical domain actions.

---

## 📐 Architecture & Technologies

### Architecture Pattern
Built using a **3-Tier Architecture**:
* **Presentation Layer (UI):** Windows Forms (.NET Framework) with custom WinForms User Controls and Delegates/Events for seamless inter-form communication.
* **Business Logic Layer (BLL):** Enforces system logic, validations, business constraints, and orchestrates domain operations.
* **Data Access Layer (DAL):** Executes parameterised SQL queries and procedures for reliable data persistence.

### Technical Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Data Provider:** ADO.NET

---

## 🗄️ Database Design Highlights

The relational SQL Server database includes tables structured around normalized design principles:
* **`People` & `Countries`:** Central personal data repository.
* **`Users`:** Application access and credentials.
* **`Applications` & `ApplicationTypes`:** Base transactional layer tracking system requests.
* **`LocalDrivingLicenseApplications` & `LicenseClasses`:** Tracks class-specific application details.
* **`TestTypes`, `TestAppointments`, & `Tests`:** Coordinates scheduled exam sessions and results.
* **`Drivers`, `Licenses`, & `InternationalLicenses`:** Tracks issued physical driving credentials.
* **`DetainedLicenses`:** Tracks fine amounts, detention dates, and release details.

---

## 📸 Screenshots & Demonstrations

> *Visual assets and UI walkthroughs will be added here.*

### Main Dashboard & System Navigation
<!-- Add Main Form Screenshot Here -->
`[Image Placeholder: Main Dashboard]`

### Person Management & Reusable Controls
<!-- Add Person Card / Person Management Screenshot Here -->
`[Image Placeholder: Person Management & Filter Control]`

### Testing & Appointment Scheduling
<!-- Add Schedule Test Screenshot Here -->
`[Image Placeholder: Schedule Test & Exam Process]`

### License Issuance & Driver Profile
<!-- Add Driver License Info Screenshot Here -->
`[Image Placeholder: Driver License Info]`

---

## 🚀 Getting Started

### Prerequisites
* **Visual Studio** (2019 or later recommended) with .NET Desktop Development workload installed.
* **Microsoft SQL Server** (2016 or later) / SQL Server Management Studio (SSMS).

### Database Setup
1. Open SQL Server Management Studio (SSMS).
2. Create a new database named `DVLD`.
3. Locate the SQL script provided in the repository under `Database/DVLD_Database.sql`.
4. Run the script to generate all required tables, constraints, relationships, and initial lookup data.

### Application Configuration
1. Clone the repository:
   ```bash
   git clone [https://github.com/your-username/DVLD-Driving-License-Management.git](https://github.com/your-username/DVLD-Driving-License-Management.git)
