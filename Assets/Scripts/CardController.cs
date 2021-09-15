﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Card card;
    public List<GameObject> blocks;
    public GameObject blockPrefab;

    private Color[] colors = {
            new Color(1, 0.20f, 0.20f),
            new Color(1, 10.12f, 0.20f),
            new Color(1, 1, 0.20f),
            new Color(0.20f, 1, 0.20f),
            new Color(0.20f, 1, 1),
            new Color(0.12f, 0.31f, 1),
            new Color(1, 0.20f, 1),
            new Color(1, 1, 1),
            new Color(1, 1, 1),
            new Color(1, 1, 1),
        };

    public void UpdateCard(Card new_card)
    {
        // delete old blocks
        foreach (GameObject block in blocks)
        {
            Destroy(block);
        }
        blocks.Clear();

        int colorCounter = 0;

        // create blocks
        for (int x = 0; x < new_card.shape.GetLength(0); x += 1)
        {
            for (int y = 0; y < new_card.shape.GetLength(1); y += 1)
            {
                if (new_card.shape[x, y] == 1)
                {
                    colorCounter++;
                    Vector3 relativePosition = new Vector3(x*15f - 30f, y*15f - 20f, -0.1f);
                    GameObject block = Instantiate(blockPrefab, transform.position, transform.rotation, transform);
                    block.GetComponent<RectTransform>().anchoredPosition = new Vector2(relativePosition.x, relativePosition.y);
                    blocks.Add(block);
                }
            }
        }

        // Change color
        this.GetComponent<Image>().color = colors[colorCounter - 1];
        foreach (GameObject block in blocks)
        {
            block.GetComponent<Image>().color = colors[colorCounter - 1];
        }
    }
}