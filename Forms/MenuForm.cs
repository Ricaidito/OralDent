using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OralDent.Forms
{
    public partial class MenuForm : Form
    {

        public string userName;

        public MenuForm(string name)
        {
            InitializeComponent();
            userName = name;
            welcomeLabel.Text = $"Bienvenid@ {name}!";
        }
    }
}
