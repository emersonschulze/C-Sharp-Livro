using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrucaoCasa
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription;

        public RoomWithDoor(string name, string decoration, string DoorDesc) : base(name, decoration)
        {
            this.DoorDescription = DoorDesc;
        }
    }
}
