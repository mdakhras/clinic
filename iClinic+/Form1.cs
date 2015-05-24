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
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
            Pateint.Pateint pateint = new Pateint.Pateint();
            pateint.MdiParent = this;
            pateint.WindowState = FormWindowState.Maximized;
            pateint.Show();
        }

        private void btn_visits_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
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
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
            Drugs.Drug drg = new Drugs.Drug();
            drg.MdiParent = this;
            drg.WindowState = FormWindowState.Maximized;
            drg.Show();
        
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) //close childrens only when there are some
            {
                foreach (Form childForm in this.MdiChildren)
                    childForm.Close();

                // e.Cancel = true;  //cancel Form2 closing
            }

            appointment.appointment ap = new appointment.appointment();
            ap.MdiParent = this;
            ap.WindowState = FormWindowState.Maximized;
            ap.Show();



        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
