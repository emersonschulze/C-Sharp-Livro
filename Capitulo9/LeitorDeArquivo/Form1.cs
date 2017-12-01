using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeitorDeArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FileInBox();
        }
        
        private void ReadTheFile()
        {
            StreamReader reader = new StreamReader(@"C: \Users\Bárbara\Desktop\PlanoSecreto.txt");
            StreamWriter writer = new StreamWriter(@"C: \Users\Bárbara\Desktop\EmailParaOBrasil.txt");

            writer.WriteLine("Para: brasiltemsalvacaosim@gmail.com");
            writer.WriteLine("De: Blade o caçador de vampiros");
            writer.WriteLine("Assunto: Salve a amazônia!!!");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("O plano: " + lineFromThePlan);
            }

            writer.WriteLine();
            writer.Close();
            reader.Close();
        }

        private void FileInBox()
        {
            StreamReader reader = new StreamReader(@"C: \Users\Bárbara\Desktop\PlanoSecreto.txt");

            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                txtTexto.Text +="\t"+lineFromThePlan+"\n";
            }
            reader.Close();
        }
    }
}
