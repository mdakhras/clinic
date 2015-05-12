namespace iClinic_
{
    partial class FirstRun
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
            System.Windows.Forms.Label usnameLabel;
            System.Windows.Forms.Label fullnameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label licenceidLabel;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label universityLabel;
            System.Windows.Forms.Label globalidLabel;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.usnameTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.licenceidTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.globalidTextBox = new System.Windows.Forms.TextBox();
            this.btn_next = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_confirmpwd = new System.Windows.Forms.TextBox();
            usnameLabel = new System.Windows.Forms.Label();
            fullnameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            licenceidLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            universityLabel = new System.Windows.Forms.Label();
            globalidLabel = new System.Windows.Forms.Label();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(409, 62);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "يرجى تعبئة معلومات الطبيب";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.tb_confirmpwd);
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Controls.Add(usnameLabel);
            this.panelEx2.Controls.Add(this.usnameTextBox);
            this.panelEx2.Controls.Add(fullnameLabel);
            this.panelEx2.Controls.Add(this.fullnameTextBox);
            this.panelEx2.Controls.Add(passwordLabel);
            this.panelEx2.Controls.Add(this.passwordTextBox);
            this.panelEx2.Controls.Add(emailLabel);
            this.panelEx2.Controls.Add(this.emailTextBox);
            this.panelEx2.Controls.Add(mobileLabel);
            this.panelEx2.Controls.Add(this.mobileTextBox);
            this.panelEx2.Controls.Add(licenceidLabel);
            this.panelEx2.Controls.Add(this.licenceidTextBox);
            this.panelEx2.Controls.Add(degreeLabel);
            this.panelEx2.Controls.Add(this.degreeTextBox);
            this.panelEx2.Controls.Add(universityLabel);
            this.panelEx2.Controls.Add(this.universityTextBox);
            this.panelEx2.Controls.Add(globalidLabel);
            this.panelEx2.Controls.Add(this.globalidTextBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 62);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(409, 379);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_exit);
            this.panelEx3.Controls.Add(this.btn_next);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 384);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(409, 57);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClinicInfoTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.GendermetaTableAdapter = null;
            this.tableAdapterManager.metaTableAdapter = null;
            this.tableAdapterManager.PateintTableAdapter = null;
            this.tableAdapterManager.QueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.VisitTableAdapter = null;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // usnameLabel
            // 
            usnameLabel.AutoSize = true;
            usnameLabel.Location = new System.Drawing.Point(259, 20);
            usnameLabel.Name = "usnameLabel";
            usnameLabel.Size = new System.Drawing.Size(101, 17);
            usnameLabel.TabIndex = 0;
            usnameLabel.Text = "اسم المستخدم";
            // 
            // usnameTextBox
            // 
            this.usnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "usname", true));
            this.usnameTextBox.Location = new System.Drawing.Point(46, 17);
            this.usnameTextBox.Name = "usnameTextBox";
            this.usnameTextBox.Size = new System.Drawing.Size(196, 24);
            this.usnameTextBox.TabIndex = 1;
            this.usnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new System.Drawing.Point(281, 50);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new System.Drawing.Size(79, 17);
            fullnameLabel.TabIndex = 2;
            fullnameLabel.Text = "اسم الطبيب";
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fullname", true));
            this.fullnameTextBox.Location = new System.Drawing.Point(46, 47);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(196, 24);
            this.fullnameTextBox.TabIndex = 3;
            this.fullnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(286, 80);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(74, 17);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "كلمة المرور";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(46, 77);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(196, 24);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(260, 142);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(100, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "البريد الالكتروني";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(45, 139);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(196, 24);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(302, 172);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(58, 17);
            mobileLabel.TabIndex = 8;
            mobileLabel.Text = "المحمول";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(45, 169);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(196, 24);
            this.mobileTextBox.TabIndex = 9;
            this.mobileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licenceidLabel
            // 
            licenceidLabel.AutoSize = true;
            licenceidLabel.Location = new System.Drawing.Point(286, 202);
            licenceidLabel.Name = "licenceidLabel";
            licenceidLabel.Size = new System.Drawing.Size(74, 17);
            licenceidLabel.TabIndex = 10;
            licenceidLabel.Text = "رقم الرخصة";
            // 
            // licenceidTextBox
            // 
            this.licenceidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "licenceid", true));
            this.licenceidTextBox.Location = new System.Drawing.Point(45, 199);
            this.licenceidTextBox.Name = "licenceidTextBox";
            this.licenceidTextBox.Size = new System.Drawing.Size(196, 24);
            this.licenceidTextBox.TabIndex = 11;
            this.licenceidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenceidTextBox.TextChanged += new System.EventHandler(this.licenceidTextBox_TextChanged);
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(270, 232);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(90, 17);
            degreeLabel.TabIndex = 12;
            degreeLabel.Text = "الدرجة العلمية";
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(45, 229);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(196, 24);
            this.degreeTextBox.TabIndex = 13;
            this.degreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // universityLabel
            // 
            universityLabel.AutoSize = true;
            universityLabel.Location = new System.Drawing.Point(309, 262);
            universityLabel.Name = "universityLabel";
            universityLabel.Size = new System.Drawing.Size(51, 17);
            universityLabel.TabIndex = 14;
            universityLabel.Text = "الجامعة";
            // 
            // universityTextBox
            // 
            this.universityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "university", true));
            this.universityTextBox.Location = new System.Drawing.Point(45, 259);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(196, 24);
            this.universityTextBox.TabIndex = 15;
            this.universityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // globalidLabel
            // 
            globalidLabel.AutoSize = true;
            globalidLabel.Location = new System.Drawing.Point(272, 292);
            globalidLabel.Name = "globalidLabel";
            globalidLabel.Size = new System.Drawing.Size(88, 17);
            globalidLabel.TabIndex = 16;
            globalidLabel.Text = "الرقم المركزي";
            // 
            // globalidTextBox
            // 
            this.globalidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "globalid", true));
            this.globalidTextBox.Location = new System.Drawing.Point(108, 289);
            this.globalidTextBox.Name = "globalidTextBox";
            this.globalidTextBox.ReadOnly = true;
            this.globalidTextBox.Size = new System.Drawing.Size(133, 24);
            this.globalidTextBox.TabIndex = 17;
            this.globalidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_next
            // 
            this.btn_next.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_next.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_next.Location = new System.Drawing.Point(202, 16);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "التالي";
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Location = new System.Drawing.Point(121, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "تأكيد كلمة المرور";
            // 
            // tb_confirmpwd
            // 
            this.tb_confirmpwd.Location = new System.Drawing.Point(46, 108);
            this.tb_confirmpwd.Name = "tb_confirmpwd";
            this.tb_confirmpwd.Size = new System.Drawing.Size(196, 24);
            this.tb_confirmpwd.TabIndex = 19;
            this.tb_confirmpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_confirmpwd.UseSystemPasswordChar = true;
            // 
            // FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 441);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "FirstRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstRun";
            this.Load += new System.EventHandler(this.FirstRun_Load);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private clinic_DBDataSetTableAdapters.userTableAdapter userTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox usnameTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox licenceidTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.TextBox globalidTextBox;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_next;
        private System.Windows.Forms.TextBox tb_confirmpwd;
        private System.Windows.Forms.Label label1;
    }
}