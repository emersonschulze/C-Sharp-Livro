using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas
{
    class GreyHound
    {
        public int startingPosition;
        public int raceTrackLength = 500;
        public PictureBox myPictureBox;
        public int location = 0;
        public Random myRandom;
        
        public bool Run()
        {
            /*
            Mova-se para frente 1, 2, 3 ou 4 espaços aleatórios 
            Atualize a posição da minha caixa de imagem no formulário
            Retorna true se eu ganhei a corrida
            */
            myRandom = new Random();

            //Gera um valor aleatório
            int valor = myRandom.Next(3);

            //Pega a posição inicial da imagem
            Point p = myPictureBox.Location;

            //Passa o valor de p.X para a posição inicial 
            startingPosition = p.X;

            //Avança o valor aleatório vezes 100
            p.X += valor*100;
            myPictureBox.Location = p;

            //Se a posição for maior que 500 significa que ganhou a corrida e retorna true
            if(p.X >= 500)
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            Point p = myPictureBox.Location;
            p.X = startingPosition;
            myPictureBox.Location = p;
        }


    }
}
