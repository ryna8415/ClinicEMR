-- database/schema.sql
-- Run this file ONCE in MySQL Workbench to set up the database.
-- Everyone on the team runs this on their own MySQL.

CREATE DATABASE IF NOT EXISTS clinicemr_db;
USE clinicemr_db;

CREATE TABLE IF NOT EXISTS users (
  user_id       INT AUTO_INCREMENT PRIMARY KEY,
  username      VARCHAR(50) NOT NULL UNIQUE,
  password_hash VARCHAR(255) NOT NULL,
  full_name     VARCHAR(100) NOT NULL,
  role          ENUM('admin','doctor','nurse') NOT NULL,
  is_active     TINYINT(1) DEFAULT 1,
  last_login    DATETIME
);

-- TABLE 2: patients
CREATE TABLE IF NOT EXISTS patients (
  patient_id        INT AUTO_INCREMENT PRIMARY KEY,
  patient_code      VARCHAR(20) NOT NULL UNIQUE,
  first_name        VARCHAR(80) NOT NULL,
  last_name         VARCHAR(80) NOT NULL,
  date_of_birth     DATE NOT NULL,
  sex               ENUM('Male','Female','Other'),
  contact_number    VARCHAR(20),
  address           TEXT,
  emergency_contact VARCHAR(120),
  known_allergies   TEXT,
  is_active         TINYINT(1) DEFAULT 1,
  registered_at     DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- TABLE 3: appointments
CREATE TABLE IF NOT EXISTS appointments (
  appointment_id INT AUTO_INCREMENT PRIMARY KEY,
  patient_id     INT NOT NULL,
  doctor_id      INT NOT NULL,
  appt_date      DATE NOT NULL,
  appt_time      TIME NOT NULL,
  purpose        VARCHAR(200),
  status         ENUM('Scheduled','Completed','Cancelled','No-Show') DEFAULT 'Scheduled',
  created_by     INT NOT NULL,
  created_at     DATETIME DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (patient_id)  REFERENCES patients(patient_id),
  FOREIGN KEY (doctor_id)   REFERENCES users(user_id),
  FOREIGN KEY (created_by)  REFERENCES users(user_id)
);

-- TABLE 4: vital_signs
CREATE TABLE IF NOT EXISTS vital_signs (
  vital_id        INT AUTO_INCREMENT PRIMARY KEY,
  patient_id      INT NOT NULL,
  recorded_by     INT NOT NULL,
  recorded_at     DATETIME DEFAULT CURRENT_TIMESTAMP,
  blood_pressure  VARCHAR(20),
  heart_rate      INT,
  temperature     DECIMAL(4,1),
  height_cm       DECIMAL(5,1),
  weight_kg       DECIMAL(5,2),
  bmi             DECIMAL(4,1),
  FOREIGN KEY (patient_id)  REFERENCES patients(patient_id),
  FOREIGN KEY (recorded_by) REFERENCES users(user_id)
);

-- TABLE 5: consultations
CREATE TABLE IF NOT EXISTS consultations (
  consultation_id INT AUTO_INCREMENT PRIMARY KEY,
  patient_id      INT NOT NULL,
  doctor_id       INT NOT NULL,
  vital_id        INT,
  chief_complaint TEXT NOT NULL,
  findings        TEXT,
  diagnosis       VARCHAR(300),
  doctor_notes    TEXT,
  consult_date    DATETIME DEFAULT CURRENT_TIMESTAMP,
  is_locked       TINYINT(1) DEFAULT 0,
  FOREIGN KEY (patient_id) REFERENCES patients(patient_id),
  FOREIGN KEY (doctor_id)  REFERENCES users(user_id),
  FOREIGN KEY (vital_id)   REFERENCES vital_signs(vital_id)
);

-- TABLE 6: prescriptions
CREATE TABLE IF NOT EXISTS prescriptions (
  prescription_id  INT AUTO_INCREMENT PRIMARY KEY,
  consultation_id  INT NOT NULL,
  patient_id       INT NOT NULL,
  medication_name  VARCHAR(150) NOT NULL,
  dosage           VARCHAR(80),
  frequency        VARCHAR(80),
  duration         VARCHAR(80),
  instructions     TEXT,
  issued_at        DATETIME DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (consultation_id) REFERENCES consultations(consultation_id),
  FOREIGN KEY (patient_id)      REFERENCES patients(patient_id)
);

INSERT IGNORE INTO users (username, password_hash, full_name, role)
VALUES ('admin', '$2a$12$//Hc0lDP.0dbks8zNxGRH.EswDGaaTcFv3gjTSXhrT6SfCW7MVrkS', 'System Admin', 'admin');

