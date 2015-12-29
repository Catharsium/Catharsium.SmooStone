using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public interface IEnforcerFactory
    {
        IEnforcer CreateEnforcer(EnforcerType type);

        IRequest CreateRequest(EnforcerType type);
    }
}