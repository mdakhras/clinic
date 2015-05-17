namespace iClinic_
{
    partial class Login
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
            this.tb_usname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_pwd = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_login = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_exit = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_usname
            // 
            // 
            // 
            // 
            this.tb_usname.Border.Class = "TextBoxBorder";
            this.tb_usname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_usname.Location = new System.Drawing.Point(64, 43);
            this.tb_usname.Name = "tb_usname";
            this.tb_usname.Size = new System.Drawing.Size(224, 29);
            this.tb_usname.TabIndex = 0;
            this.tb_usname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_pwd
            // 
            // 
            // 
            // 
            this.tb_pwd.Border.Class = "TextBoxBorder";
            this.tb_pwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_pwd.Location = new System.Drawing.Point(64, 88);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(224, 29);
            this.tb_pwd.TabIndex = 1;
            this.tb_pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_login.Location = new System.Drawing.Point(175, 132);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "دخول";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(294, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(102, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "اسم المستخدم";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelX2.Location = new System.Drawing.Point(294, 94);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(102, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "كلمة المرور";
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_exit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(94, 132);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.btn_exit);
            this.panelEx1.Controls.Add(this.tb_usname);
            this.panelEx1.Controls.Add(this.tb_pwd);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.btn_login);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(410, 191);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 6;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(410, 191);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_usname;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_pwd;
        private DevComponents.DotNetBar.ButtonX btn_login;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btn_exit;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}