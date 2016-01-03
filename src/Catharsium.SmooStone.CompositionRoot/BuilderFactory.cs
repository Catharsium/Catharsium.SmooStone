using Catharsium.SmooStone.CompositionRoot.Builders;

namespace Catharsium.SmooStone.CompositionRoot
{
    public class BuilderFactory : IBuilderFactory
    {
        public IBuilder CreateBuilder()
        {
            return new AutoFacBuilder();
        }
    }
}