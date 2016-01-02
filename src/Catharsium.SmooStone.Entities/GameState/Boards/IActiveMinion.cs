using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Boards
{
    public interface IActiveMinion
    {
        IMinion Minion { get; }

        IPlayer Player { get; }

        int Position { get; }
    }
}