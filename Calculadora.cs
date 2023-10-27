using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbValor1.Text);
            double num2 = Convert.ToDouble(tbValor2.Text);
            lblResultado.Text = (num1 + num2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbValor1.Text);
            double num2 = Convert.ToDouble(tbValor2.Text);
            lblResultado.Text = (num1 - num2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbValor1.Text);
            double num2 = Convert.ToDouble(tbValor2.Text);
            lblResultado.Text = (num1 * num2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbValor1.Text);
            double num2 = Convert.ToDouble(tbValor2.Text);
            lblResultado.Text = (num1 / num2).ToString();
        }
    }
}
