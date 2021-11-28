using System;
using System.Windows.Forms;
using OralDent.Forms;
using OralDent.Utils;

namespace OralDent
{
    public partial class LoginForm : Form
    {
        private MenuForm menuForm;

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
            if (DBUtils.CheckCredentials(userTb.Text, passTb.Text))
            {
                menuForm = new MenuForm(DBUtils.GetName(userTb.Text), this);
                ClearInputs();
                Hide();
                menuForm.Show();

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas!");
                ClearInputs();
            }
        }

        private void ClearInputs()
        {
            userTb.Clear();
            passTb.Clear();
        }
    }
}
