using System;
using Catharsium.SmooStone.Entities.Decks;
using Catharsium.SmooStone.Entities.Hands;
using Catharsium.SmooStone.Entities.Cards.Base;
using Catharsium.Logging;

namespace Catharsium.SmooStone.Entities.PlayerAgents
{
    public abstract class PlayerAgent : IPlayerAgent
    {
        public IDeck Deck
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        public IHand Hand
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }


        public void DrawCard()
        {
            var card = Deck.Draw();
            if (!Hand.AddCard(card))
            {
               new LogFactory().GetConsoleLog().Info($"Could not add {card} because this hand is full", this);
            }
        }


        public abstract ICard PlayCard();
    }
}