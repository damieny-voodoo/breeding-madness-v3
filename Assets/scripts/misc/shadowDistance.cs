using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shadowDistance : MonoBehaviour
{

    float refWidth = 1440f;
    float refHeight = 2960;
    public Vector2 effectDistance;

    void Start()
    {
        float widthProportion = Screen.width / refWidth;
        float heightProportion = Screen.height / refHeight;

        if (GetComponent<Shadow>())
            GetComponent<Shadow>().effectDistance = new Vector2( effectDistance.x* widthProportion, effectDistance.y* heightProportion);

    }

    
}
