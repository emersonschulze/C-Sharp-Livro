using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo6
{
    class DinnerParty : Party
    {
        
        public decimal CostOfBeveragesPerPerson;
        public bool HealthyOption;
        

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption) : base (numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            base.CalculateCostOfDecoration(fancyDecorations);

        }
        
        public void SetHealthyOption(bool opt)
        {
            if (opt)
            {
                CostOfBeveragesPerPerson = 5M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20M;
            }
        }
        
        public override decimal CalculateCost()
        {
            decimal cost = base.costOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople);

            if (HealthyOption)
            {

                return cost * 0.95M;
            }

            return cost;
        }
    }
}
