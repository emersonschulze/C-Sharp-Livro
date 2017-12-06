using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnotherExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você acabou de clicar em mim!");
        }

        private void SaySomething(object sender, EventArgs e)
        {
            MessageBox.Show("Alguma coisa");
        }

        private void SaySomethingElse(object sender, EventArgs e)
        {
            MessageBox.Show("Outra coisa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomething);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Click += new EventHandler(SaySomethingElse);
        }
    }
}
