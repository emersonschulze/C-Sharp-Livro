using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmDiaDeCorridas
{
    class Bet
    {
        public int amount; //A quantidade de dinheiro que foi apostada
        public int dog; //O número do cão que apostamos
        public Guy bettor; //O cara que fez a posta

        public string GetDescrition()
        {
            /*
             Retorna uma sequência de caracteres que diz quem fez a aposta, quanto
             dinheiro foi apostado e em qual cão ("João apostou 8 no cão 4").
             Se a quantidade for zero, a aposta não foi feita("João não apostou")
            */
            if(amount <= 0)
            {
                return bettor.name + " não apostou";
            }
            else
            {
                return bettor.name + " apostou " + amount + " no cão " + dog;
            }

            
        }

        public int PlayOut(int Winner)
        {

            /*
            O parametro deve receber o vencedor da corrida. Se o cao venceu, retorna
            a quantidade apostada. De outra forma, retorne um valor negativo 
            correspondente ao valor apostado
            */
            if (Winner == this.dog)
            {
                return amount;
            }
            else
            {
                return -amount;
            }
            
        }
    }
}
