using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{   
    // TODO: Undo (1 kerta)


    public CardController puzzleCard1;
    public CardController puzzleCard2;
    public CardController secondChanceCard;

    public GameObject drawStartingCardsButton;
    public GameObject drawPuzzleCardsButton;
    public GameObject secondChanceButton;
    public Text secondChanceButtonText;
    public GameObject remainingDeckSlider;

    public Text player1;
    public Text player2;
    private int numberOfPlayers = 0;

    public AudioClip[] penSounds;

    public void DrawNewStartingCards()
    {
        if (Deck.startingCards.Count <= 0)
        {
            drawStartingCardsButton.GetComponent<Button>().interactable = false;
            return;
        }
        playPenSound();
        puzzleCard1.gameObject.SetActive(true);
        puzzleCard1.UpdateCard(Deck.DrawStartingCard());
        puzzleCard2.gameObject.SetActive(true);
        puzzleCard2.UpdateCard(Deck.DrawStartingCard());
        drawPuzzleCardsButton.GetComponent<Button>().interactable = true;
        numberOfPlayers++;
        player2.text = "PLAYER " + numberOfPlayers;
        numberOfPlayers++;
        player1.text = "PLAYER " + numberOfPlayers;

        if (Deck.startingCards.Count <= 0)
        {
            drawStartingCardsButton.GetComponent<Button>().interactable = false;
        }
    }

    public void ResetGame()
    {
        playPenSound();
        drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
        secondChanceButton.SetActive(false);
        drawStartingCardsButton.SetActive(true);
        drawStartingCardsButton.GetComponent<Button>().interactable = true;
        secondChanceCard.gameObject.SetActive(false);
        puzzleCard1.gameObject.SetActive(false);
        puzzleCard2.gameObject.SetActive(false);
        secondChanceButtonText.text = "THIRD OPTION";
        player1.text = "";
        player2.text = "";
        numberOfPlayers = 0;
        Deck.ResetDecks();
    }

    public void DrawNewPuzzleCards()
    {
        playPenSound();
        // If drawing first time puzzle cards
        if (drawStartingCardsButton.activeInHierarchy == true)
        {
            player1.text = "";
            player2.text = "";
            drawStartingCardsButton.SetActive(false);
            secondChanceButton.SetActive(true);
            secondChanceButton.GetComponent<Button>().interactable = true;
        }
        puzzleCard1.UpdateCard(DrawPuzzleCard(puzzleCard1));
        puzzleCard2.UpdateCard(DrawPuzzleCard(puzzleCard2));

        remainingDeckSlider.GetComponent<Slider>().value = (float)Deck.puzzleCards.Count / (float)Deck.maxCards;
    }

    public Card DrawPuzzleCard(CardController cardObject)
    {
        if (Deck.puzzleCards.Count <= 0)
        {
            drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            cardObject.gameObject.SetActive(false);
        }

        Card card = Deck.DrawPuzzleCard();

        if (Deck.puzzleCards.Count <= 0)
        {
            drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            secondChanceButton.GetComponent<Button>().interactable = false;
        }
        return card;
    }

    public void drawSecondChance()
    {
        playPenSound();

        // Second chance card is visible
        if (secondChanceCard.gameObject.activeInHierarchy == true)
        {
            secondChanceCard.gameObject.SetActive(false);
            drawPuzzleCardsButton.GetComponent<Button>().interactable = true;
            secondChanceButton.GetComponentInChildren<Text>().text = "THIRD OPTION";
            if (Deck.puzzleCards.Count <= 0)
            {
                secondChanceButton.GetComponent<Button>().interactable = false;
                drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            }
        }
        else // Second chance card is not visible
        {
            secondChanceCard.gameObject.SetActive(true);
            secondChanceCard.UpdateCard(Deck.DrawPuzzleCard());
            drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            secondChanceButton.GetComponentInChildren<Text>().text = "CONTINUE";
        }
        remainingDeckSlider.GetComponent<Slider>().value = (float)Deck.puzzleCards.Count / (float)Deck.maxCards;
    }

    private void playPenSound()
    {
        AudioSource audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = penSounds[Random.Range(0, penSounds.Length - 1)];
        audioSource.Play();
    }
}
