using Catharsium.SmooStone.Entities.Affixes;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Cards.Base.Minions
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