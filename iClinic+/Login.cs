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
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_usname.Text) || string.IsNullOrEmpty(tb_pwd.Text))
            {
                MessageBox.Show("يرجى تعبئة الحقول المطلوبة!");
            }
            else
            {
                clinic_DBDataSetTableAdapters.userTableAdapter userAdapter = new clinic_DBDataSetTableAdapters.userTableAdapter();
                clinic_DBDataSet.userDataTable usDT = userAdapter.GetUserLoginData(tb_pwd.Text, tb_usname.Text);
                if (usDT.Rows.Count > 0)
                {
                    Properties.Settings.Default.username = usDT[0]["fullname"].ToString();
                    

                    Properties.Settings.Default.userid = int.Parse(usDT[0]["id"].ToString());

                    Properties.Settings.Default.Save();

                    this.Dispose();

                    MessageBox.Show("Welcone Dr." + Properties.Settings.Default.username + " With ID:" + Properties.Settings.Default.userid);
                   
                }
                else
                {
                    MessageBox.Show("تأكد من صحة البيانات!");
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
