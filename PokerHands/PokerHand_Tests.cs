using System;
using Xunit;

namespace PokerHand
{
    public class PokerHandTests
    {
        [Fact]
        public void PairOfAcesBeatsHighKing()
        {
            PokerHand pokerHand = new PokerHand();
            Assert.True(pokerHand.hand1Wins(new string[] { "AD", "AC", "2D", "3H", "9C" },
                                            new string[] { "AD", "KC", "2D", "3H", "9C" }));
        }

        [Fact]
        public void HasPairInTheHand()
        {
            PokerHand pokerHand = new PokerHand();
                Assert.True(pokerHand.hasPair(new string[] { "AD", "AC", "2D", "3H", "9C" }));
        }
    }
}
