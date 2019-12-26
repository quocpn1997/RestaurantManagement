/*
 * OrderPanel.cs
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
    public partial class OrderPanel : UserControl
    {
        public OrderPanel(String orderID, String table, String time, String status, String total)
        {
            InitializeComponent();
            orderIDLabel.Text = orderID;
            tableLabel.Text = table;
            timeLabel.Text = time;
            statusLabel.Text = status;
            totalLabel.Text = total;
            this.Dock = DockStyle.Top;
        }
    }
}
