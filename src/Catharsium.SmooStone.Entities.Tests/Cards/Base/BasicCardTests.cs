﻿using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.Tests.Mocks;
using Xunit;

namespace Catharsium.SmooStone.Entities.Tests.Cards.Base
{
    public class BasicCardTests
    {
        #region Fixture

        protected readonly ICard SUT;


        public BasicCardTests()
        {
            SUT = new CardMock();
        }

        #endregion


        [Fact]
        public void Name_ReturnsTypeName()
        {
            var actual = SUT.Name;
            Assert.Equal(SUT.GetType().Name, actual);
        }


        [Fact]
        public void CurrentDescription_ReturnsBaseDescription()
        {
            var actual = SUT.CurrentDescription;
            Assert.Equal(SUT.BaseDescription, actual);
        }


        [Fact]
        public void BaseCost_ReturnsDefaultValue()
        {
            var actual = SUT.BaseCost;
            Assert.Equal(1, actual);
        }


        [Fact]
        public void CurrentCost_ReturnsBaseCost()
        {
            var actual = SUT.CurrentCost;
            Assert.Equal(SUT.BaseCost, actual);
        }
    }
}