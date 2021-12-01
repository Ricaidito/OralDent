using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class MenuForm : Form
    {
        private LoginForm loginForm;
        private PacientesMenuForm pMenuForm;
        private ConsultasMenuForm cMenuForm;
        private DentistaMenuForm dMenuForm;
        private AsistenteMenuForm aMenuForm;
        private ServiciosMenuForm sMenuForm;
        private FacturaForm fForm;

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

        private void dentistaBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            dMenuForm = new DentistaMenuForm(this);
            dMenuForm.Show();
        }

        private void asistBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            aMenuForm = new AsistenteMenuForm(this);
            aMenuForm.Show();
        }

        private void consultaBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            cMenuForm = new ConsultasMenuForm(this);
            cMenuForm.Show();
        }

        private void servicioBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            sMenuForm = new ServiciosMenuForm(this);
            sMenuForm.Show();
        }

        private void facturaBtn_Click(object sender, System.EventArgs e)
        {
            Hide();
            fForm = new FacturaForm(this);
            fForm.Show();
        }
    }
}
