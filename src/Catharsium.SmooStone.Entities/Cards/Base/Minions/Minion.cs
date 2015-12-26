using Catharsium.SmooStone.Entities.Affixes;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Cards.Base.Minions
{
    public abstract class Minion : Card, IMinion
    {
        public abstract int BaseAttack { get; }
        
                
        private int? _currentAttack;
        public virtual int CurrentAttack
        {
            get
            {
                if (!_currentAttack.HasValue)
                {
                    _currentAttack = BaseAttack;
                }
                return _currentAttack.Value;
            }
            set { if (value >= 0) _currentAttack = value; }
        }

        
        public abstract int BaseHealth { get; }


        private int? _currentHealth;
        public virtual int CurrentHealth
        {
            get
            {
                if (!_currentHealth.HasValue)
                {
                    _currentHealth = BaseHealth;
                }
                return _currentHealth.Value;
            }
            set { if (value >= 0) _currentHealth = value; }
        }
        

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