using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo4
{
    class Elephant
    {
        public int earSize;
        public string name;

        public void QuemSouEu()
        {
            System.Windows.Forms.MessageBox.Show("Minhas orelhas medem "+earSize+" centímetros", name+" diz...");
        }
    }
}
