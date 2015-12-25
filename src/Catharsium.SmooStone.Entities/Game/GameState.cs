using Catharsium.SmooStone.Entities.Players;

namespace Catharsium.SmooStone.Entities.Game
{
    public class GameState : IGameState
    {
        public IPlayer Player1 { get; }

        public IPlayer Player2 { get; }
    }
}