using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.clinicinfo
{
    public partial class Clinic_info :DevComponents.DotNetBar.Office2007Form 
    {
        public Clinic_info()
        {
            InitializeComponent();
        }

        private void btn_editclinicinfo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد  حفظ التعديل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.clinicInfoBindingSource.EndEdit();
                this.clinicInfoTableAdapter.Update(this.clinic_DBDataSet.ClinicInfo);
            }
        }

        private void Clinic_info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.ClinicInfo' table. You can move, or remove it, as needed.
            this.clinicInfoTableAdapter.Fill(this.clinic_DBDataSet.ClinicInfo);

        }

        private void btn_exitclinicInfo_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
