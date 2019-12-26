/*
 * FoodOrderPanel.cs
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
    public partial class FoodOrderPanel : UserControl
    {
        String OrderID;
        String FoodID;
        String FoodName;
        int Quantity;
        OrderBUS orderBUS = new OrderBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        FoodBUS foodBUS = new FoodBUS();
        TableBUS tableBUS = new TableBUS();

        public event EventHandler SetTableStatusEmpty;

        public FoodOrderPanel(String foodID, int quantity)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;

            FoodID1 = foodID;
            FoodName = foodBUS.selectNameByFoodID(FoodID1);
            Quantity = quantity;
            OrderID = orderBUS.selectOrderIDByTableID(EatIn.SelectedTableID);

            foodNameLabel.Text = FoodName;
            quantityTextbox.Text = Quantity.ToString();
        }

        public string FoodID1 { get => FoodID; set => FoodID = value; }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            orderDetailBUS.deleteOrderDetailByFoodID(OrderID, FoodID1);

            if(this.Parent.Controls.Count == 1)
            {
                orderBUS.deleteOrderByOrderID(OrderID);
                tableBUS.UpdateStatusToEmpty(EatIn.SelectedTableID);
                if (SetTableStatusEmpty != null)
                {
                    SetTableStatusEmpty(null, null);
                }
            }

            this.Parent.Controls.Remove(this);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(quantityTextbox.Text);
            quantityTextbox.Text = (++quantity).ToString();
            orderDetailBUS.UpdateQuantityBy(OrderID, FoodID, quantity);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(quantityTextbox.Text);
            if(quantity > 1)
            {
                quantityTextbox.Text = (--quantity).ToString();
                orderDetailBUS.UpdateQuantityBy(OrderID, FoodID, quantity);
            }
        }
    }
}
