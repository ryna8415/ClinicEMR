# ClinicEMR

> A simplified Electronic Medical Record (EMR) system for small clinics.  
> Built with **C# WinForms** + **MySQL** as a 3-week IT final project.

---

## What This System Does

ClinicEMR replaces paper-based clinic records with a simple desktop application. It covers the full patient visit workflow — from registration to consultation to prescription — designed for small barangay health centers or private general practice clinics.

**Three user roles:**

| Role | What They Do |
|------|-------------|
| **Admin** | Manages user accounts, views audit logs |
| **Nurse** | Registers patients, books appointments, records vital signs |
| **Doctor** | Records consultations, diagnoses, and prescriptions |

---

## Features

- **Login system** with role-based access and lockout after 5 failed attempts
- **Patient registration** — searchable patient list with unique Patient IDs (PT-00001, etc.)
- **Appointment scheduling** — daily schedule with Scheduled / Completed / Cancelled / No-Show status
- **Vital signs entry** — BP, heart rate, temperature, height, weight, auto-calculated BMI
- **Consultation records** — chief complaint, findings, diagnosis, doctor notes (locked after same day)
- **Prescription management** — multiple medications per consultation with dosage and frequency
- **Medical history** — allergies (shown as warning), chronic conditions, family history
- **Patient record view** — tabbed view of all visits, vitals, and prescriptions per patient
- **Basic daily report** — patient visit count and summary per day
- **User account management** — admin creates / deactivates staff accounts

---

## Tech Stack

| Layer | Technology |
|-------|-----------|
| UI / Frontend | C# WinForms (.NET Framework 4.8) |
| Backend Logic | C# Service classes (Business Logic Layer) |
| Database | MySQL 8.x |
| DB Connector | MySql.Data NuGet package |
| Password Hashing | BCrypt.Net-Next NuGet package |

---

## Project Structure

```
ClinicEMR/
├── Data/
│   └── DatabaseHelper.cs        # MySQL connection manager
├── Models/
│   ├── User.cs                  # User data model
│   ├── Patient.cs               # Patient data model
│   ├── Appointment.cs
│   ├── VitalSigns.cs
│   ├── Consultation.cs
│   └── Prescription.cs
├── Services/
│   ├── LoginService.cs          # Authentication + BCrypt
│   ├── UserService.cs           # User account management
│   ├── PatientService.cs        # Patient CRUD
│   ├── AppointmentService.cs
│   ├── VitalsService.cs
│   ├── ConsultService.cs
│   └── PrescriptionService.cs
├── Forms/
│   ├── LoginForm.cs             # Entry point
│   ├── AdminDashboard.cs
│   ├── NurseDashboard.cs
│   ├── DoctorDashboard.cs
│   ├── PatientListForm.cs
│   ├── AddPatientForm.cs
│   ├── AppointmentForm.cs
│   ├── VitalsForm.cs
│   ├── ConsultationForm.cs
│   ├── PrescriptionForm.cs
│   ├── PatientRecordForm.cs
│   └── ReportForm.cs
├── database/
│   └── schema.sql               # Full MySQL schema (run this first)
├── appsettings.json             # DB connection string (not committed — see setup)
├── appsettings.example.json     # Template for contributors
├── .gitignore
└── README.md
```

---

## Getting Started

### Prerequisites

- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) (free)
- [MySQL Server 8.x](https://dev.mysql.com/downloads/mysql/)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/)
- .NET Framework 4.8 (pre-installed on Windows 10/11)

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/your-username/ClinicEMR.git
cd ClinicEMR
```

**2. Set up the database**

Open MySQL Workbench, connect to your local MySQL instance, then run:

```bash
# In MySQL Workbench Query window:
source database/schema.sql
```

Or paste the contents of `database/schema.sql` into the query window and press `Ctrl+Shift+Enter`.

**3. Configure your database connection**

Copy the example config file:

```bash
cp appsettings.example.json appsettings.json
```

Open `appsettings.json` and fill in your local MySQL credentials:

```json
{
  "ConnectionStrings": {
    "ClinicEMR": "Server=localhost;Database=clinicemr_db;Uid=root;Pwd=YOUR_PASSWORD_HERE;"
  }
}
```

> ⚠️ `appsettings.json` is listed in `.gitignore` — it will never be committed. Never commit passwords to GitHub.

**4. Install NuGet packages**

Open the solution in Visual Studio. NuGet packages restore automatically on first build. If they don't:

```
Tools → NuGet Package Manager → Manage NuGet Packages for Solution → Restore
```

Required packages:
- `MySql.Data` (≥ 8.0.0)
- `BCrypt.Net-Next` (≥ 4.0.0)

**5. Run the app**

Press `F5` in Visual Studio or click **Start**.

### Default Login

| Username | Password | Role |
|----------|----------|------|
| `admin` | `Admin@123` | Admin |

> Change this password immediately after first login via the User Accounts screen.

---

## Database Schema

Six core tables. Run `database/schema.sql` to create them all.

```
users            — Staff accounts and roles
patients         — Registered patient profiles
appointments     — Scheduled clinic visits
vital_signs      — Triage readings per visit
consultations    — Doctor's clinical notes per visit
prescriptions    — Medications issued per consultation
```

See `database/schema.sql` for the full schema with all columns, data types, foreign key constraints, and seed data.

---

## For Collaborators — Database Setup

Each team member runs MySQL locally. **Passwords and connection strings are never shared through GitHub.**

See the **[Collaboration Setup Guide](#collaboration-setup)** below.

### The Quick Version

1. Each person installs MySQL locally
2. Each person runs `database/schema.sql` to create identical schemas
3. Each person creates their own `appsettings.json` from `appsettings.example.json`
4. Only `appsettings.example.json` (no passwords) goes on GitHub

---

## Collaboration Setup

### `.gitignore` — what stays off GitHub

Make sure your `.gitignore` includes:

```gitignore
# Database credentials — never commit these
appsettings.json
*.env
connection.config

# Visual Studio build output
bin/
obj/
*.user
.vs/

# OS files
.DS_Store
Thumbs.db
```

### `appsettings.example.json` — the template everyone uses

```json
{
  "ConnectionStrings": {
    "ClinicEMR": "Server=localhost;Database=clinicemr_db;Uid=YOUR_MYSQL_USERNAME;Pwd=YOUR_MYSQL_PASSWORD;"
  }
}
```

Commit this file. It has no real credentials — just placeholders.

### How to sync database changes

When a teammate adds a new table or column, they update `database/schema.sql` and push it. You pull and re-run the changed portion in MySQL Workbench.

For big changes, they can also create a migration file like `database/migrations/002_add_audit_log_table.sql` so everyone knows exactly what changed.

---

## Build Timeline

| Week | Focus | Milestone |
|------|-------|-----------|
| **Week 1** | Foundation | Login, patient registration, user management |
| **Week 2** | Clinical core | Appointments, vitals, consultations, prescriptions |
| **Week 3** | Completion | Patient record view, reports, testing, polish |

---

## Team Roles (Suggested)

| Person | Responsibility |
|--------|---------------|
| Developer A | Database schema + Service classes (backend) |
| Developer B | WinForms UI design + form navigation |
| Both | Testing, bug fixing, Week 3 polish |

---

## Known Limitations

- Single-machine deployment only (no network/cloud support)
- No image upload for patient photos
- Reports are text-based (no charts)
- No automated database backup
- Session lockout resets on app restart

These are intentional scope limits for a 3-week student project.

---

## License

This project is for academic purposes. MIT License — free to use and modify.

---

## Acknowledgements

Built as a First-Year IT Final Project.  
System Requirements Specification (SRS) and Build Guide included in `/docs`.
