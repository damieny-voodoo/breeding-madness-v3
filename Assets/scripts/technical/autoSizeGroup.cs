using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoSizeGroup : MonoBehaviour
{

    //public TMP_Text texts;


    // Start is called before the first frame update
    void Start()
    {

       // GetComponent<TextMeshProUGUI>().enableAutoSizing = true;
       // GetComponent<TextMeshProUGUI>().ForceMeshUpdate();
        float optimumPointSize = GetComponent<TMP_Text>().fontSize;
        GetComponent<TextMeshProUGUI>().enableAutoSizing = false;
        GetComponent<TextMeshProUGUI>().fontSize = optimumPointSize;
        /*
        // Iterate over all other text objects to set the point size
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i].enableAutoSizing = true;
            texts[i].ForceMeshUpdate();
            texts[i].enableAutoSizing = false;
        }
        */

    }

}
