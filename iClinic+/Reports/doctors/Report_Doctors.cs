using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Reports.doctors
{
    public partial class Report_Doctors : Form
    {
        public Report_Doctors()
        {
            InitializeComponent();
        }

        private void Report_Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinic_DBDataSet.user);

            this.reportViewer1.RefreshReport();
        }
    }
}
