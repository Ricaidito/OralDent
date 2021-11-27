using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class MenuForm : Form
    {
        private LoginForm loginForm;

        public MenuForm(string name, LoginForm login)
        {
            InitializeComponent();
            loginForm = login;
            welcomeLabel.Text = $"Bienvenid@ {name}!";
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }
    }
}
