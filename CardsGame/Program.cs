List<int> playerOneDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> playerTwoDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

int i = 0;
while (playerOneDeck.Count > 0 && playerTwoDeck.Count > 0)
{
    int playerOneCurrentCard = playerOneDeck[i];
    int playerTwoCurrentCard = playerTwoDeck[i];

    playerOneDeck.Remove(playerOneCurrentCard);
    playerTwoDeck.Remove(playerTwoCurrentCard);

    if (playerOneCurrentCard > playerTwoCurrentCard)
    {
        playerOneDeck.Add(playerTwoCurrentCard);
        playerOneDeck.Add(playerOneCurrentCard);
    }
    else if (playerOneCurrentCard < playerTwoCurrentCard)
    {
        playerTwoDeck.Add(playerOneCurrentCard);
        playerTwoDeck.Add(playerTwoCurrentCard);
    }
}

int winnerCardsSum = 0;

if (playerOneDeck.Count == 0)
{
    winnerCardsSum = playerTwoDeck.Sum();
    Console.WriteLine($"Second player wins! Sum: {winnerCardsSum}");
}
else if (playerTwoDeck.Count == 0)
{
    winnerCardsSum = playerOneDeck.Sum();
    Console.WriteLine($"First player wins! Sum: {winnerCardsSum}");
}
