namespace GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cantLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.usernameLoginTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginFormButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeFormButtonPicture = new System.Windows.Forms.PictureBox();
            this.closeFormButtonPicture = new System.Windows.Forms.PictureBox();
            this.passwordPicturebox = new System.Windows.Forms.PictureBox();
            this.usernamePicturebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeFormButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFormButtonPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cantLoginLabel
            // 
            this.cantLoginLabel.AutoSize = true;
            this.cantLoginLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.cantLoginLabel.Location = new System.Drawing.Point(517, 358);
            this.cantLoginLabel.Name = "cantLoginLabel";
            this.cantLoginLabel.Size = new System.Drawing.Size(181, 16);
            this.cantLoginLabel.TabIndex = 19;
            this.cantLoginLabel.Text = "Something\'s wrong. Try Again!";
            this.cantLoginLabel.Visible = false;
            // 
            // passwordLoginTextbox
            // 
            this.passwordLoginTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLoginTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passwordLoginTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLoginTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passwordLoginTextbox.HintText = "Password";
            this.passwordLoginTextbox.isPassword = false;
            this.passwordLoginTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.passwordLoginTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.passwordLoginTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.passwordLoginTextbox.LineThickness = 3;
            this.passwordLoginTextbox.Location = new System.Drawing.Point(474, 231);
            this.passwordLoginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLoginTextbox.Name = "passwordLoginTextbox";
            this.passwordLoginTextbox.Size = new System.Drawing.Size(282, 33);
            this.passwordLoginTextbox.TabIndex = 14;
            this.passwordLoginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordLoginTextbox.OnValueChanged += new System.EventHandler(this.passwordLoginTextbox_OnValueChanged);
            // 
            // usernameLoginTextbox
            // 
            this.usernameLoginTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLoginTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameLoginTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usernameLoginTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.usernameLoginTextbox.HintText = "Username";
            this.usernameLoginTextbox.isPassword = false;
            this.usernameLoginTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.usernameLoginTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.usernameLoginTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.usernameLoginTextbox.LineThickness = 3;
            this.usernameLoginTextbox.Location = new System.Drawing.Point(474, 159);
            this.usernameLoginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLoginTextbox.Name = "usernameLoginTextbox";
            this.usernameLoginTextbox.Size = new System.Drawing.Size(282, 33);
            this.usernameLoginTextbox.TabIndex = 13;
            this.usernameLoginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameLoginTextbox.OnValueChanged += new System.EventHandler(this.usernameLoginTextbox_OnValueChanged);
            // 
            // loginFormButton
            // 
            this.loginFormButton.ActiveBorderThickness = 1;
            this.loginFormButton.ActiveCornerRadius = 20;
            this.loginFormButton.ActiveFillColor = System.Drawing.Color.White;
            this.loginFormButton.ActiveForecolor = System.Drawing.Color.Green;
            this.loginFormButton.ActiveLineColor = System.Drawing.Color.Green;
            this.loginFormButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginFormButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginFormButton.BackgroundImage")));
            this.loginFormButton.ButtonText = "Login";
            this.loginFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginFormButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormButton.ForeColor = System.Drawing.Color.White;
            this.loginFormButton.IdleBorderThickness = 1;
            this.loginFormButton.IdleCornerRadius = 20;
            this.loginFormButton.IdleFillColor = System.Drawing.Color.Green;
            this.loginFormButton.IdleForecolor = System.Drawing.Color.White;
            this.loginFormButton.IdleLineColor = System.Drawing.Color.White;
            this.loginFormButton.Location = new System.Drawing.Point(517, 295);
            this.loginFormButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginFormButton.Name = "loginFormButton";
            this.loginFormButton.Size = new System.Drawing.Size(181, 41);
            this.loginFormButton.TabIndex = 12;
            this.loginFormButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginFormButton.Click += new System.EventHandler(this.loginFormButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.UserLogo;
            this.pictureBox2.Location = new System.Drawing.Point(573, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // minimizeFormButtonPicture
            // 
            this.minimizeFormButtonPicture.Image = global::GUI.Properties.Resources.MinimizeForm;
            this.minimizeFormButtonPicture.Location = new System.Drawing.Point(741, 0);
            this.minimizeFormButtonPicture.Name = "minimizeFormButtonPicture";
            this.minimizeFormButtonPicture.Size = new System.Drawing.Size(31, 31);
            this.minimizeFormButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeFormButtonPicture.TabIndex = 18;
            this.minimizeFormButtonPicture.TabStop = false;
            this.minimizeFormButtonPicture.Click += new System.EventHandler(this.minimizeFormButtonPicture_Click);
            this.minimizeFormButtonPicture.MouseEnter += new System.EventHandler(this.minimizeFormButtonPicture_MouseEnter);
            this.minimizeFormButtonPicture.MouseLeave += new System.EventHandler(this.minimizeFormButtonPicture_MouseLeave);
            // 
            // closeFormButtonPicture
            // 
            this.closeFormButtonPicture.Image = global::GUI.Properties.Resources.CloseForm;
            this.closeFormButtonPicture.Location = new System.Drawing.Point(769, 0);
            this.closeFormButtonPicture.Name = "closeFormButtonPicture";
            this.closeFormButtonPicture.Size = new System.Drawing.Size(31, 31);
            this.closeFormButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeFormButtonPicture.TabIndex = 17;
            this.closeFormButtonPicture.TabStop = false;
            this.closeFormButtonPicture.Click += new System.EventHandler(this.closeFormButtonPicture_Click);
            this.closeFormButtonPicture.MouseEnter += new System.EventHandler(this.closeFormButtonPicture_MouseEnter);
            this.closeFormButtonPicture.MouseLeave += new System.EventHandler(this.closeFormButtonPicture_MouseLeave);
            // 
            // passwordPicturebox
            // 
            this.passwordPicturebox.Image = global::GUI.Properties.Resources.PasswordLoginIcon;
            this.passwordPicturebox.Location = new System.Drawing.Point(443, 238);
            this.passwordPicturebox.Name = "passwordPicturebox";
            this.passwordPicturebox.Size = new System.Drawing.Size(26, 26);
            this.passwordPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordPicturebox.TabIndex = 16;
            this.passwordPicturebox.TabStop = false;
            // 
            // usernamePicturebox
            // 
            this.usernamePicturebox.Image = global::GUI.Properties.Resources.UsernameLoginIcon;
            this.usernamePicturebox.Location = new System.Drawing.Point(443, 168);
            this.usernamePicturebox.Name = "usernamePicturebox";
            this.usernamePicturebox.Size = new System.Drawing.Size(24, 24);
            this.usernamePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.usernamePicturebox.TabIndex = 15;
            this.usernamePicturebox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.RestaurantLogo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginFormButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cantLoginLabel);
            this.Controls.Add(this.minimizeFormButtonPicture);
            this.Controls.Add(this.closeFormButtonPicture);
            this.Controls.Add(this.passwordLoginTextbox);
            this.Controls.Add(this.usernameLoginTextbox);
            this.Controls.Add(this.passwordPicturebox);
            this.Controls.Add(this.usernamePicturebox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeFormButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeFormButtonPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cantLoginLabel;
        private System.Windows.Forms.PictureBox minimizeFormButtonPicture;
        private System.Windows.Forms.PictureBox closeFormButtonPicture;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passwordLoginTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameLoginTextbox;
        private System.Windows.Forms.PictureBox passwordPicturebox;
        private System.Windows.Forms.PictureBox usernamePicturebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 loginFormButton;
    }
}

