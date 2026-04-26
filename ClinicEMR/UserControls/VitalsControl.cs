using ClinicEMR.Forms;
using ClinicEMR.Helpers;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
    public partial class VitalsControl : UserControl
    {
        private int _selectedPatientId;
        private readonly User _user;
        private bool _isLoadingPatients;
        private readonly Label _historyPlaceholder;

        public VitalsControl(User user, MainShellForm shell)
        {
            InitializeComponent();
            _user = user;

            cmbPatients.SelectedIndexChanged += cmbPatients_SelectedIndexChanged;
            nudHeight.TextChanged += HeightWeight_TextChanged;
            nudWeight.TextChanged += HeightWeight_TextChanged;
            btnSave.Click += btnSave_Click;

            GridViewService.MakeReadOnly(dgvHistory);
            ConfigureBmiBadge();
            ResetBmiDisplay();

            _historyPlaceholder = CreateGridPlaceholder(
                dgvHistory,
                "Choose a patient to display previous readings.");

            LoadPatients();
            ShowGridPlaceholder("Choose a patient to display previous readings.");

            ThemeService.ApplyRoundedCorners(tblInfoIntro, 5);
            ThemeService.TryRoundGrid(dgvHistory, 4);
        }

        public void LoadPatient(int patientId)
        {
            RefreshPatients(patientId);
            _selectedPatientId = patientId;
            UpdatePatientHeader(PatientService.GetById(patientId));
            LoadHistory();
        }

        private void HeightWeight_TextChanged(object? sender, EventArgs e)
        {
            CalculateBmi();
        }

        private void CalculateBmi()
        {
            if (!TryGetDecimal(nudHeight.Text, out decimal heightCm) ||
                !TryGetDecimal(nudWeight.Text, out decimal weightKg) ||
                heightCm <= 0 ||
                weightKg <= 0)
            {
                ResetBmiDisplay();
                return;
            }

            UpdateBmiDisplay(CalculateBmiValue(heightCm, weightKg));
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (cmbPatients.SelectedIndex == -1)
            {
                MessageBox.Show("Search and select a patient first.");
                return;
            }

            if (!ValidateOptionalNumericInputs())
                return;

            string bloodPressure = txtBP.Text.Trim();
            bool hasBloodPressure = !string.IsNullOrWhiteSpace(bloodPressure) && bloodPressure.Contains("/");
            bool hasHeartRate = TryGetInt(nudHR.Text, out int heartRate) && heartRate > 0;
            bool hasTemperature = TryGetDecimal(nudTemp.Text, out decimal temperature) && temperature > 0;

            if (!hasBloodPressure && !hasHeartRate && !hasTemperature)
            {
                MessageBox.Show("Please enter at least one valid vital sign before saving.");
                return;
            }

            bool hasHeightText = !string.IsNullOrWhiteSpace(nudHeight.Text.Trim());
            bool hasWeightText = !string.IsNullOrWhiteSpace(nudWeight.Text.Trim());

            if (hasHeightText ^ hasWeightText)
            {
                MessageBox.Show("Please enter BOTH height and weight for BMI.");
                return;
            }

            decimal heightCm = 0m;
            decimal weightKg = 0m;
            bool hasHeightWeight =
                TryGetDecimal(nudHeight.Text, out heightCm) && heightCm > 0 &&
                TryGetDecimal(nudWeight.Text, out weightKg) && weightKg > 0;

            decimal bmi = hasHeightWeight ? CalculateBmiValue(heightCm, weightKg) : 0m;
            int patientId = (int)cmbPatients.SelectedValue;

            var vital = new VitalSigns
            {
                PatientId = patientId,
                RecordedBy = _user.UserId,
                BloodPressure = bloodPressure,
                HeartRate = hasHeartRate ? heartRate : 0,
                Temperature = hasTemperature ? temperature : 0,
                HeightCm = hasHeightWeight ? heightCm : 0,
                WeightKg = hasHeightWeight ? weightKg : 0,
                Bmi = bmi
            };

            VitalsService.Record(vital);

            MessageBox.Show("Vitals saved!");
            ClearVitalsInputs();
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
                "BmiCategory",
                "RecordedByName");

            GridViewService.SetHeaders(dgvHistory, new Dictionary<string, string>
            {
                ["RecordedAt"] = "Date",
                ["BloodPressure"] = "BP",
                ["HeartRate"] = "HR",
                ["Temperature"] = "Temp",
                ["Bmi"] = "BMI",
                ["BmiCategory"] = "Interpretation",
                ["RecordedByName"] = "Recorded By"
            });

            ConfigureHistoryColumnWidths();

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

        private void cmbPatients_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (_isLoadingPatients)
                return;

            if (cmbPatients.SelectedIndex == -1)
            {
                UpdatePatientHeader(null);
                return;
            }

            var selected = (Patient)cmbPatients.SelectedItem;
            _selectedPatientId = selected.PatientId;
            UpdatePatientHeader(selected);
            LoadHistory();
        }

        private void UpdatePatientHeader(Patient patient)
        {
            if (patient == null)
            {
                lblPatientName.Text = string.Empty;
                lblMeta.Text = string.Empty;
                return;
            }

            lblPatientName.Text = patient.FullName;
            lblMeta.Text = BuildPatientMeta(patient);
        }

        private static string BuildPatientMeta(Patient patient)
        {
            int age = CalculateAge(patient.DateOfBirth);
            return $"{patient.PatientCode}      |      {age} y/o  {patient.Sex}";
        }

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                age--;

            return age;
        }

        private void ConfigureBmiBadge()
        {
            btnBMI.Enabled = false;
            btnBMI.BackColor = Color.Transparent;
            btnBMI.InactiveColor = Color.Transparent;
            btnBMI.EnteredColor = Color.Transparent;
            btnBMI.PressedColor = Color.Transparent;
            btnBMI.BorderColor = Color.Transparent;
            btnBMI.EnteredBorderColor = Color.Transparent;
            btnBMI.PressedBorderColor = Color.Transparent;
        }

        private void ResetBmiDisplay()
        {
            ApplyBmiBadge("Awaiting height/weight", UITheme.BmiEmpty);
        }

        private void UpdateBmiDisplay(decimal bmi)
        {
            string category = GetBmiCategory(bmi);

            switch (category)
            {
                case "Underweight":
                    ApplyBmiBadge($"{bmi:F1} - {category}", UITheme.BmiUnderweight);
                    break;
                case "Normal":
                    ApplyBmiBadge($"{bmi:F1} - {category}", UITheme.BmiNormal);
                    break;
                case "Overweight":
                    ApplyBmiBadge($"{bmi:F1} - {category}", UITheme.BmiOverweight);
                    break;
                default:
                    ApplyBmiBadge($"{bmi:F1} - {category}", UITheme.BmiObese);
                    break;
            }
        }

        private void ApplyBmiBadge(string text, Color foreColor)
        {
            btnBMI.Text = text;
            btnBMI.BackColor = Color.Transparent;
            btnBMI.InactiveColor = Color.Transparent;
            btnBMI.EnteredColor = Color.Transparent;
            btnBMI.PressedColor = Color.Transparent;
            btnBMI.ForeColor = foreColor;
        }

        private static decimal CalculateBmiValue(decimal heightCm, decimal weightKg)
        {
            decimal heightM = heightCm / 100m;
            return Math.Round(weightKg / (heightM * heightM), 1);
        }

        private static string GetBmiCategory(decimal bmi)
        {
            if (bmi <= 0) return string.Empty;
            if (bmi < 18.5m) return "Underweight";
            if (bmi < 25m) return "Normal";
            if (bmi < 30m) return "Overweight";
            return "Obese";
        }

        private bool ValidateOptionalNumericInputs()
        {
            return ValidateNumericText(nudHR.Text, "Heart Rate", false)
                && ValidateNumericText(nudTemp.Text, "Body Temperature", true)
                && ValidateNumericText(nudHeight.Text, "Height", true)
                && ValidateNumericText(nudWeight.Text, "Weight", true);
        }

        private static bool ValidateNumericText(string value, string label, bool allowDecimal)
        {
            string text = value.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return true;

            bool valid = allowDecimal
                ? decimal.TryParse(text, out decimal decimalValue) && decimalValue >= 0
                : int.TryParse(text, out int intValue) && intValue >= 0;

            if (valid)
                return true;

            MessageBox.Show($"Please enter a valid {(allowDecimal ? "number" : "whole number")} for {label}.");
            return false;
        }

        private static bool TryGetDecimal(string value, out decimal parsed)
        {
            return decimal.TryParse(value.Trim(), out parsed);
        }

        private static bool TryGetInt(string value, out int parsed)
        {
            return int.TryParse(value.Trim(), out parsed);
        }

        private void ConfigureHistoryColumnWidths()
        {
            if (dgvHistory.Columns.Count == 0)
                return;

            SetColumnFillWeight("RecordedAt", 100);
            SetColumnFillWeight("BloodPressure", 55);
            SetColumnFillWeight("HeartRate", 40);
            SetColumnFillWeight("Temperature", 50);
            SetColumnFillWeight("Bmi", 45);
            SetColumnFillWeight("BmiCategory", 130);
            SetColumnFillWeight("RecordedByName", 140);
        }

        private void SetColumnFillWeight(string columnName, float fillWeight)
        {
            if (dgvHistory.Columns[columnName] is not DataGridViewColumn column)
                return;

            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.FillWeight = fillWeight;
            column.MinimumWidth = columnName switch
            {
                "RecordedByName" => 150,
                "BmiCategory" => 140,
                _ => 60
            };
        }

        private void ClearVitalsInputs()
        {
            txtBP.Text = string.Empty;
            nudHR.Text = string.Empty;
            nudTemp.Text = string.Empty;
            nudHeight.Text = string.Empty;
            nudWeight.Text = string.Empty;
            ResetBmiDisplay();
        }

        private Label CreateGridPlaceholder(DataGridView grid, string text)
        {
            Control parent = grid.Parent ?? this;
            var placeholder = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 249, 250),
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.FromArgb(108, 117, 125),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Text = text,
                Margin = grid.Margin,
                Visible = false
            };

            if (parent is TableLayoutPanel layout)
            {
                var position = layout.GetPositionFromControl(grid);
                layout.Controls.Add(placeholder, position.Column, position.Row);
            }
            else
            {
                parent.Controls.Add(placeholder);
            }

            placeholder.BringToFront();
            return placeholder;
        }

        private void ShowGridPlaceholder(string message)
        {
            bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
            _historyPlaceholder.Text = message ?? string.Empty;
            _historyPlaceholder.Visible = showPlaceholder;
            dgvHistory.Visible = !showPlaceholder;
        }
    }
}
