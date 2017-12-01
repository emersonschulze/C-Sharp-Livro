using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class Guy
    {
        public int age;
        public string name;

        public Guy(int Iage, string Iname)
        {
            age = Iage;
            name = Iname;
        }
        
    }
}
