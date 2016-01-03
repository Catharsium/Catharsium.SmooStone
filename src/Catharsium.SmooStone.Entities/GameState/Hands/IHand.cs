using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using System;

namespace Catharsium.SmooStone.Entities.GameState.Hands
{
    public interface IHand
    {
        //int MaximumCards { get; set; }

        //IList<ICard> Cards { get; }
                
        bool AddCard(ICard agent);

        bool PlayCard(Guid cardId);
    }
}