/*
 * Setting.cs
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
    public partial class Setting : UserControl
    {
        FoodBUS foodBUS = new FoodBUS();
        TableBUS tableBUS = new TableBUS();
        DataTable dt = new DataTable();
        public event EventHandler LoadTableEvent;
        public event EventHandler LoadMenuEvent;

        public Setting()
        {
            InitializeComponent();

            dt = foodBUS.selectAllFoodName();
            int count = dt.Rows.Count;
            /*for(int i = 0; i< count; i++)
            {
                foodNameCombobox.Items.Add(dt.Rows[i][0].ToString());
            }*/

            int countTable = int.Parse(tableBUS.CountTable());
            totalTabelLabel.Text = countTable.ToString();
            if(countTable<10)
            {
                totalTabelLabel.Text = "0" + totalTabelLabel.Text;
            }
        }

        /*private void removeFoodButton_Click(object sender, EventArgs e)
        {
            String foodName = foodNameCombobox.SelectedItem.ToString();
            if(foodName!= "")
            {
                foodBUS.RemoveFoodByFoodName(foodName);
                MessageBox.Show(foodName + " has been removed!");
                foodNameCombobox.Items.Remove(foodName);

                if(LoadMenuEvent != null)
                {
                    LoadMenuEvent(null, null);
                }
            }
        }*/

        private void addFoodButton_Click(object sender, EventArgs e)
        {
            if (foodNameTextbox.Text != "" && priceTextbox.Text != "")
            {
                String foodName = foodNameTextbox.Text;
                int price = int.Parse(priceTextbox.Text);
                foodBUS.AddFood(foodName, price);
                MessageBox.Show(foodName + " has been added!");
                foodNameTextbox.Text = "";
                priceTextbox.Text = "";
                //foodNameCombobox.Items.Add(foodName);

                if (LoadMenuEvent != null)
                {
                    LoadMenuEvent(null, null);
                }
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(totalTabelLabel.Text);
            tmp++;
            totalTabelLabel.Text = tmp.ToString();
            if(tmp<10)
            {
                totalTabelLabel.Text = "0" + totalTabelLabel.Text;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(totalTabelLabel.Text);
            tmp--;
            if (tmp > 0)
            {
                totalTabelLabel.Text = tmp.ToString();
                if (tmp < 10)
                {
                    totalTabelLabel.Text = "0" + totalTabelLabel.Text;
                }
            }
        }

        private void applyTableButton_Click(object sender, EventArgs e)
        {
            int tableCountNew = int.Parse(totalTabelLabel.Text);
            int tableCountOld = int.Parse(tableBUS.CountTable());
            if (tableCountNew >= tableCountOld)
            {
                for (int i = tableCountOld; i < tableCountNew; i++)
                {
                    String tableID = (i+1).ToString();
                    if((i+1)<10)
                    {
                        tableID = "0" + tableID;
                    }
                    tableBUS.insertTable(tableID);
                }
            }
            else
            {
                for (int i = tableCountOld; i > tableCountNew; i--)
                {
                    String tableID = i.ToString();
                    if (i < 10)
                    {
                        tableID = "0" + tableID;
                    }
                    tableBUS.deleteTable(tableID);
                }
            }

            if(LoadTableEvent != null)
            {
                LoadTableEvent(null, null);
            }
            MessageBox.Show("Total table has been updated!");
        }
    }
}
