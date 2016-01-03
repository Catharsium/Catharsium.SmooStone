using Catharsium.SmooStone.CompositionRoot.Builders;

namespace Catharsium.SmooStone.CompositionRoot
{
    public interface ICompositionBuilderFactory
    {
        ICompositionBuilder CreateBuilder();
    }
}