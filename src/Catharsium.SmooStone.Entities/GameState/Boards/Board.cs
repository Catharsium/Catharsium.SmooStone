using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;

namespace Catharsium.SmooStone.Entities.GameState.Boards
{
    public class Board : IBoard
    {
        protected IList<ICard> Cards { get; set; }
    }
}
