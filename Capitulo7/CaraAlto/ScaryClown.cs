using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraAlto
{
    class ScaryClown : FunnyFunny, IScaryClown
    {
        public string ScaryThingIHave { get; set; }
        
        public ScaryClown(string ftih, int numberOfScary) : base (ftih)
        {
            this.ScaryThingIHave = numberOfScary + " aranhas!";
        }


        public void ScaryLittleChildren()
        {
            System.Windows.Forms.MessageBox.Show("Buh! Peguei vocês!!! ");
        }
    }
}
