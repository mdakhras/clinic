namespace iClinic_
{
    partial class FirstRun_Clinicinfo
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
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label websiteLabel;
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.clinicInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinic_DBDataSet = new iClinic_.clinic_DBDataSet();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.btn_back = new DevComponents.DotNetBar.ButtonX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.btn_save = new DevComponents.DotNetBar.ButtonX();
            this.clinicInfoTableAdapter = new iClinic_.clinic_DBDataSetTableAdapters.ClinicInfoTableAdapter();
            this.tableAdapterManager = new iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).BeginInit();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(236, 33);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(58, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "اسم العيادة";
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Location = new System.Drawing.Point(250, 63);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(44, 13);
            specLabel.TabIndex = 4;
            specLabel.Text = "التخصص";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(255, 89);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(39, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "العنوان";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(237, 115);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(57, 13);
            telLabel.TabIndex = 8;
            telLabel.Text = "رقم النلفون";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(212, 141);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(82, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "البريد الالكتروني";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(206, 167);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(88, 13);
            websiteLabel.TabIndex = 12;
            websiteLabel.Text = "الموقع الالكتروني";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(315, 48);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "يرجي ادخال بيانات العيادة";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(nameLabel);
            this.panelEx2.Controls.Add(this.nameTextBox);
            this.panelEx2.Controls.Add(specLabel);
            this.panelEx2.Controls.Add(this.specTextBox);
            this.panelEx2.Controls.Add(addressLabel);
            this.panelEx2.Controls.Add(this.addressTextBox);
            this.panelEx2.Controls.Add(telLabel);
            this.panelEx2.Controls.Add(this.telTextBox);
            this.panelEx2.Controls.Add(emailLabel);
            this.panelEx2.Controls.Add(this.emailTextBox);
            this.panelEx2.Controls.Add(websiteLabel);
            this.panelEx2.Controls.Add(this.websiteTextBox);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 48);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(315, 270);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(38, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameTextBox.Size = new System.Drawing.Size(162, 20);
            this.nameTextBox.TabIndex = 1;
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
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(38, 61);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(162, 20);
            this.specTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(38, 87);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addressTextBox.Size = new System.Drawing.Size(162, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // telTextBox
            // 
            this.telTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "tel", true));
            this.telTextBox.Location = new System.Drawing.Point(38, 113);
            this.telTextBox.Name = "telTextBox";
            this.telTextBox.Size = new System.Drawing.Size(162, 20);
            this.telTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(38, 139);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(162, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clinicInfoBindingSource, "website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(38, 165);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(162, 20);
            this.websiteTextBox.TabIndex = 13;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.btn_back);
            this.panelEx3.Controls.Add(this.btn_exit);
            this.panelEx3.Controls.Add(this.btn_save);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 268);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(315, 50);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_back.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_back.Location = new System.Drawing.Point(215, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "السابق";
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.Location = new System.Drawing.Point(54, 15);
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
            this.btn_save.Location = new System.Drawing.Point(135, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "التالي";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // clinicInfoTableAdapter
            // 
            this.clinicInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClinicInfoTableAdapter = this.clinicInfoTableAdapter;
            this.tableAdapterManager.drugTableAdapter = null;
            this.tableAdapterManager.GendermetaTableAdapter = null;
            this.tableAdapterManager.metaTableAdapter = null;
            this.tableAdapterManager.PateintTableAdapter = null;
            this.tableAdapterManager.QueueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iClinic_.clinic_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            this.tableAdapterManager.VisitTableAdapter = null;
            this.tableAdapterManager.VisitTypemetaTableAdapter = null;
            // 
            // FirstRun_Clinicinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 318);
            this.Controls.Add(this.panelEx3);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "FirstRun_Clinicinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstRun_Clinicinfo";
            this.Load += new System.EventHandler(this.FirstRun_Clinicinfo_Load);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinic_DBDataSet)).EndInit();
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private clinic_DBDataSet clinic_DBDataSet;
        private System.Windows.Forms.BindingSource clinicInfoBindingSource;
        private clinic_DBDataSetTableAdapters.ClinicInfoTableAdapter clinicInfoTableAdapter;
        private clinic_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.ButtonX btn_save;
        private DevComponents.DotNetBar.ButtonX btn_back;
    }
}