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
            // TODO: This line of code loads data into the 'clinic_DBDataSet.metaJob' table. You can move, or remove it, as needed.
            this.metaJobTableAdapter.Fill(this.clinic_DBDataSet.metaJob);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.metaBloodTypes' table. You can move, or remove it, as needed.
            this.bloodTypemetaTableAdapter.Fill(this.clinic_DBDataSet.metaBloodTypes);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.MritalStatusmeta' table. You can move, or remove it, as needed.
            this.mritalStatusmetaTableAdapter.Fill(this.clinic_DBDataSet.MritalStatusmeta);
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

        private void btn_AddVisit_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)pateintBindingSource.Current;
            int pateintid = (int)drv["id"];
            Visits.Dlg_NewVisit dlg = new Visits.Dlg_NewVisit(pateintid);
            dlg.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Dlg_pateintSearchid frm = new Dlg_pateintSearchid();
            frm.ShowDialog();
            int pateintid = frm.GetPateintid();
            pateintBindingSource.Filter = " id=" + pateintid;
            pateintBindingSource.EndEdit();


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            pateintBindingSource.RemoveFilter();
            pateintBindingSource.EndEdit();
        }
    }
}
