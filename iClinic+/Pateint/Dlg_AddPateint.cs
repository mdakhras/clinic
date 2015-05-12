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
    public partial class Dlg_AddPateint : DevComponents.DotNetBar.Office2007Form
    {
        public Dlg_AddPateint()
        {
            InitializeComponent();
        }

        private void pateintBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pateintBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Dlg_AddPateint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Gendermeta' table. You can move, or remove it, as needed.
            this.gendermetaTableAdapter.Fill(this.clinic_DBDataSet.Gendermeta);
            this.pateintBindingSource.AddNew();

            cb_gender.SelectedIndex = 0;
            pregnancyCheckBox.Checked = false;
            cb_gender.Refresh();

            tb_drid.Text = Properties.Settings.Default.userid.ToString();
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Pateint' table. You can move, or remove it, as needed.
          //  this.pateintTableAdapter.Fill(this.clinic_DBDataSet.Pateint);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool Saveflag = true;

            if (cb_gender.SelectedIndex == 0)
            {
                if (pregnancyCheckBox.Checked)
                {
                    Saveflag = false;
                    MessageBox.Show("الرجاء تعديل نوع المريض");
                }
            }


            //----if save options Okay Do Save
            if (Saveflag)
            {
                this.pateintBindingSource.EndEdit();
                this.pateintTableAdapter.Update(clinic_DBDataSet.Pateint);
                this.Dispose();
            }
            //this.pateintTableAdapter.
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
