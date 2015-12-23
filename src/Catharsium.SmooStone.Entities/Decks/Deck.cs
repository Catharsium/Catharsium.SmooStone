using Catharsium.SmooStone.Entities.Cards.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catharsium.SmooStone.Entities.Decks
{
    public class Deck : IDeck
    {
        protected IList<ICard> Cards { get; set; }


        public void Fill(IEnumerable<ICard> cards)
        {
            Cards = cards.ToList();
        }


        public ICard Draw()
        {
            if(Cards.Any())
            {
                var index = new Random().Next(Cards.Count);
                var result = Cards[index];
                Cards.RemoveAt(index);
                return result;
            }
            return null;
        }


        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("{ ");
            foreach(var card in Cards)
            {
                result.Append(card.Name);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}