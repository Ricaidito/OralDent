using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class PacientesMenuForm : Form
    {
        private MenuForm menu;

        public PacientesMenuForm(MenuForm lastMenu)
        {
            InitializeComponent();
            menu = lastMenu;
        }

        private void PacientesMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
