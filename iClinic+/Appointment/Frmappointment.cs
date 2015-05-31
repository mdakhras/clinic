using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iClinic_.Appointment;


namespace iClinic_.Appointment
{
    public partial class Frmappointment : DevComponents.DotNetBar.Office2007Form
    {
        public Frmappointment()
        {
            InitializeComponent();
        }

        private void btn_addappointment_Click(object sender, EventArgs e)
        {
           
           Dlg_appointment dlg = new Dlg_appointment();
           dlg.ShowDialog();
           appointmentTableAdapter.Fill(this.clinic_DBDataSet.Appointment);

         }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.Appointment' table. You can move, or remove it, as needed.
           // this.appointmentTableAdapter.Fill(this.clinic_DBDataSet.Appointment);
           // this.appointmentBindingSource.AddNew();

        }

        private void btn_deleteappointment_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حذف الموعد بالتأكيد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.appointmentBindingSource.RemoveCurrent();
                this.appointmentBindingSource.EndEdit();
                this.appointmentTableAdapter.Update(clinic_DBDataSet.Appointment);
            }
        }
    }
}
