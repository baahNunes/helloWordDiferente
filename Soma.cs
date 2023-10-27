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
    public partial class Soma : Form
    {
        public Soma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(inputNum1.Text);
            int num2 = Convert.ToInt32(inputNum2.Text);
            lblResultado.Text = (num1 + num2).ToString();
        }
    }
}
