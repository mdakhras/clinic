using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Pateint
{
    public partial class Pateint : DevComponents.DotNetBar.Office2007Form
    {
        public Pateint()
        {
            InitializeComponent();
        }

        private void Pateint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Gendermeta' table. You can move, or remove it, as needed.
            this.gendermetaTableAdapter.Fill(this.clinic_DBDataSet.Gendermeta);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Pateint' table. You can move, or remove it, as needed.
            this.pateintTableAdapter.Fill(this.clinic_DBDataSet.Pateint);

        }

        private void btn_addP_Click(object sender, EventArgs e)
        {
            Dlg_AddPateint dlg = new Dlg_AddPateint();
            dlg.ShowDialog();
            pateintTableAdapter.Fill(clinic_DBDataSet.Pateint);
        }

        private void btn_deleteP_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حذف السجل بالتأكيد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.pateintBindingSource.RemoveCurrent();
                this.pateintBindingSource.EndEdit();
                this.pateintTableAdapter.Update(clinic_DBDataSet.Pateint);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            this.pateintBindingSource.EndEdit();
            this.pateintTableAdapter.Update(clinic_DBDataSet.Pateint);
        }
    }
}
