using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class picturePosition : MonoBehaviour
{
    public float widthPercent;
    public float heightOffset;


    void Start() 
    {
        float totalWidth = Screen.width * widthPercent;
        float totalHeight = totalWidth * (4032 / 1960);
        float thisHeightOffset = Screen.width * heightOffset;
        GetComponent<RectTransform>().offsetMin = new Vector2(-totalWidth/2, -totalHeight/2 + thisHeightOffset);
        GetComponent<RectTransform>().offsetMax = new Vector2(totalWidth/2, totalHeight/2 + thisHeightOffset);

        float width = totalWidth/2;
        float height = totalHeight/4;
        Vector2 gridSize = new Vector2(width, height);
        GetComponent<GridLayoutGroup>().cellSize = gridSize;

    }

}
