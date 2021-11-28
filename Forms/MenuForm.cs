using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class MenuForm : Form
    {
        private LoginForm loginForm;
        private PacientesMenuForm pMenuForm;

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

        private void pacientesBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            pMenuForm = new PacientesMenuForm(this);
            pMenuForm.Show();
        }
    }
}
