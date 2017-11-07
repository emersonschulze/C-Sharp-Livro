using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletrodomesticos
{
    class Oven : Appliance
    {
        private int Capacity { get; set; }

        public Oven(string color, string plug) : base(color, plug)
        {
        }

        public void Preheat()
        {

        }

        public void HeatUp()
        {

        }

        public void Reheat()
        {

        }

        public void MonitoPower(Appliance appliance)
        {

        }
    }
}
