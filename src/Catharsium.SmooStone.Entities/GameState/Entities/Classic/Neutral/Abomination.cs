using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.GameState.Affixes;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Classic.Neutral
{
    public class Abomination : Minion, IDeathrattleMinion
    {
        #region MinionCard
        
        public override string BaseDescription => "Taunt. Deathrattle: Deal 2 damage to ALL characters.";

        public override int BaseCost { get; } = 5;

        public override int BaseAttack { get; } = 4;

        public override int BaseHealth { get; } = 4;


        public override IEnumerable<IAffix> Affixes
        {
            get
            {
                return new IAffix[]
                {
                    new TauntAffix()
                };
            }
            set { base.Affixes = value; }
        }

        #endregion

        #region IDeathrattleMinion

        public IRequest Deathrattle(IEnumerable<IMinion> targets)
        {
            var result = new RequestFactory<DamageRequest>().Create();
            result.Targets = targets;
            result.Damage = 2;
            return result;
        }

        #endregion
    }
}