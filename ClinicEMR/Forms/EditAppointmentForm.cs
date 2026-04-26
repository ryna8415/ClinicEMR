using ClinicEMR.Models;
using ClinicEMR.Services;
using System;
using System.Windows.Forms;

namespace ClinicEMR.Forms
{
    public partial class EditAppointmentForm : Form
    {
        private readonly int _appointmentId;
        private readonly int _actorUserId;
        private Appointment? _appointment;
        private Appointment? _originalAppointment;
        private bool _isSaving;

        public EditAppointmentForm(int appointmentId, int actorUserId)
        {
            InitializeComponent();
            _appointmentId = appointmentId;
            _actorUserId = actorUserId;
            WireActions();

            LoadDoctorOptions();
            LoadTimeSlots();
            LoadStatusOptions();
            LoadAppointment();
        }

        private void WireActions()
        {
            btnSave.Click -= btnSave_Click;
            btnSave.Click += btnSave_Click;

            btnCancel.Click -= btnCancel_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void LoadDoctorOptions()
        {
            var doctors = UserService.GetByRole("doctor");
            cboDoctor.DataSource = doctors;
            cboDoctor.DisplayMember = "FullName";
            cboDoctor.ValueMember = "UserId";
        }

        private void LoadTimeSlots()
        {
            cboTime.Items.Clear();

            TimeSpan start = new TimeSpan(8, 0, 0);
            TimeSpan end = new TimeSpan(17, 0, 0);

            for (TimeSpan time = start; time <= end; time = time.Add(TimeSpan.FromMinutes(30)))
            {
                cboTime.Items.Add(time.ToString(@"hh\:mm"));
            }
        }

        private void LoadStatusOptions()
        {
            cboEditStatus.Items.Clear();
            cboEditStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled", "No-Show" });
        }

        private void LoadAppointment()
        {
            try
            {
                _appointment = AppointmentService.GetById(_appointmentId);
                if (_appointment == null)
                {
                    MessageBox.Show("Unable to load the selected appointment.");
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                _originalAppointment = new Appointment
                {
                    AppointmentId = _appointment.AppointmentId,
                    PatientId = _appointment.PatientId,
                    PatientName = _appointment.PatientName,
                    DoctorId = _appointment.DoctorId,
                    DoctorName = _appointment.DoctorName,
                    ApptDate = _appointment.ApptDate,
                    ApptTime = _appointment.ApptTime,
                    Purpose = _appointment.Purpose,
                    Status = _appointment.Status,
                    CreatedBy = _appointment.CreatedBy
                };

                Text = "Edit Appointment";
                label1.Text = "Edit Appointment";
                lblMeta.Text = "Update the appointment details below";
                lblPatient.Text = _appointment.PatientName;

                cboDoctor.SelectedValue = _appointment.DoctorId;
                dtpEditDate.Value = _appointment.ApptDate.Date;
                cboTime.SelectedItem = _appointment.ApptTime.ToString(@"hh\:mm");
                txtPurpose.Text = _appointment.Purpose ?? string.Empty;
                cboEditStatus.SelectedItem = _appointment.Status;

                if (cboTime.SelectedIndex < 0 && cboTime.Items.Count > 0)
                {
                    cboTime.SelectedIndex = 0;
                }

                if (cboEditStatus.SelectedIndex < 0)
                {
                    cboEditStatus.SelectedItem = "Scheduled";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load the selected appointment.\n{ex.Message}", "Appointments",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (_isSaving)
            {
                return;
            }

            if (_appointment == null || _originalAppointment == null)
            {
                MessageBox.Show("Unable to load the selected appointment.");
                return;
            }

            if (cboDoctor.SelectedValue == null)
            {
                MessageBox.Show("Please select a doctor.");
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

            if (!int.TryParse(cboDoctor.SelectedValue?.ToString(), out var doctorId))
            {
                MessageBox.Show("Please select a valid doctor.");
                return;
            }

            if (!TimeSpan.TryParse(cboTime.SelectedItem?.ToString(), out var selectedTime))
            {
                MessageBox.Show("Please select a valid appointment time.");
                return;
            }

            _appointment.DoctorId = doctorId;
            _appointment.ApptDate = dtpEditDate.Value.Date;
            _appointment.ApptTime = selectedTime;
            _appointment.Purpose = txtPurpose.Text.Trim();
            _appointment.Status = cboEditStatus.SelectedItem?.ToString() ?? "Scheduled";

            DateTime originalAppointmentDateTime = _originalAppointment.ApptDate.Date.Add(_originalAppointment.ApptTime);
            bool isPastAppointment = originalAppointmentDateTime < DateTime.Now;
            bool scheduleChanged =
                _appointment.DoctorId != _originalAppointment.DoctorId ||
                _appointment.ApptDate.Date != _originalAppointment.ApptDate.Date ||
                _appointment.ApptTime != _originalAppointment.ApptTime ||
                !string.Equals(_appointment.Purpose, _originalAppointment.Purpose, StringComparison.Ordinal);

            try
            {
                _isSaving = true;

                if (isPastAppointment && !scheduleChanged)
                {
                    AppointmentService.UpdateStatus(_appointment.AppointmentId, _appointment.Status);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                if (!AppointmentService.UpdateAppointment(_appointment, _actorUserId))
                {
                    MessageBox.Show("The appointment could not be saved. Please check for scheduling conflicts or past date/time.");
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to save the appointment right now.\n{ex.Message}", "Appointments",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSaving = false;
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
