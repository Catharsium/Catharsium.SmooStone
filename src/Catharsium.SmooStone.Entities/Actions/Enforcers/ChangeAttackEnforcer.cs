using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public class ChangeAttackEnforcer : Enforcer
    {
        #region Construction

        public ChangeAttackEnforcer(IEnforcerResultFactory resultFactory) : base(resultFactory)
        {
        }

        #endregion


        #region IEnforcer

        public override IEnforcerResult Execute(IRequest request)
        {
            var changeAttackRequest = request as IChangeAttackRequest;
            if (changeAttackRequest == null)
            {
                return ResultFactory.Failure("Request is null");
            }
            if (changeAttackRequest.Targets == null)
            {
                return ResultFactory.Failure("Request.Targets is null");
            }

            foreach (var target in changeAttackRequest.Targets)
            {
                target.CurrentAttack = changeAttackRequest.Attack;
            }

            return ResultFactory.Succes(string.Empty);
        }

        #endregion
    }
}