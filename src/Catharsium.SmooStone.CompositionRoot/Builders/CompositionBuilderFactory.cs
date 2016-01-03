using Catharsium.SmooStone.CompositionRoot.Containers.AutoFac;

namespace Catharsium.SmooStone.CompositionRoot.Builders
{
    public class CompositionBuilderFactory : ICompositionBuilderFactory
    {
        public ICompositionBuilder CreateBuilder()
        {
            return new AutoFacBuilder();
        }
    }
}