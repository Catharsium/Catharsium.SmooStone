using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Game
{
    public class GameState : IGameState
    {
        public IPlayer Player1 { get; set; }

        public IPlayer Player2 { get; set; }
    }
}