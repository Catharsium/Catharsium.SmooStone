using Autofac;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.CompositionRoot.Containers;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;
using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;
using Catharsium.SmooStone.Entities.GameState.Game;
using Catharsium.SmooStone.Entities.GameState.Hands;
using Catharsium.SmooStone.Entities.Orchestrator;

namespace Catharsium.SmooStone.CompositionRoot.Builders
{
    public class AutoFacBuilder : IBuilder
    {
        protected ContainerBuilder ContainerBuilder { get; } = new ContainerBuilder();


        public ICompositionContainer Build()
        {
            ContainerBuilder.RegisterInstance(new LogFactory()).As<ILogFactory>();

            ContainerBuilder.RegisterType<GameState>().As<IGameState>();
            ContainerBuilder.RegisterType<Board>().As<IBoard>();
            ContainerBuilder.RegisterType<Player>().As<IPlayer>();
            ContainerBuilder.RegisterType<Deck>().As<IDeck>();
            ContainerBuilder.RegisterType<Hand>().As<IHand>();

            ContainerBuilder.RegisterType<Orchestrator>().As<IOrchestrator>();

            ContainerBuilder.RegisterType<EnforcerResultFactory>().As<IEnforcerResultFactory>();

            return new AutoFacContainer(ContainerBuilder.Build());
        }
    }
}