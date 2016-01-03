using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.GameState.Entities.Classic.Neutral;
using Catharsium.SmooStone.CompositionRoot.Builders;

namespace Catharsium.SmooStone.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new CompositionBuilderFactory().CreateBuilder().Build();
            using (var scope = container.BeginScope())
            {
                var deck = container.Resolve<IDeck>();

                var card = new AbusiveSergeant();
                deck.Fill(new ICard[] {card});

                var logFactory = container.Resolve<ILogFactory>();
                logFactory.ConsoleLog.Info(deck, null);
                System.Console.ReadLine();
            }
        }
    }
}