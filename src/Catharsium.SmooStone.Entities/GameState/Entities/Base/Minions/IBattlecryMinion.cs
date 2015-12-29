using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions
{
    public interface IBattlecryMinion : IMinion
    {
        IRequest Battlecry(IEnumerable<IMinion> targets = null);
    }
}