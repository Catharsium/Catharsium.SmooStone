using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells;

namespace Catharsium.SmooStone.Entities.Orchestrator
{
    public class Orchestrator : IOrchestrator
    {
        public void PlayCard(ICard card)
        {
            var battlecryCard = card as IBattlecryMinion;
            battlecryCard?.Battlecry();

            var spellCard = card as ISpell;
            spellCard?.Cast();
        }
    }
}