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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hello_World objHello = new Hello_World();
            objHello.Show();
        }

        private void somaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Soma objSoma = new Soma();
            objSoma.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora objCalculadora = new Calculadora();
            objCalculadora.Show();
        }

        private void mediaAritméticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaAritmetica objMediaAritmetica = new MediaAritmetica();
            objMediaAritmetica.Show();
        }

        private void médiaPonderadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MediaPonderada objMediaPonderada = new MediaPonderada();
            objMediaPonderada.Show();
        }

        private void laçoDeRepetiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaçoRepeticao objLacoRepeticao = new LaçoRepeticao();
            objLacoRepeticao.Show();
        }
    }
}
