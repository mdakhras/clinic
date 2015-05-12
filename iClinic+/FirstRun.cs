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
    public partial class FirstRun : DevComponents.DotNetBar.Office2007Form
    {
        public FirstRun()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clinic_DBDataSet);

        }

        private void FirstRun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinic_DBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.clinic_DBDataSet.user);
            this.userBindingSource.AddNew();

        }

        private void licenceidTextBox_TextChanged(object sender, EventArgs e)
        {
            string mask = DateTime.Now.Year+""+DateTime.Now.Month+""+DateTime.Now.Day+""+licenceidTextBox.Text;

            globalidTextBox.Text = mask;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            bool flag =true;
            if(!passwordTextBox.Text.Equals(tb_confirmpwd.Text) )
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(fullnameTextBox.Text) || string.IsNullOrEmpty(mobileTextBox.Text) || string.IsNullOrEmpty(licenceidTextBox.Text))
            {
                flag = false;
            }
             

            if (flag )
            {

            }
        }
    }
}
