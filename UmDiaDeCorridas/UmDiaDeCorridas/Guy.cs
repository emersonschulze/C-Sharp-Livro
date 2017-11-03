using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UmDiaDeCorridas
{
    class Guy
    {
        public string name;
        public Bet MyBet; // Uma instancia de bet que mantem as apostas
        public int cash; //Quanto dinheiro resta
        //Os últimos dois campos são os controles dos formulários
        public RadioButton myRadioButton;
        public Label myLabel;

        public void UpdateLabels()
        {
            myLabel.Text = name + " tem R$ " + cash + ",00 ";
        }

        public void ClearBet()
        {
            //Reinicia  minha aposta para que ela zere
            this.MyBet = null;

        }

        public bool PlaceBet(int amout, int Dog)
        {
            /*
             Crie uma nova aposta e armazene-a no emu campo Bet
             Retorne verdadeiro se o cara tem dinheiro  suficiente para apostar
             */
             if(amout <= cash)
            {
                MyBet.amount = amout;
                MyBet.dog = Dog;
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void Collect(int Winner)
        {
            /*
            Cobre minha aposta se eu ganhei
            A chave aqui é usar o objeto Bet... deixe que ele faça o trabalho
            */
            cash += MyBet.PlayOut(Winner);
            
        }

    }
}
