// Generates the background where list of all the 
// possible shapes are shown. 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public Camera uiCamera;
    public RectTransform mParent;

    const int gridSize = 5;
    public GameObject blockPrefab;
    public Vector3 scale = new Vector3(2, 2, 2);
    public float resolutionScale;

    private Color[] colors = {
            new Color(1, 0.20f, 0.20f,  .3f),
            new Color(1, 0.5f, 0.20f,  .3f),
            new Color(1, 1, 0.20f,      .3f),
            new Color(0.20f, 1, 0.20f,  .3f),
            new Color(0.20f, 1, 1,      .3f),
            new Color(0.12f, 0.31f, 1,  .3f),
            new Color(1, 0.20f, 1,      .3f),
            new Color(1, 1, 1,          .3f),
            new Color(1, 1, 1,          .3f),
            new Color(1, 1, 1,          .3f),
        };

    // Start is called before the first frame update
    void Start()
    {
        resolutionScale = Screen.height / 720f;
        int marginX = (int)(Screen.width * 0.25f);
        int marginY = (int)(Screen.height * 0.1f);
        int draw_area_width = (int)(Screen.width - (2*marginX));
        int draw_area_height = (int)(Screen.height - (2 * marginY));
        int distanceBetweenShapesX = (int)(draw_area_width / 5);
        int distanceBetweenShapesY = (int)(draw_area_height / 6.3);

        int row = 0;
        int column = 0;
        float x_offset, y_offset;
        foreach (Card card in Deck.puzzleCards)
        {
            x_offset = column*distanceBetweenShapesX+ marginX;
            y_offset = row*distanceBetweenShapesY+ marginY;
            CreateCard(card, x_offset, y_offset);
            if (column < gridSize)
            {
                column++;
            }
            else
            {
                column = 0;
                row++;
            }
        }
        Deck.puzzleCards.Shuffle();
    }

    void CreateCard(Card new_card, float x_offset, float y_offset)
    {
        int colorCounter = 0;
        List<GameObject> blocks = new List<GameObject>();

        // create blocks
        for (int x = 0; x < new_card.shape.GetLength(0); x += 1)
        {
            for (int y = 0; y < new_card.shape.GetLength(1); y += 1)
            {
                if (new_card.shape[x, y] == 1)
                {
                    colorCounter++;
                    Vector2 relativePosition = new Vector3(x * 15f * scale.x * resolutionScale - 30f + x_offset, y * 15f * scale.y * resolutionScale - 20f + y_offset);
                    GameObject block = Instantiate(blockPrefab, transform.position, transform.rotation, transform);
                    block.transform.SetAsFirstSibling();
                    block.transform.localScale = scale;
                    RectTransformUtility.ScreenPointToLocalPointInRectangle(mParent, relativePosition, uiCamera, out relativePosition);
                    block.GetComponent<RectTransform>().anchoredPosition = relativePosition;
                    blocks.Add(block);
                }
            }
        }

        // Change color
        foreach (GameObject block in blocks)
        {
            block.GetComponent<Image>().color = colors[colorCounter - 1];
        }
    }
}
