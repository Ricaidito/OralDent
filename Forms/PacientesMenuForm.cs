using System;
using System.Windows.Forms;
using OralDent.Utils;

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
            idTb.Clear();
        }

        private void agregarPacienteBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int ageNumber;
                string age = ageTb.Text;
                bool tryParse = int.TryParse(age, out ageNumber);

                if (tryParse)
                {
                    DBUtils.AddPaciente(
                        nameTb.Text, 
                        lastTb.Text, 
                        cedulaTb.Text, 
                        emailTb.Text, 
                        ageNumber, 
                        telTb.Text, 
                        tipoPacienteDropdown.Text
                        );
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Paciente agregado!");
                }
                else
                    MessageBox.Show("ERROR: Edad inválida!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private void eliminarPacienteBtn_Click(object sender, EventArgs e)
        {
            if (idTb.Text == string.Empty)
            {
                MessageBox.Show("ERROR: Ingrese un ID válido!");
                return;
            }

            int id = (int) Convert.ToInt64(idTb.Text);
            if (DBUtils.CheckIfPacienteExists(id))
            {
                DBUtils.DeletePaciente(id);
                MessageBox.Show("Paciente elimiando!");
                ClearBoxes();
                RefreshTable();
            }
            else
                MessageBox.Show("ERROR: No existe el paciente!");

        }

        private void updatePacienteBtn_Click(object sender, EventArgs e)
        {

            if (!CheckForNulls())
            {
                int ageNumber, idNumber;
                string age = ageTb.Text;
                string id = idTb.Text;
                bool ageResult = int.TryParse(age, out ageNumber);
                bool idResult = int.TryParse(id, out idNumber);

                if (idTb.Text == string.Empty)
                {
                    MessageBox.Show("ERROR: Ingrese un ID válido!");
                    return;
                }

                if (!DBUtils.CheckIfPacienteExists(idNumber))
                {
                    MessageBox.Show("ERROR: El paciente no existe!");
                    return;
                }

                if (idResult && ageResult)
                {
                    DBUtils.UpdatePaciente(
                        idNumber, 
                        nameTb.Text, 
                        lastTb.Text, 
                        cedulaTb.Text, 
                        emailTb.Text, 
                        ageNumber, 
                        telTb.Text, 
                        tipoPacienteDropdown.Text
                        );
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Paciente modificado!");
                }
                else
                    MessageBox.Show("ERROR: Edad inválida!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private void PacientesMenuForm_Load(object sender, EventArgs e)
        {
            dataGVPacientes.DataSource = DBUtils.GetTable("Paciente");
        }

        private bool CheckForNulls()
        {
            return tipoPacienteDropdown.SelectedIndex == -1
                || 
                (
                nameTb.Text == string.Empty 
                || lastTb.Text == string.Empty 
                || cedulaTb.Text == string.Empty 
                || emailTb.Text == string.Empty 
                || ageTb.Text == string.Empty 
                || telTb.Text == string.Empty
                );
        }

        private void ClearBoxes()
        {
            nameTb.Clear();
            lastTb.Clear();
            cedulaTb.Clear();
            emailTb.Clear();
            ageTb.Clear();
            telTb.Clear();
            tipoPacienteDropdown.SelectedIndex = -1;
            idTb.Clear();
        }

        private void RefreshTable()
        {
            dataGVPacientes.DataSource = DBUtils.GetTable("Paciente");
        }
    }
}
