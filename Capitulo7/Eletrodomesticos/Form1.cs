using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eletrodomesticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CoffeeMaker coffee = new CoffeeMaker("", "");
            Oven oven = new Oven("", "");
            Appliance[] appliance = new Appliance[2];
            appliance[0] = coffee;
            appliance[1] = oven;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
