/*
 * MainForm.cs
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
    public partial class MainForm : Form
    {
        UserBUS userBUS = new UserBUS();

        int selectingTab = 0;
        Button[] tabButton;
        Image[] tabImage = { GUI.Properties.Resources.TakeAwayIcon, GUI.Properties.Resources.SearchIcon, GUI.Properties.Resources.ResultIcon, GUI.Properties.Resources.SettingIcon, GUI.Properties.Resources.EmployeeIcon };
        Image[] tabImage1 = { GUI.Properties.Resources.TakeAwayIcon1, GUI.Properties.Resources.SearchIcon1, GUI.Properties.Resources.ResultIcon1, GUI.Properties.Resources.SettingIcon1, GUI.Properties.Resources.EmployeeIcon1 };

        EatIn eatInTakeaway = new EatIn();
        Search search = new Search();
        Report report = new Report();
        Setting setting = new Setting();
        User user = new User();
        UserControl[] mainPanelControl;

        public MainForm(String username)
        {
            InitializeComponent();
            tabButton = new Button[] { eatInTabButton, deliveryTabButton, reportTabButton, settingTabButton, employeeTabButton };

            usernameLabel.Text = userBUS.SelectNameByUsername(username);
            selectTab(0);
            if (userBUS.SelectRoleByUsername(username) != "Manager")
            {
                reportTabButton.Hide();
                settingTabButton.Hide();
                employeeTabButton.Hide();
            }

            mainPanelControl = new UserControl[] { eatInTakeaway, search, report, setting, user };
            mainPanel.Controls.Add(eatInTakeaway);
            mainPanel.Controls.Add(search);
            mainPanel.Controls.Add(report);
            mainPanel.Controls.Add(setting);
            mainPanel.Controls.Add(user);

            setting.LoadTableEvent += eatInTakeaway.LoadTableEvent;
            setting.LoadMenuEvent += eatInTakeaway.LoadMenuEvent;
        }

        #region Tab Panel
        private void selectTab(int tabNumber)
        {
            if (selectingTab != tabNumber)
            {
                tabButton[selectingTab].Image = tabImage[selectingTab];
                tabButton[selectingTab].BackColor = Color.Green;
                tabButton[selectingTab].ForeColor = Color.White;
            }

            tabButton[tabNumber].Image = tabImage1[tabNumber];
            tabButton[tabNumber].BackColor = Color.White;
            tabButton[tabNumber].ForeColor = Color.Green;
            tabButton[tabNumber].FlatAppearance.MouseOverBackColor = Color.White;

            selectingTab = tabNumber;
        }

        private void tab_MouseEnter(int tabNumber)
        {
            if (tabButton[tabNumber].BackColor == Color.White)
            {
                tabButton[tabNumber].FlatAppearance.MouseOverBackColor = Color.White;
            }
            else
            {
                tabButton[tabNumber].FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            }
        }

        private void showMainPanelControl(int panelNumber)
        {
            mainPanelControl[panelNumber].Show();

            for(int i = 0; i<5 && i!= panelNumber; i++)
            {
                mainPanelControl[i].Hide();
            }
        }

        private void eatInTabButton_Click(object sender, EventArgs e)
        {
            selectTab(0);
            showMainPanelControl(0);
        }

        private void eatInTabButton_MouseEnter(object sender, EventArgs e)
        {
            tab_MouseEnter(0);
        }

        private void deliveryTabButton_Click(object sender, EventArgs e)
        {
            selectTab(1);
            showMainPanelControl(1);
        }

        private void deliveryTabButton_MouseEnter(object sender, EventArgs e)
        {
            tab_MouseEnter(1);
        }

        private void reportTabButton_Click(object sender, EventArgs e)
        {
            selectTab(2);
            report.LoadRevenueMonth();
            showMainPanelControl(2);
        }

        private void reportTabButton_MouseEnter(object sender, EventArgs e)
        {
            tab_MouseEnter(2);
        }

        private void settingTabButton_Click(object sender, EventArgs e)
        {
            selectTab(3);
            showMainPanelControl(3);
        }

        private void settingTabButton_MouseEnter(object sender, EventArgs e)
        {
            tab_MouseEnter(3);
        }

        private void employeeTabButton_Click(object sender, EventArgs e)
        {
            selectTab(4);
            showMainPanelControl(4);
        }

        private void employeeTabButton_MouseEnter(object sender, EventArgs e)
        {
            tab_MouseEnter(4);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
        #endregion
    }
}
