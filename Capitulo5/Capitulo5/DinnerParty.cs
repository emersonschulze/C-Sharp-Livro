using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo5
{
    class DinnerParty
    {

        private int numberOfPeople;
        public decimal CostOfBeveragesPerPerson, CostOfDecorations = 0;
        public bool HealthyOption;
        private bool FancyDecorarions;
        public const int CostOfFoodPerPerson = 25;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecorarions = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecoration(fancyDecorations);
            
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
        /*
        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecoration(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }
        */

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

        public void CalculateCostOfDecoration(bool opt)
        {
            if (opt)
            {
                CostOfDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
        }

        public decimal CalculateCost(bool HealthyOption)
        {
            decimal cost = CostOfDecorations + ((CostOfFoodPerPerson + CostOfBeveragesPerPerson) * NumberOfPeople);

            if (HealthyOption)
            {
                
                return cost * 0.95M; 
            }

            return cost;
        }


    }
}
