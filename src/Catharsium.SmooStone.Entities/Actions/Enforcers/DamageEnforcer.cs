using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;
using Catharsium.SmooStone.Entities.GameState.Cards.Base.Minions;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public class DamageEnforcer : IEnforcer
    {
        #region Properties

        public IEnforcerResultFactory ResultFactory { get; set; }

        #endregion

        #region Construction

        public DamageEnforcer(IEnforcerResultFactory resultFactory)
        {
            ResultFactory = resultFactory;
        }

        #endregion

        #region IEnforcer

        public IEnforcerResult Execute(IRequest request)
        {
            var damageRequest = request as IDamageRequest;
            if (damageRequest == null)
            {
                return ResultFactory.Failure("Request is null");
            }

            // TODO get targets
            var targets = new List<IMinion>();
            foreach (var target in targets)
            {
                target.CurrentHealth -= damageRequest.Damage;
            }

            return ResultFactory.Succes(string.Empty);
        }

        #endregion
    }
}