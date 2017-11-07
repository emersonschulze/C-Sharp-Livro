using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoACasa
{
    abstract class Location
    {
        private string name;
        public Location[] Exits;

        public Location(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string Description()
        {
            string descrition = "Você está no(a) "+name+". Você verá a saída nos seguintes lugares.";
            for(int i = 0; i< Exits.Length; i++)
            {
                descrition += " "+Exits[i].Name;
                if (i != Exits.Length - 1)
                {
                    descrition += ", ";
                }
            }
            descrition += ".";
            return descrition;
            return descrition;
        }
    }
}
