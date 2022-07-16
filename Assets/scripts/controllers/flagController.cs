using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagController : MonoBehaviour
{
    public GameObject flagOutline;



    public void SelectLanguage()
    {
        flagOutline.SetActive(true);
        GetComponent<Animation>().Play("selectFlag");
    }

    public void UnselectLanguage()
    {

        flagOutline.SetActive(false);

    }
}
