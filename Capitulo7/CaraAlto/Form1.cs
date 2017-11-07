using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaraAlto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TallGuy tallGuy = new TallGuy() { Name = "Drogo", Height=72};
            //tallGuy.TalkAboutYourself();

            ScaryClown scary = new ScaryClown("Facas", 13);
            FunnyFunny funnyFunny = scary;
            IScaryClown outroPalhaco = funnyFunny as ScaryClown;
            outroPalhaco.Honk();

        }
    }
}
