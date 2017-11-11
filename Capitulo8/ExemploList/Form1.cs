using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = Duck.KindOfDuck.Mallard, Size = 17},
                new Duck() {Kind = Duck.KindOfDuck.Muscovy, Size = 18},
                new Duck() {Kind = Duck.KindOfDuck.Decoy, Size = 14},
                new Duck() {Kind = Duck.KindOfDuck.Muscovy, Size = 11},
                new Duck() {Kind = Duck.KindOfDuck.Mallard, Size = 14},
                new Duck() {Kind = Duck.KindOfDuck.Decoy, Size = 13},
            };

            DuckCompare_bySize dc = new DuckCompare_bySize();
            //dc.CompareTo();
            //ducks.Sort(dc);
            ducks.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();

            string zilch = "zero";
            string first = "one";
            string second = "two";
            string third = "three";
            string fourth = "4.2";
            string twopointtwo = "2.2";

            a.Add(zilch);
            a.Add(first);
            a.Add(second);
            a.Add(third);

            if (a.Contains("three"))
            {
                a.Add("Four");
            }

            a.RemoveAt(2);

            if(a.IndexOf("Four") != 4)
            {
                a.Add(fourth);
            }

            if (a.Contains("Two"))
            {
                a.Add(twopointtwo);
            }

            printL(a);

        }

        public void printL(List<string> a)
        {
            string result = "";
            foreach (string element in a)
            {
                result += "\n" + element;
            }

            MessageBox.Show(result);
        }
    }
}
