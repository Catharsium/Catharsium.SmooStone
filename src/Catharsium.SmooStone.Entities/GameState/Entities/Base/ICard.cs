using System;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base
{
    public interface ICard : IEntity
    {
        Guid ID { get; }

        string BaseDescription { get; }

        string CurrentDescription { get; }

        int BaseCost { get; }

        int CurrentCost { get; }
    }
}