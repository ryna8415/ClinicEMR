using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
	public partial class AddPatientForm : Form
	{
		public AddPatientForm()
		{
			InitializeComponent();
			btnSave.Click += btnSave_Click;
			cboSex.DropDownStyle = ComboBoxStyle.DropDownList;
			dtpDOB.MaxDate = DateTime.Today;
			txtContact.MaxLength = 16;
			txtEmergency.MaxLength = 11;
			txtEmergency.KeyPress += txtEmergency_KeyPress;
			txtFirstName.TextChanged += (_, _) => ClearError(lblFirstNameError);
			txtLastName.TextChanged += (_, _) => ClearError(lblLastNameError);
			cboSex.SelectedIndexChanged += (_, _) => ClearError(lblSexError);
			dtpDOB.ValueChanged += (_, _) => ClearError(lblDobError);
			txtContact.TextChanged += (_, _) => ClearError(lblContactError);
			txtEmergency.TextChanged += (_, _) => ClearError(lblEmergencyError);
			ThemeService.ApplyTheme(this);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.None;
			ClearAllErrors();

			var firstName = txtFirstName.Text.Trim();
			var lastName = txtLastName.Text.Trim();
			var sex = cboSex.SelectedItem?.ToString() ?? string.Empty;
			var contactNumber = txtContact.Text.Trim();
			var emergencyContactText = txtEmergency.Text.Trim();

			var validationErrors = PatientValidationService.ValidateNewPatientByField(
				firstName,
				lastName,
				dtpDOB.Value,
				sex,
				contactNumber,
				emergencyContactText);

			if (validationErrors.Count > 0)
			{
				ShowError(lblFirstNameError, validationErrors, "FirstName");
				ShowError(lblLastNameError, validationErrors, "LastName");
				ShowError(lblSexError, validationErrors, "Sex");
				ShowError(lblDobError, validationErrors, "DateOfBirth");
				ShowError(lblContactError, validationErrors, "ContactNumber");
				ShowError(lblEmergencyError, validationErrors, "EmergencyContact");
				FocusFirstInvalidField(validationErrors);
				return;
			}

			PatientValidationService.TryNormalizePhilippineContactNumber(contactNumber, out var normalizedContactNumber);
			PatientValidationService.TryParseEmergencyContact(emergencyContactText, out var emergencyContact);

			var p = new Patient
			{
				FirstName = firstName,
				LastName = lastName,
				DateOfBirth = dtpDOB.Value,
				Sex = sex,
				ContactNumber = normalizedContactNumber,
				Address = txtAddress.Text.Trim(),
				EmergencyContact = emergencyContact,
				KnownAllergies = txtAllergies.Text.Trim()
			};

			PatientService.Add(p);
			MessageBox.Show("Patient registered successfully!");
			DialogResult = DialogResult.OK;
			Close();
		}

		private void txtEmergency_KeyPress(object? sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void ClearAllErrors()
		{
			ClearError(lblFirstNameError);
			ClearError(lblLastNameError);
			ClearError(lblSexError);
			ClearError(lblDobError);
			ClearError(lblContactError);
			ClearError(lblEmergencyError);
		}

		private static void ShowError(Label label, Dictionary<string, List<string>> errors, string fieldName)
		{
			if (errors.TryGetValue(fieldName, out var fieldErrors))
			{
				label.Text = string.Join(Environment.NewLine, fieldErrors);
				label.Visible = true;
				return;
			}

			label.Text = string.Empty;
			label.Visible = false;
		}

		private static void ClearError(Label label)
		{
			label.Text = string.Empty;
			label.Visible = false;
		}

		private void FocusFirstInvalidField(Dictionary<string, List<string>> errors)
		{
			if (errors.ContainsKey("FirstName"))
			{
				txtFirstName.Focus();
			}
			else if (errors.ContainsKey("LastName"))
			{
				txtLastName.Focus();
			}
			else if (errors.ContainsKey("Sex"))
			{
				cboSex.Focus();
			}
			else if (errors.ContainsKey("DateOfBirth"))
			{
				dtpDOB.Focus();
			}
			else if (errors.ContainsKey("ContactNumber"))
			{
				txtContact.Focus();
			}
			else if (errors.ContainsKey("EmergencyContact"))
			{
				txtEmergency.Focus();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
