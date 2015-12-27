using Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells;

namespace Catharsium.SmooStone.Entities.Tests.Mocks
{
    public class SpellMock : Spell
    {
        public override string BaseDescription { get; } = "This is a spell";

        public override int BaseCost { get; } = 1;
    }
}