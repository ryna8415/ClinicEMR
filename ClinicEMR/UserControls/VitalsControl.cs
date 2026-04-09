using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class VitalsControl : UserControl
    {
        private int _selectedPatientId = 0;
        private readonly User _user;
        private bool _isLoadingPatients = false;
        private readonly Label _historyPlaceholder;


        public VitalsControl(User user, MainShellForm shell)
        {
            InitializeComponent(); 
            _user = user;
            GridViewService.MakeReadOnly(dgvHistory);
            _historyPlaceholder = CreateGridPlaceholder(
                dgvHistory,
                "Choose a patient to display previous readings.");

            LoadPatients();
            ShowGridPlaceholder("Choose a patient to display previous readings.");

        }

        // Called from outside (e.g. patient list 'Take Vitals' button)
        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            _selectedPatientId = patientId;
            var p = PatientService.GetById(patientId);
            lblPatientName.Text = p?.FullName ?? "Unknown";
            LoadHistory();
        }

        private void CalculateBmi()
        {
            decimal h = nudHeight.Value / 100m;
            decimal w = nudWeight.Value;

            if (h > 0 && w > 0)
            {
                decimal bmi = w / (h * h);
                lblBmi.Text = bmi.ToString("F1");
            }
            else
            {
                lblBmi.Text = "";
            }
        }

        private void nudHeight_ValueChanged(object s, EventArgs e) => CalculateBmi();
        private void nudWeight_ValueChanged(object s, EventArgs e) => CalculateBmi();

        private void btnSave_Click(object s, EventArgs e)
        {
            if (cmbPatients.SelectedIndex == -1)
            {
                MessageBox.Show("Search and select a patient first.");
                return;
            }

            bool hasCoreVitals =
                (!string.IsNullOrWhiteSpace(txtBP.Text) && txtBP.Text.Contains("/")) ||
                nudHR.Value > 0 ||
                nudTemp.Value > 0;

            if (!hasCoreVitals)
            {
                MessageBox.Show("Please enter at least one valid vital sign before saving.");
                return;
            }

            bool hasHeightWeight =
                nudHeight.Value > 0 &&
                nudWeight.Value > 0;

            decimal bmi = 0;

            if ((nudHeight.Value > 0 && nudWeight.Value == 0) ||
                (nudHeight.Value == 0 && nudWeight.Value > 0))
            {
                MessageBox.Show("Please enter BOTH height and weight for BMI.");
                return;
            }
            if (hasHeightWeight)
            {
                decimal h = nudHeight.Value / 100m; // cm → meters
                bmi = nudWeight.Value / (h * h);
                bmi = Math.Round(bmi, 1);
                lblBmi.Text = bmi.ToString("F1");
            }
            else
            {
                bmi = 0; // or null if you change DB later
            }

            int patientId = (int)cmbPatients.SelectedValue;


            var v = new VitalSigns
            {
                PatientId = patientId,
                RecordedBy = _user.UserId,
                BloodPressure = txtBP.Text.Trim(),
                HeartRate = (int)nudHR.Value,
                Temperature = nudTemp.Value,
                HeightCm = nudHeight.Value,
                WeightKg = nudWeight.Value,
                Bmi = Math.Round(bmi, 1)
            };

            VitalsService.Record(v);

            MessageBox.Show("Vitals saved!");
            LoadHistory();
            dgvHistory.Refresh();
        }
        private void LoadHistory()
        {
            if (cmbPatients.SelectedIndex == -1)
            {
                dgvHistory.DataSource = null;
                ShowGridPlaceholder("Choose a patient to display previous readings.");
                return;
            }

            int patientId = (int)cmbPatients.SelectedValue;
            var history = VitalsService.GetByPatient(patientId);

            dgvHistory.DataSource = history;
            GridViewService.ShowOnly(
                dgvHistory,
                "RecordedAt",
                "BloodPressure",
                "HeartRate",
                "Temperature",
                "Bmi",
                "RecordedByName");

            GridViewService.SetHeaders(dgvHistory, new Dictionary<string, string>
            {
                ["RecordedAt"] = "Date",
                ["BloodPressure"] = "BP",
                ["HeartRate"] = "HR",
                ["Temperature"] = "Temp",
                ["Bmi"] = "BMI",
                ["RecordedByName"] = "Recorded By"
            });

            ShowGridPlaceholder(history.Count == 0 ? "No vitals to show for this patient yet." : null);
        }

        private void LoadPatients()
        {
            LoadPatients(_selectedPatientId);
        }

        public void RefreshPatients(int? selectedPatientId = null)
        {
            LoadPatients(selectedPatientId ?? _selectedPatientId);
        }

        private void LoadPatients(int? selectedPatientId)
        {
            _isLoadingPatients = true;

            var patients = PatientService.GetAll();

            cmbPatients.DataSource = null;
            cmbPatients.DataSource = patients;
            cmbPatients.DisplayMember = "FullName";
            cmbPatients.ValueMember = "PatientId";

            cmbPatients.SelectedIndex = -1;

            if (selectedPatientId.HasValue && selectedPatientId.Value > 0)
            {
                for (int i = 0; i < cmbPatients.Items.Count; i++)
                {
                    if (cmbPatients.Items[i] is Patient patient && patient.PatientId == selectedPatientId.Value)
                    {
                        cmbPatients.SelectedIndex = i;
                        break;
                    }
                }
            }

            _isLoadingPatients = false;
        }


        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoadingPatients) return;
            if (cmbPatients.SelectedIndex == -1) return;

            var selected = (Patient)cmbPatients.SelectedItem;
            _selectedPatientId = selected.PatientId;

            lblPatientName.Text = selected.FullName;

            LoadHistory();
        }

        private Label CreateGridPlaceholder(DataGridView grid, string text)
        {
            var placeholder = new Label
            {
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Text = text,
                Visible = false,
                Bounds = grid.Bounds,
                Anchor = grid.Anchor
            };

            Controls.Add(placeholder);
            placeholder.BringToFront();
            return placeholder;
        }

        private void ShowGridPlaceholder(string? message)
        {
            bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
            _historyPlaceholder.Text = message ?? string.Empty;
            _historyPlaceholder.Visible = showPlaceholder;
            dgvHistory.Visible = !showPlaceholder;
        }
    }

}
