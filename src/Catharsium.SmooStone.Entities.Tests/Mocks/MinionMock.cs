using System;
using Catharsium.SmooStone.Entities.Cards.Base.Minions;

namespace Catharsium.SmooStone.Entities.Tests.Cards
{
    public class MinionMock : Minion
    {
        #region Minion

        public override string BaseDescription
        {
            get { return "This is a basic card"; }
        }


        public override int BaseCost { get; } = 1;

        public override int BaseAttack { get; } = 2;

        public override int BaseHealth { get; } = 3;

        #endregion
    }
}