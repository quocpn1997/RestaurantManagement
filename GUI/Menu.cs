/*
 * Menu.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class Menu : UserControl
    {
        FoodBUS foodBUS = new FoodBUS();
        static String SelectedFood = String.Empty;

        public static string SelectedFood1 { get => SelectedFood; set => SelectedFood = value; }

        public event EventHandler AddFoodEvent;

        public Menu()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            LoadFood();
        }

        public void LoadFood()
        {
            menuFlowLayoutPanel.Controls.Clear();

            DataTable dt = new DataTable();
            dt = foodBUS.selectAllFoodIDName();
            int count = dt.Rows.Count;

            for(int i = 0; i< count; i++)
            {
                string foodID = dt.Rows[i][0].ToString();
                string foodName = dt.Rows[i][1].ToString();
                Food food = new Food(foodID, foodName);
                addFoodClickEvent(food);
                menuFlowLayoutPanel.Controls.Add(food);
            }
        }

        private void addFoodClickEvent(Food food)
        {
            food.Click += new System.EventHandler(Food_Click);
        }

        private void Food_Click(object sender, EventArgs e)
        {
            Food food = (Food)sender;
            SelectedFood1 = food.FoodID1;
            if(AddFoodEvent != null)
            {
                AddFoodEvent(null, null);
            }
        }
    }

    public class Food : Bunifu.Framework.UI.BunifuThinButton2
    {
        String FoodName = string.Empty;
        String FoodID = string.Empty;

        public Food(string foodID, string foodName)
        {
            FoodID1 = foodID;
            FoodName1 = foodName;

            InitializeComponet();
        }

        public string FoodName1 { get => FoodName; set => FoodName = value; }
        public string FoodID1 { get => FoodID; set => FoodID = value; }

        private void InitializeComponet()
        {
            this.ActiveBorderThickness = 1;
            this.ActiveCornerRadius = 20;
            this.ActiveFillColor = System.Drawing.Color.Black;
            this.ActiveForecolor = System.Drawing.Color.White;
            this.ActiveLineColor = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ButtonText = FoodName1;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.IdleBorderThickness = 1;
            this.IdleCornerRadius = 20;
            this.IdleFillColor = System.Drawing.Color.White;
            this.IdleForecolor = System.Drawing.Color.Black;
            this.IdleLineColor = System.Drawing.Color.Black;
            this.Location = new System.Drawing.Point(40, 12);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = FoodID1 + "Button";
            this.Size = new System.Drawing.Size(149, 57);
            this.TabIndex = 0;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}
