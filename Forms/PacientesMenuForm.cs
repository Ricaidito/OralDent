using System;
using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class PacientesMenuForm : Form
    {
        private MenuForm lastForm;

        public PacientesMenuForm(MenuForm lastMenu)
        {
            InitializeComponent();
            lastForm = lastMenu;
        }

        private void PacientesMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private void clearBoxBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            lastTb.Clear();
            cedulaTb.Clear();
            emailTb.Clear();
            ageTb.Clear();
            telTb.Clear();
            tipoPacienteDropdown.SelectedIndex = -1;
        }

        private void agregarPacienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void eliminarPacienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void updatePacienteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
