using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoACasa
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description()
        {
            return base.Description()+" e você vê "+decoration+".";
        }
    }
}
