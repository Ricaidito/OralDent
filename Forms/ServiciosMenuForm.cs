using System;
using System.Windows.Forms;
using OralDent.Utils;

namespace OralDent.Forms
{
    public partial class ServiciosMenuForm : Form
    {
        private MenuForm lastForm;

        public ServiciosMenuForm(MenuForm last)
        {
            InitializeComponent();
            lastForm = last;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int idDentista, idPaciente, idSucursal;
                bool result1 = int.TryParse(idDTb.Text, out idDentista);
                bool result2 = int.TryParse(idPTb.Text, out idPaciente);
                bool result3 = int.TryParse(idSucursalTB.Text, out idSucursal);
                if (DBUtils.CheckIfPacienteExists(idPaciente) && DBUtils.CheckIfDentistaExists(idDentista) && DBUtils.CheckIfSucursalExist(idSucursal)
                    && result1 && result2 && result3)
                {
                    DBUtils.AddServicio(int.Parse(montoTb.Text), DateTime.Now, idPaciente, idSucursal, idDentista, cbTipoServicio.Text);
                    MessageBox.Show("Servicio registrado!");
                }
                else
                    MessageBox.Show("ERROR: ID's inválidos!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
            ClearBoxes();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private void ServiciosMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }

        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            montoTb.Text = Servicio.GetMonto(cbTipoServicio.Text);
        }

        private void ClearBoxes()
        {
            idDTb.Clear();
            idPTb.Clear();
        }

        private bool CheckForNulls() => idPTb.Text == string.Empty && idDTb.Text == string.Empty;

    }
}
