using Catharsium.SmooStone.Entities.GameState.Hands;
using Catharsium.SmooStone.Entities.Tests.Mocks;
using Xunit;

namespace Catharsium.SmooStone.Entities.Tests.GameState.Hands
{
    public class HandTests
    {
        #region Fixture

        readonly Hand SUT;

        static readonly int MaximumCards = 3;


        public HandTests()
        {
            SUT = new Hand(MaximumCards);
        }

        #endregion

        [Fact]
        public void AddCard_ToEmptyHand_ReturnsTrue()
        {
            var result = SUT.AddCard(new CardMock());
            Assert.True(result);
        }


        [Fact]
        public void AddCard_ToFullHand_ReturnsFalls()
        {
            bool result;
            for(int i = 0; i < MaximumCards; i++)
            {
                result = SUT.AddCard(new CardMock());
                Assert.True(result);
            }

            result = SUT.AddCard(new CardMock());
            Assert.False(result);
        }
    }
}