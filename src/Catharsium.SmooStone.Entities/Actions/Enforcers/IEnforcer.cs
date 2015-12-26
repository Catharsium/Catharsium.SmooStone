using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public interface IEnforcer
    {
        IEnforcerResult Execute(IRequest request);
    }
}