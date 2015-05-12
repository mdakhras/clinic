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
    public partial class Dlg_NewVisit : Form
    {
        private int pateintid = 0;
        private bool edit = false;
        private int visitid = 0;
        public Dlg_NewVisit(int pid)
        {
            InitializeComponent();
            pateintid = pid;

            
        }

        public Dlg_NewVisit(int pid,int _visitid)
        {
            InitializeComponent();
            pateintid = pid;
            visitid = _visitid;
            edit = true;
           
        }
       

        private void visitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.visitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Dlg_NewVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.VisitTypemeta' table. You can move, or remove it, as needed.
            this.visitTypemetaTableAdapter.Fill(this.clinic_DBDataSet.VisitTypemeta);
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Visit' table. You can move, or remove it, as needed.
           // this.visitBindingSource.RemoveFilter();
            if (edit)
            {
                
                this.visitTableAdapter.Fill(this.clinic_DBDataSet.Visit);
                this.visitBindingSource.Filter = " id="+visitid;
                pidTextBox.Text = pateintid.ToString();
            }
            else
            {
                this.visitTableAdapter.Fill(this.clinic_DBDataSet.Visit);

                this.visitBindingSource.AddNew();
                cb_visitType.SelectedIndex = 0;
                pidTextBox.Text = pateintid.ToString();
            }
           

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            this.visitBindingSource.EndEdit();
            this.visitTableAdapter.Update(clinic_DBDataSet.Visit);
            this.Dispose();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
