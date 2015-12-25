using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.Cards.Base;
using Catharsium.SmooStone.Entities.Cards.Classic;
using Catharsium.SmooStone.Entities.Decks;

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