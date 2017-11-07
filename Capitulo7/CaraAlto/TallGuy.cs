using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraAlto
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public string FunnyThingsIHave { get { return "Sapatos grandes!"; } }

        public void Honk()
        {
            System.Windows.Forms.MessageBox.Show("Honk, honk!");
        }

        public void TalkAboutYourself()
        {
            System.Windows.Forms.MessageBox.Show("Meu nome é "+Name+" e eu tenho "+Height+" de altura!");
        }
    }
}
