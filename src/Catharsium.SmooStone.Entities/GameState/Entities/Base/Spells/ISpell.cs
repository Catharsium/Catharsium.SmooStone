using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Actions.Enforcers.Request;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells
{
    public interface ISpell : ICard
    {
        IRequest Cast(IEnumerable<IMinion> targets = null);
    }
}