using Autofac;
using Catharsium.SmooStone.Entities.GameState.Decks;

namespace Catharsium.SmooStone.CompositionRoot.Builder
{
    public class AutoFacBuilder
    {
        public IContainer BuildUnityContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Deck>().As<IDeck>();

            return builder.Build();
        }
    }
}