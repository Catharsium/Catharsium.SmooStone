using Catharsium.SmooStone.Entities.Players;

namespace Catharsium.SmooStone.Entities.Game
{
    public interface IGameState
    {
        IPlayerAgent Player1 { get; }

        IPlayerAgent Player2 { get; }
    }
}