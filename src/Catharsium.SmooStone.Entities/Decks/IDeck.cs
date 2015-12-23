using Catharsium.SmooStone.Entities.Cards.Base;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Decks
{
    public interface IDeck
    {
        void Fill(IEnumerable<ICard> cards);

        ICard Draw();
    }
}