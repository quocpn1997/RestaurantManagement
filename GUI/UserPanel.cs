/*
 * UserPanel.cs
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
    public partial class UserPanel : UserControl
    {
        string Username;
        string Role;
        bool Gender;
        UserBUS userBUS = new UserBUS();

        public UserPanel(string username, string role, bool gender)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            Username1 = username;
            Role = role;
            Gender = gender;
            usernameLabel.Text = Username1;
            roleLabel.Text = Role;
            ChangeGenderAvatar(gender);
        }

        public string Username1 { get => Username; set => Username = value; }

        public void ChangeRoleLabel(string role)
        {
            roleLabel.Text = role;
        }

        public void ChangeGenderAvatar(bool gender)
        {
            if(gender == true)
            {
                this.pictureBox1.Image = global::GUI.Properties.Resources.UserAvatar;
            }
            else
            {
                this.pictureBox1.Image = global::GUI.Properties.Resources.UserAvatar0;
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if(Role == "Manager" && userBUS.CountUserManager() == 1)
            {
                MessageBox.Show("There must be exist 1 manager account!");
            }
            else
            {
                userBUS.DeleteUserByUsername(Username1);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
