namespace iClinic_.Pateint
{
    partial class Pateint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label noteLabel;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_pateintName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_deleteP = new DevComponents.DotNetBar.ButtonX();
            this.btn_addP = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pateintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.pateintTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.PateintTableAdapter();
            this.gendermetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gendermetaTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.GendermetaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nCDPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pregnancyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nCD_PCheckBox = new System.Windows.Forms.CheckBox();
            this.pregnancyCheckBox = new System.Windows.Forms.CheckBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            nameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendermetaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1363, 65);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_pateintName);
            this.panel1.Controls.Add(this.btn_deleteP);
            this.panel1.Controls.Add(this.btn_addP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(746, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 65);
            this.panel1.TabIndex = 0;
            // 
            // tb_pateintName
            // 
            this.tb_pateintName.BackColor = System.Drawing.SystemColors.ScrollBar;
            // 
            // 
            // 
            this.tb_pateintName.Border.Class = "TextBoxBorder";
            this.tb_pateintName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pateintName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "name", true));
            this.tb_pateintName.Location = new System.Drawing.Point(246, 19);
            this.tb_pateintName.Name = "tb_pateintName";
            this.tb_pateintName.Size = new System.Drawing.Size(272, 29);
            this.tb_pateintName.TabIndex = 3;
            // 
            // btn_deleteP
            // 
            this.btn_deleteP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_deleteP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_deleteP.Location = new System.Drawing.Point(43, 22);
            this.btn_deleteP.Name = "btn_deleteP";
            this.btn_deleteP.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_deleteP.TabIndex = 2;
            this.btn_deleteP.Text = "حذف";
            this.btn_deleteP.Click += new System.EventHandler(this.btn_deleteP_Click);
            // 
            // btn_addP
            // 
            this.btn_addP.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addP.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addP.Location = new System.Drawing.Point(124, 22);
            this.btn_addP.Name = "btn_addP";
            this.btn_addP.Size = new System.Drawing.Size(116, 23);
            this.btn_addP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addP.TabIndex = 1;
            this.btn_addP.Text = "اضافة بيانات المريض";
            this.btn_addP.Click += new System.EventHandler(this.btn_addP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريض";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.comboBox1);
            this.panelEx2.Controls.Add(this.btn_Save);
            this.panelEx2.Controls.Add(nameLabel);
            this.panelEx2.Controls.Add(this.nameTextBox);
            this.panelEx2.Controls.Add(dobLabel);
            this.panelEx2.Controls.Add(this.dobDateTimePicker);
            this.panelEx2.Controls.Add(genderLabel);
            this.panelEx2.Controls.Add(this.nCD_PCheckBox);
            this.panelEx2.Controls.Add(this.pregnancyCheckBox);
            this.panelEx2.Controls.Add(noteLabel);
            this.panelEx2.Controls.Add(this.noteTextBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(992, 65);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(371, 597);
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
            this.panelEx3.Controls.Add(this.dataGridViewX1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 65);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(992, 597);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewX1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.nCDPDataGridViewCheckBoxColumn,
            this.pregnancyDataGridViewCheckBoxColumn});
            this.dataGridViewX1.DataSource = this.pateintBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.RowTemplate.Height = 26;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(992, 597);
            this.dataGridViewX1.TabIndex = 0;
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
            // pateintTableAdapter
            // 
            this.pateintTableAdapter.ClearBeforeFill = true;
            // 
            // gendermetaBindingSource
            // 
            this.gendermetaBindingSource.DataMember = "Gendermeta";
            this.gendermetaBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // gendermetaTableAdapter
            // 
            this.gendermetaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.DataSource = this.gendermetaBindingSource;
            this.genderDataGridViewTextBoxColumn.DisplayMember = "name";
            this.genderDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.genderDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.genderDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // nCDPDataGridViewCheckBoxColumn
            // 
            this.nCDPDataGridViewCheckBoxColumn.DataPropertyName = "NCD_P";
            this.nCDPDataGridViewCheckBoxColumn.HeaderText = "NCD_P";
            this.nCDPDataGridViewCheckBoxColumn.Name = "nCDPDataGridViewCheckBoxColumn";
            this.nCDPDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // pregnancyDataGridViewCheckBoxColumn
            // 
            this.pregnancyDataGridViewCheckBoxColumn.DataPropertyName = "pregnancy";
            this.pregnancyDataGridViewCheckBoxColumn.HeaderText = "pregnancy";
            this.pregnancyDataGridViewCheckBoxColumn.Name = "pregnancyDataGridViewCheckBoxColumn";
            this.pregnancyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClinicInfoTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.GendermetaTableAdapter = this.gendermetaTableAdapter;
            this.tableAdapterManager.metaTableAdapter = null;
            this.tableAdapterManager.PateintTableAdapter = this.pateintTableAdapter;
            this.tableAdapterManager.QueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.VisitTableAdapter = null;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(312, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "الاسم";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(60, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 24);
            this.nameTextBox.TabIndex = 3;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(284, 97);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(72, 17);
            dobLabel.TabIndex = 4;
            dobLabel.Text = "تايخ الميلاد";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pateintBindingSource, "dob", true));
            this.dobDateTimePicker.Location = new System.Drawing.Point(60, 97);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dobDateTimePicker.TabIndex = 5;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(322, 128);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(34, 17);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "النوع";
            // 
            // nCD_PCheckBox
            // 
            this.nCD_PCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pateintBindingSource, "NCD_P", true));
            this.nCD_PCheckBox.Location = new System.Drawing.Point(60, 157);
            this.nCD_PCheckBox.Name = "nCD_PCheckBox";
            this.nCD_PCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nCD_PCheckBox.Size = new System.Drawing.Size(200, 24);
            this.nCD_PCheckBox.TabIndex = 9;
            this.nCD_PCheckBox.Text = "أمراض مزمنة";
            this.nCD_PCheckBox.UseVisualStyleBackColor = true;
            // 
            // pregnancyCheckBox
            // 
            this.pregnancyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.pateintBindingSource, "pregnancy", true));
            this.pregnancyCheckBox.Location = new System.Drawing.Point(60, 187);
            this.pregnancyCheckBox.Name = "pregnancyCheckBox";
            this.pregnancyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pregnancyCheckBox.Size = new System.Drawing.Size(200, 24);
            this.pregnancyCheckBox.TabIndex = 11;
            this.pregnancyCheckBox.Text = "حمل";
            this.pregnancyCheckBox.UseVisualStyleBackColor = true;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(297, 217);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(59, 17);
            noteLabel.TabIndex = 12;
            noteLabel.Text = "ملاحظات";
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pateintBindingSource, "note", true));
            this.noteTextBox.Location = new System.Drawing.Point(60, 217);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 125);
            this.noteTextBox.TabIndex = 13;
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Location = new System.Drawing.Point(152, 356);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(108, 41);
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "حفظ التعديلات";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pateintBindingSource, "gender", true));
            this.comboBox1.DataSource = this.gendermetaBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id";
            // 
            // Pateint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 662);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Pateint";
            this.Text = "Pateint";
            this.Load += new System.EventHandler(this.Pateint_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pateintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendermetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pateintName;
        private DevComponents.DotNetBar.ButtonX btn_deleteP;
        private DevComponents.DotNetBar.ButtonX btn_addP;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource pateintBindingSource;
        private clinic_DBDataSetTableAdapters.PateintTableAdapter pateintTableAdapter;
        private System.Windows.Forms.BindingSource gendermetaBindingSource;
        private clinic_DBDataSetTableAdapters.GendermetaTableAdapter gendermetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nCDPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pregnancyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.CheckBox nCD_PCheckBox;
        private System.Windows.Forms.CheckBox pregnancyCheckBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}