using Catharsium.SmooStone.Entities.Tests.Mocks;
using System.Collections.Generic;
using Catharsium.SmooStone.Entities.GameState.Decks;
using Catharsium.SmooStone.Entities.GameState.Entities.Base;
using Xunit;

namespace Catharsium.SmooStone.Entities.Tests.Decks
{
    public class DeckTests
    {
        #region Fixture

        readonly IDeck SUT;


        public DeckTests()
        {
            SUT = new Deck();
        }

        #endregion

        [Fact]
        public void Draw_FromEmptyDeck_ReturnsNull()
        {
            var cards = new ICard[0];
            SUT.Fill(cards);
            var card = SUT.Draw();
            Assert.Null(card);
        }


        [Fact]
        public void Draw_FromSingleCardDeck_ReturnsCard()
        {
            var card = new CardMock();
            var cards = new ICard[] { card };
            SUT.Fill(cards);
            var actual = SUT.Draw();
            Assert.Equal(card, actual);
        }


        [Fact]
        public void Draw_FromMultiCardDeck_ReturnsNullWhenEmpty()
        {
            var deckSize = 3;
            var cards = new List<ICard>();
            for (var i= 0; i < deckSize; i++)
            {
                cards.Add(new CardMock());
            }
            SUT.Fill(cards);

            ICard actual;
            for(var i = 0; i < deckSize; i++)
            {
                actual = SUT.Draw();
                Assert.NotNull(actual);
            }
            actual = SUT.Draw();
            Assert.Null(actual);
        }
    }
}