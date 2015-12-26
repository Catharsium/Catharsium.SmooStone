using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;

namespace Catharsium.SmooStone.Entities.GameState.Decks
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