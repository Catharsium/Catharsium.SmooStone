using Catharsium.SmooStone.Entities.Cards.Base;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Hands
{
    public interface IHand
    {
        IList<ICard> Cards { get; }

        int MaximumCards { get; set; }
        
        bool AddCard(ICard card);
    }
}
