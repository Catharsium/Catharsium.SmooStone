using Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells;
using Catharsium.SmooStone.Entities.Tests.Mocks;
using Xunit;

namespace Catharsium.SmooStone.Entities.Tests.GameState.Entities.Base
{
    public class SpellTests
    {
        #region Fixture

        protected Spell SUT;


        public SpellTests()
        {
            SUT = new SpellMock();
        }

        #endregion

        [Fact]
        public void Name_ReturnsTypeName()
        {
            var expected = SUT.GetType().Name;
            var actual = SUT.Name;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CurrentDescription_WithoutSetting_ReturnsBaseDescription()
        {
            var expected = SUT.BaseDescription;
            var actual = SUT.CurrentDescription;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CurrentDescription_SetToValue_ReturnsValue()
        {
            var expected = "A different description";
            SUT.CurrentDescription = expected;
            var actual = SUT.CurrentDescription;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CurrentCost_WithoutSetting_ReturnsBaseCost()
        {
            var expected = SUT.BaseCost;
            var actual = SUT.CurrentCost;
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CurrentCost_SetToValue_ReturnsValue()
        {
            var expected = int.MaxValue;
            SUT.CurrentCost = expected;
            var actual = SUT.CurrentCost;
            Assert.Equal(expected, actual);
        }
    }
}