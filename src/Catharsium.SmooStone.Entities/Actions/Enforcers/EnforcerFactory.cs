using System;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Result;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers
{
    public class EnforcerFactory : IEnforcerFactory
    {
        #region Properties

        protected IEnforcerResultFactory EnforcerResultFactory { get; set; }

        #endregion

        #region Construction

        public EnforcerFactory(IEnforcerResultFactory enforcerResultFactory)
        {
            EnforcerResultFactory = enforcerResultFactory;
        }

        #endregion

        #region IEnforcerFactory

        public IEnforcer CreateEnforcer(EnforcerType type)
        {
            switch (type)
            {
                case EnforcerType.ChangeAttack:
                    return new ChangeAttackEnforcer(EnforcerResultFactory);
                case EnforcerType.Damage:
                    return new DamageEnforcer(EnforcerResultFactory);
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }


        public IRequest CreateRequest(EnforcerType type)
        {
            switch (type)
            {
                case EnforcerType.ChangeAttack:
                    return new ChangeAttackRequest();
                case EnforcerType.Damage:
                    return new DamageRequest();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        #endregion
    }
}