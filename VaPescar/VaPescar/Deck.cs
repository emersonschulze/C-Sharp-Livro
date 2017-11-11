using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaPescar
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < cards.Count; suit++)
            {
                for(int value = 0; value < cards.Count; value++)
                {
                    cards.Add(new Card((Card.Suits)suit, (Card.Values)value));
                }
            }
        }

        public Deck(Card[] initialCard)
        {
            cards = new List<Card>(initialCard);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while(cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = NewCards;
        }

        public string[] GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for(int i = 0; i < cards.Count; i++)
                CardNames[i] = cards[i].Name;
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardCompare_byValue());
        }

        //Permite dar uma espiada na carta do baralho sem ter que pegá-la
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        //Sobrecarga do método Deal
        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Card.Values values)
        {
            foreach (Card card in cards)
                if (card.Value == values)
                    return true;
            return false;
             
        }


        //Quando um livro for gerado este método irá tirar as cartas referentes
        //a ele do baralho antigo e retornar um baralho novo
        public Deck Pullout(Card.Values values)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count; i >= 0; i--)
                if (cards[i].Value == values)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
        }

        //Este método checa um baralho para ver se ele um livro de quatro 
        //cartas de qualquer valor que seja passado como parâmetro
        public bool HasBook(Card.Values values)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Value == values)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
        
        public void SortByValue()
        {
            cards.Sort(new CardCompare_byValue());
        }

    }
}
