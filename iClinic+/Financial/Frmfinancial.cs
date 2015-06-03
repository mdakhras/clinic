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
    public partial class Frmfinancial : DevComponents.DotNetBar.Office2007Form
    {
        public Frmfinancial()
        {
            InitializeComponent();
        }

        private void Frmfinancial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.financial' table. You can move, or remove it, as needed.
            this.financialTableAdapter.Fill(this.clinic_DBDataSet.financial);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DLG_addnewfinancial frm = new DLG_addnewfinancial();
            frm.ShowDialog();
            financialTableAdapter.Fill(clinic_DBDataSet.financial);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حفظ التعديلات ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.financialBindingSource.EndEdit();
                this.financialTableAdapter.Update(clinic_DBDataSet.financial);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Dlg_finSearshed frm = new Dlg_finSearshed();
            frm.ShowDialog();
            

        }
    }
}
