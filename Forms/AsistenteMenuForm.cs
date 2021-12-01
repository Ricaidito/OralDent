using System;
using System.Windows.Forms;
using OralDent.Utils;

namespace OralDent.Forms
{
    public partial class AsistenteMenuForm : Form
    {
        private MenuForm lastForm;

        public AsistenteMenuForm(MenuForm menuForm)
        {
            InitializeComponent();
            lastForm = menuForm;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private void AsistenteMenuForm_Load(object sender, EventArgs e)
        {
            dtGvAsistente.DataSource = DBUtils.GetTable("Asistente");
            dtGvDentista.DataSource = DBUtils.GetTable("Dentista", "IdDentista", "Nombre", "Apellido");
        }

        private void AsistenteMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            lastTb.Clear();
            telTb.Clear();
            salTb.Clear();
            idDentTb.Clear();
            idTb.Clear();
        }

        private void ClearBoxes()
        {
            nameTb.Clear();
            lastTb.Clear();
            telTb.Clear();
            salTb.Clear();
            idDentTb.Clear();
            idTb.Clear();
        }

        private void RefreshTable()
        {
            dtGvAsistente.DataSource = DBUtils.GetTable("Asistente");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int salaryNumber, idNumber;
                string salary = salTb.Text;
                string id = idDentTb.Text;
                bool tryParseSalary = int.TryParse(salary, out salaryNumber);
                bool tryParseId = int.TryParse(id, out idNumber);

                if (!DBUtils.CheckIfDentistaExists(idNumber))
                {
                    MessageBox.Show("ERROR: ID de dentista inválido!");
                    return;
                }

                if (tryParseSalary && tryParseId)
                {
                    DBUtils.AddAsistente(nameTb.Text, lastTb.Text, telTb.Text, salaryNumber, idNumber);
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Asistente agregado!");
                }
                else
                    MessageBox.Show("ERROR: Salario o ID dentista inválido!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int salaryNumber, idDentistNumber;
                string salary = salTb.Text;
                string idDentist = idDentTb.Text;
                bool salaryResult = int.TryParse(salary, out salaryNumber);
                bool idResult = int.TryParse(idDentist, out idDentistNumber);

                if (idTb.Text == string.Empty)
                {
                    MessageBox.Show("ERROR: Ingrese un ID válido!");
                    return;
                }

                if (!DBUtils.CheckIfAsistenteExists(idDentistNumber))
                {
                    MessageBox.Show("ERROR: El asistente no existe!");
                    return;
                }

                if (!DBUtils.CheckIfDentistaExists(idDentistNumber))
                {
                    MessageBox.Show("ERROR: ID de dentista inválido!");
                    return;
                }

                if (idResult && salaryResult)
                {
                    DBUtils.UpdateAsistente(idDentistNumber, nameTb.Text, lastTb.Text, telTb.Text, salaryNumber, idDentistNumber);
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Asistente modificado!");
                }
                else
                    MessageBox.Show("ERROR: Salario o ID inválido!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (idTb.Text == string.Empty)
            {
                MessageBox.Show("ERROR: Ingrese un ID válido!");
                return;
            }

            int id = (int)Convert.ToInt64(idTb.Text);
            if (DBUtils.CheckIfAsistenteExists(id))
            {
                DBUtils.DeleteAsistente(id);
                MessageBox.Show("Asistente elimiando!");
                ClearBoxes();
                RefreshTable();
            }
            else
                MessageBox.Show("ERROR: No existe el asistente!");
        }

        private bool CheckForNulls()
        {
            return nameTb.Text == string.Empty 
                || lastTb.Text == string.Empty 
                || telTb.Text == string.Empty 
                || salTb.Text == string.Empty 
                || idDentTb.Text == string.Empty;
        }
    }
}
