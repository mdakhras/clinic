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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.firstrun == 0)
            {
                FirstRun firstrun = new FirstRun();
                firstrun.ShowDialog();
            }
            else
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            Drugs.Drug drg = new Drugs.Drug();
            drg.MdiParent = this;
            drg.WindowState = FormWindowState.Maximized;
            drg.Show();
        
        }
    }
}
