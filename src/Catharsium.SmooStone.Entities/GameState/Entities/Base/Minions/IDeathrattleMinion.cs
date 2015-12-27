using Catharsium.SmooStone.Entities.Actions.Enforcers;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions
{
    public interface IDeathrattleMinion : IMinion
    {
        IEnforcer Deathrattle();
    }
}