using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
{
    public class SpellMock : Spell
    {
        public override string BaseDescription { get; } = "This is a spell";

        public override int BaseCost { get; } = 1;


        public override IRequest Cast(IEnumerable<IMinion> targets = null)
        {
            throw new System.NotImplementedException();
        }
    }
}