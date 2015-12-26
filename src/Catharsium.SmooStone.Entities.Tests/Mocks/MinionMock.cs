using Catharsium.SmooStone.Entities.GameState.Cards.Base.Minions;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
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