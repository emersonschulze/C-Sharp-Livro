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

namespace UnicodeExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscreve_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt","Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            Console.WriteLine("==============BYTES============");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            Console.WriteLine("==============HEXA============");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine("");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText("eureka.txt", "ڡݕ۠ݫۿ");
            byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
            Console.WriteLine("==============ÁRABE?============");
            foreach (byte b in eurekaBytes)
            {
                Console.Write("{0} ", b);
            }
            Console.WriteLine("");
        }
    }
}
