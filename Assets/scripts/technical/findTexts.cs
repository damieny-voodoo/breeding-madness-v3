using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class findTexts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text[] myItems = FindObjectsOfType(typeof(Text)) as Text[];
        foreach (Text item in myItems)
        {
            Debug.Log("Found UI text with name: " + item.name);
        }
        TextMesh[] myTextMeshs = FindObjectsOfType(typeof(TextMesh)) as TextMesh[];
        foreach (TextMesh item in myTextMeshs)
        {
            Debug.Log("Found Text Mesh with name: " + item.name);
        }
    }


}
