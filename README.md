# 🚗 Driving & Vehicle License Department (DVLD)

A comprehensive **Driving License Management System** built with **C# Windows Forms, SQL Server, and ADO.NET**. The system manages people, users, driving license applications, examinations, license issuance, renewals, replacements, and license detention through a structured, database-driven desktop application.

This project was developed as part of the **DVLD Project – Programming Advices** learning journey, with additional assistance from AI tools during development and problem-solving.

---

## 📌 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Architecture](#%EF%B8%8F-architecture)
- [Technologies](#%EF%B8%8F-technologies)
- [Database Design](#db-design)
- [Technical Highlights](#-technical-highlights)
- [Project Structure](#-project-structure)
- [Getting Started](#%EF%B8%8F-getting-started)
- [Security Implementation](#-security-implementation)
- [What I Learned](#-what-i-learned)
- [Future Improvements](#-future-improvements)
- [Author](#project-author)
- [Acknowledgments](#-acknowledgments)

---

## 📖 Overview

The DVLD system simulates the core operations of a driving license department. It provides a centralized application for managing individuals, processing license applications, scheduling examinations, recording test results, and maintaining driver license records.

The system follows a **three-tier architecture** to separate the user interface, business logic, and database access responsibilities.

The main objective of this project was to apply object-oriented programming, relational database design, ADO.NET, reusable UI components, and real-world business rules in a complete desktop application.

## ✨ Features

### 👥 People Management

- Add, view, update, delete, and search for people.
- Manage personal information, national identification numbers, contact details, countries, and profile images.
- Prevent duplicate people based on national identification numbers.
- Reusable controls for displaying and selecting people.

### 🔐 User & Account Management

- User login and account settings.
- Create, view, update, and manage system users.
- Change account passwords.
- Associate system users with existing people records.
- Securely store user passwords as hashed values in the database.

### 📋 Application Management

- Manage configurable application types and their fees.
- Process local driving license applications.
- Process international driving license applications.
- Track application status and related records.
- Validate application eligibility and prevent conflicting active applications where applicable.

### 📝 Examination Management

- Schedule vision, written theory, and practical driving tests.
- Record examination appointments and results.
- Support retake workflows for failed examinations.
- Associate tests with their corresponding applications.

### 🚗 Driving License Management

- Issue driving licenses for the first time after completing the required process.
- Renew existing licenses.
- Replace lost or damaged licenses.
- Display license information and driver license history.
- Manage different license classes, fees, minimum ages, and validity periods.

### 🚨 License Detention & Release

- Detain driving licenses and record detention details.
- Record detention dates, and applicable fines.
- Release detained licenses after the required process.
- Track detention and release records.

### 🔎 Search, Filtering & Data Display

- Search records using relevant identifiers and personal information.
- Filter and display people, users, applications, drivers, and license records.
- Dynamically populate data grids.
- Use reusable information cards and filter controls across multiple forms.

---

## 🏗️ Architecture

The application follows a **Three-Tier Architecture (3-Tier)** to improve separation of concerns, maintainability, and code organization.

| Layer                             | Responsibility                                                                          |
| --------------------------------- | --------------------------------------------------------------------------------------- |
| 🖥️ **Presentation Layer (UI)**   | Windows Forms, user interaction, forms, reusable controls, and data presentation.       |
| ⚙️ **Business Logic Layer (BLL)** | Business rules, validations, application workflows, and coordination of operations.     |
| 🗄️ **Data Access Layer (DAL)**   | SQL Server communication, parameterized queries, and database operations using ADO.NET. |

### 🔄 How the Layers Interact

1. The user interacts with a form or reusable user control.
2. The presentation layer calls the appropriate business logic methods.
3. The business logic layer validates the operation and applies the relevant rules.
4. The data access layer executes the required database operations.
5. The results are returned through the layers and displayed to the user.

This structure helps keep database operations separate from business rules and UI code.

### 🧩 Object-Oriented Design

The project also applies several object-oriented programming concepts:

- **Encapsulation:** Organizing data and behavior within classes.
- **Inheritance:** Reusing shared application behavior through base classes and specialized application types.
- **Composition:** Building objects from reusable components, such as incorporating `PersonInfo` into application-related objects.

### 🔗 Reusable Controls & Event-Driven Communication

Custom Windows Forms user controls are used to reduce duplication and standardize the UI.

Examples include:

- `PersonCard`
- `PersonCardWithFilter`
- `DriverLicenseInfo`
- `ScheduleTestControl`

Custom properties, delegates, and events allow controls and forms to exchange information and respond to user actions without placing all interaction logic in a single form.

---

## 🛠️ Technologies

| Technology             | Purpose                                    |
| ---------------------- | ------------------------------------------ |
| **C#**                 | Application development and business logic |
| **.NET Windows Forms** | Desktop user interface                     |
| **SQL Server**         | Relational database management             |
| **ADO.NET**            | Database connectivity and data access      |
| **T-SQL**              | Database queries and operations            |
| **Visual Studio**      | Development and debugging                  |
| **Git & GitHub**       | Version control and project hosting        |

---

<a id="db-design"></a>

## 🗄️ Database Design

The system uses a relational database to maintain data consistency and represent relationships between people, applications, examinations, drivers, and licenses.

Core database entities include:

- `People` — Personal and contact information.
- `Users` — System accounts and user-related information.
- `Applications` — Application records, types, fees, and statuses.
- `ApplicationTypes` — Configurable application categories.
- `LicenseClasses` — License class requirements, fees, and validity periods.
- `LocalDrivingLicenseApplications` — Local driving application details.
- `TestTypes` — Examination types and associated configuration.
- `TestAppointments` — Scheduled examination appointments.
- `Tests` — Examination results and related records.
- `Drivers` — Driver records.
- `Licenses` — Issued driving licenses and their details.
- `DetainedLicenses` — License detention and release information.
- `InternationalDrivingLicenseApplications` — International driving application details.
- Countries — Country names.

---

## 🧠 Technical Highlights

### 1. Database Access with ADO.NET

Database operations are implemented using ADO.NET components such as:

- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`

Parameterized queries are used to pass input values safely to SQL commands and help prevent SQL injection.

### 2. Business Rules & Workflow Management

The application implements multi-step workflows rather than treating every operation as an isolated CRUD action.

Examples include:

- Checking eligibility before processing license applications.
- Scheduling examinations and recording their results.
- Handling failed tests and retake requests.
- Issuing licenses after the required steps are completed.
- Renewing licenses and processing replacement requests.
- Managing license detention and release.

### 3. Reusable UI Components

Custom user controls encapsulate recurring UI behavior and display logic. Properties, delegates, and events allow these controls to communicate with their parent forms and exchange data.

### 4. Maintainable Code Organization

Separating UI, business logic, and data access responsibilities makes the application easier to understand, debug, test, and extend compared with placing all logic directly inside Windows Forms.

---

## 📂 Project Structure

The solution is organized around its presentation, business logic, and data access responsibilities.

```text
Solution 'DVLD' (3 of 3 projects)
│
├── 📁 DVLD (Presentation Layer)
│   ├── 📁 Applications
│   │   ├── 📁 ApplicationTypes
│   │   │   ├── frmEditApplicationTypes.cs
│   │   │   └── frmManageApplicationTypes.cs
│   │   ├── 📁 International Licenses
│   │   │   ├── frmListInternationalLicenseApplication.cs
│   │   │   └── frmNewInternationalLicenseApplication.cs
│   │   ├── 📁 LocalDrivingLicenseApplications
│   │   │   ├── ctrlLocalDrivingLicenseAppInfo.cs
│   │   │   ├── frmAddEditLocalDrivingLicenseApplication.cs
│   │   │   ├── frmManageLocalDrivingLicenseApplications.cs
│   │   │   └── frmShowLocalDrivingLicenseApplicationInfo.cs
│   │   ├── 📁 Release Detained License
│   │   │   ├── frmListDetainedLicenses.cs
│   │   │   └── frmReleaseDetainedLicense.cs
│   │   ├── 📁 Renew Local License
│   │   │   └── frmRenewLocalDrivingLicenseApplication.cs
│   │   ├── 📁 Replace Lost Or Damaged License
│   │   │   └── frmReplaceLostOrDamagedLicenseApplication.cs
│   │   ├── 📁 TestTypes
│   │   │   ├── frmEditTestTypes.cs
│   │   │   └── frmManageTestTypes.cs
│   │   └── ctrlApplicationBasicInfo.cs
│   ├── 📁 Auth
│   │   └── frmLogin.cs
│   ├── 📁 Drivers
│   │   ├── 📁 Controls
│   │   │   └── ctrlDriverLicenses.cs
│   │   ├── frmListDrivers.cs
│   │   └── frmShowPersonLicenseHistory.cs
│   ├── 📁 Global Classes
│   │   ├── clsFormat.cs
│   │   ├── clsGlobal.cs
│   │   ├── clsUtil.cs
│   │   └── clsValidation.cs
│   ├── 📁 Licenses
│   │   ├── 📁 Detain Licenses
│   │   │   └── frmDetainLocalDrivingLicense.cs
│   │   ├── 📁 International Licenses
│   │   │   ├── 📁 Controls
│   │   │   │   └── ctrlDriverInternationalLicenseInfo.cs
│   │   │   └── frmShowInternationalLicenseInfo.cs
│   │   └── 📁 Local Licenses
│   │       ├── 📁 Controls
│   │       │   ├── ctrlDriverLicenseInfo.cs
│   │       │   └── ctrlDriverLicenseInfoWithFilter.cs
│   │       ├── frmIssueDriverLicenseFirstTime.cs
│   │       └── frmShowLicenseInfo.cs
│   ├── 📁 People
│   │   ├── 📁 Controls
│   │   │   ├── ctrlShowPersonDetails.cs
│   │   │   └── ctrlShowPersonDetailsWithFilter.cs
│   │   ├── frmAddEditPerson.cs
│   │   ├── frmFindPerson.cs
│   │   ├── frmManagePeople.cs
│   │   └── frmShowPersonDetails.cs
│   ├── 📁 Tests
│   │   ├── 📁 Controls
│   │   │   ├── ctrlScheduledTest.cs
│   │   │   └── ctrlSheduleTest.cs
│   │   ├── frmListTestAppointments.cs
│   │   ├── frmScheduleTest.cs
│   │   └── frmTakeTest.cs
│   ├── 📁 Users
│   │   ├── 📁 Controls
│   │   │   └── ctrlShowUserDetails.cs
│   │   ├── frmAddEditUser.cs
│   │   ├── frmChangePassword.cs
│   │   ├── frmManageUsers.cs
│   │   └── frmShowUserDetails.cs
│   ├── frmMain.cs
│   └── Program.cs
│
├── 📁 DVLD_BLL (Business Logic Layer)
│   ├── clsApplication.cs
│   ├── clsApplicationType.cs
│   ├── clsCountry.cs
│   ├── clsDetainedLicense.cs
│   ├── clsDriver.cs
│   ├── clsInternationalLicense.cs
│   ├── clsLicense.cs
│   ├── clsLicenseClass.cs
│   ├── clsLocalDrivingLicenseApplication.cs
│   ├── clsPerson.cs
│   ├── clsTest.cs
│   ├── clsTestAppointment.cs
│   ├── clsTestType.cs
│   └── clsUser.cs
│
└── 📁 DVLD_DAL (Data Access Layer)
    ├── clsDataAccessSettings.cs
    ├── clsDataApplication.cs
    ├── clsDataApplicationType.cs
    ├── clsDataCountry.cs
    ├── clsDataDetainedLicense.cs
    ├── clsDataDriver.cs
    ├── clsDataInternationalLicense.cs
    ├── clsDataLicense.cs
    ├── clsDataLicenseClass.cs
    ├── clsDataLocalDrivingLicenseApplication.cs
    ├── clsDataPerson.cs
    ├── clsDataTest.cs
    ├── clsDataTestAppointment.cs
    ├── clsDataTestType.cs
    └── clsDataUser.cs
```

---

## ⚙️ Getting Started

Follow these steps to run the project locally.

### ✅ Prerequisites

- Windows operating system.
- Visual Studio with the required .NET desktop development workload.
- A compatible .NET Framework or .NET runtime matching the solution.
- SQL Server.
- SQL Server Management Studio (SSMS), or another compatible database management tool.

### 📥 1. Clone the Repository

```bash
git clone https://github.com/Ibrahim-Abu-Asaad/DVLD.git
```

Open the cloned repository and locate the solution file (`.sln`).

### 🗄️ 2. Set Up the Database

1. Open SQL Server Management Studio.
2. Connect to your SQL Server instance.
3. Locate the DVLD database script in the repository or the project's provided database files.
4. Execute the script to create and populate the database, if sample data is included.

**Note:** The database script must be available separately if it has not been committed to the repository.

### 🔌 3. Configure the Connection String

Locate the database connection settings in the Data Access Layer. In this project, the connection settings are maintained in:

`DVLD_DAL/clsDataAccessSettings.cs`

Update the connection string to match your SQL Server instance and database configuration.

Never commit passwords or other sensitive connection details to a public repository.

### ▶️ 4. Build & Run

1. Open the solution in Visual Studio.
2. Restore any required dependencies.
3. Ensure the database is accessible and the connection string is correct.
4. Build the solution.
5. Run the Windows Forms application.

If the application requires an initial user account, configure one using the project's supported setup process.

---

## 🔐 Security Implementation

- **Parameterized SQL Queries:** Used parameterized `SqlCommand` objects throughout the Data Access Layer (DAL) to prevent SQL injection attacks.
- **Password Hashing:** Hashed user passwords before storing them in the database to protect credentials.
- **Authentication & Access Control:** Implemented user login authentication, account settings, and password modification workflows.
- **Database Connection Security:** Centralized connection string configuration in `clsDataAccessSettings` for consistent database connectivity management across the DAL..

---

## 🎯 What I Learned

Building this project helped me develop practical experience with:

- Designing and implementing a multi-layered C# application.
- Applying object-oriented programming to a larger codebase.
- Designing and working with relational databases in SQL Server.
- Implementing data access operations using ADO.NET.
- Translating business requirements into application workflows.
- Building reusable Windows Forms user controls.
- Using delegates and events for communication between components.
- Debugging, understanding, and extending an existing codebase.
- Using AI tools as supplementary learning and help me alittle in designing and some debuging.

---

## 🚀 Future Improvements

Potential improvements for future iterations include:

- 🧪 Adding automated unit and integration tests.
- 🔒 Strengthening authentication, authorization, and credential management.
- 📊 Improving reporting, dashboards, and operational statistics.
- 🧾 Adding more comprehensive audit logging.
- 🧹 Refactoring duplicated logic and improving error handling.
- 🌐 Developing a RESTful API with ASP.NET Core to expose the core business functionality to web and mobile clients.
- ☁️ Exploring deployment options and a more scalable application architecture.

---

<a id="project-author"></a>

## 👨‍💻 Author

**Ibrahim Abu-Asaad**

IT Student at Faculty of Informatics Engineering – Latakia University 🇸🇾

Interested in backend development, software engineering, databases, and building practical software systems.

- 🐙 **GitHub:** [Ibrahim-Abu-Asaad](https://github.com/Ibrahim-Abu-Asaad)
- 🚗 **Project Repository:** [DVLD – Driving License Management System](https://github.com/Ibrahim-Abu-Asaad/DVLD)

---

## 🙏 Acknowledgments

- [**Programming Advices**](https://programmingadvices.com/) — For the DVLD project requirements, course lessons.

This project represents a learning milestone in my journey toward becoming a stronger software engineer.

---

⭐ If you find this project interesting, feel free to explore the repository and follow my progress as I continue learning and building software.
