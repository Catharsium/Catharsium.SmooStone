using Catharsium.SmooStone.Entities.Actions.Enforcers;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions
{
    public interface IInspireCard : IMinion
    {
        IEnforcer Inspire();
    }
}