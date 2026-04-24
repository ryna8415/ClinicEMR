using ClinicEMR.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.UserControls
{
	public partial class PatientRecordControl : UserControl
	{
		private int _patientId = 0;
		private readonly User _user;
		private readonly MainShellForm _shell;
		private bool _isLoadingPatients = false;

		// Placeholders for empty states
		private readonly Label _vitalsPlaceholder;
		private readonly Label _consultationsPlaceholder;
		private readonly Label _prescriptionsPlaceholder;

		public PatientRecordControl(User user, MainShellForm shell)
		{
			InitializeComponent();
			_user = user;
			_shell = shell;

			// Initialize Placeholders with themed colors
			_vitalsPlaceholder = CreateGridPlaceholder(tabVitals, "Choose a patient to display vital signs.");
			_consultationsPlaceholder = CreateGridPlaceholder(tabConsultations, "Choose a patient to display consultations.");
			_prescriptionsPlaceholder = CreateGridPlaceholder(tabPrescriptions, "Choose a patient to display prescriptions.");

			// Initial UI Setup
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

			// Header Updates
			lblPatientName.Text = p.FullName.ToUpper();
			int age = CalculateAge(p.DateOfBirth);
			lblMeta.Text = $"{p.PatientCode}  |  {age} Y/O  {p.Sex}  |  {p.ContactNumber}";

			// Allergy Alert Styling
			if (!string.IsNullOrWhiteSpace(p.KnownAllergies))
			{
				lblAllergy.Text = $" ⚠ ALLERGY ALERT: {p.KnownAllergies} ";
				lblAllergy.Visible = true;
				lblAllergy.BackColor = Color.FromArgb(153, 27, 27); // Medical Red
				lblAllergy.ForeColor = Color.White;
				lblAllergy.Padding = new Padding(5, 2, 5, 2);
			}
			else
			{
				lblAllergy.Visible = false;
			}

			// Load Grid Data
			var vitals = VitalsService.GetByPatient(_patientId);
			dgvVitals.DataSource = vitals;

			var consultations = ConsultService.GetByPatient(_patientId);
			dgvConsultations.DataSource = consultations;

			var prescriptions = PrescriptionService.GetByPatient(_patientId);
			dgvPrescriptions.DataSource = prescriptions;

			// Load Medical History
			txtHxAllergies.Text = p.KnownAllergies ?? "";
			txtHxConditions.Text = p.ChronicConditions ?? "";
			txtHxSurgeries.Text = p.PastSurgeries ?? "";
			txtHxFamily.Text = p.FamilyHistory ?? "";
			txtHxMeds.Text = p.CurrentMedications ?? "";

			// Format UI
			FormatVitalsGrid();
			FormatConsultGrid();
			FormatRxGrid();

			ShowPlaceholder(_vitalsPlaceholder, dgvVitals, vitals.Count == 0 ? "No vital signs recorded for this patient." : null);
			ShowPlaceholder(_consultationsPlaceholder, dgvConsultations, consultations.Count == 0 ? "No consultation history found." : null);
			ShowPlaceholder(_prescriptionsPlaceholder, dgvPrescriptions, prescriptions.Count == 0 ? "No active prescriptions." : null);
		}

		private void ConfigureGrid(DataGridView grid)
		{
			grid.AutoGenerateColumns = true;
			grid.BackgroundColor = Color.White;
			grid.BorderStyle = BorderStyle.None;
			grid.EnableHeadersVisualStyles = false;
			grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			grid.RowHeadersVisible = false;

			// Header Styling
			grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 242, 245);
			grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(37, 45, 56);
			grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F);
			grid.ColumnHeadersHeight = 35;

			// Cell Styling
			grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 235, 245);
			grid.DefaultCellStyle.SelectionForeColor = Color.Black;

			GridViewService.MakeReadOnly(grid);
		}

		private void ClearView()
		{
			_patientId = 0;
			lblPatientName.Text = "No Patient Selected";
			lblMeta.Text = "";
			lblAllergy.Visible = false;

			dgvVitals.DataSource = null;
			dgvConsultations.DataSource = null;
			dgvPrescriptions.DataSource = null;

			txtHxAllergies.Clear();
			txtHxConditions.Clear();
			txtHxSurgeries.Clear();
			txtHxFamily.Clear();
			txtHxMeds.Clear();

			ShowPlaceholder(_vitalsPlaceholder, dgvVitals, "Choose a patient to display vital signs.");
			ShowPlaceholder(_consultationsPlaceholder, dgvConsultations, "Choose a patient to display consultations.");
			ShowPlaceholder(_prescriptionsPlaceholder, dgvPrescriptions, "Choose a patient to display prescriptions.");
		}

		private void SetHistoryReadOnly()
		{
			txtHxAllergies.ReadOnly = true;
			txtHxConditions.ReadOnly = true;
			txtHxSurgeries.ReadOnly = true;
			txtHxFamily.ReadOnly = true;
			txtHxMeds.ReadOnly = true;
		}

		#region Grid Formatting

		private void FormatVitalsGrid()
		{
			GridViewService.ShowOnly(dgvVitals, "RecordedAt", "BloodPressure", "HeartRate", "Temperature", "Bmi", "RecordedByName");
			GridViewService.SetHeaders(dgvVitals, new Dictionary<string, string>
			{
				["RecordedAt"] = "Date / Time",
				["BloodPressure"] = "BP",
				["HeartRate"] = "HR",
				["Temperature"] = "Temp",
				["Bmi"] = "BMI",
				["RecordedByName"] = "Recorded By"
			});
		}

		private void FormatConsultGrid()
		{
			GridViewService.ShowOnly(dgvConsultations, "ConsultDate", "DoctorName", "ChiefComplaint", "Diagnosis");
			GridViewService.SetHeaders(dgvConsultations, new Dictionary<string, string>
			{
				["ConsultDate"] = "Date",
				["DoctorName"] = "Doctor",
				["ChiefComplaint"] = "Chief Complaint",
				["Diagnosis"] = "Diagnosis"
			});
		}

		private void FormatRxGrid()
		{
			GridViewService.ShowOnly(dgvPrescriptions, "MedicationName", "Dosage", "Frequency", "Duration", "Instructions");
			GridViewService.SetHeaders(dgvPrescriptions, new Dictionary<string, string>
			{
				["MedicationName"] = "Medication",
				["Dosage"] = "Dosage",
				["Frequency"] = "Frequency",
				["Duration"] = "Duration",
				["Instructions"] = "Instructions"
			});
		}

		#endregion

		private void btnEditHistory_Click(object sender, EventArgs e)
		{
			if (_patientId <= 0)
			{
				MessageBox.Show("Please select a patient first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			_shell.NavigateTo("medhistory", _patientId);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (_patientId <= 0) return;

			var patient = PatientService.GetById(_patientId);
			if (patient == null) return;

			var vitals = VitalsService.GetByPatient(_patientId);
			var consultations = ConsultService.GetByPatient(_patientId);
			var prescriptions = PrescriptionService.GetByPatient(_patientId);

			PrintService.ShowPrintPreview(
				this,
				$"Patient Record - {patient.FullName}",
				BuildPrintableRecord(patient, vitals, consultations, prescriptions));
		}

		private Label CreateGridPlaceholder(Control parent, string text)
		{
			var placeholder = new Label
			{
				Dock = DockStyle.Fill,
				BackColor = Color.FromArgb(235, 238, 243),
				ForeColor = Color.FromArgb(108, 117, 125),
				TextAlign = ContentAlignment.MiddleCenter,
				Font = new Font("Segoe UI", 10F, FontStyle.Italic),
				Text = text,
				Visible = false
			};

			parent.Controls.Add(placeholder);
			placeholder.BringToFront();
			return placeholder;
		}

		private void ShowPlaceholder(Label placeholder, DataGridView grid, string? message)
		{
			bool showPlaceholder = !string.IsNullOrWhiteSpace(message);
			placeholder.Text = message ?? string.Empty;
			placeholder.Visible = showPlaceholder;
			grid.Visible = !showPlaceholder;
		}

		private string BuildPrintableRecord(Patient patient, IReadOnlyList<VitalSigns> vitals, IReadOnlyList<Consultation> consultations, IReadOnlyList<Prescription> prescriptions)
		{
			var builder = new StringBuilder();
			int age = CalculateAge(patient.DateOfBirth);

			builder.AppendLine("CLINIC EMR PATIENT RECORD");
			builder.AppendLine($"Printed On: {DateTime.Now:MMMM dd, yyyy hh:mm tt}");
			builder.AppendLine($"Prepared by: {_user.FullName}");
			builder.AppendLine();

			PrintService.AppendSection(builder, "Patient Information", new[]
			{
				$"Name: {patient.FullName}",
				$"DOB: {patient.DateOfBirth:MMMM dd, yyyy} ({age} y/o)",
				$"Sex: {PrintService.DisplayValue(patient.Sex)}",
				$"Contact: {PrintService.DisplayValue(patient.ContactNumber)}"
			});

			PrintService.AppendSection(builder, "Medical History", new[]
			{
				$"Allergies: {PrintService.DisplayValue(patient.KnownAllergies)}",
				$"Chronic Conditions: {PrintService.DisplayValue(patient.ChronicConditions)}",
				$"Current Medications: {PrintService.DisplayValue(patient.CurrentMedications)}"
			});

			return builder.ToString();
		}

		private static int CalculateAge(DateTime dateOfBirth)
		{
			int age = DateTime.Today.Year - dateOfBirth.Year;
			if (dateOfBirth.Date > DateTime.Today.AddYears(-age)) age--;
			return age;
		}
	}
}