using System.Collections.Generic;
using Catharsium.SmooStone.Entities.Cards.Base;

namespace Catharsium.SmooStone.Entities.Hands
{
    public class Hand : IHand
    {
        private IList<ICard> _cards;
        public IList<ICard> Cards
        {
            get { return _cards; }
            set
            {
                _cards = value;
            }
        }


        public int MaximumCards { get; set; }


        public Hand(int maximumCards)
        {
            MaximumCards = maximumCards;
        }


        public bool AddCard(ICard card)
        {
            if(Cards.Count < MaximumCards)
            {
                Cards.Add(card);
                return true;
            }
            return false;
        }
    }
}