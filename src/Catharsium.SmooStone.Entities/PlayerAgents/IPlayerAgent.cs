using Catharsium.SmooStone.Entities.Cards.Base;
using Catharsium.SmooStone.Entities.Decks;
using Catharsium.SmooStone.Entities.Hands;

namespace Catharsium.SmooStone.Entities.PlayerAgents
{
    public interface IPlayerAgent
    {
        IDeck Deck { get; set; }

        IHand Hand { get; set; }

        void DrawCard();

        ICard PlayCard();
    }
}