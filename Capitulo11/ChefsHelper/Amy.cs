using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsHelper
{
    class Amy
    {
        public GetSecretIngredient AmySecretIngerdientMethod
        {
            get
            {
                return new GetSecretIngredient(AmySecretIngredient);
            }
        }

        private string AmySecretIngredient(int amount)
        {
            if(amount < 10)
            {
                return amount.ToString()+" cans of sardines -- you need more!";
            }
            else
            {
                return amount.ToString()+"cans of sardines";
            }
        }
    }
}
