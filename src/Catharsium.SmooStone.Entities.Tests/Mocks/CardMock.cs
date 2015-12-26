using Catharsium.SmooStone.Entities.GameState.Cards.Base;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
{
    public class CardMock : Card
    {
        #region Card
        
        public override string BaseDescription
        {
            get { return "This is a basic card"; }
        }


        public override int BaseCost { get; } = 1;

        #endregion
    }
}