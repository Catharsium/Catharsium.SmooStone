using Catharsium.SmooStone.Entities.GameState.Players;

namespace Catharsium.SmooStone.Entities.GameState.Game
{
    public class GameState : IGameState
    {
        public IPlayer Player1 { get; }

        public IPlayer Player2 { get; }
    }
}