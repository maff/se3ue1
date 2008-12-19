using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A4
{
    public partial class MainWindow : Form
    {
        private Rechner rechner = new Rechner();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonEvent()
        {
            rechner.zahl1 = int.Parse(textBoxZahl1.Text);
            rechner.zahl2 = int.Parse(textBoxZahl2.Text);
        }

        private void showResults()
        {
            textBoxResult.Text = rechner.result.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonEvent();
            rechner.add();
            showResults();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            buttonEvent();
            rechner.subtract();
            showResults();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            buttonEvent();
            rechner.multiply();
            showResults();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            buttonEvent();
            rechner.divide();
            showResults();
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            buttonEvent();
            rechner.modulo();
            showResults();
        }
    }
}
