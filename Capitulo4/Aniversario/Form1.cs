using MenuMaker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aniversario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            CriadorDeMenu criadorDeMenu = new CriadorDeMenu() { Randomizer = new Random() };
            label1.Text = criadorDeMenu.getMenuItem();
            label2.Text = criadorDeMenu.getMenuItem();
            label3.Text = criadorDeMenu.getMenuItem();
            label4.Text = criadorDeMenu.getMenuItem();
            label5.Text = criadorDeMenu.getMenuItem();
            label6.Text = criadorDeMenu.getMenuItem();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!tabPage2.IsDisposed)
            {
                BirthdayParty birthday = new BirthdayParty();
                birthday.numberOfPeople = (int) numericUpDown1.Value;
                birthday.cakeWriting = textBox2.TextLength;
                birthday.CalculateCostOfDecorations("normal");
                birthday.CalculateCost();
                MessageBox.Show("A festa irá custar R$"+birthday.CalculateCost().ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            BirthdayParty birthday = new BirthdayParty();
            birthday.numberOfPeople = (int)numericUpDown2.Value;
            birthday.cakeWriting = textBox3.TextLength;
            birthday.CalculateCostOfDecorations("chique");
            birthday.CalculateCost();
            MessageBox.Show("A festa irá custar R$" + birthday.CalculateCost().ToString());
        }
    }
}
