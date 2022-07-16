using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingBar_offset : MonoBehaviour
{
    bool toAnimate = true;
    public float offsetSpeed;
    Material imageMat;
    float offset = 0;

    void Start()
    {
        imageMat = GetComponent<Image>().material;
        //StartCoroutine(OffsetTile());
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        //while (toAnimate)
        //{
            //imageMat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            //offset += offsetSpeed;
            //Debug.Log(offset);
        //}

    }
    
    IEnumerator OffsetTile()
    {
        while (toAnimate)
        {
            //offset = Mathf.Lerp()
            imageMat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
            offset += offsetSpeed;
            //transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, Time.deltaTime * offsetSpeed);
            //Debug.Log(offset);
            yield return null;
        }


        yield return null;

    }

}
