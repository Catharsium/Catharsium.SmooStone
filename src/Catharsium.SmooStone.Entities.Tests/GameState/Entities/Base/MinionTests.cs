﻿using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Affixes;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.Tests.Mocks;
using Xunit;

namespace Catharsium.SmooStone.Entities.Tests.GameState.Entities.Base
{
    public class MinionTests
    {
        #region Fixture

        protected readonly IMinion SUT;


        public MinionTests()
        {
            SUT = new MinionMock();
        }

        #endregion


        [Fact]
        public void CurrentAttack_ReturnsBaseAttack()
        {
            var actual = SUT.CurrentAttack;
            Assert.Equal(SUT.BaseAttack, actual);
        }


        [Fact]
        public void CurrentHealth_ReturnsBaseHealth()
        {
            var actual = SUT.CurrentHealth;
            Assert.Equal(SUT.BaseHealth, actual);
        }


        [Fact]
        public void Affixes_ReturnsInputAffixes()
        {
            var affixes = new List<Affix>
            {
                new AffixMock()
            };
            SUT.Affixes = affixes;
            var actual = SUT.Affixes;
            Assert.Equal(affixes, actual);
        }
    }
}