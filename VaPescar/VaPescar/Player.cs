using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaPescar
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public string[] GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }


        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += ""+name+" has just joined the game...\r\n";
        }

        public List<Card.Values> PullOutBooks()
        {
            List<Card.Values> Book = new List<Card.Values>();
            for(int i = 1; i<=13; i++)
            {
                Card.Values values = (Card.Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == values)
                        howMany++;
                if(howMany == 4)
                {
                    Book.Add(values);
                    for (int card = cards.Count - 1; card >= 0; card--)
                        cards.Deal(card);
                }
            }
            return Book;

        }

        public Card.Values GetRandomValue()
        {
            //Este método retorna um valor aleatório que ainda exista no baralho
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        public Deck DoYouHaveAny(Card.Values values)
        {
            //Neste método  um oponente pergunta se o jogador tem cartas de um certo valor
            //usando deck.pulloutvalues() para retirar os valores. Adicione uma linha na 
            //caixa de texto que dis "João tem 3 seis" - use o novo método estatico card.plural

            Deck cardsIHave = cards.Pullout(values);
            textBoxOnForm.Text += Name + " has " + cardsIHave.Count + " " + Card.Plural(values) + "\r\n";
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            //Aqui temos uma versão sobrecarregada de ask for a card  - escolha um valor
            //aleatório do baralho usando GetRandomValue() e pergunte por ele usando AskForACard()

            Card.Values radomValue = GetRandomValue();
            AskForACard(players, myIndex, stock, radomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Card.Values values)
        {
            /*
            Pergunta para outros jogadores se eles tem um dado valor. Primeiro adicione 
            uma linha na caixa de texto que diz "João pergunta se alguém tem alguma rainha", por exemplo.
            Então itere epla lista de jogadores passada como parametros e para  cada
            um deles pergunte se ele tem o valor (usando o método DoYouHaveAny);
            Ele deve passar  a você o baralho  - adicione este ao seu.Mantenha registro de
            quantas cartas foram adicionadas, Se forem zero, teremos que pegar uma do monte
            (que também foi passada como parametro), e nesse caso uma linha "João tem  que pegar uma carta da pilha"
            deve ser adicionada
            */

            textBoxOnForm.Text += name + " asks if anyone has a "+values+"\r\n";
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if(i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(values);
                    totalCardsGiven += cardsGiven.Count;
                    while(cardsGiven.Count > 0)
                    {
                        cards.Add(cardsGiven.Deal());
                    }
                }

            }

            if(totalCardsGiven == 0)
            {
                textBoxOnForm.Text += name + " musta draw from the stock.\r\n";
                cards.Add(stock.Deal());

            }
        }

    }
}
