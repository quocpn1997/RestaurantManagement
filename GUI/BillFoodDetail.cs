/*
 * BillFoodDetail.cs
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

namespace GUI
{
    public partial class BillFoodDetail : UserControl
    {
        public BillFoodDetail(String foodName, string quantity, string price)
        {
            InitializeComponent();
            foodNameLabel.Text = foodName;
            quantityLabel.Text = quantity;
            priceLabel.Text = price;
            this.Dock = DockStyle.Top;
        }
    }
}
