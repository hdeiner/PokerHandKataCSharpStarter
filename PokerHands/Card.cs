using System;

namespace PokerHand
{
    public class Card
    {
        string rank;
        string suit;

        String VALID_RANKS = "234567890JQKA";  // two, three, four, ... ten, jack, queen, king, ace
        String VALID_SUITS = "DCHS";           // diamond, club, heart, spade

        public Card(string rankAndSuit)
        {
            if (rankAndSuit.Length != 2) throw new ArgumentException("Card " +rankAndSuit+" does not have two characters");
            rank = rankAndSuit.Substring(0, 1);
            suit = rankAndSuit.Substring(1, 1);
            if (VALID_RANKS.IndexOf(rank, StringComparison.Ordinal) == -1) throw new ArgumentException("Card " + rankAndSuit + " does not have a valid rank");
            if (VALID_SUITS.IndexOf(suit, StringComparison.Ordinal) == -1) throw new ArgumentException("Card " + rankAndSuit + " does not have a valid suit");
        }
    }
}
