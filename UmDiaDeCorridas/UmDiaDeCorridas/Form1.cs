using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas
{
    public partial class Form1 : Form
    {
        Guy[] guys = new Guy[3];
        Bet[] bets = new Bet[3];
        GreyHound[] grey = new GreyHound[4];

        public Form1()
        {
            InitializeComponent();
  
            //João
            guys[0] = new Guy();
            guys[0].name = "João";
            guys[0].cash = 50;
            guys[0].myLabel = label4;
            guys[0].UpdateLabels();

            //Beto
            guys[1] = new Guy();
            guys[1].name = "Beto";
            guys[1].cash = 75;
            guys[1].myLabel = label5;
            guys[1].UpdateLabels();

            //Alfredo
            guys[2] = new Guy();
            guys[2].name = "Alfredo";
            guys[2].cash = 45;
            guys[2].myLabel = label6;
            guys[2].UpdateLabels();
        }

        private void rbJoao_Click(object sender, EventArgs e)
        {
            lblNome.Text = guys[0].name;
        }

        private void rbBeto_Click(object sender, EventArgs e)
        {
            lblNome.Text = guys[1].name;
        }

        private void rbAlfredo_Click(object sender, EventArgs e)
        {
            lblNome.Text = guys[2].name;
        }

        private void btnAposta_Click(object sender, EventArgs e)
        {
            if(lblNome.Text == guys[0].name)
            {
                bets[0] = new Bet();
                bets[0].bettor = guys[0];
                bets[0].amount = (int)numericUpDown1.Value;
                bets[0].dog = (int)numericUpDown2.Value;
                txtAposta1.Text = bets[0].GetDescrition();
                guys[0].MyBet = bets[0];
            }

            if (lblNome.Text == guys[1].name)
            {
                bets[1] = new Bet();
                bets[1].bettor = guys[1];
                bets[1].amount = (int)numericUpDown1.Value;
                bets[1].dog = (int)numericUpDown2.Value;
                txtAposta2.Text = bets[1].GetDescrition();
                guys[1].MyBet = bets[1];
            }

            if (lblNome.Text == guys[2].name)
            {
                bets[2] = new Bet();
                bets[2].bettor = guys[2];
                bets[2].amount = (int)numericUpDown1.Value;
                bets[2].dog = (int)numericUpDown2.Value;
                txtAposta3.Text = bets[2].GetDescrition();
                guys[2].MyBet = bets[2];
            }
        }

        private void btnCorram_Click(object sender, EventArgs e)
        {
            guys[0].PlaceBet(bets[0].amount, bets[0].dog);
            guys[1].PlaceBet(bets[1].amount, bets[1].dog);
            guys[2].PlaceBet(bets[2].amount, bets[2].dog);
            
            
            //Cão 1
            grey[0] = new GreyHound();
            grey[0].myPictureBox = Cao1;
            //grey[0].Run();

            //Cão 2
            grey[1] = new GreyHound();
            grey[1].myPictureBox = Cao2;
            //grey[1].Run();

            //Cão 3
            grey[2] = new GreyHound();
            grey[2].myPictureBox = Cao3;
            //grey[2].Run();

            //Cão 4
            grey[3] = new GreyHound();
            grey[3].myPictureBox = Cao4;
            //grey[3].Run();


            for(int i = 0; i<4; i++)
            {
                grey[i].Run();
                if (grey[i].Run())
                {
                    MessageBox.Show("O cão "+i+1+ " ganhou!");
                    for (int j = 0; j < 3; j++)
                    {
                        int d = bets[j].dog;
                        if (d == i+1)
                        {
                            guys[j].Collect(i+1);
                        }
                        else
                        {
                            guys[j].Collect(0);
                        }

                        guys[j].UpdateLabels();
                        
                    }
                }

                //grey[i].TakeStartingPosition();
            }
           
        }

    }
}

