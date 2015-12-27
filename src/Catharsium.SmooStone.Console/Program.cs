using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.GameState.Entities.Classic.Neutral;

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