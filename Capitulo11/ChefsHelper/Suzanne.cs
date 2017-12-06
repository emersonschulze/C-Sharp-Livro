using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsHelper
{
    class Suzanne
    {
        //A variável de referencia é criada
        public GetSecretIngredient MySecretIngredientMethod {
            //Esta propriedade é apenas leitura com um retorno 'GetSecretIngredient'
            get
            {
                //Dentro deste tipo, basta adicionar um mátodo que tenha a mesma 
                //que o delagate utilizado.
                return new GetSecretIngredient(SuzanneSecretIngredient);
            }
        }

        //Este método tem a assinatura equivalente ao delegate
        private string SuzanneSecretIngredient(int amount)
        {
            return amount.ToString()+" ounces of cloves";
        }

    }
}
