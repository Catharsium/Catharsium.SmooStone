using System;

namespace Catharsium.SmooStone.CompositionRoot.Builders
{
    public interface ICompositionContainer
    {
        IDisposable BeginScope();

        TComponent Resolve<TComponent>();
    }
}