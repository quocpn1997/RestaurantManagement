namespace GUI
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.applyTableButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.plusButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minusButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.totalTabelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addFoodButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.foodNameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.label2);
            this.menuPanel.Controls.Add(this.applyTableButton);
            this.menuPanel.Controls.Add(this.plusButton);
            this.menuPanel.Controls.Add(this.minusButton);
            this.menuPanel.Controls.Add(this.totalTabelLabel);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Location = new System.Drawing.Point(624, 105);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(315, 292);
            this.menuPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 60);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Table";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applyTableButton
            // 
            this.applyTableButton.ActiveBorderThickness = 1;
            this.applyTableButton.ActiveCornerRadius = 20;
            this.applyTableButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.applyTableButton.ActiveForecolor = System.Drawing.Color.White;
            this.applyTableButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.applyTableButton.BackColor = System.Drawing.Color.Transparent;
            this.applyTableButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("applyTableButton.BackgroundImage")));
            this.applyTableButton.ButtonText = "Apply";
            this.applyTableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyTableButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyTableButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.applyTableButton.IdleBorderThickness = 1;
            this.applyTableButton.IdleCornerRadius = 20;
            this.applyTableButton.IdleFillColor = System.Drawing.Color.White;
            this.applyTableButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.applyTableButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.applyTableButton.Location = new System.Drawing.Point(68, 216);
            this.applyTableButton.Margin = new System.Windows.Forms.Padding(5);
            this.applyTableButton.Name = "applyTableButton";
            this.applyTableButton.Size = new System.Drawing.Size(181, 41);
            this.applyTableButton.TabIndex = 14;
            this.applyTableButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.applyTableButton.Click += new System.EventHandler(this.applyTableButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.Image = global::GUI.Properties.Resources.PlusIcon;
            this.plusButton.ImageActive = null;
            this.plusButton.Location = new System.Drawing.Point(188, 149);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(24, 24);
            this.plusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.plusButton.TabIndex = 12;
            this.plusButton.TabStop = false;
            this.plusButton.Zoom = 10;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.Image = global::GUI.Properties.Resources.MinusIcon;
            this.minusButton.ImageActive = null;
            this.minusButton.Location = new System.Drawing.Point(108, 149);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(24, 24);
            this.minusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minusButton.TabIndex = 11;
            this.minusButton.TabStop = false;
            this.minusButton.Zoom = 10;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // totalTabelLabel
            // 
            this.totalTabelLabel.AutoSize = true;
            this.totalTabelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTabelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTabelLabel.Location = new System.Drawing.Point(138, 142);
            this.totalTabelLabel.Name = "totalTabelLabel";
            this.totalTabelLabel.Size = new System.Drawing.Size(46, 33);
            this.totalTabelLabel.TabIndex = 13;
            this.totalTabelLabel.Text = "10";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(178, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 347);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addFoodButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.priceTextbox);
            this.panel2.Controls.Add(this.foodNameTextbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 284);
            this.panel2.TabIndex = 1;
            // 
            // addFoodButton
            // 
            this.addFoodButton.ActiveBorderThickness = 1;
            this.addFoodButton.ActiveCornerRadius = 20;
            this.addFoodButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addFoodButton.ActiveForecolor = System.Drawing.Color.White;
            this.addFoodButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addFoodButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addFoodButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addFoodButton.BackgroundImage")));
            this.addFoodButton.ButtonText = "Add to Menu";
            this.addFoodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addFoodButton.IdleBorderThickness = 1;
            this.addFoodButton.IdleCornerRadius = 20;
            this.addFoodButton.IdleFillColor = System.Drawing.Color.White;
            this.addFoodButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addFoodButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addFoodButton.Location = new System.Drawing.Point(95, 216);
            this.addFoodButton.Margin = new System.Windows.Forms.Padding(5);
            this.addFoodButton.Name = "addFoodButton";
            this.addFoodButton.Size = new System.Drawing.Size(181, 41);
            this.addFoodButton.TabIndex = 15;
            this.addFoodButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addFoodButton.Click += new System.EventHandler(this.addFoodButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 60);
            this.label4.TabIndex = 23;
            this.label4.Text = "New Food";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name:";
            // 
            // priceTextbox
            // 
            this.priceTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.priceTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.priceTextbox.HintText = "";
            this.priceTextbox.isPassword = false;
            this.priceTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.priceTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.priceTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.priceTextbox.LineThickness = 3;
            this.priceTextbox.Location = new System.Drawing.Point(124, 138);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(169, 33);
            this.priceTextbox.TabIndex = 20;
            this.priceTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // foodNameTextbox
            // 
            this.foodNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.foodNameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.foodNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.foodNameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.foodNameTextbox.HintText = "";
            this.foodNameTextbox.isPassword = false;
            this.foodNameTextbox.LineFocusedColor = System.Drawing.Color.Black;
            this.foodNameTextbox.LineIdleColor = System.Drawing.Color.Black;
            this.foodNameTextbox.LineMouseHoverColor = System.Drawing.Color.Black;
            this.foodNameTextbox.LineThickness = 3;
            this.foodNameTextbox.Location = new System.Drawing.Point(124, 64);
            this.foodNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.foodNameTextbox.Name = "foodNameTextbox";
            this.foodNameTextbox.Size = new System.Drawing.Size(169, 33);
            this.foodNameTextbox.TabIndex = 19;
            this.foodNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "Menu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPanel);
            this.Name = "Setting";
            this.Size = new System.Drawing.Size(1160, 768);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTabelLabel;
        private Bunifu.Framework.UI.BunifuImageButton plusButton;
        private Bunifu.Framework.UI.BunifuImageButton minusButton;
        private Bunifu.Framework.UI.BunifuThinButton2 applyTableButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 addFoodButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox priceTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox foodNameTextbox;
        private System.Windows.Forms.Label label2;
    }
}
