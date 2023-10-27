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
    public partial class MediaAritmetica : Form
    {
        public MediaAritmetica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ac1, ac2, tio, ar, media;
            String situacao;

            ac1 = Convert.ToDouble(tbAc1.Text);
            ac2 = Convert.ToDouble(tbAc2.Text);
            tio = Convert.ToDouble(tbTio.Text);
            ar = Convert.ToDouble(tbAr.Text);
            
            media = ((ac1 + ac2 + tio + ar) / 4);
            if (media > 7)
            {
                situacao = "Aprovado"; 
            }else if( media > 3 && media < 7)
            {
                situacao = "Exame";
            }
            else
            {
                situacao = "Reprovado";
            }

            lblResultado.Text = "Sua média é: " + media;
            lblResultado.Text += "\n Você está: " + situacao;
        }
    }
}
