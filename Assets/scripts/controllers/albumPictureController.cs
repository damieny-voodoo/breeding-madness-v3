using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class albumPictureController : MonoBehaviour
{
    public GameObject questionMark;
    public Image itemImage;
    public Image itemBg;
    public int familyID;
    public string family;
    public int tier;
    public Color imageLocked;
    public Color bgColorLocked;
    public Color bgColorUnlocked;


  

    public void SetImageUnlocked()
    {
        questionMark.SetActive(false);
        itemBg.color = bgColorUnlocked;
        itemImage.color = Color.white;
    }

    public void SetImageLocked()
    {
        questionMark.SetActive(true);
        questionMark.transform.eulerAngles = new Vector3(70, 0, Random.Range(-10, 10));
        itemBg.color = bgColorLocked;
        itemImage.color = imageLocked;
    }
}
