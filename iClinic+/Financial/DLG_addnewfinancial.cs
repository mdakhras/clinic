using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Financial
{
    public partial class DLG_addnewfinancial : DevComponents.DotNetBar.Office2007Form
    {
        public DLG_addnewfinancial()
        {
            InitializeComponent();
        }

        private void financialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.financialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void DLG_addnewfinancial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.financial' table. You can move, or remove it, as needed.
            this.financialTableAdapter.Fill(this.clinic_DBDataSet.financial);
            this.financialBindingSource.AddNew();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.financialBindingSource.EndEdit();
            this.financialTableAdapter.Update(clinic_DBDataSet.financial);
            this.financialTableAdapter.Fill(clinic_DBDataSet.financial);
            this.Dispose();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cheb_credit_CheckedChanged(object sender, EventArgs e)
        {
            if (cheb_credit.Checked == true)
                creditTextBox.Enabled = true;
            else
                creditTextBox.Enabled = false;
        }

        private void cheb_debit_CheckedChanged(object sender, EventArgs e)
        {
            if (cheb_debit.Checked == true)
                debitTextBox.Enabled = true;
            else
                debitTextBox.Enabled = false;
        }
    }
}
