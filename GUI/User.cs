/*
 * User.cs
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
    public partial class User : UserControl
    {
        UserBUS userBUS = new UserBUS();
        DataTable dt = new DataTable();
        string selectedUsername = "";

        public User()
        {
            InitializeComponent();

            dt = userBUS.SelectAllUsernameRoleGender();
            int userCount = dt.Rows.Count;

            for(int i = 0; i< userCount; i++)
            {
                string username = dt.Rows[i][0].ToString();
                string role = dt.Rows[i][1].ToString();
                bool gender;
                if(dt.Rows[i][2].ToString() == "True")
                {
                    gender = true;
                }
                else
                {
                    gender = false;
                }
                UserPanel userPanel = new UserPanel(username, role, gender);
                userPanel.Click += new EventHandler(userPanel_Click);
                userListPanel.Controls.Add(userPanel);
            }
        }

        private void userPanel_Click(object sender, EventArgs e)
        {
            UserPanel userPanel = (UserPanel)sender;
            userPanel.BackColor = Color.Silver;
            selectedUsername = userPanel.Username1;

            foreach(UserPanel up in userListPanel.Controls)
            {
                if(up.Username1 != userPanel.Username1)
                {
                    up.BackColor = Color.White;
                }
            }

            ShowUserInfo();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (var addUserForm = new AddUserForm())
            {
                if(addUserForm.ShowDialog() == DialogResult.OK)
                {
                    UserPanel userPanel = new UserPanel(addUserForm.username, addUserForm.role, false);
                    userPanel.Click += new EventHandler(userPanel_Click);
                    userListPanel.Controls.Add(userPanel);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text != "")
            {
                userBUS.UpdateNameByUsername(selectedUsername, nameTextbox.Text);
            }

            if(phoneTextbox.Text != "")
            {
                userBUS.UpdatePhoneByUsername(selectedUsername, phoneTextbox.Text);
            }

            if (addressTextbox.Text != "")
            {
                userBUS.UpdateAddressByUsername(selectedUsername, addressTextbox.Text);
            }

            if (birthdayTextbox.Text != "")
            {
                userBUS.UpdateBirthdayByUsername(selectedUsername, birthdayTextbox.Text);
            }

            userBUS.UpdateRoleByUsername(selectedUsername, roleComboBox.SelectedItem.ToString());

            bool temp = true;
            if(genderComboBox.SelectedItem.ToString() == "Male")
            {
                userBUS.UpdateGenderByUsername(selectedUsername, true);
            }
            else
            {
                userBUS.UpdateGenderByUsername(selectedUsername, false);
                temp = false;
            }

            foreach (UserPanel userPanel in userListPanel.Controls)
            {
                if (userPanel.Username1 == selectedUsername)
                {
                    userPanel.ChangeRoleLabel(roleComboBox.SelectedItem.ToString());

                    userPanel.ChangeGenderAvatar(temp);
                }
            }

            MessageBox.Show("The information has been updated!");
        }

        private void ShowUserInfo()
        {
            dt = userBUS.SelectUserByUsername(selectedUsername);
            if(dt.Rows[0][0] != null)
            {
                nameTextbox.Text = dt.Rows[0][0].ToString();
            }

            if(dt.Rows[0][1] != null)
            {
                birthdayTextbox.Text = dt.Rows[0][1].ToString();
            }

            if (dt.Rows[0][2] != null)
            {
                phoneTextbox.Text = dt.Rows[0][2].ToString();
            }

            if (dt.Rows[0][3] != null)
            {
                addressTextbox.Text = dt.Rows[0][3].ToString();
            }

            if (dt.Rows[0][4] != null)
            {
                if(dt.Rows[0][4].ToString() == "True")
                {
                    genderComboBox.SelectedIndex = 0;
                }
                else
                {
                    genderComboBox.SelectedIndex = 1;

                }
            }

            if (dt.Rows[0][5] != null)
            {
                if (dt.Rows[0][5].ToString() == "Manager")
                {
                    roleComboBox.SelectedIndex = 0;
                }
                else
                {
                    roleComboBox.SelectedIndex = 1;
                }
            }
        }

    }
}
