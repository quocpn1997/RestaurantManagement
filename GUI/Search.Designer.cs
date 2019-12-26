namespace GUI
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateRadioButton = new System.Windows.Forms.RadioButton();
            this.tableRadioButton = new System.Windows.Forms.RadioButton();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.searchButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inforPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.inforPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dateRadioButton);
            this.panel1.Controls.Add(this.tableRadioButton);
            this.panel1.Controls.Add(this.idRadioButton);
            this.panel1.Controls.Add(this.allRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchTextbox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Location = new System.Drawing.Point(283, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 149);
            this.panel1.TabIndex = 0;
            // 
            // dateRadioButton
            // 
            this.dateRadioButton.AutoSize = true;
            this.dateRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRadioButton.Location = new System.Drawing.Point(421, 101);
            this.dateRadioButton.Name = "dateRadioButton";
            this.dateRadioButton.Size = new System.Drawing.Size(56, 21);
            this.dateRadioButton.TabIndex = 7;
            this.dateRadioButton.TabStop = true;
            this.dateRadioButton.Text = "Date";
            this.dateRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableRadioButton
            // 
            this.tableRadioButton.AutoSize = true;
            this.tableRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableRadioButton.Location = new System.Drawing.Point(329, 101);
            this.tableRadioButton.Name = "tableRadioButton";
            this.tableRadioButton.Size = new System.Drawing.Size(62, 21);
            this.tableRadioButton.TabIndex = 6;
            this.tableRadioButton.TabStop = true;
            this.tableRadioButton.Text = "Table";
            this.tableRadioButton.UseVisualStyleBackColor = true;
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRadioButton.Location = new System.Drawing.Point(220, 100);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(80, 21);
            this.idRadioButton.TabIndex = 5;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "Order ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRadioButton.Location = new System.Drawing.Point(147, 101);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(41, 21);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "All";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search by:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextbox.BackgroundImage")));
            this.searchTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextbox.ForeColor = System.Drawing.Color.Black;
            this.searchTextbox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextbox.Icon")));
            this.searchTextbox.Location = new System.Drawing.Point(25, 22);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(384, 42);
            this.searchTextbox.TabIndex = 1;
            this.searchTextbox.text = "";
            // 
            // searchButton
            // 
            this.searchButton.ActiveBorderThickness = 1;
            this.searchButton.ActiveCornerRadius = 20;
            this.searchButton.ActiveFillColor = System.Drawing.Color.Black;
            this.searchButton.ActiveForecolor = System.Drawing.Color.White;
            this.searchButton.ActiveLineColor = System.Drawing.Color.Black;
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.ButtonText = "Search";
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.IdleBorderThickness = 1;
            this.searchButton.IdleCornerRadius = 20;
            this.searchButton.IdleFillColor = System.Drawing.Color.White;
            this.searchButton.IdleForecolor = System.Drawing.Color.Black;
            this.searchButton.IdleLineColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(417, 22);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 42);
            this.searchButton.TabIndex = 2;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(51, 234);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(84, 347);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuSeparator4);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 59);
            this.panel2.TabIndex = 2;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(406, -1);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(17, 59);
            this.bunifuSeparator4.TabIndex = 4;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(300, -1);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(17, 59);
            this.bunifuSeparator3.TabIndex = 4;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(454, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(175, -1);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(17, 59);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(97, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(17, 59);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Order ID";
            // 
            // inforPanel
            // 
            this.inforPanel.Controls.Add(this.listPanel);
            this.inforPanel.Controls.Add(this.panel2);
            this.inforPanel.Location = new System.Drawing.Point(283, 182);
            this.inforPanel.Name = "inforPanel";
            this.inforPanel.Size = new System.Drawing.Size(541, 545);
            this.inforPanel.TabIndex = 3;
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 59);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(541, 486);
            this.listPanel.TabIndex = 3;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.inforPanel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(1160, 768);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.inforPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 searchButton;
        private Bunifu.Framework.UI.BunifuTextbox searchTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dateRadioButton;
        private System.Windows.Forms.RadioButton tableRadioButton;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel inforPanel;
        private System.Windows.Forms.Panel listPanel;
    }
}
