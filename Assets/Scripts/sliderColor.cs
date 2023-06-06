using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderColor : MonoBehaviour
{
    public GameObject fill;

    public void OnValueChanged()
    {
        if  (this.GetComponent<Slider>().value >= 0.33f)
        {
            // R, G, B
            // red: 1, 0, 0
            // yellow: 1, 1, 0
            Color newColor = new Color(1f, 1f, this.GetComponent<Slider>().value * 1.5f - 0.5f);
            fill.GetComponent<Image>().color = newColor;
        }
        else
        {
            Color newColor = new Color(1f, this.GetComponent<Slider>().value * 3 - 0.1f, 0f);
            fill.GetComponent<Image>().color = newColor;
        }
    }
}
