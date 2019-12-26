/*
 * EatIn.cs
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
    public partial class EatIn : UserControl
    {
        TableBUS tableBUS = new TableBUS();
        OrderBUS orderBUS = new OrderBUS();
        FoodBUS foodBUS = new FoodBUS();
        OrderDetailBUS orderDetailBUS = new OrderDetailBUS();
        static String selectedTableID = "01";
        Menu menu = new Menu();
        DataTable dt = new DataTable();
        bool isMenuOpened = false;

        public static string SelectedTableID { get => selectedTableID; set => selectedTableID = value; }

        public EatIn()
        {
            InitializeComponent();    
            LoadTable();
            LoadFoodOrder();
            menu.AddFoodEvent += AddFoodEvent;
        }

        private void LoadTable()
        {
            tableFlowLayoutPanel.Controls.Clear();

            dt = tableBUS.SelectAllTable();
            int rowsCount = dt.Rows.Count;

            for (int i = 0; i < rowsCount; i++)
            {
                String TableID = dt.Rows[i][0].ToString();
                String Status = dt.Rows[i][1].ToString();
                Table table = new Table(TableID, Status);
                table.Click += new EventHandler(table_Click);
                tableFlowLayoutPanel.Controls.Add(table);
            }
        }

        public void LoadTableEvent(object sender, EventArgs e)
        {
            LoadTable();
        }

        public void LoadMenuEvent(object sender, EventArgs e)
        {
            menu.LoadFood();
        }

        private void AddFoodEvent(object sender, EventArgs e)
        {
            dt = orderBUS.selectOrderByTableIDStatus(SelectedTableID);
            int count = dt.Rows.Count;
            if (count == 0)
            {
                orderBUS.insertNewOrder(SelectedTableID);
                tableBUS.UpdateStatusToFull(SelectedTableID);
                SetTableStatusFull();
                dt = orderBUS.selectOrderByTableIDStatus(SelectedTableID);
            }

            String orderID = dt.Rows[0][0].ToString();
            String foodID = Menu.SelectedFood1;
            if (!isFoodOrderExist(foodID))
            {
                orderDetailBUS.insertNewOrderDetail(orderID, foodID, 1);
                FoodOrderPanel foodOrderPanel = new FoodOrderPanel(foodID, 1);
                foodOrderPanel.SetTableStatusEmpty += new EventHandler(SetTableStatusEmpty);
                orderPanel.Controls.Add(foodOrderPanel);
            }
        }

        private bool isFoodOrderExist(String foodID)
        {
            foreach (FoodOrderPanel foodOrderPanel in orderPanel.Controls)
            {
                if (foodOrderPanel.FoodID1 == foodID)
                {
                    return true;
                }
            }
            return false;
        }

        private void table_Click(object sender, EventArgs e)
        {
            orderPanel.Controls.Clear();
            Table table = (Table)sender;
            SelectedTableID = table.TableID1;
            tableNumberLabel.Text = SelectedTableID;
            LoadFoodOrder();
        }

        private void LoadFoodOrder()

        {
            String orderID = orderBUS.selectOrderIDByTableID(SelectedTableID);
            if (orderID != "0")
            {
                dt = orderDetailBUS.selectAllOrderDetailByOrderID(orderID);
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    String foodID = dt.Rows[i][0].ToString();
                    int quantity = int.Parse(dt.Rows[i][1].ToString());
                    FoodOrderPanel foodOrderPanel = new FoodOrderPanel(foodID, quantity);
                    foodOrderPanel.SetTableStatusEmpty += new EventHandler(SetTableStatusEmpty);
                    orderPanel.Controls.Add(foodOrderPanel);
                }
            }
        }

        private void SetFullSelectedTableEvent(object sender, EventArgs e)
        {
            foreach (Table table in tableFlowLayoutPanel.Controls)
            {
                if (table.TableID1 == selectedTableID)
                {
                    table.SetFull();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (isMenuOpened)
            {
                tablePanel.Controls.Remove(menu);
                this.menuButton.LabelText = "Menu";
                this.menuButton.Image = global::GUI.Properties.Resources.MenuIcon;
                isMenuOpened = false;
            }
            else
            {
                tablePanel.Controls.Add(menu);
                this.menuButton.LabelText = "Table";
                this.menuButton.Image = global::GUI.Properties.Resources.Table;
                isMenuOpened = true;
            }
        }

        private void SetTableStatusFull()
        {
            foreach (Table table in tableFlowLayoutPanel.Controls)
            {
                if (table.TableID1 == selectedTableID)
                {
                    table.Status1 = "Full";
                    table.SetFull();
                }
            }
        }

        private void SetTableStatusEmptyAfterPayment()
        {
            foreach (Table table in tableFlowLayoutPanel.Controls)
            {
                if (table.TableID1 == selectedTableID)
                {
                    table.Status1 = "Empty";
                    table.SetEmpty();
                }
            }
        }

        private void SetTableStatusEmpty(object sender, EventArgs e)
        {
            foreach (Table table in tableFlowLayoutPanel.Controls)
            {
                if (table.TableID1 == selectedTableID)
                {
                    table.Status1 = "Empty";
                    table.SetEmpty();
                }
            }
        }

        public class Table : Bunifu.Framework.UI.BunifuTileButton
        {
            String TableID = String.Empty;
            string Status = String.Empty;

            public Table(string tableID, string status)
            {
                TableID = tableID;
                Status1 = status;

                InitializeComponet();
            }

            public string TableID1 { get => TableID; set => TableID = value; }
            public string Status1 { get => Status; set => Status = value; }

            private void InitializeComponet()
            {
                this.BackColor = System.Drawing.Color.Transparent;
                this.color = System.Drawing.Color.Transparent;
                this.colorActive = System.Drawing.Color.Transparent;
                this.Cursor = System.Windows.Forms.Cursors.Hand;
                this.ImagePosition = 20;
                this.ImageZoom = 60;
                this.LabelPosition = 41;
                this.LabelText = TableID;
                this.Size = new System.Drawing.Size(117, 131);

                if (Status1 == "Full")
                {
                    SetFull();
                }
                else
                {
                    SetEmpty();
                }
            }

            public void SetFull()
            {
                this.Image = global::GUI.Properties.Resources.TableFull;
                this.ForeColor = System.Drawing.Color.MediumSeaGreen;
                this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            }

            public void SetEmpty()
            {
                this.Image = global::GUI.Properties.Resources.TableEmpty;
                this.ForeColor = System.Drawing.Color.Black;
                this.Font = new System.Drawing.Font("Century Gothic", 15.75F);

                TableBUS tableBUS = new TableBUS();
                tableBUS.UpdateStatusToEmpty(TableID);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (orderPanel.Controls.Count == 0)
            {
                MessageBox.Show("There's nothing to check out!");
            }
            else
            {
                String orderID = orderBUS.selectOrderIDByTableID(SelectedTableID);
                using (Payment payment = new Payment(orderID))
                {
                    var result = payment.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        orderPanel.Controls.Clear();
                        SetTableStatusEmptyAfterPayment();
                    }
                }
            }
        }
    }
}
