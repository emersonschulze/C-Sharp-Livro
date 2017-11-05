using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6
{
    class Party
    {
        public int numberOfPeople;
        public decimal costOfDecorations = 0;
        public const int CostOfFoodPerPerson = 25;
        public bool FancyDecorarions;


        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorarions = fancyDecorations;
        }

        public int NumberOfPeople
        {
            get
            {
                return numberOfPeople;
            }

            set
            {
                numberOfPeople = value;
                CalculateCostOfDecoration(true);
            }
        }

        public void CalculateCostOfDecoration(bool opt)
        {
            if (opt)
            {
                costOfDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            return 2M;
        }
    }
}
