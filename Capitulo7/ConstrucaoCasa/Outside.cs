using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrucaoCasa
{
    class Outside : Location
    {
        private bool hot;

        public bool Hot
        {
            get
            {
                return hot;
            }

        }

        public Outside(string name) : base(name)
        {
            hot = true;
        }

        public override string Description
        {
            get
            {
                string desc = "";
                if (Hot && !(Name == "back yard" || Name == "front yard"))
                {
                    desc = base.Description+"\nEstá muito quente aqui!";
                    
                }
                else
                {
                    return base.Description;
                }
                return desc;
            }
            
        }


    }
}
