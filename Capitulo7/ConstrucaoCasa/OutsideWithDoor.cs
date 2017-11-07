using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrucaoCasa
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public string DoorDescription;

        public OutsideWithDoor(string name, string doorDescription) : base(name)
        {
            this.DoorDescription = doorDescription;
        }
    }
}
