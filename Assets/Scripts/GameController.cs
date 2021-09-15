using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{   
    // TODO: Korjaa se että kortin nostonappia voi painaa vielä yhden kerran
    // sillon kun pakka on jo tyhjä
    // Ratkaisu: Kirjoita kortin nostolle uusi funktio joka tsekkaa ennen ja
    // jälkeen voiko kortin nostaa. 
    // TODO: Sliderin väri vaihtuu keltaiseksi kun < 1/3 pakasta jäljellä ja 
    // punaiseksi kun < 1/10
    // TODO: Taustakuva jiiriin (kaikki mahdolliset kortit näkyvät ihan
    // haalealla taustalla). 

    public CardController puzzleCard1;
    public CardController puzzleCard2;
    public CardController secondChanceCard;

    public GameObject drawStartingCardsButton;
    public GameObject drawPuzzleCardsButton;
    public GameObject secondChanceButton;
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
        player2.text = "Player " + numberOfPlayers;
        numberOfPlayers++;
        player1.text = "Player " + numberOfPlayers;

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
        player1.text = "";
        player2.text = "";
        numberOfPlayers = 0;
        Deck.ResetDecks();
    }

    public void DrawNewPuzzleCards()
    {
        if (Deck.puzzleCards.Count <= 0)
        {
            drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            return;
        }
        playPenSound();
        // If drawing first time puzzle cards
        if (drawStartingCardsButton.activeInHierarchy == true)
        {
            player1.text = "";
            player2.text = "";
            drawStartingCardsButton.SetActive(false);
            secondChanceButton.SetActive(true);
        }
        puzzleCard1.UpdateCard(Deck.DrawPuzzleCard());
        puzzleCard2.UpdateCard(Deck.DrawPuzzleCard());
        if (Deck.puzzleCards.Count <= 0)
        {
            drawStartingCardsButton.GetComponent<Button>().interactable = false;
        }
        remainingDeckSlider.GetComponent<Slider>().value = (float)Deck.puzzleCards.Count / (float)Deck.maxCards;
    }

    public void drawSecondChance()
    {
        playPenSound();

        // Second chance card is visible
        if (secondChanceCard.gameObject.activeInHierarchy == true)
        {
            secondChanceCard.gameObject.SetActive(false);
            drawPuzzleCardsButton.GetComponent<Button>().interactable = true;
            secondChanceButton.GetComponentInChildren<Text>().text = "Second chance";
        }
        else // Second chance card is not visible
        {
            secondChanceCard.gameObject.SetActive(true);
            secondChanceCard.UpdateCard(Deck.DrawPuzzleCard());
            drawPuzzleCardsButton.GetComponent<Button>().interactable = false;
            secondChanceButton.GetComponentInChildren<Text>().text = "Continue";
        }
    }

    private void playPenSound()
    {
        AudioSource audioSource = this.GetComponent<AudioSource>();
        audioSource.clip = penSounds[Random.Range(0, penSounds.Length - 1)];
        audioSource.Play();
    }
}
