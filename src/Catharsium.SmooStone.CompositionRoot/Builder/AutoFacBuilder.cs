using Autofac;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Decks;

namespace Catharsium.SmooStone.CompositionRoot.Builder
{
    public class AutoFacBuilder
    {
        public IContainer BuildUnityContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Deck>().As<IDeck>();
            builder.RegisterType<LogFactory>().As<ILogFactory>();

            return builder.Build();
        }
    }
}