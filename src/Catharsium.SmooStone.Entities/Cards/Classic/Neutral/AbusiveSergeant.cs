using Catharsium.SmooStone.Entities.Cards.Base.Minions;
using System;

namespace Catharsium.SmooStone.Entities.Cards.Classic.Neutral
{
    public class AbusiveSergeant : Minion, IBattlecryMinion
    {
        #region MinionCard

        public override string Name
        {
            get { return "Abusive Sergeant"; }
        }


        public override string BaseDescription
        {
            get { return "Battlecry: Give a minion +2 Attack this turn."; }
        }


        public override int BaseCost { get; } = 1;

        public override int BaseAttack { get; } = 2;

        public override int BaseHealth { get; } = 1;


        private int? _currentAttack;
        public override int CurrentAttack
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


        private int? _currentCost;
        public override int CurrentCost
        {
            get
            {
                if(!_currentCost.HasValue)
                {
                    _currentCost = BaseCost;
                }
                return _currentCost.Value;
            }
            set { if (value >= 0) _currentCost = value; }
        }


        private int? _currentHealth;
        public override int CurrentHealth
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
        
        #endregion

        #region IBattlecryMinion

        public void Battlecry()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}