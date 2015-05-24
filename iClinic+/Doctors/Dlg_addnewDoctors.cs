using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Doctors
{
    public partial class Dlg_addnewDoctors : DevComponents.DotNetBar.Office2007Form 
    {
        public Dlg_addnewDoctors()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Dlg_addnewDoctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinic_DBDataSet.user);
            this.userBindingSource.AddNew();

        }

        private void userBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.userBindingSource.EndEdit();
            this.userTableAdapter.Update(clinic_DBDataSet.user);
            this.userTableAdapter.Fill(clinic_DBDataSet.user);
            this.Dispose();
        }

        private void btn_closed_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
