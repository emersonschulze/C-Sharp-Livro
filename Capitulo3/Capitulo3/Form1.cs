using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo3
{
    public partial class Form1 : Form
    {

        Guy joe, bob;
        int banco = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy();
            joe.nome = "Joe";
            joe.dinheiro = 45;

            bob = new Guy() { dinheiro = 234, nome = "Bob" };
            

            AtualizaForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Talker.BlaBlaBla(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("O tamanho da mensagem é: "+len);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();
            int x = 0;
            while (x < 4)
            {
                result += e1.Ola() + "\n";
                e1.count = e1.count + 1;
                if (x > 0)
                {
                    e2.count += 1;
                }
                if(x > 1)
                {
                    e2.count = e2.count + e1.count;
                }

                x++;
            }
            MessageBox.Show(result + "\nContagem: "+e2.count);


        }

        private void Joe_Click(object sender, EventArgs e)
        {
            if(banco >= 10)
            {
                banco -= joe.receberDinheiro(10);
                AtualizaForm();
            }
            else
            {
                MessageBox.Show("O banco está sem dinheiro :(");
            }
        }

        private void Bob_Click(object sender, EventArgs e)
        {
            banco += bob.darDinheiro(5);
            AtualizaForm();
        }

        private void joeGivestoBob_Click(object sender, EventArgs e)
        {
            if(joe.dinheiro > 0)
            {
                bob.receberDinheiro(joe.darDinheiro(10));
                AtualizaForm();
            }
            else
            {
                MessageBox.Show("Joe não tem mais grana :(");
            }
            
        }

        private void bobGivestoJoe_Click(object sender, EventArgs e)
        {
            if(bob.dinheiro > 0)
            {
                joe.receberDinheiro(bob.darDinheiro(5));
                AtualizaForm();
            }
            else
            {
                MessageBox.Show("Bob não tem mais grana :(");
            }
            
        }

        public void AtualizaForm()
        {
            joesCash.Text = joe.nome + " tem R$ " + joe.dinheiro;
            bobsCash.Text = bob.nome + " tem R$ " + bob.dinheiro;
            banksCash.Text = "O banco tem R$ " + banco;
        }
    }

    

    public class Echo {
        public int count =  0;

        public string Ola()
        {
            return "Olá";
        }
    }


}
