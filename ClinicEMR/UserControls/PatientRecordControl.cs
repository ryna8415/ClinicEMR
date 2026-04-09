using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class PatientRecordControl : UserControl
    {
        private int _patientId = 0;
        private readonly User _user;
        private readonly MainShellForm _shell;
        private bool _isLoadingPatients = false;

        public PatientRecordControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;
            _shell = shell;

            LoadPatients();
            ConfigureGrid(dgvVitals);
            ConfigureGrid(dgvConsultations);
            ConfigureGrid(dgvPrescriptions);
            SetHistoryReadOnly();
            ClearView();
        }

        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            LoadPatientDetails(patientId);
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
            cboPatient.DisplayMember = "DisplayInfo";
            cboPatient.ValueMember = "PatientId";
            cboPatient.SelectedIndex = -1;

            if (selectedPatientId.HasValue && selectedPatientId.Value > 0)
            {
                for (int i = 0; i < cboPatient.Items.Count; i++)
                {
                    if (cboPatient.Items[i] is Patient patient && patient.PatientId == selectedPatientId.Value)
                    {
                        cboPatient.SelectedIndex = i;
                        break;
                    }
                }
            }

            _isLoadingPatients = false;
        }

        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients || cboPatient.SelectedIndex == -1) return;
            if (cboPatient.SelectedItem is not Patient selectedPatient) return;

            LoadPatientDetails(selectedPatient.PatientId);
        }

        private void LoadPatientDetails(int patientId)
        {
            _patientId = patientId;

            var p = PatientService.GetById(patientId);
            if (p == null)
            {
                ClearView();
                return;
            }

            lblPatientName.Text = p.FullName;

            int age = DateTime.Today.Year - p.DateOfBirth.Year;
            if (p.DateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            lblMeta.Text = $"{p.PatientCode}  |  {age} y/o  {p.Sex}  |  {p.ContactNumber}";

            if (!string.IsNullOrWhiteSpace(p.KnownAllergies))
            {
                lblAllergy.Text = "ALLERGY ALERT: " + p.KnownAllergies;
                lblAllergy.Visible = true;
                lblAllergy.BackColor = Color.FromArgb(153, 27, 27);
                lblAllergy.ForeColor = Color.White;
            }
            else
            {
                lblAllergy.Text = "";
                lblAllergy.Visible = false;
            }

            dgvVitals.DataSource = null;
            dgvVitals.DataSource = VitalsService.GetByPatient(_patientId);

            dgvConsultations.DataSource = null;
            dgvConsultations.DataSource = ConsultService.GetByPatient(_patientId);

            dgvPrescriptions.DataSource = null;
            dgvPrescriptions.DataSource = PrescriptionService.GetByPatient(_patientId);

            txtHxAllergies.Text = p.KnownAllergies ?? "";
            txtHxConditions.Text = p.ChronicConditions ?? "";
            txtHxSurgeries.Text = p.PastSurgeries ?? "";
            txtHxFamily.Text = p.FamilyHistory ?? "";
            txtHxMeds.Text = p.CurrentMedications ?? "";

            FormatVitalsGrid();
            FormatConsultGrid();
            FormatRxGrid();
        }

        private void ConfigureGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = true;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetHistoryReadOnly()
        {
            txtHxAllergies.ReadOnly = true;
            txtHxConditions.ReadOnly = true;
            txtHxSurgeries.ReadOnly = true;
            txtHxFamily.ReadOnly = true;
            txtHxMeds.ReadOnly = true;
        }

        private void ClearView()
        {
            _patientId = 0;
            lblPatientName.Text = "";
            lblMeta.Text = "";
            lblAllergy.Text = "";
            lblAllergy.Visible = false;
            dgvVitals.DataSource = null;
            dgvConsultations.DataSource = null;
            dgvPrescriptions.DataSource = null;
            txtHxAllergies.Clear();
            txtHxConditions.Clear();
            txtHxSurgeries.Clear();
            txtHxFamily.Clear();
            txtHxMeds.Clear();
        }

        private void FormatVitalsGrid()
        {
            string[] hide = { "VitalId", "PatientId", "RecordedBy" };
            foreach (var c in hide)
                if (dgvVitals.Columns[c] != null)
                    dgvVitals.Columns[c].Visible = false;

            if (dgvVitals.Columns["RecordedAt"] != null)
                dgvVitals.Columns["RecordedAt"].HeaderText = "Date / Time";
        }

        private void FormatConsultGrid()
        {
            string[] hide = { "ConsultationId", "PatientId", "DoctorId", "IsLocked", "VitalId" };
            foreach (var c in hide)
                if (dgvConsultations.Columns[c] != null)
                    dgvConsultations.Columns[c].Visible = false;

            if (dgvConsultations.Columns["ConsultDate"] != null)
                dgvConsultations.Columns["ConsultDate"].DisplayIndex = 0;
        }

        private void FormatRxGrid()
        {
            string[] hide = { "PrescriptionId", "ConsultationId", "PatientId" };
            foreach (var c in hide)
                if (dgvPrescriptions.Columns[c] != null)
                    dgvPrescriptions.Columns[c].Visible = false;
        }

        private void btnEditHistory_Click(object sender, EventArgs e)
        {
            if (_patientId <= 0)
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            _shell.NavigateTo("medhistory", _patientId);
        }
    }
}
