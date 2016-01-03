using Autofac;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;
using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;
using Catharsium.SmooStone.Entities.GameState.Game;
using Catharsium.SmooStone.Entities.GameState.Hands;
using Catharsium.SmooStone.Entities.Orchestrator;

namespace Catharsium.SmooStone.CompositionRoot.Builder
{
    public class AutoFacBuilder
    {
        public IContainer BuildAutoFacContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterInstance(new LogFactory()).As<ILogFactory>();

            builder.RegisterType<GameState>().As<IGameState>();
            builder.RegisterType<Board>().As<IBoard>();
            builder.RegisterType<Player>().As<IPlayer>();
            builder.RegisterType<Deck>().As<IDeck>();
            builder.RegisterType<Hand>().As<IHand>();

            builder.RegisterType<Orchestrator>().As<IOrchestrator>();

            builder.RegisterType<EnforcerResultFactory>().As<IEnforcerResultFactory>();
            
            return builder.Build();
        }
    }
}