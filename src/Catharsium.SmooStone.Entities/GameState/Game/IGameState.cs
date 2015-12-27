using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Game
{
    public interface IGameState
    {
        IPlayer Player1 { get; }

        IPlayer Player2 { get; }
    }
}