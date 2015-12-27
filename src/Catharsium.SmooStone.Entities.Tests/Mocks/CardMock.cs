using Catharsium.SmooStone.Entities.GameState.Entities.Base;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
{
    public class CardMock : Card
    {
        #region Card
        
        public override string BaseDescription => "This is a basic card";


        public override int BaseCost { get; } = 1;

        #endregion
    }
}