using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paddingDistance : MonoBehaviour
{
    // Start is called before the first frame update
    float refWidth = 1440f;
    public float paddingLeft;
    public float paddingRight;
    public float spacing;

    void Start()
    {
        float widthProportion = Screen.width / refWidth;

        if (GetComponent < HorizontalLayoutGroup>())
        {

            GetComponent<HorizontalLayoutGroup>().padding.left = Mathf.CeilToInt(paddingLeft * widthProportion);
            GetComponent<HorizontalLayoutGroup>().padding.right = Mathf.CeilToInt(paddingRight * widthProportion);
            GetComponent<HorizontalLayoutGroup>().spacing = Mathf.CeilToInt(spacing * widthProportion);

        }

    }
}
