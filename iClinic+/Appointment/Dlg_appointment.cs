using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Appointment
{
    public partial class Dlg_appointment : DevComponents.DotNetBar.Office2007Form
    {
        public Dlg_appointment()
        {
            InitializeComponent();
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void Dlg_appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.clinic_DBDataSet.Appointment);

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            this.appointmentBindingSource.EndEdit();
            this.appointmentTableAdapter.Update(clinic_DBDataSet.Appointment);
           // this.appointmentTableAdapter.Fill(clinic_DBDataSet.Appointment);

            this.Dispose();
            

        }
    }
}
