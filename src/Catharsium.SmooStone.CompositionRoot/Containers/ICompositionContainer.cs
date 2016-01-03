using System;

namespace Catharsium.SmooStone.CompositionRoot.Containers
{
    public interface ICompositionContainer
    {
        IDisposable BeginScope();

        TComponent Resolve<TComponent>();
    }
}