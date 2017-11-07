using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstrucaoCasa
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        RoomWithDoor diningRoom;
        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;
        Outside garden;
            

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            
            
        }

        private void GoTo_Click(object sender, EventArgs e)
        {
            //MoveToANewLocation();
        }

        public void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room", "An antique carpet", "an oak with a brass knob");
            diningRoom = new RoomWithDoor("Dining Room", "An antique table", "an oak with a brass knob");
            frontYard = new OutsideWithDoor("Front Yard", "good one!");
            backYard = new OutsideWithDoor("Back Yard", "good one!");
            garden = new Outside("Garden");

            livingRoom.Exits = new Location[] { diningRoom, frontYard};
            diningRoom.Exits = new Location[] { livingRoom, backYard};
            backYard.Exits = new Location[] { frontYard, garden };
            frontYard.Exits = new Location[] { backYard, garden };
            garden.Exits = new Location[] { backYard, frontYard};

            txtPosicaoAtual.Text = livingRoom.Description;
            
            for(int i = 0; i< livingRoom.Exits.Length; i++)
            {
                string names = livingRoom.Exits[i].Name+"\n";
                ComboBox.Items.Add(names);
            }

        }

        private void MoveToANewLocation(Location location)
        {
            txtPosicaoAtual.Text = location.Description;

            for (int i = 0; i < location.Exits.Length; i++)
            {
                string names = location.Exits[i].Name + "\n";
                ComboBox.Items.Add(names);
            }
        }

        
    }
}
