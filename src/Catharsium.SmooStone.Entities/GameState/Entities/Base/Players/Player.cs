using System.Collections.Generic;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Affixes;
using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Hands;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Players
{
    public abstract class Player : IPlayer
    {
        #region Properties

        public string Name { get; set; }

        public virtual IDeck Deck { get; set; }
        
        public virtual IHand Hand { get; set; }

        public virtual IBoard Board { get; set; }

        public virtual int Armor { get; set; }

        public abstract ICard PlayCard();

        public int BaseAttack { get; set; }

        public int CurrentAttack { get; set; }

        public int BaseHealth { get; set; }

        public int CurrentHealth { get; set; }

        public IEnumerable<IAffix> Affixes { get; set; }

        #endregion

        public void DrawCard()
        {
            var card = Deck.Draw();
            if (!Hand.AddCard(card))
            {
               new LogFactory().GetConsoleLog().Info($"Could not add {card} because this hand is full", this);
            }
        }
    }
}