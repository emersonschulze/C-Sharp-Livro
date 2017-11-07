using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConhecendoACasa
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[comboBox1.SelectedIndex]);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Living Room","an antique carpet","an oak door with a brass knob");
            diningRoom = new Room("Dinig Room", "A crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel aplience", "a screen door");
            frontYard = new OutsideWithDoor("Front Yard",false, "an oak door with a brass knob");
            backYard = new OutsideWithDoor("Back Yard", true,"a screen door");
            garden = new Outside("Garden", false);

            diningRoom.Exits = new Location[] { livingRoom, kitchen};
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden};
            backYard.Exits = new Location[] { frontYard, garden};
            garden.Exits = new Location[] { backYard, frontYard };

            

        }

        private void MoveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            comboBox1.Items.Clear();
            for(int i = 0; i < currentLocation.Exits.Length; i++)
                comboBox1.Items.Add(currentLocation.Exits[i].Name);
            comboBox1.SelectedIndex = 0;
            textBox1.Text = currentLocation.Description();
            

        }
    }
}
