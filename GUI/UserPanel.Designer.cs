namespace GUI
{
    partial class UserPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roleLabel = new System.Windows.Forms.Label();
            this.deleteUserButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deleteUserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(255, 31);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(38, 17);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Role";
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteUserButton.Image = global::GUI.Properties.Resources.DeleteIcon;
            this.deleteUserButton.ImageActive = null;
            this.deleteUserButton.Location = new System.Drawing.Point(400, 31);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(26, 26);
            this.deleteUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.TabStop = false;
            this.deleteUserButton.Zoom = 10;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(103, 31);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(75, 17);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.UserAvatar;
            this.pictureBox1.Location = new System.Drawing.Point(30, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(454, 84);
            ((System.ComponentModel.ISupportInitialize)(this.deleteUserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleLabel;
        private Bunifu.Framework.UI.BunifuImageButton deleteUserButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
