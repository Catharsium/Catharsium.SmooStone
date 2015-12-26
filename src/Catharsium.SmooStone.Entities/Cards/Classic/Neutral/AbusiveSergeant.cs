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
        
        #endregion

        #region IBattlecryMinion

        public void Battlecry()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}