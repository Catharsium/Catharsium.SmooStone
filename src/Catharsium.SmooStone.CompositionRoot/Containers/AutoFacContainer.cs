using Autofac;
using System;

namespace Catharsium.SmooStone.CompositionRoot.Containers
{
    public class AutoFacContainer : ICompositionContainer
    {
        #region Properties

        protected IContainer Container { get; set; }

        protected ILifetimeScope Scope { get; set; }

        #endregion

        #region Construction

        public AutoFacContainer(IContainer container)
        {
            Container = container;
        }

        #endregion

        #region ICompositionContainer<ILifetimeScope>

        public IDisposable BeginScope()
        {
            return Scope = Container.BeginLifetimeScope();
        }


        public TComponent Resolve<TComponent>()
        {
            return Scope.Resolve<TComponent>();
        }

        #endregion
    }
}