using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Cards.Base.Minions;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Request
{
    public class DamageRequest : IDamageRequest
    {
        public int Damage { get; set; }

        public IEnumerable<IMinion> Targets { get; set; }
    }
}