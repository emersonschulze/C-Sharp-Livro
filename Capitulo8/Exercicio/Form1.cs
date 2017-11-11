using Capitulo8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string name = "";
            List<Card> cards = new List<Card>();
            for (int i = 0; i < 5; i++)
            { 
                Card card = new Card(((Card.Values)random.Next(1, 14)), ((Card.Suits)random.Next(4)));
                cards.Add(card);
                name += card.Name+"\n";
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Without Order");
            Console.WriteLine("=============================");
            Console.WriteLine(name);

            CardCompare_byValue cardCompare = new CardCompare_byValue();
            cards.Sort(cardCompare);
            string bobEsponja = "";
            foreach ( Card card in cards)
            {
                bobEsponja += card.Name + "\n";
            }
            Console.WriteLine("=============================");
            Console.WriteLine("With Order");
            Console.WriteLine("=============================");
            Console.WriteLine(bobEsponja);
           


        }
    }
}
