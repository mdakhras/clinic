namespace iClinic_.clinicinfo
{
    partial class Clinic_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitclinicInfo = new DevComponents.DotNetBar.ButtonX();
            this.btn_editclinicinfo = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_website = new System.Windows.Forms.TextBox();
            this.clinicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_spec = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clinicInfoTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.ClinicInfoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 58);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "يرجي ادخال بيانات العيادة ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exitclinicInfo);
            this.panel2.Controls.Add(this.btn_editclinicinfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 61);
            this.panel2.TabIndex = 1;
            // 
            // btn_exitclinicInfo
            // 
            this.btn_exitclinicInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exitclinicInfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exitclinicInfo.Location = new System.Drawing.Point(76, 20);
            this.btn_exitclinicInfo.Name = "btn_exitclinicInfo";
            this.btn_exitclinicInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_exitclinicInfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exitclinicInfo.TabIndex = 1;
            this.btn_exitclinicInfo.Text = "خروج";
            this.btn_exitclinicInfo.Click += new System.EventHandler(this.btn_exitclinicInfo_Click);
            // 
            // btn_editclinicinfo
            // 
            this.btn_editclinicinfo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editclinicinfo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editclinicinfo.Location = new System.Drawing.Point(165, 21);
            this.btn_editclinicinfo.Name = "btn_editclinicinfo";
            this.btn_editclinicinfo.Size = new System.Drawing.Size(75, 23);
            this.btn_editclinicinfo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editclinicinfo.TabIndex = 0;
            this.btn_editclinicinfo.Text = "تعديل";
            this.btn_editclinicinfo.Click += new System.EventHandler(this.btn_editclinicinfo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_website);
            this.panel3.Controls.Add(this.textBox_email);
            this.panel3.Controls.Add(this.textBox_tel);
            this.panel3.Controls.Add(this.textBox_address);
            this.panel3.Controls.Add(this.textBox_spec);
            this.panel3.Controls.Add(this.textBox_name);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 241);
            this.panel3.TabIndex = 2;
            // 
            // textBox_website
            // 
            this.textBox_website.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "website", true));
            this.textBox_website.Location = new System.Drawing.Point(16, 181);
            this.textBox_website.Name = "textBox_website";
            this.textBox_website.Size = new System.Drawing.Size(164, 20);
            this.textBox_website.TabIndex = 18;
            // 
            // clinicInfoBindingSource
            // 
            this.clinicInfoBindingSource.DataMember = "ClinicInfo";
            this.clinicInfoBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_email
            // 
            this.textBox_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "email", true));
            this.textBox_email.Location = new System.Drawing.Point(16, 148);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(164, 20);
            this.textBox_email.TabIndex = 17;
            // 
            // textBox_tel
            // 
            this.textBox_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "tel", true));
            this.textBox_tel.Location = new System.Drawing.Point(16, 115);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(164, 20);
            this.textBox_tel.TabIndex = 16;
            // 
            // textBox_address
            // 
            this.textBox_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "address", true));
            this.textBox_address.Location = new System.Drawing.Point(18, 82);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(164, 20);
            this.textBox_address.TabIndex = 15;
            // 
            // textBox_spec
            // 
            this.textBox_spec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "spec", true));
            this.textBox_spec.Location = new System.Drawing.Point(18, 49);
            this.textBox_spec.Name = "textBox_spec";
            this.textBox_spec.Size = new System.Drawing.Size(164, 20);
            this.textBox_spec.TabIndex = 14;
            // 
            // textBox_name
            // 
            this.textBox_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "name", true));
            this.textBox_name.Location = new System.Drawing.Point(18, 16);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(164, 20);
            this.textBox_name.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "الموقع الاكتروني ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "البريد الالكتروني ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "رقم التلفون";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "التخصص ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم العيادة";
            // 
            // clinicInfoTableAdapter
            // 
            this.clinicInfoTableAdapter.ClearBeforeFill = true;
            // 
            // Clinic_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Clinic_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات العيادة";
            this.Load += new System.EventHandler(this.Clinic_info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_website;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_spec;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.ButtonX btn_exitclinicInfo;
        private DevComponents.DotNetBar.ButtonX btn_editclinicinfo;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource clinicInfoBindingSource;
        private clinic_DBDataSetTableAdapters.ClinicInfoTableAdapter clinicInfoTableAdapter;

    }
}