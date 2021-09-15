using System.Collections.Generic;

public static class CardTypes
{
    public static List<Card> startingCardTypes;
    public static List<Card> puzzleCardTypes;


    static CardTypes()
    {
        InitializeStartingCards();
        InitializePuzzleCards();
    }

    static void InitializeStartingCards()
    {
        startingCardTypes = new List<Card>();
        startingCardTypes.Clear();
        startingCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 1},
                {1, 1, 1, 1},
                {0, 1, 0, 1},
                {0, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 1, 1},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
            {
                {1, 1, 1, 1},
                {1, 0, 0, 1},
                {0, 0, 0, 1},
                {0, 0, 0, 1},
                {0, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
            {
                {1, 0, 0, 1},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {1, 0, 0, 1},
                {0, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
            {
                {1, 0, 0, 0},
                {1, 1, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 0, 0},
                {1, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 1},
                {1, 1, 1, 1},
                {1, 0, 1, 0},
                {0, 0, 0, 0}
            }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 1, 1},
                {1, 1, 1, 0},
                {0, 0, 0, 0}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {0, 0, 0, 0},
                {1, 0, 0, 1},
                {1, 1, 1, 1},
                {1, 0, 0, 1},
                {0, 0, 0, 0}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {1, 0, 0, 0},
                {1, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 1}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {1, 1, 0, 0},
                {1, 1, 1, 1},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {1, 0, 1, 0},
                {1, 1, 1, 0},
                {0, 0, 0, 0}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 1, 1},
                {1, 0, 0, 1},
                {0, 0, 0, 0}
        }));
        startingCardTypes.Add(new Card(new int[,]
        {
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0}
        }));
    }

    static void InitializePuzzleCards()
    {
        puzzleCardTypes = new List<Card>();
        puzzleCardTypes.Clear();

        // 1, yellow
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            }));
        // 2, orange
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        // 3, red
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        // 4, pink
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        // 5, purple
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {1, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 1, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 1, 0, 0},
                {0, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        // 6, blue
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 0, 0},
                {1, 1, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 1, 1},
                {0, 0, 0, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 1, 0},
                {0, 0, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 1, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 0, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        // 7, green
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 1, 1, 0},
                {1, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 1, 0},
                {0, 0, 1, 0},
                {1, 1, 1, 1},
                {0, 0, 1, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {1, 0, 0, 0},
                {1, 1, 0, 0},
                {0, 1, 1, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {0, 0, 1, 1},
                {1, 1, 1, 0},
                {0, 0, 1, 1},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 1, 0},
                {1, 1, 1, 0},
                {0, 0, 0, 0}
            }));
        puzzleCardTypes.Add(new Card(new int[,]
            {
                {0, 0, 0, 0},
                {1, 1, 1, 0},
                {0, 1, 0, 0},
                {1, 1, 1, 0},
                {0, 0, 0, 0}
            }));
    }
}
