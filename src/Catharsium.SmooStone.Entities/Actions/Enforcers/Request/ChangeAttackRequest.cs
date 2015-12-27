using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Request
{
    public class ChangeAttackRequest : IChangeAttackRequest
    {
        public int Attack { get; set; }

        public IEnumerable<IMinion> Targets { get; set; }
    }
}