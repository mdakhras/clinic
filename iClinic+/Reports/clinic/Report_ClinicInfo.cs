using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Reports.clinic
{
    public partial class Report_ClinicInfo : Form
    {
        public Report_ClinicInfo()
        {
            InitializeComponent();
        }

        private void Report_ClinicInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.ClinicInfo' table. You can move, or remove it, as needed.
            this.clinicInfoTableAdapter.Fill(this.clinic_DBDataSet.ClinicInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
