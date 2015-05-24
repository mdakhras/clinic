using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Drugs
{
    public partial class Dlg_AddDrugs : DevComponents.DotNetBar.Office2007Form
    {
        public Dlg_AddDrugs()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.drugBindingSource.EndEdit();
            this.drugTableAdapter.Update(clinic_DBDataSet.drug);
<<<<<<< HEAD
           
=======
            this.drugTableAdapter.Fill(clinic_DBDataSet.drug);
>>>>>>> accc08ea17247c59061d9db819d42a3c2dc36d8c
            this.Dispose();

        }

        private void drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Dlg_AddDrugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.clinic_DBDataSet.drug);
<<<<<<< HEAD
            this.drugBindingSource.AddNew();
=======
>>>>>>> accc08ea17247c59061d9db819d42a3c2dc36d8c

        }
    }
}
