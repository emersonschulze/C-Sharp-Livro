using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AcerteATopeira
{
    class Mole
    {
        public delegate void PopUp(int hole, bool show);
        private PopUp popUpCalback;
        private bool hidden;
        public bool Hidden { get { return hidden; } }
        private int timesHit = 0;
        private int timesShown = 0;
        private int hole = 0;
        Random random;


        public Mole(Random random, PopUp popUpCallback)
        {
            if(popUpCalback == null)
            {
                throw new ArgumentException("popUpCallBack can't be null");
            }
            else
            {
                this.random = random;
                this.popUpCalback = popUpCallback;
                hidden = true;
            }

            
        }

        public void Show()
        {
            timesShown++;
            hidden = false;
            hole = random.Next(5);
            popUpCalback(hole, true);
        }

        public void HideAgain()
        {
            hidden = true;
            popUpCalback(hole, false);
            CheckForGameOver();
        }

        public void Smacked(int holeSmacked)
        {
            if(holeSmacked == hole)
            {
                timesHit++;
                hidden = true;
                CheckForGameOver();
                popUpCalback(hole, false);
            }
        }

        private void CheckForGameOver()
        {
            if(timesShown >= 10)
            {
                popUpCalback(-1, false);
                System.Windows.Forms.MessageBox.Show("Você acertou: "+timesHit+"\nGame Over :(");
                Application.Exit();
            }
        }
    }
}
