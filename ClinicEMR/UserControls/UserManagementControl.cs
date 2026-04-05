using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClinicEMR.Models;
using ClinicEMR.Services;

namespace ClinicEMR.UserControls
{
    public partial class UserManagementControl : UserControl
    {
        private readonly User _user;
        public UserManagementControl(User user)
        {
            InitializeComponent();
            _user = user;
        }
    }

}
