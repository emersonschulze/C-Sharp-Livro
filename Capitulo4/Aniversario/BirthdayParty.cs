using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversario
{
    class BirthdayParty
    {
        public int numberOfPeople;
        public double costOfDecorations;
        public int cakeSize;
        public int cakeWriting;

        public void CalculateCostOfDecorations(string opcao)
        {
            if(opcao == "normal")
            {
                costOfDecorations = numberOfPeople * 7.5 + 30;
            }

            if(opcao == "chique")
            {
                costOfDecorations = numberOfPeople * 15 + 50;
            }

        }
        
        public double CalculateCost()
        {
            
            if(numberOfPeople < 4)
            {
                cakeSize = 20;
                if(cakeWriting <= 16)
                {
                    return 0.25 * cakeWriting + 40 + costOfDecorations;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Mensagem muito grande!");
                }
                
            }
            else
            {
                cakeSize = 40;
                if(cakeWriting <= 40)
                {
                    return 0.25 * cakeWriting + 75 + costOfDecorations;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Mensagem muito grande!");
                }
                
            }

            return 0;
        }
    }
}
