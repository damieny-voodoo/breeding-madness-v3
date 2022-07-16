using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tradeOfferManager : MonoBehaviour
{
    /*
    /// <summary>
    /// ///////////////////////////////////////////////////////////////////// OBSOLETE /////////////////////////////////////////////////////////////////////
    /// </summary>
    public GameObject traderPopup;
    public GameObject[] orderList;
    public GameObject tutorialOffer;




    public void OpenPopup()
    {

        ////////////////////////// OPEN
        GetComponent<tapManager>().popupOpen = true;
        traderPopup.GetComponent<Animation>().Play("album_popup_open");        
        traderPopup.SetActive(true);


        ////////////////////////// UPDATE OFFER
        foreach (GameObject go in orderList)
            go.GetComponent<traderOfferController>().UpdateOffer();


        ////////////////////////// CHECK TUTORIAL
        CheckTutorial();


        ////////////////////////// SHOW HIDE TUTORIAL OFFER
        int currentTradePurchased = PlayerPrefs.GetInt("currentTradePurchased");
        if (currentTradePurchased == 0)
        {
            orderList[0].SetActive(false);
            tutorialOffer.SetActive(true);
            tutorialOffer.GetComponent<traderOfferController>().UpdateOffer();
        }
        else
        {
            orderList[0].SetActive(true);
            tutorialOffer.SetActive(false);
        }
    }


    public void ClosePopup()
    {

        GetComponent<tapManager>().popupOpen = false;
        traderPopup.GetComponent<Animation>().Play("album_popup_close");
    }

    void CheckTutorial()
    {
        int currentTradePurchased = PlayerPrefs.GetInt("currentTradePurchased");
        //Debug.Log("Trader purchased: " + currentTradePurchased);

        if(currentTradePurchased == 0)
        {
            GetComponent<tutorialManager>().ShowTuto(8, false);
            GetComponent<tutorialManager>().HideTuto(6);
        }
       // else
         //   GetComponent<tutorialManager>().HideTuto(7);


    }
    */
}
