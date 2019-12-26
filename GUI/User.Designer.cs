namespace GUI
{
    partial class User
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
            this.tablePanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.birthdayTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addUserButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.userListPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tablePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.label8);
            this.tablePanel.Controls.Add(this.label7);
            this.tablePanel.Controls.Add(this.label5);
            this.tablePanel.Controls.Add(this.label4);
            this.tablePanel.Controls.Add(this.roleComboBox);
            this.tablePanel.Controls.Add(this.label2);
            this.tablePanel.Controls.Add(this.genderComboBox);
            this.tablePanel.Controls.Add(this.panel2);
            this.tablePanel.Controls.Add(this.label3);
            this.tablePanel.Controls.Add(this.addressTextbox);
            this.tablePanel.Controls.Add(this.phoneTextbox);
            this.tablePanel.Controls.Add(this.birthdayTextbox);
            this.tablePanel.Controls.Add(this.nameTextbox);
            this.tablePanel.Controls.Add(this.label1);
            this.tablePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePanel.Location = new System.Drawing.Point(585, 50);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(518, 659);
            this.tablePanel.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birthday:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fullname:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.roleComboBox.Location = new System.Drawing.Point(82, 328);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 24);
            this.roleComboBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Role:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(98, 237);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(105, 24);
            this.genderComboBox.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 97);
            this.panel2.TabIndex = 11;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.color = System.Drawing.Color.Transparent;
            this.updateButton.colorActive = System.Drawing.Color.Transparent;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Image = global::GUI.Properties.Resources.UpdateIcon;
            this.updateButton.ImagePosition = 15;
            this.updateButton.ImageZoom = 30;
            this.updateButton.LabelPosition = 33;
            this.updateButton.LabelText = "Update Info";
            this.updateButton.Location = new System.Drawing.Point(195, 9);
            this.updateButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(121, 87);
            this.updateButton.TabIndex = 0;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gender:";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addressTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.addressTextbox.HintText = "";
            this.addressTextbox.isPassword = false;
            this.addressTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.addressTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.addressTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.addressTextbox.LineThickness = 3;
            this.addressTextbox.Location = new System.Drawing.Point(98, 441);
            this.addressTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(381, 33);
            this.addressTextbox.TabIndex = 5;
            this.addressTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.phoneTextbox.HintText = "";
            this.phoneTextbox.isPassword = false;
            this.phoneTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.phoneTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.phoneTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.phoneTextbox.LineThickness = 3;
            this.phoneTextbox.Location = new System.Drawing.Point(310, 319);
            this.phoneTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(169, 33);
            this.phoneTextbox.TabIndex = 4;
            this.phoneTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // birthdayTextbox
            // 
            this.birthdayTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthdayTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.birthdayTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthdayTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.birthdayTextbox.HintText = "";
            this.birthdayTextbox.isPassword = false;
            this.birthdayTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.birthdayTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.birthdayTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.birthdayTextbox.LineThickness = 3;
            this.birthdayTextbox.Location = new System.Drawing.Point(310, 228);
            this.birthdayTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.birthdayTextbox.Name = "birthdayTextbox";
            this.birthdayTextbox.Size = new System.Drawing.Size(169, 33);
            this.birthdayTextbox.TabIndex = 3;
            this.birthdayTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.nameTextbox.HintText = "";
            this.nameTextbox.isPassword = false;
            this.nameTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.nameTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.nameTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.nameTextbox.LineThickness = 3;
            this.nameTextbox.Location = new System.Drawing.Point(98, 114);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(381, 33);
            this.nameTextbox.TabIndex = 1;
            this.nameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.userListPanel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(64, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 659);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addUserButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 560);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 97);
            this.panel3.TabIndex = 2;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.Transparent;
            this.addUserButton.color = System.Drawing.Color.Transparent;
            this.addUserButton.colorActive = System.Drawing.Color.Transparent;
            this.addUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addUserButton.ForeColor = System.Drawing.Color.Black;
            this.addUserButton.Image = global::GUI.Properties.Resources.AddUserIcon;
            this.addUserButton.ImagePosition = 15;
            this.addUserButton.ImageZoom = 30;
            this.addUserButton.LabelPosition = 33;
            this.addUserButton.LabelText = "Add User";
            this.addUserButton.Location = new System.Drawing.Point(159, 8);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(121, 87);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userListPanel
            // 
            this.userListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userListPanel.Location = new System.Drawing.Point(0, 60);
            this.userListPanel.Name = "userListPanel";
            this.userListPanel.Size = new System.Drawing.Size(456, 500);
            this.userListPanel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "User";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tablePanel);
            this.Name = "User";
            this.Size = new System.Drawing.Size(1160, 768);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tablePanel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addressTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox birthdayTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel userListPanel;
        private Bunifu.Framework.UI.BunifuTileButton addUserButton;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton updateButton;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}
