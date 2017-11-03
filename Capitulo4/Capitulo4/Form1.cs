using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo4
{

    public partial class Form1 : Form
    {

        Elephant lucinda, loy, auxiliar;
        int milhagemInicial, milhagemFinal;
        double milhasViajadas, taxaReebolso = 0.39  , quantiaDevida;
        
        public Form1()
        {
             InitializeComponent();
             lucinda = new Elephant() { name = "Lucinda", earSize = 33 };
             loy = new Elephant() { name = "Lloyd", earSize = 40 };

        }

        private void Lucinda_Click(object sender, EventArgs e)
        {
           lucinda.QuemSouEu();
        }

        private void Troca_Click(object sender, EventArgs e)
        {
            auxiliar = lucinda;
            lucinda = loy;
            loy = auxiliar;
            MessageBox.Show("Objetos trocados!s");
        }

        private void Lloyd_Click(object sender, EventArgs e)
        {
            loy.QuemSouEu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal meuValorDecimal = 10;
            int meuValorInt = (int) meuValorDecimal;
            MessageBox.Show("Meu valor int é : "+meuValorInt);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(+milhasViajadas + " milhas.", "Milhas viajadas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            milhagemInicial = (int)numericUpDown1.Value;
            milhagemFinal = (int)numericUpDown2.Value;

            if (milhagemInicial >= milhagemFinal)
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a quilometragem final!", "Impossível calcular");
            }

            milhasViajadas = milhagemFinal - milhagemInicial;
            quantiaDevida = milhasViajadas * taxaReebolso;
            label4.Text = "R$ " + quantiaDevida;
        }


    }
}
