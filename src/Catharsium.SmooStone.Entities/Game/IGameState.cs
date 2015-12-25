using Catharsium.SmooStone.Entities.Players;

namespace Catharsium.SmooStone.Entities.Game
{
    public interface IGameState
    {
        IPlayer Player1 { get; }

        IPlayer Player2 { get; }
    }
}