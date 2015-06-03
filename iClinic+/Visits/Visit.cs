using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Visits
{
    public partial class Visit : DevComponents.DotNetBar.Office2007Form
    {
        public Visit()
        {
            InitializeComponent();
        }

        private void Visit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.VisitTypemeta' table. You can move, or remove it, as needed.
            this.visitTypemetaTableAdapter.Fill(this.clinic_DBDataSet.VisitTypemeta);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Visit' table. You can move, or remove it, as needed.
           this.visitTableAdapter.Fill(this.clinic_DBDataSet.Visit);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Pateint' table. You can move, or remove it, as needed.
            this.pateintTableAdapter.Fill(this.clinic_DBDataSet.Pateint);

            if (dataGridViewX2.Rows.Count != 0)
            {
                DataRowView drv = (DataRowView)pateintBindingSource.Current;
                int pateintid = (int)drv["id"];

                visitBindingSource.Filter = " pid=" + pateintid;
                visitBindingSource.EndEdit();
            }//end if

        }

        private void dataGridViewX2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView drv = (DataRowView) pateintBindingSource.Current;
            int pateintid = (int) drv["id"];

            visitBindingSource.Filter = " pid=" + pateintid;
            visitBindingSource.EndEdit();

        }

        private void btn_addNewVisit_Click(object sender, EventArgs e)
        {
            if (dataGridViewX2.Rows.Count != 0)
            {
                DataRowView drv = (DataRowView)pateintBindingSource.Current;
                int pateintid = (int)drv["id"];

                Dlg_NewVisit dlg = new Dlg_NewVisit(pateintid);
                dlg.ShowDialog();
                visitTableAdapter.Fill(clinic_DBDataSet.Visit);
                visitBindingSource.Filter = " pid=" + pateintid;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حذف السجل بالتأكيد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.visitBindingSource.RemoveCurrent();
                this.visitBindingSource.EndEdit();
                this.visitTableAdapter.Update(clinic_DBDataSet.Visit);
            }
        }

        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView drv = (DataRowView)pateintBindingSource.Current;
            int pateintid = (int)drv["id"];

            DataRowView drv1 = (DataRowView)visitBindingSource.Current;
            int visitid = (int)drv1["id"];

            Dlg_NewVisit dlg = new Dlg_NewVisit(pateintid, visitid);
            dlg.ShowDialog();

            visitTableAdapter.Fill(clinic_DBDataSet.Visit);
            visitBindingSource.Filter = " pid=" + pateintid;
        }

       
    }
}
