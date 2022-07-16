using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoSizeText : MonoBehaviour
{
    public bool deactivateScript;
    public bool autoSizeAtStart;
    TextMeshProUGUI uiText;
    TextMeshPro worldText;

    public GameObject parentObject;
    public bool debug;


    // Start is called before the first frame update
    void Start()
    {

        if (autoSizeAtStart)
            RedoFontSize();

    }

    // Update is called once per frame
    public void RedoFontSize()
    {
        if (debug)
            Debug.Log("redo size of "+gameObject.name);
        if (!deactivateScript)
        {
            if (GetComponent<TextMeshProUGUI>())
            {
                uiText = GetComponent<TextMeshProUGUI>();
                uiText.enableAutoSizing = true;
                uiText.ForceMeshUpdate(true);
                float textSize = uiText.fontSize;
                if (debug)
                    Debug.Log("Text size: " + textSize);
                uiText.enableAutoSizing = false;
                uiText.fontSize = textSize;
                if (parentObject)
                {
                    parentObject.SetActive(false);
                    parentObject = null;
                }
            }

        }

    }
}
