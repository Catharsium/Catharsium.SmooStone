using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Hands;

namespace Catharsium.SmooStone.Entities.GameState.Players
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