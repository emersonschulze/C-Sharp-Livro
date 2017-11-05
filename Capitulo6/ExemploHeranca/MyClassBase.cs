using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class MyClassBase
    {
        public string papinho;
        public MyClassBase(string papinho)
        {
            System.Windows.Forms.MessageBox.Show("Esta é a Classe BASE!!!!: " + papinho);
        }

    }
}
