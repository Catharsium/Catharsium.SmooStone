using Autofac;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.CompositionRoot.Builder;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.GameState.Entities.Classic.Neutral;

namespace Catharsium.SmooStone.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = new AutoFacBuilder().BuildUnityContainer();
            using (var scope = container.BeginLifetimeScope())
            {
                var deck = scope.Resolve<IDeck>();

                var card = new AbusiveSergeant();
                deck.Fill(new ICard[] {card});

                new LogFactory().GetConsoleLog().Info(deck, null);
                System.Console.ReadLine();
            }
        }
    }
}