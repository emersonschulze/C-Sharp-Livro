using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrucaoCasa
{
    class Room : Location
    {
        public string Decoration { get; set; }

        public Room(string name, string decoration) : base(name)
        {
            this.Decoration = decoration;
        }

        public override string Description
        {
            get
            {
                string descrition = "Você pode ver "+this.Decoration+" aqui.";

                return descrition;
            }
            
        }
    }
}
