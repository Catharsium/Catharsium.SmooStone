using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.Actions.Enforcers.Request
{
    public interface IChangeAttackRequest : IRequest
    {
        int Attack { get; }

        IEnumerable<IMinion> Targets { get; }
    }
}