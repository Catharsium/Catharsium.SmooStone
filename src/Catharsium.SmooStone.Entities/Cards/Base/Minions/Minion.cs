using Catharsium.SmooStone.Entities.Affixes;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Cards.Base.Minions
{
    public abstract class Minion : Card, IMinion
    {
        public abstract int BaseAttack { get; }

        public abstract int CurrentAttack { get; set; }

        public abstract int BaseHealth { get; }
                
        public abstract int CurrentHealth { get; set; }


        private IEnumerable<IAffix> _affixes;
        public virtual IEnumerable<IAffix> Affixes
        {
            get
            {
                if(_affixes == null)
                {
                    _affixes = new List<IAffix>();
                }
                return _affixes;
            }

            set { _affixes = value; }
        }
    }
}