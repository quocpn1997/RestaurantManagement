namespace GUI
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.roleCombobox = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.closeButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.roleCombobox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordTextbox);
            this.panel1.Controls.Add(this.usernameTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 391);
            this.panel1.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.ActiveBorderThickness = 1;
            this.addButton.ActiveCornerRadius = 20;
            this.addButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addButton.ActiveForecolor = System.Drawing.Color.White;
            this.addButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton.BackgroundImage")));
            this.addButton.ButtonText = "Add";
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addButton.IdleBorderThickness = 1;
            this.addButton.IdleCornerRadius = 20;
            this.addButton.IdleFillColor = System.Drawing.Color.White;
            this.addButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addButton.Location = new System.Drawing.Point(31, 315);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(109, 41);
            this.addButton.TabIndex = 11;
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Role";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordTextbox.HintText = "Password";
            this.passwordTextbox.isPassword = false;
            this.passwordTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.passwordTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.passwordTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.passwordTextbox.LineThickness = 3;
            this.passwordTextbox.Location = new System.Drawing.Point(31, 162);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(249, 34);
            this.passwordTextbox.TabIndex = 8;
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordTextbox.OnValueChanged += new System.EventHandler(this.passwordTextbox_OnValueChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.usernameTextbox.HintText = "Username";
            this.usernameTextbox.isPassword = false;
            this.usernameTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.usernameTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.usernameTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.usernameTextbox.LineThickness = 3;
            this.usernameTextbox.Location = new System.Drawing.Point(31, 84);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(249, 34);
            this.usernameTextbox.TabIndex = 7;
            this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // roleCombobox
            // 
            this.roleCombobox.BackColor = System.Drawing.Color.Transparent;
            this.roleCombobox.BorderRadius = 3;
            this.roleCombobox.DisabledColor = System.Drawing.Color.Gray;
            this.roleCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleCombobox.ForeColor = System.Drawing.Color.Black;
            this.roleCombobox.Items = new string[] {
        "Employee",
        "Manager"};
            this.roleCombobox.Location = new System.Drawing.Point(72, 234);
            this.roleCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roleCombobox.Name = "roleCombobox";
            this.roleCombobox.NomalColor = System.Drawing.Color.Transparent;
            this.roleCombobox.onHoverColor = System.Drawing.Color.Transparent;
            this.roleCombobox.selectedIndex = 0;
            this.roleCombobox.Size = new System.Drawing.Size(148, 43);
            this.roleCombobox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "New User";
            // 
            // closeButton
            // 
            this.closeButton.ActiveBorderThickness = 1;
            this.closeButton.ActiveCornerRadius = 20;
            this.closeButton.ActiveFillColor = System.Drawing.Color.Red;
            this.closeButton.ActiveForecolor = System.Drawing.Color.White;
            this.closeButton.ActiveLineColor = System.Drawing.Color.Red;
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.ButtonText = "Cancel";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.IdleBorderThickness = 1;
            this.closeButton.IdleCornerRadius = 20;
            this.closeButton.IdleFillColor = System.Drawing.Color.White;
            this.closeButton.IdleForecolor = System.Drawing.Color.Red;
            this.closeButton.IdleLineColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(171, 315);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(109, 41);
            this.closeButton.TabIndex = 14;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(308, 391);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 addButton;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTextbox;
        private Bunifu.Framework.UI.BunifuDropdown roleCombobox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 closeButton;
    }
}