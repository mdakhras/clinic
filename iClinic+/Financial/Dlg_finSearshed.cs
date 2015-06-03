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
    public partial class Dlg_finSearshed : DevComponents.DotNetBar.Office2007Form
    {
        public Dlg_finSearshed()
        {
            InitializeComponent();
        }

        private void btn_sarech_Click(object sender, EventArgs e)
        {
            clinic_DBDataSetTableAdapters.financialTableAdapter datefin = new clinic_DBDataSetTableAdapters.financialTableAdapter();
            //DateTime? dd = datefin.GetData(dateTimePicker1.);
             

        }
    }
}
