using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderItemTap : MonoBehaviour
{
    public int orderId;
    public GameObject orderParent;
    public GameObject infoPopup;

    [Header("ITEM INFO ------------")]
    public string itemFamily;
    public int itemTier;

    private void Awake()
    {
        infoPopup = GameObject.Find("infoPopup");
    }

    void OnMouseDown()
    {

        Debug.Log("Tapped order of " + orderParent.name + ", item " + orderId);
        GetItemInfo();

        infoPopup.GetComponent<infoPopupController>().ShowPopup(itemFamily, itemTier);

    }

    void GetItemInfo()
    {
        itemFamily = transform.parent.parent.parent.GetComponent<petController>().currentFoodFamily;
        itemTier = transform.parent.parent.parent.GetComponent<petController>().currentFoodTier;

    }


}
