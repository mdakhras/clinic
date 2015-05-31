namespace iClinic_.Appointment
{
    partial class Dlg_appointment
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.ap_pidTextBox = new System.Windows.Forms.TextBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.ap_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ap_orderTextBox = new System.Windows.Forms.TextBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.appointmentTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.AppointmentTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            ap_pidLabel = new System.Windows.Forms.Label();
            ap_dateLabel = new System.Windows.Forms.Label();
            ap_orderLabel = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ap_pidLabel
            // 
            ap_pidLabel.AutoSize = true;
            ap_pidLabel.Location = new System.Drawing.Point(196, 43);
            ap_pidLabel.Name = "ap_pidLabel";
            ap_pidLabel.Size = new System.Drawing.Size(57, 13);
            ap_pidLabel.TabIndex = 0;
            ap_pidLabel.Text = "رقم المريض";
            // 
            // ap_dateLabel
            // 
            ap_dateLabel.AutoSize = true;
            ap_dateLabel.Location = new System.Drawing.Point(189, 70);
            ap_dateLabel.Name = "ap_dateLabel";
            ap_dateLabel.Size = new System.Drawing.Size(64, 13);
            ap_dateLabel.TabIndex = 2;
            ap_dateLabel.Text = "موعد المريض";
            // 
            // ap_orderLabel
            // 
            ap_orderLabel.AutoSize = true;
            ap_orderLabel.Location = new System.Drawing.Point(215, 95);
            ap_orderLabel.Name = "ap_orderLabel";
            ap_orderLabel.Size = new System.Drawing.Size(32, 13);
            ap_orderLabel.TabIndex = 4;
            ap_orderLabel.Text = "الحجز";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(284, 50);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(72, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(138, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "يرجي اضافة موعد للمريض";
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
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 50);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(284, 190);
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
            this.ap_pidTextBox.Location = new System.Drawing.Point(86, 37);
            this.ap_pidTextBox.Name = "ap_pidTextBox";
            this.ap_pidTextBox.Size = new System.Drawing.Size(90, 20);
            this.ap_pidTextBox.TabIndex = 1;
            this.ap_pidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.ap_dateDateTimePicker.Location = new System.Drawing.Point(8, 63);
            this.ap_dateDateTimePicker.Name = "ap_dateDateTimePicker";
            this.ap_dateDateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.ap_dateDateTimePicker.TabIndex = 3;
            // 
            // ap_orderTextBox
            // 
            this.ap_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "ap_order", true));
            this.ap_orderTextBox.Location = new System.Drawing.Point(86, 89);
            this.ap_orderTextBox.Name = "ap_orderTextBox";
            this.ap_orderTextBox.Size = new System.Drawing.Size(90, 20);
            this.ap_orderTextBox.TabIndex = 5;
            this.ap_orderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_exit);
            this.panelEx3.Controls.Add(this.btn_save);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 190);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(284, 50);
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
            this.btn_exit.Location = new System.Drawing.Point(66, 14);
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
            this.btn_save.Location = new System.Drawing.Point(147, 14);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
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
            // Dlg_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Dlg_appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dlg_appointment";
            this.Load += new System.EventHandler(this.Dlg_appointment_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private clinic_DBDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ap_pidTextBox;
        private System.Windows.Forms.DateTimePicker ap_dateDateTimePicker;
        private System.Windows.Forms.TextBox ap_orderTextBox;
    }
}