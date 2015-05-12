using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_
{
    public partial class FirstRun_Clinicinfo : DevComponents.DotNetBar.Office2007Form
    {
        public FirstRun_Clinicinfo()
        {
            InitializeComponent();
        }

        private void clinicInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clinicInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void FirstRun_Clinicinfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.ClinicInfo' table. You can move, or remove it, as needed.
            this.clinicInfoTableAdapter.Fill(this.clinic_DBDataSet.ClinicInfo);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(specTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || string.IsNullOrEmpty(telTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(websiteTextBox.Text))
            {
                flag = false;

            }//end if

            if (flag)
            {
                this.clinicInfoBindingSource.EndEdit();
                this.clinicInfoTableAdapter.Update(clinic_DBDataSet.ClinicInfo);
                this.Dispose();
                Login login = new Login();
                login.ShowDialog();
            }//end if
                
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }
    }
}
