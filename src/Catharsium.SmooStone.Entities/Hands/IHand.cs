using Catharsium.SmooStone.Entities.Cards.Base;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Hands
{
    public interface IHand
    {
        int MaximumCards { get; set; }

        IList<ICard> Cards { get; }
                
        bool AddCard(ICard card);
    }
}