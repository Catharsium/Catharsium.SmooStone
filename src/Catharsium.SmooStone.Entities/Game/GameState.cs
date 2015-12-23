using Catharsium.SmooStone.Entities.Players;

namespace Catharsium.SmooStone.Entities.Game
{
    public class GameState : IGameState
    {
        public IPlayerAgent Player1 { get; }

        public IPlayerAgent Player2 { get; }
    }
}