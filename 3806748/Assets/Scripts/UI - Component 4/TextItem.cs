using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextItem : MonoBehaviour
{
    public string StartingText;
    public string EndText;
    public Color ContextGoodColour = new Color32(0, 255, 0, 255);
    public Color ContextBadColour = new Color32(255, 0, 0, 255);


    private Text TextObject;
    private Color ContextNeutralColour;

    private void Start()
    {
        TextObject = gameObject.GetComponent<Text>();
        StartingText = TextObject.text;
        ContextNeutralColour = TextObject.color;
    }

    public void UpdateUI(string NewText = "0", bool ColourContext = false, bool ColourByPercent = false, float Percent = 1)
    {
        TextObject.text = NewText;

        if (ColourContext)
        {
            if (ColourByPercent)
            {
                TextObject.color = Color32.Lerp(ContextBadColour, ContextGoodColour, Percent);
            }
            else
            {
                int tempValue = int.Parse(NewText);

                if (tempValue > 0)
                {
                    TextObject.color = ContextGoodColour;
                }
                else if (tempValue < 0)
                {
                    TextObject.color = ContextBadColour;
                }
                else
                {
                    TextObject.color = ContextNeutralColour;
                }
            }
        }
    }

    public void ChangeUIState(bool State = false)
    {
        transform.parent.gameObject.SetActive(State);
    }                       
}
