using Catharsium.SmooStone.CompositionRoot.Containers;

namespace Catharsium.SmooStone.CompositionRoot.Builders
{
    public interface IBuilder
    {
        ICompositionContainer Build();
    }
}