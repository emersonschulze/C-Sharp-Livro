using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class MySubClass : MyClassBase
    {
        public MySubClass(string aClasseBasePrecisaDisso, int outroValor) : base(aClasseBasePrecisaDisso)
        {
            System.Windows.Forms.MessageBox.Show("Esta é a subclasse! : "+aClasseBasePrecisaDisso+" e "+outroValor);
        }
    }
}
