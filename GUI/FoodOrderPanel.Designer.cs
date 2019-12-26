namespace GUI
{
    partial class FoodOrderPanel
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.plusButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minusButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.deleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.quantityTextbox = new System.Windows.Forms.TextBox();
            this.foodNameLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.plusButton);
            this.panel6.Controls.Add(this.minusButton);
            this.panel6.Controls.Add(this.deleteButton);
            this.panel6.Controls.Add(this.quantityTextbox);
            this.panel6.Controls.Add(this.foodNameLabel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(421, 69);
            this.panel6.TabIndex = 1;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.Image = global::GUI.Properties.Resources.PlusIcon;
            this.plusButton.ImageActive = null;
            this.plusButton.Location = new System.Drawing.Point(316, 24);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(24, 24);
            this.plusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.plusButton.TabIndex = 10;
            this.plusButton.TabStop = false;
            this.plusButton.Zoom = 10;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.Image = global::GUI.Properties.Resources.MinusIcon;
            this.minusButton.ImageActive = null;
            this.minusButton.Location = new System.Drawing.Point(254, 24);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(24, 24);
            this.minusButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minusButton.TabIndex = 9;
            this.minusButton.TabStop = false;
            this.minusButton.Zoom = 10;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.Image = global::GUI.Properties.Resources.DeleteIcon;
            this.deleteButton.ImageActive = null;
            this.deleteButton.Location = new System.Drawing.Point(361, 22);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(26, 26);
            this.deleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteButton.TabIndex = 8;
            this.deleteButton.TabStop = false;
            this.deleteButton.Zoom = 10;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // quantityTextbox
            // 
            this.quantityTextbox.Location = new System.Drawing.Point(284, 24);
            this.quantityTextbox.Name = "quantityTextbox";
            this.quantityTextbox.Size = new System.Drawing.Size(26, 20);
            this.quantityTextbox.TabIndex = 1;
            this.quantityTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // foodNameLabel
            // 
            this.foodNameLabel.AutoSize = true;
            this.foodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodNameLabel.Location = new System.Drawing.Point(39, 28);
            this.foodNameLabel.Name = "foodNameLabel";
            this.foodNameLabel.Size = new System.Drawing.Size(42, 17);
            this.foodNameLabel.TabIndex = 0;
            this.foodNameLabel.Text = "Pizza";
            // 
            // FoodOrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Name = "FoodOrderPanel";
            this.Size = new System.Drawing.Size(421, 69);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minusButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuImageButton plusButton;
        private Bunifu.Framework.UI.BunifuImageButton minusButton;
        private Bunifu.Framework.UI.BunifuImageButton deleteButton;
        private System.Windows.Forms.TextBox quantityTextbox;
        private System.Windows.Forms.Label foodNameLabel;
    }
}
