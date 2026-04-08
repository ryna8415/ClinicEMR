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
        public BookAppointmentForm(int createdByUserId)
        {
            InitializeComponent();

            _createdBy = createdByUserId;
            cboPatient.DataSource = PatientService.GetAll();
            LoadTimeSlots();
            cboPatient.DisplayMember = "FullName";
            cboPatient.ValueMember = "PatientId";
            cboDoctor.DataSource = UserService.GetByRole("doctor");
            cboDoctor.DisplayMember = "FullName";
            cboDoctor.ValueMember = "UserId";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            TimeSpan selectedTime = TimeSpan.Parse(cboTime.SelectedItem.ToString());


            var a = new Appointment
            {
                PatientId = (int)cboPatient.SelectedValue,
                DoctorId = (int)cboDoctor.SelectedValue,
                ApptDate = dtpDate.Value.Date,
                ApptTime = selectedTime,
                Purpose = txtPurpose.Text.Trim(),
                CreatedBy = _createdBy
            };
            bool ok = AppointmentService.Book(a);


            if (cboPatient.SelectedValue == null || cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select both patient and doctor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                MessageBox.Show("Please enter purpose of visit.");
                return;
            }

            if (!ok)
            {
                MessageBox.Show("That time slot is already taken for this doctor.");
                this.DialogResult = DialogResult.None;
                return;
            }

            MessageBox.Show("Appointment booked successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoadTimeSlots()
        {
            cboTime.Items.Clear();

            // Example: 8:00 AM to 5:00 PM every 30 minutes
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
