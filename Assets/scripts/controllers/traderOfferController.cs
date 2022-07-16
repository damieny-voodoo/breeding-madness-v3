using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class traderOfferController : MonoBehaviour
{

    /// /////////////////////////////////////////////////////////// OBSOLETE ///////////////////////////////////////////////////////////
    /*


    [Header("REQUIREMENTS ------------")]
    public string itemRequired;
    public int itemAmountRequired;
    public TextMeshProUGUI itemRequiredText;

    [Header("REWARDS ------------")]
    public GameObject rewardBox;
    public int rewardAmount;
    public TextMeshProUGUI rewardAmountText;

    [Header("PURCHASE ------------")]
    public Image purchaseButton;

    [Header("MISC ------------")]
    public Image backgroundImage;

    [Header("COLORS ------------")]
    public Color backgroundColor_tradable;
    public Color backgroundColor_notTradable;

    public Color buttonColor_tradable;
    public Color buttonColor_notTradable;

    public Color textColor_tradable;
    public Color textColor_notTradable;
    public bool canTrade;




    // Update is called once per frame
    public void UpdateOffer()
    {
        
        //GameObject tradedItem = ItemToTrade();
        int found = itemsFound();
        itemRequiredText.text = found.ToString() + "/" + itemAmountRequired.ToString();
        rewardAmountText.text = "x" + rewardAmount.ToString();


        if (found >= itemAmountRequired)
        {
            canTrade = true;
            backgroundImage.color = backgroundColor_tradable;
            purchaseButton.color = buttonColor_tradable;
            itemRequiredText.color = textColor_tradable;
        }

        else
        {
            canTrade = false;
            backgroundImage.color = backgroundColor_notTradable;
            purchaseButton.color = buttonColor_notTradable;
            itemRequiredText.color = textColor_notTradable;

        }

    }

    public void PurchaseOffer()
    {
        if (canTrade)
        {
            ////////// init data
            int currentTradePurchased = 0;
            currentTradePurchased = PlayerPrefs.GetInt("currentTradePurchased");
            GameObject instantiatedBox = null;

            ////////// give
            for (int i =0;i< itemAmountRequired; i++)
                ItemToTrade().GetComponent<itemController>().DestroyItem(false);

            ////////// get
            for (int i = 0; i < rewardAmount; i++)
            {
                /// ----- pool section
                //instantiatedBox = Instantiate(rewardBox, transform.position, transform.rotation) as GameObject;
                //instantiatedBox = ObjectPool.SharedInstance.GetPooledObject("quickSellFeedback");
                //instantiatedBox.SetActive(true);
                /// ----- pool section

                /////////// CHECK TUTORIAL
                if (currentTradePurchased == 1)
                    instantiatedBox.GetComponent<boxController>().ShowTuto();
            }

           // GameObject instantiatedCoin = Instantiate(prefab, spawnPoint.position, transform.rotation) as GameObject;
            ClosePopup();

            GameObject.Find("gameProperties").GetComponent<saveManager>().SaveTradePurchased(currentTradePurchased + 1);

            

        }


    }


    void ClosePopup()
    {

        GameObject.Find("gameProperties").GetComponent<tradeOfferManager>().ClosePopup();


    }


    void CheckTutorial(GameObject instantiatedBox)
    {

        int currentTradePurchased = PlayerPrefs.GetInt("currentTradePurchased");
        if(currentTradePurchased == 1)
        {
            instantiatedBox.GetComponent<boxController>().ShowTuto();

        }


    }


    GameObject ItemToTrade()
    {
        
        GameObject item = null;

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            string itemId = go.GetComponent<itemController>().itemFamily + "_" + go.GetComponent<itemController>().itemTier.ToString();
            if (itemId == itemRequired)
                item = go;

        }

        return item;

    }

    int itemsFound()
    {
        int found = 0;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            string itemId = go.GetComponent<itemController>().itemFamily + "_" + go.GetComponent<itemController>().itemTier.ToString();
            if (itemId == itemRequired)
            {
                found++;
            }

        }

        return found;
    }

    */
}
