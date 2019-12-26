/*
 * AddUserForm.cs
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
    public partial class AddUserForm : Form
    {
        UserBUS userBUS = new UserBUS();
        public string username;
        public string role;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(usernameTextbox.Text != "" && passwordTextbox.Text != "")
            {
                if (!userBUS.countByUsername(usernameTextbox.Text))
                {
                    username = usernameTextbox.Text;
                    role = roleCombobox.selectedValue.ToString();
                    userBUS.InsertUserByUsernamePasswordRole(usernameTextbox.Text, passwordTextbox.Text, roleCombobox.selectedValue.ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already exists!");
                }
            }           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextbox_OnValueChanged(object sender, EventArgs e)
        {
            this.passwordTextbox.isPassword = true;
        }
    }
}
