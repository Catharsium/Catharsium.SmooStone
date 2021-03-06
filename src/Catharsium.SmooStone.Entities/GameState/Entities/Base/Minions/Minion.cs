﻿using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Affixes;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions
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
            get { return _affixes ?? (_affixes = new List<IAffix>()); }
            set { _affixes = value; }
        }
    }
}