using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;

namespace Catharsium.SmooStone.Entities.GameState.Hands
{
    public class Hand : IHand
    {
        #region Properties

        public int MaximumCards { get; set; }

        private IList<ICard> _cards;
        public IList<ICard> Cards
        {
            get
            {
                if (_cards == null)
                {
                    _cards = new List<ICard>();
                }
                return _cards;
            }
            set
            {
                _cards = value;
            }
        }

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
            if(Cards.Count < MaximumCards)
            {
                Cards.Add(card);
                return true;
            }
            return false;
        }

        #endregion
    }
}