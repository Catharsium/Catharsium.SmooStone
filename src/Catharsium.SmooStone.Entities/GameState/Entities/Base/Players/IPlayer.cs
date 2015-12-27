using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Hands;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Players
{
    public interface IPlayer : IAgent
    {
        #region Properties

        IDeck Deck { get; }

        IHand Hand { get; }

        IBoard Board { get; }
        
        int Armor { get; }

        #endregion

        #region Methods

        void DrawCard();

        ICard PlayCard();

        #endregion
    }
}