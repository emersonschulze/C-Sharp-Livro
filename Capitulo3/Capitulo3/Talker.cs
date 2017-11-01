using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo3
{
    class Talker
    {
        public static int BlaBlaBla(string coisasPraFalar, int vezes)
        {
            string stringFinal = " ";
            for(int i = 0; i< vezes; i++)
            {
                stringFinal += " "+coisasPraFalar +"\n ";
            }
            MessageBox.Show(stringFinal);
            return stringFinal.Length;
        }
    }
}
