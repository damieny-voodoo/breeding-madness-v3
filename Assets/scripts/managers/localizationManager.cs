using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class localizationManager : MonoBehaviour
{
    public bool updateLocaAtStart;
    public string[] texts;
    public int textId;
    int savedLanguage;
    int currentLanguage;


    public void UpdateThisText(string newText)
    {

        if (GetComponent<Text>())
        {
            GetComponent<Text>().text = newText;
            //Debug.Log("Update text " + newText + ", font size: " + GetComponent<Text>().fontSize);

        }

        else if (GetComponent<TextMesh>())
        {
            GetComponent<TextMesh>().text = newText;
            //Debug.Log("Update text " + newText + ", font size: " + GetComponent<TextMesh>().fontSize);

        }


        else if (GetComponent<TextMeshProUGUI>())
        {
            GetComponent<TextMeshProUGUI>().text = newText;
            //Debug.Log("Update text " + newText + ", font size: " + GetComponent<TextMeshProUGUI>().fontSize);

        }

        else if (GetComponent<TextMeshPro>())
        {
            GetComponent<TextMeshPro>().text = newText;
            //Debug.Log("Update text " + newText + ", font size: " + GetComponent<TextMeshPro>().fontSize);
        }


        GetComponent<autoSizeText>().RedoFontSize();

    }


    public void UpdateText()
    {
    }
}
