namespace GUI
{
    partial class MainForm
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
            this.tabPanel = new System.Windows.Forms.Panel();
            this.employeeTabButton = new System.Windows.Forms.Button();
            this.logoutButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.quitButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.settingTabButton = new System.Windows.Forms.Button();
            this.reportTabButton = new System.Windows.Forms.Button();
            this.deliveryTabButton = new System.Windows.Forms.Button();
            this.eatInTabButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userAvatar = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.Green;
            this.tabPanel.Controls.Add(this.employeeTabButton);
            this.tabPanel.Controls.Add(this.logoutButton);
            this.tabPanel.Controls.Add(this.quitButton);
            this.tabPanel.Controls.Add(this.settingTabButton);
            this.tabPanel.Controls.Add(this.reportTabButton);
            this.tabPanel.Controls.Add(this.deliveryTabButton);
            this.tabPanel.Controls.Add(this.eatInTabButton);
            this.tabPanel.Controls.Add(this.usernameLabel);
            this.tabPanel.Controls.Add(this.userAvatar);
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tabPanel.Size = new System.Drawing.Size(200, 768);
            this.tabPanel.TabIndex = 2;
            // 
            // employeeTabButton
            // 
            this.employeeTabButton.BackColor = System.Drawing.Color.Transparent;
            this.employeeTabButton.FlatAppearance.BorderSize = 0;
            this.employeeTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.employeeTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.employeeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeTabButton.ForeColor = System.Drawing.Color.White;
            this.employeeTabButton.Image = global::GUI.Properties.Resources.EmployeeIcon;
            this.employeeTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeTabButton.Location = new System.Drawing.Point(0, 457);
            this.employeeTabButton.Name = "employeeTabButton";
            this.employeeTabButton.Size = new System.Drawing.Size(200, 63);
            this.employeeTabButton.TabIndex = 5;
            this.employeeTabButton.Text = "User";
            this.employeeTabButton.UseVisualStyleBackColor = false;
            this.employeeTabButton.Click += new System.EventHandler(this.employeeTabButton_Click);
            this.employeeTabButton.MouseEnter += new System.EventHandler(this.employeeTabButton_MouseEnter);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.BackColor = System.Drawing.Color.Green;
            this.logoutButton.color = System.Drawing.Color.Green;
            this.logoutButton.colorActive = System.Drawing.Color.DarkGreen;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Image = global::GUI.Properties.Resources.LogoutIcon;
            this.logoutButton.ImagePosition = 8;
            this.logoutButton.ImageZoom = 25;
            this.logoutButton.LabelPosition = 25;
            this.logoutButton.LabelText = "Logout";
            this.logoutButton.Location = new System.Drawing.Point(0, 703);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(95, 65);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitButton.BackColor = System.Drawing.Color.Green;
            this.quitButton.color = System.Drawing.Color.Green;
            this.quitButton.colorActive = System.Drawing.Color.DarkGreen;
            this.quitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Image = global::GUI.Properties.Resources.QuitIcon;
            this.quitButton.ImagePosition = 8;
            this.quitButton.ImageZoom = 25;
            this.quitButton.LabelPosition = 25;
            this.quitButton.LabelText = "Quit";
            this.quitButton.Location = new System.Drawing.Point(94, 703);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(106, 65);
            this.quitButton.TabIndex = 3;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // settingTabButton
            // 
            this.settingTabButton.BackColor = System.Drawing.Color.Transparent;
            this.settingTabButton.FlatAppearance.BorderSize = 0;
            this.settingTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.settingTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingTabButton.ForeColor = System.Drawing.Color.White;
            this.settingTabButton.Image = global::GUI.Properties.Resources.SettingIcon;
            this.settingTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingTabButton.Location = new System.Drawing.Point(0, 399);
            this.settingTabButton.Name = "settingTabButton";
            this.settingTabButton.Size = new System.Drawing.Size(200, 63);
            this.settingTabButton.TabIndex = 2;
            this.settingTabButton.Text = "Setting";
            this.settingTabButton.UseVisualStyleBackColor = false;
            this.settingTabButton.Click += new System.EventHandler(this.settingTabButton_Click);
            this.settingTabButton.MouseEnter += new System.EventHandler(this.settingTabButton_MouseEnter);
            // 
            // reportTabButton
            // 
            this.reportTabButton.BackColor = System.Drawing.Color.Transparent;
            this.reportTabButton.FlatAppearance.BorderSize = 0;
            this.reportTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reportTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.reportTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTabButton.ForeColor = System.Drawing.Color.White;
            this.reportTabButton.Image = global::GUI.Properties.Resources.ResultIcon;
            this.reportTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportTabButton.Location = new System.Drawing.Point(0, 341);
            this.reportTabButton.Name = "reportTabButton";
            this.reportTabButton.Size = new System.Drawing.Size(200, 63);
            this.reportTabButton.TabIndex = 2;
            this.reportTabButton.Text = "Report";
            this.reportTabButton.UseVisualStyleBackColor = false;
            this.reportTabButton.Click += new System.EventHandler(this.reportTabButton_Click);
            this.reportTabButton.MouseEnter += new System.EventHandler(this.reportTabButton_MouseEnter);
            // 
            // deliveryTabButton
            // 
            this.deliveryTabButton.BackColor = System.Drawing.Color.Transparent;
            this.deliveryTabButton.FlatAppearance.BorderSize = 0;
            this.deliveryTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deliveryTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.deliveryTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deliveryTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTabButton.ForeColor = System.Drawing.Color.White;
            this.deliveryTabButton.Image = global::GUI.Properties.Resources.SearchIcon;
            this.deliveryTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deliveryTabButton.Location = new System.Drawing.Point(0, 282);
            this.deliveryTabButton.Name = "deliveryTabButton";
            this.deliveryTabButton.Size = new System.Drawing.Size(200, 63);
            this.deliveryTabButton.TabIndex = 3;
            this.deliveryTabButton.Text = "Search";
            this.deliveryTabButton.UseVisualStyleBackColor = false;
            this.deliveryTabButton.Click += new System.EventHandler(this.deliveryTabButton_Click);
            this.deliveryTabButton.MouseEnter += new System.EventHandler(this.deliveryTabButton_MouseEnter);
            // 
            // eatInTabButton
            // 
            this.eatInTabButton.BackColor = System.Drawing.Color.Transparent;
            this.eatInTabButton.FlatAppearance.BorderSize = 0;
            this.eatInTabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eatInTabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.eatInTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eatInTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatInTabButton.ForeColor = System.Drawing.Color.White;
            this.eatInTabButton.Image = global::GUI.Properties.Resources.TakeAwayIcon;
            this.eatInTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eatInTabButton.Location = new System.Drawing.Point(0, 222);
            this.eatInTabButton.Name = "eatInTabButton";
            this.eatInTabButton.Size = new System.Drawing.Size(200, 63);
            this.eatInTabButton.TabIndex = 1;
            this.eatInTabButton.Text = "Eat - in";
            this.eatInTabButton.UseVisualStyleBackColor = false;
            this.eatInTabButton.Click += new System.EventHandler(this.eatInTabButton_Click);
            this.eatInTabButton.MouseEnter += new System.EventHandler(this.eatInTabButton_MouseEnter);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(0, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(200, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userAvatar
            // 
            this.userAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.userAvatar.Image = global::GUI.Properties.Resources.UserAvatar;
            this.userAvatar.Location = new System.Drawing.Point(0, 30);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(200, 50);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userAvatar.TabIndex = 1;
            this.userAvatar.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(206, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1160, 768);
            this.mainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Button employeeTabButton;
        private Bunifu.Framework.UI.BunifuTileButton logoutButton;
        private Bunifu.Framework.UI.BunifuTileButton quitButton;
        private System.Windows.Forms.Button settingTabButton;
        private System.Windows.Forms.Button reportTabButton;
        private System.Windows.Forms.Button deliveryTabButton;
        private System.Windows.Forms.Button eatInTabButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox userAvatar;
        private System.Windows.Forms.Panel mainPanel;
    }
}