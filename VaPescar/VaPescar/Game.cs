using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VaPescar
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Card.Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, string[] opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));
            books = new Dictionary<Card.Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        public void Deal()
        {
            //Será aqui o método a partir do qual o jogo começa  - ele será chamado apenas no
            //inicio do jogo. Ele embaralha o monte, dá cinco cartas para cada jogador e
            //usa um laço foreach para chamar o metodo  pullOutBook() de cada um.   
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
                foreach (Player player in players)
                    player.TakeCard(stock.Deal());
            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
                
            
        }

        public bool PlayOneRound(int selectedCard)
        {
            /*
            Execute um turno do jogo. O parâmetro será a carta que o jogador selecionou     
            na sua mão  - recupera seu valor. Então itere por todos os jogadores e chame o 
            método AskForCard() de cada um, começando pelo jogador humano (que deve estar
            no indice zero da lista de jogadores.Certifique-se  de que ele pergunte pelo valor)
            da carta que selecionou). Então chame pullOutBooks() - se ele retornar true,
            o jogador ficou sem cartas e precisa comprar uma nova mão. Depois que todos 
            jogaram, ordene a mão do jogador humano (para que ela apareça bem arrumada no formulário)
            verifique se o monte ainta tem cartas. Se não tem, apague o texto na caixa e escreva "O monte esta sem
            cartas. O jogo acabou!" e retorne true.Se não for o caso, o jogo ainda n cabaou, logo retorne false.
            */

            Card.Values cardToAskFor = players[0].Peek(selectedCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForACard(players, i, stock);
                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name + " drew  a new hand\r\n";
                    int card = 1;
                    while(card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if(stock.Count == 0)
                {
                    textBoxOnForm.Text = "The stock is out of cards. Game over!\r\n";
                    return true;
                }

            }

            return false;
        }

        public bool PullOutBooks(Player player)
        {
            /*
            Monte um livro para um jogador. Retorne true se o jogador ficar sem cartas
            Se não for o caso, retone false. Cada livro deve ser adicionado ao dicionário Books
            Um jogador fica sem carta quando usar todas as suas  restantes para  montar um livro e assim tentar ganhar o jogo
            */
            List<Card.Values> BooksPulled = player.PullOutBooks();
            foreach (Card.Values value in BooksPulled)
                books.Add(value, player);
            if (player.CardCount == 0)
                return true;
            return false;
        }

        public string DescribeBooks()
        {
            /*Retorne uma longa string que descreve os livros de todos, composta 
             examinando o dicionário books. "João tem um livro seis (quebra de linha). 
             Edu tem um livro da Ases"
            */

            string whoHasWichBooks = "";
            foreach (Card.Values  value in books.Keys)
            {
                whoHasWichBooks += books[value].Name + " has book of " + Card.Plural(value)+"\r\n";
            }
            return whoHasWichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary <string, int>();
            foreach (Card.Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                {
                    winners[name]++;
                }
                else
                {
                    winners.Add(name, 1);
                }
            }

            int mostBooks = 0;
            foreach (string name in winners.Keys)
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            bool tie = false;
            string winnerList = "";
            foreach (string name in winners.Keys)
            {
                if(winners[name] == mostBooks)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            }

            winnerList += " with " + mostBooks + " books";
            if (tie)
                return "A tie between " + winnerList;
            else
                return winnerList;
            
        }

        public string[] GetPLayerCards()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string description = "";
            for(int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if(players[i].CardCount == 1)
                {
                    description += "card.\r\n";
                }
                else
                {
                    description += "cards. \r\n";
                }
            }
            description += "The stock has "+stock.Count+" cards left";
            return description;
        }
    }
}
