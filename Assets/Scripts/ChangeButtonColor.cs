using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    public Color wantedColor;
    public Image button;

    public void Incorrect()
    {
        /* ColorBlock cb = button.color;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.color = cb; */
        button.color = wantedColor;
    }
}
