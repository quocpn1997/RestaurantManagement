/*
 * Report.cs
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
    public partial class Report : UserControl
    {
        OrderBUS orderBUS = new OrderBUS();
        int[] revenueMonth = new int[12];
        public Report()
        {
            InitializeComponent();
            LoadRevenueMonth();
        }

        private void LoadChart()
        {
            foreach(var reries in revenueChart.Series)
            {
                reries.Points.Clear();
            }

            this.revenueChart.Series["Revenue"].Points.AddXY("1", revenueMonth[0]);
            this.revenueChart.Series["Revenue"].Points.AddXY("2", revenueMonth[1]);
            this.revenueChart.Series["Revenue"].Points.AddXY("3", revenueMonth[2]);
            this.revenueChart.Series["Revenue"].Points.AddXY("4", revenueMonth[3]);
            this.revenueChart.Series["Revenue"].Points.AddXY("5", revenueMonth[4]);
            this.revenueChart.Series["Revenue"].Points.AddXY("6", revenueMonth[5]);
            this.revenueChart.Series["Revenue"].Points.AddXY("7", revenueMonth[6]);
            this.revenueChart.Series["Revenue"].Points.AddXY("8", revenueMonth[7]);
            this.revenueChart.Series["Revenue"].Points.AddXY("9", revenueMonth[8]);
            this.revenueChart.Series["Revenue"].Points.AddXY("10", revenueMonth[9]);
            this.revenueChart.Series["Revenue"].Points.AddXY("11", revenueMonth[10]);
            this.revenueChart.Series["Revenue"].Points.AddXY("12", revenueMonth[11]);
        }

        public void LoadRevenueMonth()
        {
            for (int i = 0; i < 12; i++)
            {
                String tmp = orderBUS.selectSumTotalByMonth(i + 1);
                if (tmp == "")
                {
                    tmp = "0";
                }
                revenueMonth[i] = int.Parse(tmp);
            }

            LoadChart();
        }
    }
}
