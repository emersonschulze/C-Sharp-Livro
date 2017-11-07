using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraAlto
{
    class FunnyFunny : IClown
    {
        public string FunnyThingsIHave { get; set; }

        public FunnyFunny(String ftih)
        {
            this.FunnyThingsIHave = ftih;
        }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Fom! Fom! Eu tenho "+ FunnyThingsIHave);
        }
    }
}
