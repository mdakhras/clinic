namespace iClinic_.Doctors
{
    partial class Doctors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label fullnameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label licenceidLabel;
            System.Windows.Forms.Label degreeLabel;
            System.Windows.Forms.Label universityLabel;
            System.Windows.Forms.Label globalidLabel;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.btn_del = new DevComponents.DotNetBar.ButtonX();
            this.btn_addDoctors = new DevComponents.DotNetBar.ButtonX();
            this.tb_doctorsname = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.userTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.userTableAdapter();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.licenceidTextBox = new System.Windows.Forms.TextBox();
            this.degreeTextBox = new System.Windows.Forms.TextBox();
            this.universityTextBox = new System.Windows.Forms.TextBox();
            this.globalidTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.university = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.globalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fullnameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            licenceidLabel = new System.Windows.Forms.Label();
            degreeLabel = new System.Windows.Forms.Label();
            universityLabel = new System.Windows.Forms.Label();
            globalidLabel = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1206, 85);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx4.Controls.Add(this.btn_del);
            this.panelEx4.Controls.Add(this.btn_addDoctors);
            this.panelEx4.Controls.Add(this.tb_doctorsname);
            this.panelEx4.Controls.Add(this.label1);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx4.Location = new System.Drawing.Point(649, 0);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(557, 85);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 0;
            // 
            // btn_del
            // 
            this.btn_del.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_del.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_del.Location = new System.Drawing.Point(112, 32);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "حذف ";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_addDoctors
            // 
            this.btn_addDoctors.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addDoctors.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addDoctors.Location = new System.Drawing.Point(193, 32);
            this.btn_addDoctors.Name = "btn_addDoctors";
            this.btn_addDoctors.Size = new System.Drawing.Size(75, 23);
            this.btn_addDoctors.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addDoctors.TabIndex = 2;
            this.btn_addDoctors.Text = "اضافة طبيب ";
            this.btn_addDoctors.Click += new System.EventHandler(this.btn_addDoctors_Click);
            // 
            // tb_doctorsname
            // 
            this.tb_doctorsname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fullname", true));
            this.tb_doctorsname.Location = new System.Drawing.Point(274, 35);
            this.tb_doctorsname.Name = "tb_doctorsname";
            this.tb_doctorsname.ReadOnly = true;
            this.tb_doctorsname.Size = new System.Drawing.Size(198, 20);
            this.tb_doctorsname.TabIndex = 1;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الطبيب ";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelEx2.Controls.Add(this.btn_save);
            this.panelEx2.Controls.Add(this.checkBoxX1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(908, 85);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(298, 421);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(213, 335);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "حفظ ";
            this.btn_save.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // checkBoxX1
            // 
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.Class = "";
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.userBindingSource, "active", true));
            this.checkBoxX1.Location = new System.Drawing.Point(20, 263);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(137, 23);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 10;
            this.checkBoxX1.Text = "نشيط ";
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.dataGridViewX1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 85);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(908, 421);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            this.panelEx3.Text = "panelEx3";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.password,
            this.email,
            this.mobile,
            this.licenceid,
            this.degree,
            this.university,
            this.globalid});
            this.dataGridViewX1.DataSource = this.userBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.Size = new System.Drawing.Size(908, 421);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BloodTypemetaTableAdapter = null;
            this.tableAdapterManager.ClinicInfoTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.financialTableAdapter = null;
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
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new System.Drawing.Point(192, 55);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new System.Drawing.Size(99, 13);
            fullnameLabel.TabIndex = 13;
            fullnameLabel.Text = "اسم الطبيب كامل : ";
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "fullname", true));
            this.fullnameTextBox.Location = new System.Drawing.Point(20, 55);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(137, 20);
            this.fullnameTextBox.TabIndex = 14;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(226, 81);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(65, 13);
            passwordLabel.TabIndex = 15;
            passwordLabel.Text = "كلمة السر : ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(20, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(137, 20);
            this.passwordTextBox.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(204, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(87, 13);
            emailLabel.TabIndex = 17;
            emailLabel.Text = "البريد الاكتروني : ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(20, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(137, 20);
            this.emailTextBox.TabIndex = 18;
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(222, 133);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(69, 13);
            mobileLabel.TabIndex = 19;
            mobileLabel.Text = "رقم التلفون : ";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(20, 133);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(137, 20);
            this.mobileTextBox.TabIndex = 20;
            // 
            // licenceidLabel
            // 
            licenceidLabel.AutoSize = true;
            licenceidLabel.Location = new System.Drawing.Point(221, 159);
            licenceidLabel.Name = "licenceidLabel";
            licenceidLabel.Size = new System.Drawing.Size(70, 13);
            licenceidLabel.TabIndex = 21;
            licenceidLabel.Text = "رقم الرخصة : ";
            // 
            // licenceidTextBox
            // 
            this.licenceidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "licenceid", true));
            this.licenceidTextBox.Location = new System.Drawing.Point(20, 159);
            this.licenceidTextBox.Name = "licenceidTextBox";
            this.licenceidTextBox.Size = new System.Drawing.Size(137, 20);
            this.licenceidTextBox.TabIndex = 22;
            // 
            // degreeLabel
            // 
            degreeLabel.AutoSize = true;
            degreeLabel.Location = new System.Drawing.Point(245, 185);
            degreeLabel.Name = "degreeLabel";
            degreeLabel.Size = new System.Drawing.Size(46, 13);
            degreeLabel.TabIndex = 23;
            degreeLabel.Text = "الدرجة : ";
            // 
            // degreeTextBox
            // 
            this.degreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "degree", true));
            this.degreeTextBox.Location = new System.Drawing.Point(20, 185);
            this.degreeTextBox.Name = "degreeTextBox";
            this.degreeTextBox.Size = new System.Drawing.Size(137, 20);
            this.degreeTextBox.TabIndex = 24;
            // 
            // universityLabel
            // 
            universityLabel.AutoSize = true;
            universityLabel.Location = new System.Drawing.Point(240, 211);
            universityLabel.Name = "universityLabel";
            universityLabel.Size = new System.Drawing.Size(51, 13);
            universityLabel.TabIndex = 25;
            universityLabel.Text = "الجامعة : ";
            // 
            // universityTextBox
            // 
            this.universityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "university", true));
            this.universityTextBox.Location = new System.Drawing.Point(20, 211);
            this.universityTextBox.Name = "universityTextBox";
            this.universityTextBox.Size = new System.Drawing.Size(137, 20);
            this.universityTextBox.TabIndex = 26;
            // 
            // globalidLabel
            // 
            globalidLabel.AutoSize = true;
            globalidLabel.Location = new System.Drawing.Point(225, 237);
            globalidLabel.Name = "globalidLabel";
            globalidLabel.Size = new System.Drawing.Size(66, 13);
            globalidLabel.TabIndex = 27;
            globalidLabel.Text = "الرقم العام : ";
            // 
            // globalidTextBox
            // 
            this.globalidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "globalid", true));
            this.globalidTextBox.Location = new System.Drawing.Point(20, 237);
            this.globalidTextBox.Name = "globalidTextBox";
            this.globalidTextBox.Size = new System.Drawing.Size(137, 20);
            this.globalidTextBox.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "رقم  ";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "اسم الطبيب كامل ";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "رقم التلفون ";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileDataGridViewTextBoxColumn.Width = 50;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "نشيط ";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activeDataGridViewCheckBoxColumn.Width = 50;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "كلمة السر ";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "البريد الاكتروني ";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "رقم التلفون ";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 50;
            // 
            // licenceid
            // 
            this.licenceid.DataPropertyName = "licenceid";
            this.licenceid.HeaderText = "رقم الرخصة ";
            this.licenceid.Name = "licenceid";
            this.licenceid.ReadOnly = true;
            // 
            // degree
            // 
            this.degree.DataPropertyName = "degree";
            this.degree.HeaderText = "الدرجة ";
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            this.degree.Width = 50;
            // 
            // university
            // 
            this.university.DataPropertyName = "university";
            this.university.HeaderText = "الجامعة ";
            this.university.Name = "university";
            this.university.ReadOnly = true;
            // 
            // globalid
            // 
            this.globalid.DataPropertyName = "globalid";
            this.globalid.HeaderText = "الرقم العام ";
            this.globalid.Name = "globalid";
            this.globalid.ReadOnly = true;
            this.globalid.Width = 50;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1206, 506);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Doctors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة الاطباء ";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_doctorsname;
        private DevComponents.DotNetBar.ButtonX btn_del;
        private DevComponents.DotNetBar.ButtonX btn_addDoctors;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private clinic_DBDataSetTableAdapters.userTableAdapter userTableAdapter;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox licenceidTextBox;
        private System.Windows.Forms.TextBox degreeTextBox;
        private System.Windows.Forms.TextBox universityTextBox;
        private System.Windows.Forms.TextBox globalidTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn university;
        private System.Windows.Forms.DataGridViewTextBoxColumn globalid;
    }
}