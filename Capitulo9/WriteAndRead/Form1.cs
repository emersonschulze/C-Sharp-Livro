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

namespace WriteAndRead
{
    public partial class Form1 : Form
    {
        private string name;
        public Form1()
        {
            InitializeComponent();
            using (StreamWriter writer = new StreamWriter("email.txt"))
            {
                //Comandos que usam writer
                writer.WriteLine("oieeeee");
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C: \Users\Bárbara\Desktop\"; //Diretório para abrir 
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);

            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
