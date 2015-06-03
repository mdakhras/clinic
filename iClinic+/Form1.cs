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

        private void btn_clinic_info_Click(object sender, EventArgs e)
        {
            clinicinfo.Clinic_info clin_fo = new clinicinfo.Clinic_info();
           
            clin_fo.ShowDialog(); 
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            Doctors.Doctors doc = new Doctors.Doctors();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
        }

        private void btn_Appointment_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment.Frmappointment appointment = new Appointment.Frmappointment();
                appointment.MdiParent = this;
                appointment.WindowState = FormWindowState.Maximized;
                appointment.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_financial_Click(object sender, EventArgs e)
        {
            Financial.Frmfinancial frm = new Financial.Frmfinancial();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btn_rclinicinfo_Click(object sender, EventArgs e)
        {
            Reports.clinic.Report_ClinicInfo frm = new Reports.clinic.Report_ClinicInfo();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void btn_rdoctors_Click(object sender, EventArgs e)
        {
            Reports.doctors.Report_Doctors  frm = new Reports.doctors.Report_Doctors();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

       
    }
}
