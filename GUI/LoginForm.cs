/*
 * LoginForm.cs
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
    public partial class LoginForm : Form
    {
        UserBUS userBUS = new UserBUS();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeFormButtonPicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeFormButtonPicture_MouseEnter(object sender, EventArgs e)
        {
            this.closeFormButtonPicture.Image = global::GUI.Properties.Resources.CloseForm1;
        }

        private void closeFormButtonPicture_MouseLeave(object sender, EventArgs e)
        {
            this.closeFormButtonPicture.Image = global::GUI.Properties.Resources.CloseForm;
        }

        private void minimizeFormButtonPicture_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeFormButtonPicture_MouseEnter(object sender, EventArgs e)
        {
            this.minimizeFormButtonPicture.Image = global::GUI.Properties.Resources.MinimizeForm1;
        }

        private void minimizeFormButtonPicture_MouseLeave(object sender, EventArgs e)
        {
            this.minimizeFormButtonPicture.Image = global::GUI.Properties.Resources.MinimizeForm;
        }

        private void loginFormButton_Click(object sender, EventArgs e)
        {
            if (userBUS.SelectUserByUsernamePassword(this.usernameLoginTextbox.Text, this.passwordLoginTextbox.Text))
            {
                this.Hide();
                new MainForm(this.usernameLoginTextbox.Text).ShowDialog();
                this.Close();
            }
            else
            {
                this.cantLoginLabel.Visible = true;
            }
        }

        private void usernameLoginTextbox_OnValueChanged(object sender, EventArgs e)
        {
            this.cantLoginLabel.Visible = false;
        }

        private void passwordLoginTextbox_OnValueChanged(object sender, EventArgs e)
        {
            this.cantLoginLabel.Visible = false;
            this.passwordLoginTextbox.isPassword = true;
        }
    }
}
