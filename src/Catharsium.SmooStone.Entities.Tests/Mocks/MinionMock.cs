using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
{
    public class MinionMock : Minion
    {
        #region Minion

        public override string BaseDescription => "This is a basic card";
        
        public override int BaseCost { get; } = 1;

        public override int BaseAttack { get; } = 2;

        public override int BaseHealth { get; } = 3;

        #endregion
    }
}