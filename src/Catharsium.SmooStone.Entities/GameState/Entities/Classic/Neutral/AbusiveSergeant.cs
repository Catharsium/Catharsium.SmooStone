using System;
using Catharsium.SmooStone.Entities.Actions.Enforcers;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Classic.Neutral
{
    public class AbusiveSergeant : Minion, IBattlecryMinion
    {
        #region MinionCard

        public override string Name => "Abusive Sergeant";

        public override string BaseDescription => "Battlecry: Give a minion +2 Attack this turn.";
        
        public override int BaseCost { get; } = 1;

        public override int BaseAttack { get; } = 2;

        public override int BaseHealth { get; } = 1;
        
        #endregion

        #region IBattlecryMinion

        public IEnforcer Battlecry()
        {
            // TODO
            throw new NotImplementedException();
        }

        #endregion
    }
}