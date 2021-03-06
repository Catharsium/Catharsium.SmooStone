﻿using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Boards
{
    public interface IBoard
    {
        void AddMinion(IMinion minion, IPlayer player, int position);

        void RemoveMinion(IMinion minion);
    }
}