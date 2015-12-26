using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;
using Catharsium.SmooStone.Entities.GameState.Cards.Classic.Neutral;
using Catharsium.SmooStone.Entities.GameState.Decks;

namespace Catharsium.SmooStone.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var deck = new Deck();

            var card = new AbusiveSergeant();
            deck.Fill(new ICard[] { card});

            new LogFactory().GetConsoleLog().Info(deck);
            System.Console.ReadLine();
        }
    }
}