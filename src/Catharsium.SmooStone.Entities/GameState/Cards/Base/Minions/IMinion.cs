using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Affixes;

namespace Catharsium.SmooStone.Entities.GameState.Cards.Base.Minions
{
    public interface IMinion
    {
        int BaseAttack { get; }

        int CurrentAttack { get; set; }

        int BaseHealth { get; }

        int CurrentHealth { get; set; }

        IEnumerable<IAffix> Affixes { get; set; }
    }
}