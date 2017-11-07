using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConhecendoACasa
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        private string doorDescription;

        public RoomWithDoor(string name, string decoration, string doorDecription) : base (name, decoration)
        {
            this.DoorDescription = doorDescription;
        }
        
        public string DoorDescription
        {
            get { return doorDescription; }
            set { doorDescription = value; }
        }

        
    }
}
