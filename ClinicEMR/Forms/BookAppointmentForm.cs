using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class BookAppointmentForm : Form
    {
        private readonly int _createdBy;
        private bool _isBooking;
        public BookAppointmentForm(int createdByUserId)
        {
            InitializeComponent();

            _createdBy = createdByUserId;
            LoadTimeSlots();
            InitializeLookupData();
        }

        private void InitializeLookupData()
        {
            try
            {
                var patients = PatientService.GetAll();
                var doctors = UserService.GetByRole("doctor");

                cboPatient.DataSource = patients;
                cboPatient.DisplayMember = "FullName";
                cboPatient.ValueMember = "PatientId";

                cboDoctor.DataSource = doctors;
                cboDoctor.DisplayMember = "FullName";
                cboDoctor.ValueMember = "UserId";

                if (patients.Count == 0 || doctors.Count == 0)
                {
                    btnSave.Enabled = false;
                    MessageBox.Show(
                        "Appointments need at least one active patient and one active doctor.",
                        "Appointment Setup",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                btnSave.Enabled = false;
                MessageBox.Show($"Unable to load appointment options.\n{ex.Message}", "Appointment Setup",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_isBooking)
            {
                return;
            }

            if (cboPatient.SelectedValue == null || cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select both patient and doctor.");
                return;
            }

            if (cboTime.SelectedItem == null)
            {
                MessageBox.Show("Please select an appointment time.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show("Please enter purpose of visit.");
                return;
            }

            if (!TimeSpan.TryParse(cboTime.SelectedItem?.ToString(), out var selectedTime))
            {
                MessageBox.Show("Please select a valid appointment time.");
                return;
            }

            if (!int.TryParse(cboPatient.SelectedValue.ToString(), out var patientId) ||
                !int.TryParse(cboDoctor.SelectedValue.ToString(), out var doctorId))
            {
                MessageBox.Show("Please choose a valid patient and doctor.");
                return;
            }

            DateTime appointmentDateTime = dtpDate.Value.Date.Add(selectedTime);

            if (appointmentDateTime < DateTime.Now)
            {
                MessageBox.Show("Please select a future appointment date and time.");
                return;
            }

            var a = new Appointment
            {
                PatientId = patientId,
                DoctorId = doctorId,
                ApptDate = dtpDate.Value.Date,
                ApptTime = selectedTime,
                Purpose = txtPurpose.Text.Trim(),
                CreatedBy = _createdBy
            };

            try
            {
                _isBooking = true;
                bool ok = AppointmentService.Book(a);

                if (!ok)
                {
                    MessageBox.Show("The appointment could not be booked. Check for schedule conflicts or past date/time.");
                    this.DialogResult = DialogResult.None;
                    return;
                }

                MessageBox.Show("Appointment booked successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to book the appointment right now.\n{ex.Message}", "Appointments",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
            finally
            {
                _isBooking = false;
            }
        }

        private void LoadTimeSlots()
        {
            cboTime.Items.Clear();

            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);

            for (var time = start; time <= end; time = time.Add(TimeSpan.FromMinutes(30)))
            {
                cboTime.Items.Add(time.ToString(@"hh\:mm"));
            }

            cboTime.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
