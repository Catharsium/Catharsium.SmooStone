using System.Collections.Generic;
using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Affixes;
using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Hands;

namespace Catharsium.SmooStone.Entities.GameState.Entities.Base.Players
{
    public class Player : IPlayer
    {
        #region Properties

        public string Name { get; set; }

        public virtual IDeck Deck { get; set; }
        
        public virtual IHand Hand { get; set; }

        public virtual IBoard Board { get; set; }

        public virtual int Armor { get; set; }

        public int BaseAttack { get; set; }

        public int CurrentAttack { get; set; }

        public int BaseHealth { get; set; }

        public int CurrentHealth { get; set; }

        public IEnumerable<IAffix> Affixes { get; set; }

        protected ILog Log { get; set; }

        #endregion

        #region Construction

        public Player(ILog log)
        {
            Log = log;
        }

        #endregion

        #region IPlayer

        public void DrawCard()
        {
            var card = Deck.Draw();
            if (!Hand.AddCard(card))
            {
                Log.Info($"Could not add {card} because this hand is full", this);
            }
        }


        public ICard PlayCard()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}