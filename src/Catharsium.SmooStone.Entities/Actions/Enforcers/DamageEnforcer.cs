﻿using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public class DamageEnforcer : Enforcer
    {
        #region Construction

        public DamageEnforcer(IEnforcerResultFactory resultFactory) : base(resultFactory)
        {
        }

        #endregion

        #region IEnforcer

        public override IEnforcerResult Execute(IRequest request)
        {
            var damageRequest = request as IDamageRequest;
            if (damageRequest == null)
            {
                return ResultFactory.Failure("Request is null");
            }
            if (damageRequest.Targets == null)
            {
                return ResultFactory.Failure("Request.Targets is null");
            }
            
            foreach (var target in damageRequest.Targets)
            {
                target.CurrentHealth -= damageRequest.Damage;
            }

            return ResultFactory.Succes(string.Empty);
        }

        #endregion
    }
}