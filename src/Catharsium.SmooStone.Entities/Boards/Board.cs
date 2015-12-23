using Catharsium.SmooStone.Entities.Cards.Base;
using System.Collections.Generic;

namespace Catharsium.SmooStone.Entities.Boards
{
    public class Board : IBoard
    {
        protected IList<ICard> Cards { get; set; }
    }
}
