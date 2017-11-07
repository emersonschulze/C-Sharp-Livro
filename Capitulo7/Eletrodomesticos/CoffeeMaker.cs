using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletrodomesticos
{
    class CoffeeMaker : Appliance
    {
        private int CoffeeLeft { get; set; }

        public CoffeeMaker(string color, string plug) : base(color, plug)
        {
        }

        public void FillWithWater()
        {

        }

        public void MakeCoffe()
        {

        }

        public void MonitoPower(Appliance appliance)
        {

        }
    }
}
