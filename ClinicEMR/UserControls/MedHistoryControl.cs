using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class MedHistoryControl : UserControl
    {
        private int _patientId;
        private bool _isLoadingPatients;
        private readonly User _user;
        private DateTime _currentDateOfBirth = DateTime.Today;

        public MedHistoryControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;

            cboPatient.SelectedIndexChanged += cboPatient_SelectedIndexChanged;
            btnSave.Click += btnSave_Click;

            LoadPatients();
            ThemeService.ApplyRoundedCorners(tblInfoIntro, 5);
            ThemeService.ApplyRoundedCorners(tblContent, 5);
        }

        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            _patientId = patientId;

            var patient = PatientService.GetById(patientId);
            if (patient == null)
                return;

            SelectPatient(patientId);
            PopulatePatientDetails(patient);
        }

        public void RefreshPatients(int? selectedPatientId = null)
        {
            LoadPatients(selectedPatientId ?? _patientId);
        }

        private void LoadPatients(int? selectedPatientId = null)
        {
            _isLoadingPatients = true;

            var patients = PatientService.GetAll();
            cboPatient.DataSource = null;
            cboPatient.DataSource = patients;
            cboPatient.DisplayMember = "FullName";
            cboPatient.ValueMember = "PatientId";
            cboPatient.SelectedIndex = -1;

            if (selectedPatientId.HasValue && selectedPatientId.Value > 0)
                SelectPatient(selectedPatientId.Value);
            else
                ResetPatientDetails();

            _isLoadingPatients = false;
        }

        private void SelectPatient(int patientId)
        {
            for (int i = 0; i < cboPatient.Items.Count; i++)
            {
                if (cboPatient.Items[i] is Patient patient && patient.PatientId == patientId)
                {
                    cboPatient.SelectedIndex = i;
                    return;
                }
            }
        }

        private void cboPatient_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isLoadingPatients || cboPatient.SelectedIndex == -1)
                return;

            if (cboPatient.SelectedItem is not Patient selectedPatient)
                return;

            _patientId = selectedPatient.PatientId;
            PopulatePatientDetails(selectedPatient);
        }

        private void PopulatePatientDetails(Patient patient)
        {
            _currentDateOfBirth = patient.DateOfBirth;
            lblPatientName.Text = patient.FullName;
            lblMeta.Text = BuildPatientMeta(patient);

            txtAge.Text = CalculateAge(patient.DateOfBirth).ToString();
            cboSex.Text = patient.Sex ?? string.Empty;
            txtAddress.Text = patient.Address ?? string.Empty;
            txtAllergies.Text = patient.KnownAllergies ?? string.Empty;
            txtContactNumber.Text = patient.ContactNumber ?? string.Empty;
            txtEmergency.Text = patient.EmergencyContact?.ToString() ?? string.Empty;
            txtConditions.Text = patient.ChronicConditions ?? string.Empty;
            txtSurgeries.Text = patient.PastSurgeries ?? string.Empty;
            txtFamHx.Text = patient.FamilyHistory ?? string.Empty;
            txtCurrentMeds.Text = patient.CurrentMedications ?? string.Empty;
        }

        private void ResetPatientDetails()
        {
            _patientId = 0;
            _currentDateOfBirth = DateTime.Today;
            lblPatientName.Text = "None Selected";
            lblMeta.Text = "Select a patient from the list";

            txtAge.Text = string.Empty;
            cboSex.SelectedIndex = -1;
            txtAddress.Text = string.Empty;
            txtAllergies.Text = string.Empty;
            txtContactNumber.Text = string.Empty;
            txtEmergency.Text = string.Empty;
            txtConditions.Text = string.Empty;
            txtSurgeries.Text = string.Empty;
            txtFamHx.Text = string.Empty;
            txtCurrentMeds.Text = string.Empty;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.");
                cboPatient.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 0 || age > 150)
            {
                MessageBox.Show("Please enter a valid age between 0 and 150.");
                txtAge.Focus();
                txtAge.SelectionStart = 0;
                txtAge.SelectionLength = txtAge.Text.Length;
                return;
            }

            string sex = cboSex.Text.Trim();
            if (string.IsNullOrWhiteSpace(sex))
            {
                MessageBox.Show("Please select the patient's sex.");
                cboSex.Focus();
                return;
            }

            DateTime updatedDateOfBirth = BuildDateOfBirthFromAge(age, _currentDateOfBirth);
            _currentDateOfBirth = updatedDateOfBirth;

            var patient = new Patient
            {
                PatientId = _patientId,
                DateOfBirth = updatedDateOfBirth,
                Sex = sex,
                ContactNumber = txtContactNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                EmergencyContact = long.TryParse(txtEmergency.Text.Trim(), out long emergencyContact)
                    ? emergencyContact
                    : null,
                KnownAllergies = txtAllergies.Text.Trim(),
                ChronicConditions = txtConditions.Text.Trim(),
                PastSurgeries = txtSurgeries.Text.Trim(),
                FamilyHistory = txtFamHx.Text.Trim(),
                CurrentMedications = txtCurrentMeds.Text.Trim()
            };

            PatientService.UpdateHistory(patient);
            lblMeta.Text = BuildPatientMeta(new Patient
            {
                PatientCode = (cboPatient.SelectedItem as Patient)?.PatientCode ?? string.Empty,
            });

            AuditLogService.Log(_user.UserId, $"Updated medical history for patient #{_patientId}.");
            MessageBox.Show("Medical history saved.");
        }

        private static string BuildPatientMeta(Patient patient)
        {
            return patient.PatientCode ?? string.Empty;
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }

        private static DateTime BuildDateOfBirthFromAge(int age, DateTime currentDateOfBirth)
        {
            int year = DateTime.Today.Year - age;
            if (currentDateOfBirth.Date > DateTime.Today.AddYears(-age))
                year--;

            int month = Math.Clamp(currentDateOfBirth.Month, 1, 12);
            int day = Math.Min(currentDateOfBirth.Day, DateTime.DaysInMonth(year, month));
            return new DateTime(year, month, day);
        }
    }
}
