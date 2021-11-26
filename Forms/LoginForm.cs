﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OralDent.Forms;

namespace OralDent
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userTb.Text == string.Empty ? "x" : userTb.Text;
            string pass = passTb.Text == string.Empty ? "y" : passTb.Text;

            MessageBox.Show($"{user} ha iniciado sesión con la contraseña: {pass}");

            var menuForm = new MenuForm(user);
            menuForm.ShowDialog();
        }
    }
}
