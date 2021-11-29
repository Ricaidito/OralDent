using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OralDent.Utils;

namespace OralDent.Forms
{
    public partial class DentistaMenuForm : Form
    {
        private MenuForm lastForm;

        public DentistaMenuForm(MenuForm lastMenu)
        {
            InitializeComponent();
            lastForm = lastMenu;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
            lastForm.Show();
        }

        private void DentistaMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lastForm.Show();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            lastTb.Clear();
            telTb.Clear();
            moneyTb.Clear();
            especialidadCb.SelectedIndex = -1;
            idTb.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int salaryNumber;
                string salary = moneyTb.Text;
                bool tryParse = int.TryParse(salary, out salaryNumber);

                if (tryParse)
                {
                    DBUtils.AddDentista(
                        nameTb.Text,
                        lastTb.Text,
                        telTb.Text,
                        salaryNumber,
                        especialidadCb.Text
                        );
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Dentista agregado!");
                }
                else
                    MessageBox.Show("ERROR: Salario inválido!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (idTb.Text == string.Empty)
            {
                MessageBox.Show("ERROR: Ingrese un ID válido!");
                return;
            }

            int id = (int)Convert.ToInt64(idTb.Text);
            if (DBUtils.CheckIfDentistaExists(id))
            {
                DBUtils.DeleteDentista(id);
                MessageBox.Show("Dentista elimiando!");
                ClearBoxes();
                RefreshTable();
            }
            else
                MessageBox.Show("ERROR: No existe el dentista!");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForNulls())
            {
                int salaryNumber, idNumber;
                string salary = moneyTb.Text;
                string id = idTb.Text;
                bool salaryResult = int.TryParse(salary, out salaryNumber);
                bool idResult = int.TryParse(id, out idNumber);

                if (idTb.Text == string.Empty)
                {
                    MessageBox.Show("ERROR: Ingrese un ID válido!");
                    return;
                }

                if (!DBUtils.CheckIfDentistaExists(idNumber))
                {
                    MessageBox.Show("ERROR: El dentista no existe!");
                    return;
                }

                if (idResult && salaryResult)
                {
                    DBUtils.UpdateDentista(
                        idNumber,
                        nameTb.Text,
                        lastTb.Text,
                        telTb.Text,
                        salaryNumber,
                        especialidadCb.Text
                        );
                    ClearBoxes();
                    RefreshTable();
                    MessageBox.Show("Dentista modificado!");
                }
                else
                    MessageBox.Show("ERROR: salario o ID inválido!");
            }
            else
                MessageBox.Show("ERROR: No se permiten campos vacíos!");
        }

        private bool CheckForNulls()
        {
            return especialidadCb.SelectedIndex == -1
                ||
                (
                nameTb.Text == string.Empty
                || lastTb.Text == string.Empty
                || telTb.Text == string.Empty
                || moneyTb.Text == string.Empty
                );
        }

        private void RefreshTable()
        {
            dtGVDentista.DataSource = DBUtils.GetTable("Dentista");
        }

        private void ClearBoxes()
        {
            nameTb.Clear();
            lastTb.Clear();
            moneyTb.Clear();
            telTb.Clear();
            especialidadCb.SelectedIndex = -1;
            idTb.Clear();
        }

        private void DentistaMenuForm_Load(object sender, EventArgs e)
        {
            dtGVDentista.DataSource = DBUtils.GetTable("Dentista");
        }
    }
}
