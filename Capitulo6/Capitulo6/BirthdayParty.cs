using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo6
{
    class BirthdayParty : Party
    {
      
        public int cakeSize;
        public int cakeWriting;
        
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) : base (numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            base.CalculateCostOfDecoration(fancyDecorations);
        }

        public void CalculateCakeSize()
        {
            if(NumberOfPeople <= 4)
            {
                cakeSize = 8;
            }
            else
            {
                cakeSize = 16;
            }

        }

        public override decimal CalculateCost()
        {

            if (numberOfPeople < 4)
            {
                cakeSize = 20;
                if (cakeWriting <= 16)
                {
                    return 0.25M * cakeWriting + 40M + costOfDecorations;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Mensagem muito grande!");
                }

            }
            else
            {
                cakeSize = 40;
                if (cakeWriting <= 40)
                {
                    return 0.25M * cakeWriting + 75M + costOfDecorations;
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
