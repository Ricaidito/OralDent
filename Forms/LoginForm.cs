using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OralDent.Forms;
using OralDent.Utils;

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
            string user = userTb.Text;
            string pass = passTb.Text;

            if (DBUtils.CheckCredentials(user, pass))
            {
                MessageBox.Show("Se ha iniciado sesión!");
                var menuForm = new MenuForm(DBUtils.GetName(user));
                menuForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
                userTb.Clear();
                passTb.Clear();
            }

        }
    }
}
