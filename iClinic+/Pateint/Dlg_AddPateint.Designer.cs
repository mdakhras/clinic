namespace iClinic_.Pateint
{
    partial class Dlg_AddPateint
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.pateintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.metaJobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.metaBloodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mritalStatusmetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_drid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.gendermetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nCD_PCheckBox = new System.Windows.Forms.CheckBox();
            this.pregnancyCheckBox = new System.Windows.Forms.CheckBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.pateintTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.PateintTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.gendermetaTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.GendermetaTableAdapter();
            this.mritalStatusmetaTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.MritalStatusmetaTableAdapter();
            this.bloodTypemetaTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.BloodTypemetaTableAdapter();
            this.metaJobTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.metaJobTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_age = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pateintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaJobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaBloodTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mritalStatusmetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendermetaBindingSource)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(288, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(81, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "اسم المريض";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(292, 116);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(77, 17);
            dobLabel.TabIndex = 4;
            dobLabel.Text = "تاريخ الميلاد";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(335, 143);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(34, 17);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "النوع";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(310, 328);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(59, 17);
            noteLabel.TabIndex = 11;
            noteLabel.Text = "ملاحظات";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(296, 480);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 17);
            label1.TabIndex = 15;
            label1.Text = "رقم الطبيب";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(264, 235);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 17);
            label2.TabIndex = 17;
            label2.Text = "الحالة الاحتماعية";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(299, 266);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 17);
            label3.TabIndex = 18;
            label3.Text = "فصيلة الدم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(324, 294);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(45, 17);
            label4.TabIndex = 19;
            label4.Text = "المهنة";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(381, 53);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "يرجى ادخال بيانات المريض الجديد";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.tb_age);
            this.panelEx2.Controls.Add(this.label5);
            this.panelEx2.Controls.Add(this.comboBox3);
            this.panelEx2.Controls.Add(this.comboBox2);
            this.panelEx2.Controls.Add(this.comboBox1);
            this.panelEx2.Controls.Add(label4);
            this.panelEx2.Controls.Add(label3);
            this.panelEx2.Controls.Add(label2);
            this.panelEx2.Controls.Add(this.tb_drid);
            this.panelEx2.Controls.Add(label1);
            this.panelEx2.Controls.Add(this.pictureBox1);
            this.panelEx2.Controls.Add(this.cb_gender);
            this.panelEx2.Controls.Add(noteLabel);
            this.panelEx2.Controls.Add(this.noteTextBox);
            this.panelEx2.Controls.Add(nameLabel);
            this.panelEx2.Controls.Add(this.nameTextBox);
            this.panelEx2.Controls.Add(dobLabel);
            this.panelEx2.Controls.Add(this.dobDateTimePicker);
            this.panelEx2.Controls.Add(genderLabel);
            this.panelEx2.Controls.Add(this.nCD_PCheckBox);
            this.panelEx2.Controls.Add(this.pregnancyCheckBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 53);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(381, 572);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pateintBindingSource, "job", true));
            this.comboBox3.DataSource = this.metaJobBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(57, 287);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 24);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "id";
            // 
            // pateintBindingSource
            // 
            this.pateintBindingSource.DataMember = "Pateint";
            this.pateintBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metaJobBindingSource
            // 
            this.metaJobBindingSource.DataMember = "metaJob";
            this.metaJobBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pateintBindingSource, "blood_type", true));
            this.comboBox2.DataSource = this.metaBloodTypesBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(57, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 24);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "id";
            // 
            // metaBloodTypesBindingSource
            // 
            this.metaBloodTypesBindingSource.DataMember = "metaBloodTypes";
            this.metaBloodTypesBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pateintBindingSource, "maritalstatus", true));
            this.comboBox1.DataSource = this.mritalStatusmetaBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "id";
            // 
            // mritalStatusmetaBindingSource
            // 
            this.mritalStatusmetaBindingSource.DataMember = "MritalStatusmeta";
            this.mritalStatusmetaBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // tb_drid
            // 
            this.tb_drid.BackColor = System.Drawing.SystemColors.ButtonFace;
            // 
            // 
            // 
            this.tb_drid.Border.Class = "TextBoxBorder";
            this.tb_drid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_drid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "usid", true));
            this.tb_drid.Location = new System.Drawing.Point(91, 475);
            this.tb_drid.Name = "tb_drid";
            this.tb_drid.ReadOnly = true;
            this.tb_drid.Size = new System.Drawing.Size(164, 29);
            this.tb_drid.TabIndex = 16;
            this.tb_drid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::iClinic_.Properties.Resources.patient_ico;
            this.pictureBox1.Location = new System.Drawing.Point(299, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 57);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cb_gender
            // 
            this.cb_gender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pateintBindingSource, "gender", true));
            this.cb_gender.DataSource = this.gendermetaBindingSource;
            this.cb_gender.DisplayMember = "name";
            this.cb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(57, 140);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(200, 24);
            this.cb_gender.TabIndex = 13;
            this.cb_gender.ValueMember = "id";
            // 
            // gendermetaBindingSource
            // 
            this.gendermetaBindingSource.DataMember = "Gendermeta";
            this.gendermetaBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "note", true));
            this.noteTextBox.Location = new System.Drawing.Point(57, 321);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noteTextBox.Size = new System.Drawing.Size(200, 140);
            this.noteTextBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(57, 80);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "اسم المريض";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pateintBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(57, 110);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dobDateTimePicker.RightToLeftLayout = true;
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dobDateTimePicker.TabIndex = 5;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // nCD_PCheckBox
            // 
            this.nCD_PCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pateintBindingSource, "NCD_P", true));
            this.nCD_PCheckBox.Location = new System.Drawing.Point(79, 170);
            this.nCD_PCheckBox.Name = "nCD_PCheckBox";
            this.nCD_PCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nCD_PCheckBox.Size = new System.Drawing.Size(178, 24);
            this.nCD_PCheckBox.TabIndex = 9;
            this.nCD_PCheckBox.Text = " أمراض مزمنة";
            this.nCD_PCheckBox.UseVisualStyleBackColor = true;
            // 
            // pregnancyCheckBox
            // 
            this.pregnancyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pateintBindingSource, "pregnancy", true));
            this.pregnancyCheckBox.Location = new System.Drawing.Point(57, 201);
            this.pregnancyCheckBox.Name = "pregnancyCheckBox";
            this.pregnancyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pregnancyCheckBox.Size = new System.Drawing.Size(200, 24);
            this.pregnancyCheckBox.TabIndex = 11;
            this.pregnancyCheckBox.Text = "حمل";
            this.pregnancyCheckBox.UseVisualStyleBackColor = true;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_exit);
            this.panelEx3.Controls.Add(this.btn_save);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 570);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(381, 55);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(104, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(187, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pateintTableAdapter
            // 
            this.pateintTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PateintTableAdapter = this.pateintTableAdapter;
            this.tableAdapterManager.QueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.VisitTableAdapter = null;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // gendermetaTableAdapter
            // 
            this.gendermetaTableAdapter.ClearBeforeFill = true;
            // 
            // mritalStatusmetaTableAdapter
            // 
            this.mritalStatusmetaTableAdapter.ClearBeforeFill = true;
            // 
            // bloodTypemetaTableAdapter
            // 
            this.bloodTypemetaTableAdapter.ClearBeforeFill = true;
            // 
            // metaJobTableAdapter
            // 
            this.metaJobTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "العمر";
            // 
            // tb_age
            // 
            this.tb_age.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "age", true));
            this.tb_age.Location = new System.Drawing.Point(177, 23);
            this.tb_age.Name = "tb_age";
            this.tb_age.ReadOnly = true;
            this.tb_age.Size = new System.Drawing.Size(78, 24);
            this.tb_age.TabIndex = 24;
            // 
            // Dlg_AddPateint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(381, 625);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Dlg_AddPateint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة سجل مريض";
            this.Load += new System.EventHandler(this.Dlg_AddPateint_Load);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pateintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaJobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metaBloodTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mritalStatusmetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendermetaBindingSource)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource pateintBindingSource;
        private clinic_DBDataSetTableAdapters.PateintTableAdapter pateintTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.CheckBox nCD_PCheckBox;
        private System.Windows.Forms.CheckBox pregnancyCheckBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.BindingSource gendermetaBindingSource;
        private clinic_DBDataSetTableAdapters.GendermetaTableAdapter gendermetaTableAdapter;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_drid;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource mritalStatusmetaBindingSource;
        private clinic_DBDataSetTableAdapters.MritalStatusmetaTableAdapter mritalStatusmetaTableAdapter;
        private System.Windows.Forms.BindingSource metaBloodTypesBindingSource;
        private clinic_DBDataSetTableAdapters.BloodTypemetaTableAdapter bloodTypemetaTableAdapter;
        private System.Windows.Forms.BindingSource metaJobBindingSource;
        private clinic_DBDataSetTableAdapters.metaJobTableAdapter metaJobTableAdapter;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label5;
    }
}