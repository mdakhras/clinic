using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iClinic_.Doctors
{
    public partial class Doctors : DevComponents.DotNetBar.Office2007Form 
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinic_DBDataSet.user);

        }

        private void btn_addDoctors_Click(object sender, EventArgs e)
        {
            Dlg_addnewDoctors doc = new Dlg_addnewDoctors();
            doc.ShowDialog();
            userTableAdapter.Fill(clinic_DBDataSet.user);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حذف السجل بالتأكيد", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.userBindingSource.RemoveCurrent();
                this.userBindingSource.EndEdit();
                this.userTableAdapter.Update(clinic_DBDataSet.user);

            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد حفظ التعديلات ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.userBindingSource.EndEdit();
                this.userTableAdapter.Update(clinic_DBDataSet.user);
            }
        }
    }
}
