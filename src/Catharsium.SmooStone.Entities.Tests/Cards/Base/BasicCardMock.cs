using Catharsium.SmooStone.Entities.Cards.Base;

namespace Catharsium.SmooStone.Entities.Tests.Cards.Base
{
    public class BasicCardMock : Card
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