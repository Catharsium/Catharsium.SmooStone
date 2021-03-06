﻿using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;

namespace Catharsium.SmooStone.Entities.GameState.Decks
{
    public interface IDeck
    {
        void Fill(IEnumerable<ICard> cards);

        ICard Draw();
    }
}