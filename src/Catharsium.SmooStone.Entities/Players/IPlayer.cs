using Catharsium.SmooStone.Entities.Boards;
using Catharsium.SmooStone.Entities.Cards.Base;
using Catharsium.SmooStone.Entities.Decks;
using Catharsium.SmooStone.Entities.Hands;

namespace Catharsium.SmooStone.Entities.Players
{
    public interface IPlayer
    {
        IDeck Deck { get; }

        IHand Hand { get; }

        IBoard Board { get; }

        int Health { get; }

        int Armor { get; }


        void DrawCard();

        ICard PlayCard();
    }
}