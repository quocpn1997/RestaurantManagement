/*
 * Payment.cs
 * Copyright 2018 by Pham Nguyen Quoc <quocpn1997@gmail.com>
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class Payment : Form
    {
        String OrderID;
        OrderBUS orderBUS = new OrderBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        FoodBUS foodBUS = new FoodBUS();
        int total = 0;

        public Payment(String orderID)
        {
            InitializeComponent();
            OrderID = orderID;
            LoadOrderDetail();
        }

        private void LoadOrderDetail()
        {
            DataTable dt = new DataTable();
            dt = orderDetailBUS.selectAllOrderDetailByOrderID(OrderID);
            int count = dt.Rows.Count;
            String foodname;
            String quantity;
            String price;

            for(int i = 0; i < count; i++)
            {
                String foodID = dt.Rows[i][0].ToString();
                quantity = dt.Rows[i][1].ToString();
                foodname = foodBUS.selectNameByFoodID(foodID);
                price = foodBUS.selectPriceByID(foodID);
                foodDetailPanel.Controls.Add(new BillFoodDetail(foodname, quantity, price));

                total += int.Parse(quantity) * int.Parse(price);
            }
            totalLabel.Text = total.ToString();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            orderBUS.updateDoneStatus(OrderID);
            orderBUS.updateTotal(OrderID, total);
            orderBUS.updateTime();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
