using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petTap : MonoBehaviour
{
    public GameObject infoPopup;
    petController petController;
    tapManager tapManager;

    private void Start()
    {
        infoPopup = GameObject.Find("infoPopup");
        petController = transform.parent.GetComponent<petController>();
        tapManager = GameObject.Find("gameProperties").GetComponent<tapManager>();
    }

    private void OnMouseDown()
    {
        // TAP BEHAVIOR
        if(!tapManager.popupOpen)
            petController.TapPet();
    }
}
