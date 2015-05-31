namespace iClinic_.Appointment
{
    partial class Frmappointment
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
            System.Windows.Forms.Label ap_pidLabel;
            System.Windows.Forms.Label ap_dateLabel;
            System.Windows.Forms.Label ap_orderLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_deleteappointment = new DevComponents.DotNetBar.ButtonX();
            this.btn_editappointment = new DevComponents.DotNetBar.ButtonX();
            this.btn_addappointment = new DevComponents.DotNetBar.ButtonX();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.ap_pidTextBox = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.ap_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ap_orderTextBox = new System.Windows.Forms.TextBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.apidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apinsdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.AppointmentTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            ap_pidLabel = new System.Windows.Forms.Label();
            ap_dateLabel = new System.Windows.Forms.Label();
            ap_orderLabel = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // ap_pidLabel
            // 
            ap_pidLabel.AutoSize = true;
            ap_pidLabel.Location = new System.Drawing.Point(259, 123);
            ap_pidLabel.Name = "ap_pidLabel";
            ap_pidLabel.Size = new System.Drawing.Size(39, 13);
            ap_pidLabel.TabIndex = 0;
            ap_pidLabel.Text = "ap pid:";
            // 
            // ap_dateLabel
            // 
            ap_dateLabel.AutoSize = true;
            ap_dateLabel.Location = new System.Drawing.Point(252, 150);
            ap_dateLabel.Name = "ap_dateLabel";
            ap_dateLabel.Size = new System.Drawing.Size(46, 13);
            ap_dateLabel.TabIndex = 2;
            ap_dateLabel.Text = "ap date:";
            // 
            // ap_orderLabel
            // 
            ap_orderLabel.AutoSize = true;
            ap_orderLabel.Location = new System.Drawing.Point(249, 175);
            ap_orderLabel.Name = "ap_orderLabel";
            ap_orderLabel.Size = new System.Drawing.Size(49, 13);
            ap_orderLabel.TabIndex = 4;
            ap_orderLabel.Text = "ap order:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.panel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1335, 69);
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
            this.panel1.Controls.Add(this.btn_deleteappointment);
            this.panel1.Controls.Add(this.btn_editappointment);
            this.panel1.Controls.Add(this.btn_addappointment);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(803, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 69);
            this.panel1.TabIndex = 0;
            // 
            // btn_deleteappointment
            // 
            this.btn_deleteappointment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_deleteappointment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_deleteappointment.Location = new System.Drawing.Point(11, 24);
            this.btn_deleteappointment.Name = "btn_deleteappointment";
            this.btn_deleteappointment.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteappointment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_deleteappointment.TabIndex = 4;
            this.btn_deleteappointment.Text = "حذف موعد";
            this.btn_deleteappointment.Click += new System.EventHandler(this.btn_deleteappointment_Click);
            // 
            // btn_editappointment
            // 
            this.btn_editappointment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_editappointment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_editappointment.Location = new System.Drawing.Point(92, 23);
            this.btn_editappointment.Name = "btn_editappointment";
            this.btn_editappointment.Size = new System.Drawing.Size(75, 23);
            this.btn_editappointment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_editappointment.TabIndex = 3;
            this.btn_editappointment.Text = "تعديل موعد";
            // 
            // btn_addappointment
            // 
            this.btn_addappointment.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_addappointment.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_addappointment.Location = new System.Drawing.Point(176, 24);
            this.btn_addappointment.Name = "btn_addappointment";
            this.btn_addappointment.Size = new System.Drawing.Size(75, 23);
            this.btn_addappointment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_addappointment.TabIndex = 2;
            this.btn_addappointment.Text = "اضافة موعد";
            this.btn_addappointment.Click += new System.EventHandler(this.btn_addappointment_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المريض";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(ap_pidLabel);
            this.panelEx2.Controls.Add(this.ap_pidTextBox);
            this.panelEx2.Controls.Add(ap_dateLabel);
            this.panelEx2.Controls.Add(this.ap_dateDateTimePicker);
            this.panelEx2.Controls.Add(ap_orderLabel);
            this.panelEx2.Controls.Add(this.ap_orderTextBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(1012, 69);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(323, 446);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // ap_pidTextBox
            // 
            this.ap_pidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "ap_pid", true));
            this.ap_pidTextBox.Location = new System.Drawing.Point(26, 116);
            this.ap_pidTextBox.Name = "ap_pidTextBox";
            this.ap_pidTextBox.Size = new System.Drawing.Size(200, 20);
            this.ap_pidTextBox.TabIndex = 1;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ap_dateDateTimePicker
            // 
            this.ap_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "ap_date", true));
            this.ap_dateDateTimePicker.Location = new System.Drawing.Point(26, 142);
            this.ap_dateDateTimePicker.Name = "ap_dateDateTimePicker";
            this.ap_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ap_dateDateTimePicker.TabIndex = 3;
            // 
            // ap_orderTextBox
            // 
            this.ap_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "ap_order", true));
            this.ap_orderTextBox.Location = new System.Drawing.Point(26, 168);
            this.ap_orderTextBox.Name = "ap_orderTextBox";
            this.ap_orderTextBox.Size = new System.Drawing.Size(200, 20);
            this.ap_orderTextBox.TabIndex = 5;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.dataGridViewX1);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 69);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1012, 446);
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
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apidDataGridViewTextBoxColumn,
            this.appidDataGridViewTextBoxColumn,
            this.apdateDataGridViewTextBoxColumn,
            this.aporderDataGridViewTextBoxColumn,
            this.apinsdateDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.appointmentBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewX1.Size = new System.Drawing.Size(1012, 446);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // apidDataGridViewTextBoxColumn
            // 
            this.apidDataGridViewTextBoxColumn.DataPropertyName = "ap_id";
            this.apidDataGridViewTextBoxColumn.HeaderText = "ap_id";
            this.apidDataGridViewTextBoxColumn.Name = "apidDataGridViewTextBoxColumn";
            this.apidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appidDataGridViewTextBoxColumn
            // 
            this.appidDataGridViewTextBoxColumn.DataPropertyName = "ap_pid";
            this.appidDataGridViewTextBoxColumn.HeaderText = "ap_pid";
            this.appidDataGridViewTextBoxColumn.Name = "appidDataGridViewTextBoxColumn";
            this.appidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apdateDataGridViewTextBoxColumn
            // 
            this.apdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apdateDataGridViewTextBoxColumn.DataPropertyName = "ap_date";
            this.apdateDataGridViewTextBoxColumn.HeaderText = "ap_date";
            this.apdateDataGridViewTextBoxColumn.Name = "apdateDataGridViewTextBoxColumn";
            this.apdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aporderDataGridViewTextBoxColumn
            // 
            this.aporderDataGridViewTextBoxColumn.DataPropertyName = "ap_order";
            this.aporderDataGridViewTextBoxColumn.HeaderText = "ap_order";
            this.aporderDataGridViewTextBoxColumn.Name = "aporderDataGridViewTextBoxColumn";
            this.aporderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apinsdateDataGridViewTextBoxColumn
            // 
            this.apinsdateDataGridViewTextBoxColumn.DataPropertyName = "ap_insdate";
            this.apinsdateDataGridViewTextBoxColumn.HeaderText = "ap_insdate";
            this.apinsdateDataGridViewTextBoxColumn.Name = "apinsdateDataGridViewTextBoxColumn";
            this.apinsdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = this.appointmentTableAdapter;
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
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.VisitTableAdapter = null;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 515);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "appointment";
            this.Text = "appointment";
            this.Load += new System.EventHandler(this.appointment_Load);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.panelEx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_deleteappointment;
        private DevComponents.DotNetBar.ButtonX btn_editappointment;
        private DevComponents.DotNetBar.ButtonX btn_addappointment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private clinic_DBDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ap_pidTextBox;
        private System.Windows.Forms.DateTimePicker ap_dateDateTimePicker;
        private System.Windows.Forms.TextBox ap_orderTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn apidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apinsdateDataGridViewTextBoxColumn;
    }
}