namespace GUI
{
    partial class Menu
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(552, 718);
            this.menuPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuFlowLayoutPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 658);
            this.panel1.TabIndex = 29;
            // 
            // menuFlowLayoutPanel
            // 
            this.menuFlowLayoutPanel.AutoScroll = true;
            this.menuFlowLayoutPanel.AutoSize = true;
            this.menuFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuFlowLayoutPanel.Name = "menuFlowLayoutPanel";
            this.menuFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(30, 2, 0, 0);
            this.menuFlowLayoutPanel.Size = new System.Drawing.Size(552, 658);
            this.menuFlowLayoutPanel.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(552, 718);
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel menuFlowLayoutPanel;
        private System.Windows.Forms.Label label1;
    }
}
