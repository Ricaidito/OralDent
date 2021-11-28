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
            //DBUtils.AddPaciente("test", "test", "test", "test", 25, "000", "si");
            //DBUtils.DeletePaciente(2);
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
                ClearInputs();
                Hide();
                MessageBox.Show("Se ha iniciado sesión!");
                menuForm = new MenuForm(DBUtils.GetName(user), this);
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
