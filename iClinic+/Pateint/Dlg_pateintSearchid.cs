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
    public partial class Dlg_pateintSearchid : DevComponents.DotNetBar.Office2007Form
    {
        int pateintid = 0;
        public Dlg_pateintSearchid()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //int 
            clinic_DBDataSetTableAdapters.PateintTableAdapter adap = new clinic_DBDataSetTableAdapters.PateintTableAdapter();
             int? id =  adap.GetPatientIdbyIdentity(tb_idenitityval.Text);
             if (id != null)
             {
                 pateintid = id.Value;
             }
             this.Hide();
        }

        public int GetPateintid()
        {
            return pateintid;
        }
    }
}
