﻿using Catharsium.Modules.Logging;
using Catharsium.SmooStone.Entities.GameState.Boards;
using Catharsium.SmooStone.Entities.GameState.Cards.Base;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Hands;

namespace Catharsium.SmooStone.Entities.GameState.Players
{
    public abstract class Player : IPlayer
    {
        public IDeck Deck { get; }
        
        public IHand Hand { get; }

        public IBoard Board { get; }

        public int Health { get; }

        public int Armor { get; }


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