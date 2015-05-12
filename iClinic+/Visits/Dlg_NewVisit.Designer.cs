namespace iClinic_.Visits
{
    partial class Dlg_NewVisit
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
            System.Windows.Forms.Label pidLabel;
            System.Windows.Forms.Label complainLabel;
            System.Windows.Forms.Label diagnoseLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label drugLabel;
            System.Windows.Forms.Label label2;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.cb_visitType = new System.Windows.Forms.ComboBox();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.visitTypemetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pidTextBox = new System.Windows.Forms.TextBox();
            this.complainTextBox = new System.Windows.Forms.TextBox();
            this.diagnoseTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.drugTextBox = new System.Windows.Forms.TextBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.visitTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.VisitTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            this.visitTypemetaTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.VisitTypemetaTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            pidLabel = new System.Windows.Forms.Label();
            complainLabel = new System.Windows.Forms.Label();
            diagnoseLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            drugLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitTypemetaBindingSource)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pidLabel
            // 
            pidLabel.AutoSize = true;
            pidLabel.Location = new System.Drawing.Point(265, 23);
            pidLabel.Name = "pidLabel";
            pidLabel.Size = new System.Drawing.Size(75, 17);
            pidLabel.TabIndex = 0;
            pidLabel.Text = "رقم المريض";
            // 
            // complainLabel
            // 
            complainLabel.AutoSize = true;
            complainLabel.Location = new System.Drawing.Point(285, 101);
            complainLabel.Name = "complainLabel";
            complainLabel.Size = new System.Drawing.Size(55, 17);
            complainLabel.TabIndex = 2;
            complainLabel.Text = "الشكوى";
            // 
            // diagnoseLabel
            // 
            diagnoseLabel.AutoSize = true;
            diagnoseLabel.Location = new System.Drawing.Point(274, 207);
            diagnoseLabel.Name = "diagnoseLabel";
            diagnoseLabel.Size = new System.Drawing.Size(66, 17);
            diagnoseLabel.TabIndex = 4;
            diagnoseLabel.Text = "التشخيص";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(281, 294);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(59, 17);
            noteLabel.TabIndex = 6;
            noteLabel.Text = "ملاحظات";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(297, 353);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(43, 17);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "التاريخ";
            // 
            // drugLabel
            // 
            drugLabel.AutoSize = true;
            drugLabel.Location = new System.Drawing.Point(254, 382);
            drugLabel.Name = "drugLabel";
            drugLabel.Size = new System.Drawing.Size(86, 17);
            drugLabel.TabIndex = 10;
            drugLabel.Text = "الوصفة الطبية";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(380, 61);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "يرجى ادخال بيانات الزيارة";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.dateTimePicker1);
            this.panelEx2.Controls.Add(label2);
            this.panelEx2.Controls.Add(this.cb_visitType);
            this.panelEx2.Controls.Add(this.label1);
            this.panelEx2.Controls.Add(pidLabel);
            this.panelEx2.Controls.Add(this.pidTextBox);
            this.panelEx2.Controls.Add(complainLabel);
            this.panelEx2.Controls.Add(this.complainTextBox);
            this.panelEx2.Controls.Add(diagnoseLabel);
            this.panelEx2.Controls.Add(this.diagnoseTextBox);
            this.panelEx2.Controls.Add(noteLabel);
            this.panelEx2.Controls.Add(this.noteTextBox);
            this.panelEx2.Controls.Add(dateLabel);
            this.panelEx2.Controls.Add(this.dateDateTimePicker);
            this.panelEx2.Controls.Add(drugLabel);
            this.panelEx2.Controls.Add(this.drugTextBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 61);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(380, 576);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // cb_visitType
            // 
            this.cb_visitType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.visitBindingSource, "type", true));
            this.cb_visitType.DataSource = this.visitTypemetaBindingSource;
            this.cb_visitType.DisplayMember = "name";
            this.cb_visitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_visitType.FormattingEnabled = true;
            this.cb_visitType.Location = new System.Drawing.Point(47, 55);
            this.cb_visitType.Name = "cb_visitType";
            this.cb_visitType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_visitType.Size = new System.Drawing.Size(200, 24);
            this.cb_visitType.TabIndex = 13;
            this.cb_visitType.ValueMember = "id";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "Visit";
            this.visitBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitTypemetaBindingSource
            // 
            this.visitTypemetaBindingSource.DataMember = "VisitTypemeta";
            this.visitTypemetaBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "نوع الزيارة";
            // 
            // pidTextBox
            // 
            this.pidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "pid", true));
            this.pidTextBox.Location = new System.Drawing.Point(163, 20);
            this.pidTextBox.Name = "pidTextBox";
            this.pidTextBox.ReadOnly = true;
            this.pidTextBox.Size = new System.Drawing.Size(84, 24);
            this.pidTextBox.TabIndex = 1;
            this.pidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // complainTextBox
            // 
            this.complainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "complain", true));
            this.complainTextBox.Location = new System.Drawing.Point(47, 100);
            this.complainTextBox.Multiline = true;
            this.complainTextBox.Name = "complainTextBox";
            this.complainTextBox.Size = new System.Drawing.Size(200, 89);
            this.complainTextBox.TabIndex = 3;
            this.complainTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // diagnoseTextBox
            // 
            this.diagnoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "diagnose", true));
            this.diagnoseTextBox.Location = new System.Drawing.Point(47, 204);
            this.diagnoseTextBox.Multiline = true;
            this.diagnoseTextBox.Name = "diagnoseTextBox";
            this.diagnoseTextBox.Size = new System.Drawing.Size(200, 81);
            this.diagnoseTextBox.TabIndex = 5;
            this.diagnoseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // noteTextBox
            // 
            this.noteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "note", true));
            this.noteTextBox.Location = new System.Drawing.Point(47, 291);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(200, 52);
            this.noteTextBox.TabIndex = 7;
            this.noteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(47, 349);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateDateTimePicker.RightToLeftLayout = true;
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // drugTextBox
            // 
            this.drugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitBindingSource, "drug", true));
            this.drugTextBox.Location = new System.Drawing.Point(47, 379);
            this.drugTextBox.Multiline = true;
            this.drugTextBox.Name = "drugTextBox";
            this.drugTextBox.Size = new System.Drawing.Size(200, 101);
            this.drugTextBox.TabIndex = 11;
            this.drugTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_exit);
            this.panelEx3.Controls.Add(this.btn_save);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 584);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(380, 53);
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
            this.btn_exit.Location = new System.Drawing.Point(105, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(189, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.VisitTableAdapter = this.visitTableAdapter;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // visitTypemetaTableAdapter
            // 
            this.visitTypemetaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(254, 488);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 17);
            label2.TabIndex = 14;
            label2.Text = "تاريخ المراجعة";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitBindingSource, "review_date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 488);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Dlg_NewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(380, 637);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Name = "Dlg_NewVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة زيارات جديدة";
            this.Load += new System.EventHandler(this.Dlg_NewVisit_Load);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitTypemetaBindingSource)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private clinic_DBDataSetTableAdapters.VisitTableAdapter visitTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox pidTextBox;
        private System.Windows.Forms.TextBox complainTextBox;
        private System.Windows.Forms.TextBox diagnoseTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox drugTextBox;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private System.Windows.Forms.ComboBox cb_visitType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource visitTypemetaBindingSource;
        private clinic_DBDataSetTableAdapters.VisitTypemetaTableAdapter visitTypemetaTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}