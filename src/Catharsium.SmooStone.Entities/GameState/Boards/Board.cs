using System.Collections.Generic;
using System.Linq;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Players;

namespace Catharsium.SmooStone.Entities.GameState.Boards
{
    public class Board : IBoard
    {
        private IList<IActiveMinion> ActiveMinions { get; } = new List<IActiveMinion>(14);

        #region IBoard

        public void AddMinion(IMinion minion, IPlayer player, int position)
        {
            ActiveMinions.Add(new ActiveMinion(minion, player, position));
        }


        public void RemoveMinion(IMinion minion)
        {
            var activeMinion = ActiveMinions.FirstOrDefault(m => m.Minion == minion);
            if (activeMinion != null)
            {
                ActiveMinions.Remove(activeMinion);
            }
        }

        #endregion
    }
}