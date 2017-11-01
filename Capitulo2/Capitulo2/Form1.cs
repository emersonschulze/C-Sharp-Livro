using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = "Carmilla";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("O nome é: " + nome
                + "\n O x é: " + x
                + "\nO d é: " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x com certeza é 10!");
            }
            else
            {
                MessageBox.Show("x não é 10!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valorQualquer = 4;
            string nome = "João das Neves";
            if ((valorQualquer < 3) && (nome.Equals("João")))
            {
                MessageBox.Show("x é 3 e o nome é João");
            }

            MessageBox.Show("Essa linha executa de qualquer maneira :)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while(count < 10)
            {
                count++;
            }

            for(int i = 0; i<5; i++)
            {
                count--;
            }

            MessageBox.Show("O resultado é: "+count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string result = "";
            int x = 3;
            while (x > 0)
            {
                

                if(x > 2)
                {
                    result = result + "a";
                }

                x = x - 1;
                result = result + "-";

                if (x == 2)
                {
                    result = result + "b c";
                }

                if(x == 1)
                {
                    result += "d";
                    x = x - 1;
                }

               

            }
            

            MessageBox.Show("O resultado é: "+result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked != true)
            {
                MessageBox.Show("A caixinha não está marcada!");
            }
            else if(label1.BackColor == Color.BlueViolet)
            {
                label1.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.BlueViolet;
            }
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int i = 0; i < 254; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    //Atrasa a mudança das cores
                    //System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
