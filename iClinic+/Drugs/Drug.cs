﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Drugs
{
    public partial class Drug : DevComponents.DotNetBar.Office2007Form
    {
        public Drug()
        {
            InitializeComponent();
        }

        private void clinicInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.clinicInfoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void drugBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Drug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.clinic_DBDataSet.drug);
            this.drugBindingSource.AddNew();
        }

        private void btn_Adddrug_Click(object sender, EventArgs e)
        {
            Dlg_AddDrugs dlg = new Dlg_AddDrugs();
            dlg.ShowDialog();
            drugTableAdapter.Fill(clinic_DBDataSet.drug);
        }

        private void btn_DeletDrug_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حذف الدواء بالتأكيد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.drugBindingSource.RemoveCurrent();
                this.drugBindingSource.EndEdit();
                this.drugTableAdapter.Update(clinic_DBDataSet.drug);
            }
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حفظ التعديلات ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.drugBindingSource.EndEdit();
                this.drugTableAdapter.Update(clinic_DBDataSet.drug);
            }
        }
    }
}
