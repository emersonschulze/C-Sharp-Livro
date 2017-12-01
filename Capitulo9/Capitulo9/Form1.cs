using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capitulo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flobbo f = new Flobbo("blue yellow");
            StreamWriter sw = f.Snobbo();
            f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
            
        }

        private void FirstExemple()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Bárbara\Desktop\Arquivo.txt", true);
            writer.WriteLine("These are my words, hear me NOW!!!!! MUA HA HA HA HA.");
            writer.Close();
        }

        private void MoreThingsToWrite()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\Bárbara\Desktop\Evil.txt", true);
            writer.WriteLine("These are my words, hear me NOW!!!!! MUA HA HA HA HA.\nI'll find everybody on these places...");
            string location = "The mall";
            for(int i = 0; i<=6; i++)
            {
                writer.WriteLine(location+"\n");
                if(location == "The mall")
                {
                    location = "Downtown";
                }
                else
                {
                    location = "The mall";
                }
            }
            writer.Close();
        }
    }
}
