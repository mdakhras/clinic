namespace iClinic_.Doctors
{
    partial class Dlg_addnewDoctors
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
            System.Windows.Forms.Label globalidLabel;
            System.Windows.Forms.Label universityLabel;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label licenceidLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label fullnameLabel;
            System.Windows.Forms.Label usnameLabel;
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.userTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.usnameTextBox = new System.Windows.Forms.TextBox();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.licenceidTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.globalidTextBox = new System.Windows.Forms.TextBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.btn_closed = new DevComponents.DotNetBar.ButtonX();
            globalidLabel = new System.Windows.Forms.Label();
            universityLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            licenceidLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            fullnameLabel = new System.Windows.Forms.Label();
            usnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // globalidLabel
            // 
            globalidLabel.AutoSize = true;
            globalidLabel.Location = new System.Drawing.Point(224, 231);
            globalidLabel.Name = "globalidLabel";
            globalidLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            globalidLabel.Size = new System.Drawing.Size(69, 13);
            globalidLabel.TabIndex = 16;
            globalidLabel.Text = "رقم الطبيب : ";
            // 
            // universityLabel
            // 
            universityLabel.AutoSize = true;
            universityLabel.Location = new System.Drawing.Point(242, 205);
            universityLabel.Name = "universityLabel";
            universityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            universityLabel.Size = new System.Drawing.Size(51, 13);
            universityLabel.TabIndex = 14;
            universityLabel.Text = "الجامعة : ";
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(211, 179);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            degreeLabel.Size = new System.Drawing.Size(82, 13);
            degreeLabel.TabIndex = 12;
            degreeLabel.Text = "الدرجة العلمية : ";
            // 
            // licenceidLabel
            // 
            licenceidLabel.AutoSize = true;
            licenceidLabel.Location = new System.Drawing.Point(223, 153);
            licenceidLabel.Name = "licenceidLabel";
            licenceidLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            licenceidLabel.Size = new System.Drawing.Size(70, 13);
            licenceidLabel.TabIndex = 10;
            licenceidLabel.Text = "رقم الرخصة : ";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(228, 127);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            mobileLabel.Size = new System.Drawing.Size(65, 13);
            mobileLabel.TabIndex = 8;
            mobileLabel.Text = "رقم الجوال : ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(202, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            emailLabel.Size = new System.Drawing.Size(91, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "البريد الالكتروني : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(224, 75);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            passwordLabel.Size = new System.Drawing.Size(69, 13);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "كلمة المرور : ";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new System.Drawing.Point(222, 49);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            fullnameLabel.Size = new System.Drawing.Size(71, 13);
            fullnameLabel.TabIndex = 2;
            fullnameLabel.Text = "الاسم كامل : ";
            // 
            // usnameLabel
            // 
            usnameLabel.AutoSize = true;
            usnameLabel.Location = new System.Drawing.Point(222, 23);
            usnameLabel.Name = "usnameLabel";
            usnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            usnameLabel.Size = new System.Drawing.Size(71, 13);
            usnameLabel.TabIndex = 0;
            usnameLabel.Text = "الاسم الاول : ";
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
            this.tableAdapterManager.BloodTypemetaTableAdapter = null;
            this.tableAdapterManager.ClinicInfoTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.GendermetaTableAdapter = null;
            this.tableAdapterManager.metaJobTableAdapter = null;
            this.tableAdapterManager.metaTableAdapter = null;
            this.tableAdapterManager.MritalStatusmetaTableAdapter = null;
            this.tableAdapterManager.PateintTableAdapter = null;
            this.tableAdapterManager.QueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.VisitTableAdapter = null;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(321, 51);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "يرجي اخال بيانات الطبيب ";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_closed);
            this.panelEx3.Controls.Add(this.btn_save);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 332);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(321, 77);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            // 
            // panelEx4
            // 
            this.panelEx4.AutoScroll = true;
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(usnameLabel);
            this.panelEx4.Controls.Add(this.usnameTextBox);
            this.panelEx4.Controls.Add(fullnameLabel);
            this.panelEx4.Controls.Add(this.fullnameTextBox);
            this.panelEx4.Controls.Add(passwordLabel);
            this.panelEx4.Controls.Add(this.passwordTextBox);
            this.panelEx4.Controls.Add(emailLabel);
            this.panelEx4.Controls.Add(this.emailTextBox);
            this.panelEx4.Controls.Add(mobileLabel);
            this.panelEx4.Controls.Add(this.mobileTextBox);
            this.panelEx4.Controls.Add(licenceidLabel);
            this.panelEx4.Controls.Add(this.licenceidTextBox);
            this.panelEx4.Controls.Add(degreeLabel);
            this.panelEx4.Controls.Add(this.degreeTextBox);
            this.panelEx4.Controls.Add(universityLabel);
            this.panelEx4.Controls.Add(this.universityTextBox);
            this.panelEx4.Controls.Add(globalidLabel);
            this.panelEx4.Controls.Add(this.globalidTextBox);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 51);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(321, 281);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 2;
            // 
            // usnameTextBox
            // 
            this.usnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "usname", true));
            this.usnameTextBox.Location = new System.Drawing.Point(30, 23);
            this.usnameTextBox.Name = "usnameTextBox";
            this.usnameTextBox.Size = new System.Drawing.Size(158, 20);
            this.usnameTextBox.TabIndex = 1;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fullname", true));
            this.fullnameTextBox.Location = new System.Drawing.Point(30, 49);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(158, 20);
            this.fullnameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(30, 75);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(158, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(30, 101);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(158, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(30, 127);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(158, 20);
            this.mobileTextBox.TabIndex = 9;
            // 
            // licenceidTextBox
            // 
            this.licenceidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "licenceid", true));
            this.licenceidTextBox.Location = new System.Drawing.Point(30, 153);
            this.licenceidTextBox.Name = "licenceidTextBox";
            this.licenceidTextBox.Size = new System.Drawing.Size(158, 20);
            this.licenceidTextBox.TabIndex = 11;
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(30, 179);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(158, 20);
            this.degreeTextBox.TabIndex = 13;
            // 
            // universityTextBox
            // 
            this.universityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "university", true));
            this.universityTextBox.Location = new System.Drawing.Point(30, 205);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(158, 20);
            this.universityTextBox.TabIndex = 15;
            // 
            // globalidTextBox
            // 
            this.globalidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "globalid", true));
            this.globalidTextBox.Location = new System.Drawing.Point(30, 231);
            this.globalidTextBox.Name = "globalidTextBox";
            this.globalidTextBox.Size = new System.Drawing.Size(158, 20);
            this.globalidTextBox.TabIndex = 17;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(321, 409);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(159, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_closed
            // 
            this.btn_closed.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_closed.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_closed.Location = new System.Drawing.Point(70, 22);
            this.btn_closed.Name = "btn_closed";
            this.btn_closed.Size = new System.Drawing.Size(75, 23);
            this.btn_closed.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_closed.TabIndex = 1;
            this.btn_closed.Text = "خروج ";
            this.btn_closed.Click += new System.EventHandler(this.btn_closed_Click);
            // 
            // Dlg_addnewDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 409);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Dlg_addnewDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dlg_addnewDoctors";
            this.Load += new System.EventHandler(this.Dlg_addnewDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private clinic_DBDataSetTableAdapters.userTableAdapter userTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private System.Windows.Forms.TextBox usnameTextBox;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox licenceidTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.TextBox globalidTextBox;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btn_closed;
        private DevComponents.DotNetBar.ButtonX btn_save;

    }
}