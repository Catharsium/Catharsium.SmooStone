using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Boards
{
    public class ActiveMinion : IActiveMinion
    {
        public IMinion Minion { get; }

        public IPlayer Player { get; }

        public int Position { get; }


        public ActiveMinion(IMinion minion, IPlayer player, int position)
        {
            Minion = minion;
            Player = player;
            Position = position;
        }
    }
}