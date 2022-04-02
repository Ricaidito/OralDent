using System;
using System.Windows.Forms;
using OralDent.Utils;

namespace OralDent.Forms
{
    public partial class ConsultasMenuForm : Form
    {
        private MenuForm lastForm;

        public ConsultasMenuForm(MenuForm last)
        {
            InitializeComponent();
            lastForm = last;
        }

        private void ConsultasMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }

        private void ConsultasMenuForm_Load(object sender, EventArgs e)
        {
            consultasDGV.DataSource = DBUtils.GetTable("Consulta");
            dentistaDGV.DataSource = DBUtils.GetTable(
                "Dentista", 
                "IdDentista", 
                "Nombre", 
                "Apellido"
                );
            pacientesDGV.DataSource = DBUtils.GetTable(
                "Paciente",
                "IdPaciente",
                "Nombre",
                "Apellido"
                );
        }

        private void RefreshTable()
        {
            consultasDGV.DataSource = DBUtils.GetTable("Consulta");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int idPaciente, idDentista, idSucursal;
            bool result1 = int.TryParse(idPacienteTb.Text, out idPaciente);
            bool result2 = int.TryParse(idDentTb.Text, out idDentista);
            bool result3 = int.TryParse(idSucTb.Text, out idSucursal);

            if (
                !CheckForNulls() &&
                DBUtils.CheckIfDentistaExists(idDentista) &&
                DBUtils.CheckIfPacienteExists(idPaciente) &&
                DBUtils.CheckIfSucursalExist(idSucursal) &&
                result1 &&
                result2 &&
                result3
                )
            {
                DBUtils.AddConsulta(dateTb.Value, descTb.Text, idDentista, idPaciente, idSucursal);
                MessageBox.Show("Consulta agregada!");
                RefreshTable();
            }
            else
            {
                MessageBox.Show("ERROR: Campos inválidos!");
                ClearBoxes();
            }      
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idPacienteTb.Clear();
            descTb.Clear();
            idDentTb.Clear();
            idConsultaTb.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(idConsultaTb.Text, out id);
            if (result && DBUtils.CheckIfConsultaExists(id))
            {
                DBUtils.DeleteConsulta(id);
                MessageBox.Show("Consulta elimianda!");
                RefreshTable();
                ClearBoxes();
            }
            else
            {
                MessageBox.Show("ERROR: ID inválido!");
                ClearBoxes();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int idDentista, idPaciente, idConsulta, idSucursal;
            bool result1 = int.TryParse(idDentTb.Text, out idDentista);
            bool result2 = int.TryParse(idPacienteTb.Text, out idPaciente);
            bool result3 = int.TryParse(idConsultaTb.Text, out idConsulta);
            bool result4 = int.TryParse(idSucTb.Text, out idSucursal);
            if (result1 && result2 && result3 && result4) 
            {
                if (
                    DBUtils.CheckIfDentistaExists(idDentista) 
                    && DBUtils.CheckIfConsultaExists(idConsulta) 
                    && DBUtils.CheckIfDentistaExists(idDentista)
                    && DBUtils.CheckIfSucursalExist(idSucursal)
                    )
                {
                    DBUtils.UpdateConsulta(idConsulta, dateTb.Value, descTb.Text, idDentista, idPaciente, idSucursal);
                    MessageBox.Show("Consulta actualizada!");
                    RefreshTable();
                    ClearBoxes();
                }
            }
            else
            {
                MessageBox.Show("ERROR: Campos inválidos!");
                ClearBoxes();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private void ClearBoxes()
        {
            idPacienteTb.Clear();
            descTb.Clear();
            idDentTb.Clear();
            idConsultaTb.Clear();
        }
        private bool CheckForNulls() => idPacienteTb.Text == string.Empty || idDentTb.Text == string.Empty;

        private void dateTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
