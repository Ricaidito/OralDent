using System;
using System.Windows.Forms;
using OralDent.Utils;

namespace OralDent.Forms
{
    public partial class FacturaForm : Form
    {
        private MenuForm lastForm;

        public FacturaForm(MenuForm lastForm)
        {
            InitializeComponent();
            this.lastForm = lastForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (CheckValidID())
            {
                if (DBUtils.CheckIfPacienteHasService(int.Parse(idPacienteTb.Text)))
                {
                    var factura = new Factura(int.Parse(idPacienteTb.Text));
                    DBUtils.GenerarFactura(factura);
                    RefreshTables();
                    MessageBox.Show(factura.ToString());
                }
                else
                    MessageBox.Show("ERROR: El paciente no ha generado ningún servicio");
            }
            else
                MessageBox.Show("ERROR: Campo inválido!");
            idPacienteTb.Clear();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private bool CheckValidID()
        {
            int idNumber;
            bool valid = int.TryParse(idPacienteTb.Text, out idNumber);

            if (valid)
                if (DBUtils.CheckIfPacienteExists(idNumber))
                    return true;
            return false;
        }

        private void RefreshTables()
        {
            facturaDGV.DataSource = DBUtils.GetTable("Factura");
            servicioDGV.DataSource = DBUtils.GetTable("Servicio");
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            facturaDGV.DataSource = DBUtils.GetTable("Factura");
            servicioDGV.DataSource = DBUtils.GetTable("Servicio");
        }

        private void FacturaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }
    }
}
