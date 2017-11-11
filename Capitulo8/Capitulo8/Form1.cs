using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Card card = new Card(Card.Values.Four, Card.Suits.Clubs);
            string name = card.Name;
            label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Card card = new Card(((Card.Values)random.Next(1,14)), ((Card.Suits)random.Next(4)));
            label1.Text = card.Name;
        }
    }
}
