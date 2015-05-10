using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pateint_Click(object sender, EventArgs e)
        {
            Pateint.Pateint pateint = new Pateint.Pateint();
            pateint.MdiParent = this;
            pateint.WindowState = FormWindowState.Maximized;
            pateint.Show();
        }

        private void btn_visits_Click(object sender, EventArgs e)
        {
            Visits.Visit pateint = new Visits.Visit();
            pateint.MdiParent = this;
            pateint.WindowState = FormWindowState.Maximized;
            pateint.Show();
        }
    }
}
