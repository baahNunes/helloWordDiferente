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
    public partial class LaçoRepeticao : Form
    {
        double[] vetor1 = new double[5];
        double[] vetor2 = new double[5];
        double[] vetorR = new double[5];

        public LaçoRepeticao()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbLista1.Items.Add(int.Parse(tbNumero1.Text));
            vetor1[lbLista1.Items.Count - 1] = Double.Parse(tbNumero1.Text);

            lbLista2.Items.Add(int.Parse(tbNumero2.Text));
            vetor2[lbLista2.Items.Count - 1] = Double.Parse(tbNumero2.Text);

            tbNumero1.Text = "";
            tbNumero2.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            lbLista3.Items.Clear();
            for(int i=0; i < 5; i++)
            {
                vetorR[i] = vetor1[i] + vetor2[i];
                lbLista3.Items.Add(vetorR[i]);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lbLista3.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                vetorR[i] = vetor1[i] - vetor2[i];
                lbLista3.Items.Add(vetorR[i]);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lbLista3.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                vetorR[i] = vetor1[i] * vetor2[i];
                lbLista3.Items.Add(vetorR[i]);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lbLista3.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                if(vetor2[i] == 0)
                {
                    vetorR[i] = 0;
                    lbLista3.Items.Add(vetorR[i]);
                    continue;
                }
                vetorR[i] = vetor1[i] / vetor2[i];
                lbLista3.Items.Add(vetorR[i]);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbLista1.Items.Clear();
            lbLista2.Items.Clear();
            lbLista3.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                vetor1[i] = 0;
                vetor2[i] = 0;
                vetorR[i] = 0;
            }
        }
    }
}
