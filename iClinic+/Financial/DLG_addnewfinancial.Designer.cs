namespace iClinic_.Financial
{
    partial class DLG_addnewfinancial
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
            System.Windows.Forms.Label descLabel;
            System.Windows.Forms.Label creditLabel;
            System.Windows.Forms.Label debitLabel;
            System.Windows.Forms.Label fin_dateLabel;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.btn_Exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.cheb_credit = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cheb_debit = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.fin_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.financialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.creditTextBox = new System.Windows.Forms.TextBox();
            this.debitTextBox = new System.Windows.Forms.TextBox();
            this.financialTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.financialTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            descLabel = new System.Windows.Forms.Label();
            creditLabel = new System.Windows.Forms.Label();
            debitLabel = new System.Windows.Forms.Label();
            fin_dateLabel = new System.Windows.Forms.Label();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            descLabel.AutoSize = true;
            descLabel.Location = new System.Drawing.Point(262, 30);
            descLabel.Name = "descLabel";
            descLabel.Size = new System.Drawing.Size(47, 13);
            descLabel.TabIndex = 2;
            descLabel.Text = "الوصف : ";
            // 
            // creditLabel
            // 
            creditLabel.AutoSize = true;
            creditLabel.Location = new System.Drawing.Point(261, 84);
            creditLabel.Name = "creditLabel";
            creditLabel.Size = new System.Drawing.Size(48, 13);
            creditLabel.TabIndex = 4;
            creditLabel.Text = "ايرادات : ";
            // 
            // debitLabel
            // 
            debitLabel.AutoSize = true;
            debitLabel.Location = new System.Drawing.Point(250, 110);
            debitLabel.Name = "debitLabel";
            debitLabel.Size = new System.Drawing.Size(59, 13);
            debitLabel.TabIndex = 6;
            debitLabel.Text = "مصروفات : ";
            // 
            // fin_dateLabel
            // 
            fin_dateLabel.AutoSize = true;
            fin_dateLabel.Location = new System.Drawing.Point(235, 139);
            fin_dateLabel.Name = "fin_dateLabel";
            fin_dateLabel.Size = new System.Drawing.Size(74, 13);
            fin_dateLabel.TabIndex = 7;
            fin_dateLabel.Text = "تاريخ العملية : ";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.label1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(355, 64);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "إضافة عملية حسابية جديدة ";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.btn_Exit);
            this.panelEx2.Controls.Add(this.btn_save);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 288);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(355, 76);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Exit.Location = new System.Drawing.Point(78, 16);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "خروج ";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_save.Location = new System.Drawing.Point(181, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "حفظ ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.cheb_credit);
            this.panelEx3.Controls.Add(this.cheb_debit);
            this.panelEx3.Controls.Add(fin_dateLabel);
            this.panelEx3.Controls.Add(this.fin_dateDateTimePicker);
            this.panelEx3.Controls.Add(descLabel);
            this.panelEx3.Controls.Add(this.descTextBox);
            this.panelEx3.Controls.Add(creditLabel);
            this.panelEx3.Controls.Add(this.creditTextBox);
            this.panelEx3.Controls.Add(debitLabel);
            this.panelEx3.Controls.Add(this.debitTextBox);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(0, 64);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(355, 224);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // cheb_credit
            // 
            // 
            // 
            // 
            this.cheb_credit.BackgroundStyle.Class = "";
            this.cheb_credit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cheb_credit.Location = new System.Drawing.Point(206, 51);
            this.cheb_credit.Name = "cheb_credit";
            this.cheb_credit.Size = new System.Drawing.Size(100, 23);
            this.cheb_credit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cheb_credit.TabIndex = 10;
            this.cheb_credit.Text = "ايرادات ";
            this.cheb_credit.CheckedChanged += new System.EventHandler(this.cheb_credit_CheckedChanged);
            // 
            // cheb_debit
            // 
            // 
            // 
            // 
            this.cheb_debit.BackgroundStyle.Class = "";
            this.cheb_debit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cheb_debit.Location = new System.Drawing.Point(89, 52);
            this.cheb_debit.Name = "cheb_debit";
            this.cheb_debit.Size = new System.Drawing.Size(100, 23);
            this.cheb_debit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cheb_debit.TabIndex = 9;
            this.cheb_debit.Text = "مصروفات ";
            this.cheb_debit.CheckedChanged += new System.EventHandler(this.cheb_debit_CheckedChanged);
            // 
            // fin_dateDateTimePicker
            // 
            this.fin_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.financialBindingSource, "fin_date", true));
            this.fin_dateDateTimePicker.Location = new System.Drawing.Point(30, 133);
            this.fin_dateDateTimePicker.Name = "fin_dateDateTimePicker";
            this.fin_dateDateTimePicker.Size = new System.Drawing.Size(176, 20);
            this.fin_dateDateTimePicker.TabIndex = 8;
            // 
            // financialBindingSource
            // 
            this.financialBindingSource.DataMember = "financial";
            this.financialBindingSource.DataSource = this.clinic_DBDataSet;
            // 
            // clinic_DBDataSet
            // 
            this.clinic_DBDataSet.DataSetName = "clinic_DBDataSet";
            this.clinic_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descTextBox
            // 
            this.descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialBindingSource, "desc", true));
            this.descTextBox.Location = new System.Drawing.Point(30, 27);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(176, 20);
            this.descTextBox.TabIndex = 3;
            // 
            // creditTextBox
            // 
            this.creditTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialBindingSource, "credit", true));
            this.creditTextBox.Enabled = false;
            this.creditTextBox.Location = new System.Drawing.Point(30, 81);
            this.creditTextBox.Name = "creditTextBox";
            this.creditTextBox.Size = new System.Drawing.Size(176, 20);
            this.creditTextBox.TabIndex = 5;
            this.creditTextBox.Text = "0";
            // 
            // debitTextBox
            // 
            this.debitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.financialBindingSource, "debit", true));
            this.debitTextBox.Enabled = false;
            this.debitTextBox.Location = new System.Drawing.Point(30, 107);
            this.debitTextBox.Name = "debitTextBox";
            this.debitTextBox.Size = new System.Drawing.Size(176, 20);
            this.debitTextBox.TabIndex = 7;
            this.debitTextBox.Text = "0";
            // 
            // financialTableAdapter
            // 
            this.financialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BloodTypemetaTableAdapter = null;
            this.tableAdapterManager.ClinicInfoTableAdapter = null;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.financialTableAdapter = this.financialTableAdapter;
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
            // DLG_addnewfinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 364);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "DLG_addnewfinancial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة عملية جديدة ";
            this.Load += new System.EventHandler(this.DLG_addnewfinancial_Load);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource financialBindingSource;
        private clinic_DBDataSetTableAdapters.financialTableAdapter financialTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox creditTextBox;
        private System.Windows.Forms.TextBox debitTextBox;
        private DevComponents.DotNetBar.ButtonX btn_Exit;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private System.Windows.Forms.DateTimePicker fin_dateDateTimePicker;
        private DevComponents.DotNetBar.Controls.CheckBoxX cheb_credit;
        private DevComponents.DotNetBar.Controls.CheckBoxX cheb_debit;
    }
}