using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3
{
    class Guy
    {
        public string nome;
        public int dinheiro;
        
        public int darDinheiro(int qtd)
        {
            if(qtd <= dinheiro && qtd > 0)
            {
                dinheiro -= qtd;
                return qtd;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Eu não tenho dinheiro o suficiente para te dar! "+nome+"\nQuantidade: "+qtd);
                return 0;
            }
        }

        public int receberDinheiro(int qtd)
        {
            if(qtd > 0)
            {
                dinheiro += qtd;
                return qtd;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Essa quantidade eu não posso receber! "+nome);
                return 0;
            }
        }

    }
}
