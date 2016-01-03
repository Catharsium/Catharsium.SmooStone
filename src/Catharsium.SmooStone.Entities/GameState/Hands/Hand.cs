using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Minions;
using Catharsium.SmooStone.Entities.GameState.Entities.Base.Spells;
using System.Linq;
using System;

namespace Catharsium.SmooStone.Entities.GameState.Hands
{
    public class Hand : IHand
    {
        #region Properties

        protected int MaximumCards { get; set; }

        protected IList<ICard> Cards { get; set; } = new List<ICard>();

        #endregion

        #region Construction

        public Hand(int maximumCards)
        {
            MaximumCards = maximumCards;
        }

        #endregion

        #region IDeck

        public bool AddCard(ICard card)
        {
            if (Cards.Count >= MaximumCards) return false;

            Cards.Add(card);
            return true;
        }


        public bool PlayCard(Guid cardId)
        {
            var card = Cards.FirstOrDefault(c => c.ID == cardId);
            if (card == null) return false;

            var battlecryCard = card as IBattlecryMinion;
            battlecryCard?.Battlecry();

            var spellCard = card as ISpell;
            spellCard?.Cast();

            Cards.Remove(card);

            return false;
        }

        #endregion
    }
}