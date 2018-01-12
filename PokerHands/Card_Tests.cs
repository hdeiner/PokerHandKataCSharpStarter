using System;
using Xunit;

namespace PokerHand
{
    public class Card_Tests
    {
        [Fact]
        public void CardNotLongEnough()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new Card("X"));
            Assert.Equal("Card X does not have two characters", ex.Message);
        }

        [Fact]
        public void CardTooLong()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new Card("XXX"));
            Assert.Equal("Card XXX does not have two characters", ex.Message);
        }

        [Fact]
        public void CardBadRank()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new Card("HD"));
            Assert.Equal("Card HD does not have a valid rank", ex.Message);
        }

        [Fact]
        public void CardBadSuit()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new Card("AX"));
            Assert.Equal("Card AX does not have a valid suit", ex.Message);
        }
    }
}
