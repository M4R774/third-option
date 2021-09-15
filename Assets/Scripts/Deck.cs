using System.Collections.Generic;
using System.Linq;

public static class Deck
{
    public static List<Card> startingCards;
    public static List<Card> puzzleCards;
    public static List<Card> discardPile;  // For undo operations
    public static int maxCards;

    static Deck()
    {
        startingCards = new List<Card>();
        puzzleCards = new List<Card>();
        discardPile = new List<Card>(); 
        ResetDecks();
        maxCards = puzzleCards.Count();
    }

    public static void ResetDecks()
    {
        // Starting
        Deck.startingCards.Clear();
        for (int i = 0; i < CardTypes.startingCardTypes.Count - 1; i++)
        {
            Deck.startingCards.Add(CardTypes.startingCardTypes[i]);
        }
        Deck.startingCards.Shuffle();

        // Puzzle
        Deck.puzzleCards.Clear();
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[0]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[0]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[0]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[1]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[1]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[1]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[2]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[2]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[3]);
        Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[3]);
        for (int i = 4; i < CardTypes.puzzleCardTypes.Count - 1; i++)
        {
            Deck.puzzleCards.Add(CardTypes.puzzleCardTypes[i]);
        }
        Deck.puzzleCards.Shuffle();

        // Discard pile
        Deck.discardPile.Clear();
    }

    public static int GetNumberOfPuzzleCardsLeftInDeck()
    {
        return Deck.puzzleCards.Count;
    }

    public static Card DrawStartingCard()
    {
        Card card = Deck.startingCards.Last();
        Deck.startingCards.RemoveAt(startingCards.Count - 1);
        discardPile.Add(card);
        return card;
    }

    public static Card DrawPuzzleCard()
    {
        Card card = Deck.puzzleCards.Last();
        Deck.discardPile.Add(card);
        Deck.puzzleCards.RemoveAt(puzzleCards.Count - 1);
        return card;
    }

    public static Card DrawDiscardPileCard()
    {
        Card card = Deck.discardPile.Last();
        return card;
    }

    public static void Shuffle<T>(this IList<T> list)
    {
        System.Random randomizer = new System.Random();

        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = randomizer.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
