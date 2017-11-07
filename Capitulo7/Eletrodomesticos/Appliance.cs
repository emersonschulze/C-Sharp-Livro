using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletrodomesticos
{
    class Appliance
    {
        private string  Color { get; set; }
        public string Pluggedln{ get; set; }

        public Appliance(string color, string plug)
        {
            this.Color = color;
            this.Pluggedln = plug;
        }
        
        public void ConsumePower()
        {

        }
    }
}
