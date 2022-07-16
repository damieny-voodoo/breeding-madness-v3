using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popupTextAndScaleManager : MonoBehaviour
{

    public autoSizeText[] textsToAutoSize;
    public Vector3 popupTargetScale;


    // Start is called before the first frame update
    void Start()
    {
        DoIt();
    }

    // Update is called once per frame
    void DoIt()
    {
        foreach (autoSizeText t in textsToAutoSize)
            t.RedoFontSize();

        //transform.localScale = popupTargetScale;
        
    }
}
