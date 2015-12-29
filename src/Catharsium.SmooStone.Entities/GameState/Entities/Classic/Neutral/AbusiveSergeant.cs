using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
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

        public IRequest Battlecry(IEnumerable<IMinion> targets)
        {
            var result = new RequestFactory<ChangeAttackRequest>().Create();
            result.Targets = targets;
            result.Attack = 2;
            result.Permanent = false;
                
            return result;
        }

        #endregion
    }
}