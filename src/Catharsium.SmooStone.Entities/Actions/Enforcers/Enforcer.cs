using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public abstract class Enforcer : IEnforcer
    {
        #region Properties

        public IEnforcerResultFactory ResultFactory { get; set; }

        #endregion

        #region Construction

        protected Enforcer(IEnforcerResultFactory resultFactory)
        {
            ResultFactory = resultFactory;
        }

        #endregion

        #region IEnforcer

        public abstract IEnforcerResult Execute(IRequest request);

        #endregion
    }
}