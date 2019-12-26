/*
 * Search.cs
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
    public partial class Search : UserControl
    {
        OrderBUS orderBUS = new OrderBUS();

        public Search()
        {
            InitializeComponent();
            allRadioButton.Checked = true;
            inforPanel.Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (allRadioButton.Checked == true)
            {
                dt = orderBUS.selectAll();
            }
            if (idRadioButton.Checked == true)
            {
                if (searchTextbox.text != "")
                {
                    dt = orderBUS.selectAllByOrderID(searchTextbox.text);
                }
                else
                {
                    dt = orderBUS.selectAll();
                }
            }
            if (tableRadioButton.Checked == true)
            {
                if (searchTextbox.text != "")
                {
                    dt = orderBUS.selectAllByTable(searchTextbox.text);
                }
                else
                {
                    dt = orderBUS.selectAll();
                }
            }
            if (dateRadioButton.Checked == true)
            {
                if (searchTextbox.text != "")
                {
                    dt = orderBUS.selectAllByTime(searchTextbox.text);
                }
                else
                {
                    dt = orderBUS.selectAll();
                }
            }


            int count = dt.Rows.Count;
            if (count > 0)
            {
                listPanel.Controls.Clear();
                for (int i = 0; i < count; i++)
                {
                    String orderID = dt.Rows[i][0].ToString();
                    String table = dt.Rows[i][1].ToString();
                    String time = dt.Rows[i][2].ToString();
                    String status = dt.Rows[i][3].ToString();
                    String total = dt.Rows[i][4].ToString();
                    listPanel.Controls.Add(new OrderPanel(orderID, table, time, status, total));
                }
                inforPanel.Visible = true;
            }
            else
            {
                ShowNoFound();
            }
        }

        private void ShowNoFound()
        {
            inforPanel.Visible = false;
            MessageBox.Show("No Results Found!");
        }
    }
}
