using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class necManager : MonoBehaviour
{

    public RectTransform necDiamondPanel;
    public RectTransform necCoinsPanel;
    public RectTransform necFertilizerPanel;
    public RectTransform necOwnedPetsPanel;
    public RectTransform necOnePetLeftPanel;
    public RectTransform necCollectionTooltip;

    public TextMeshProUGUI collectionDesc;


    public void ShowNec( string necType)
    {
        if (necType == "diamonds")
            NecTooltip(necDiamondPanel);
        else if (necType == "coins")
            NecTooltip(necCoinsPanel);
        else if (necType == "fertilizer")
            NecTooltip(necFertilizerPanel);
        else if (necType == "notEnoughPets")
            NecTooltip(necOwnedPetsPanel);
        else if (necType == "onePetLeft")
            NecTooltip(necOnePetLeftPanel);

    }

    public void ShowCollectionTooltip(string necType, string descText)
    {
        if (necType == "collectionTooltip")
            NecCollectionTooltip(necCollectionTooltip, descText);
    }


     void NecTooltip(RectTransform necRect)
    {
        //Vector2 tapPosition = TapPosition();
        //Debug.Log("Tapped with error at position x = " + tapPosition.x + "and y = " + tapPosition.y);
        // POS X
        float proportionx = TapPosition().x / Screen.width;
        float anchorXMin = proportionx - 0.25f;
        if (anchorXMin < 0)
            anchorXMin = 0;
        else if (anchorXMin > .5f)
            anchorXMin = .5f;
        float anchorXMax = anchorXMin + 0.5f;

        // POS Y
        float proportiony = TapPosition().y / Screen.height;
        float offsetY = 0.1f;
        float anchorYMin = proportiony - 0.05f + offsetY;
        float anchorYMax = proportiony + offsetY;

        necRect.anchorMin = new Vector2(anchorXMin, anchorYMin);
        necRect.anchorMax = new Vector2(anchorXMax, anchorYMax);

        necRect.offsetMin = new Vector2(0, 0);
        necRect.offsetMax = new Vector2(0, 0);

        necRect.GetComponent<Animation>().Stop("nec_text_pop");
        necRect.GetComponent<Animation>().Play("nec_text_pop");
    }     
    
    void NecCollectionTooltip(RectTransform necRect, string descText)
    {
        collectionDesc.text = descText;

        // POS X
        float proportionx = TapPosition().x / Screen.width;
        float anchorXMin = proportionx - 0.25f;
        if (anchorXMin < 0)
            anchorXMin = 0;
        else if (anchorXMin > .5f)
            anchorXMin = .5f;
        float anchorXMax = anchorXMin + 0.5f;

        // POS Y
        float proportiony = TapPosition().y / Screen.height;
        float offsetY = 0.2f;
        float anchorYMin = proportiony - 0.15f + offsetY;
        float anchorYMax = proportiony + offsetY;

        necRect.anchorMin = new Vector2(anchorXMin, anchorYMin);
        necRect.anchorMax = new Vector2(anchorXMax, anchorYMax);

        necRect.offsetMin = new Vector2(0, 0);
        necRect.offsetMax = new Vector2(0, 0);

        necRect.GetComponent<Animation>().Stop("nec_text_pop");
        necRect.GetComponent<Animation>().Play("nec_text_pop");
    }


    Vector2 TapPosition()
    {
        Vector2 tapPos = new Vector2(0, 0);

        if (Application.isEditor)
            tapPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        else
        {
            if (Input.touchCount > 0)
                tapPos = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
        }

        return tapPos;

    }
}
