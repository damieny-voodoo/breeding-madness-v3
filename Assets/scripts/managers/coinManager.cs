using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coinManager : MonoBehaviour
{
    //public pictureBalancing pictureBalancing;
    public tileBalancing tileBalancing;
    public analyticsManager analyticsManager;
    public int currentCoins;
    public TextMeshProUGUI coinsText;
    public GameObject coinFX;
    public GameObject topPanel;
    gridController grid0;
    //gridController grid1;

    //tapManager tapManager;
    tutorialManager tutorialManager;
    saveManager saveManager;
    GameObject balancingData;
    GameObject gameProperties;

    public Color priceNotOk;
    public Color priceOk;




    void Awake()
    {
        grid0 = GameObject.Find("grid0").GetComponent<gridController>();
        //grid1 = GameObject.Find("grid1").GetComponent<gridController>();
        gameProperties = GameObject.Find("gameProperties");
        balancingData = GameObject.Find("balancingData");
        tutorialManager = gameProperties.GetComponent<tutorialManager>();
        saveManager = gameProperties.GetComponent<saveManager>();
        tileBalancing = balancingData.GetComponent<tileBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();

        AddCoins(0);

    }


    public void AddCoins(int coinsToAdd)
    {
        ///////////////////////////////////// SAVE COINS
        int coinSaved = saveManager.GetSavedInt("currentCoins");
        currentCoins = coinsToAdd + coinSaved;
        SaveCoins(currentCoins);


        ///////////////////////////////////// UI
        UpdateUI();

        ///////////////////////////////////// UPDATE PRICES TEXTS
        //CheckPicturePrices(coinSaved, currentCoins);
        //CheckTilesPrices(coinSaved, currentCoins);

        ///////////////////////////////////// CHECK NOTIFICATION
        //GetComponent<pictureManager>().UpdateNotification();


        ///////////////////////////////////// ANIM
        coinsText.GetComponent<Animation>().Stop("rewardText_anim");
        coinsText.GetComponent<Animation>().Play("rewardText_anim");


        ///////////////////////////////////// FX
        if (coinsToAdd > 0)
        {
            GameObject instantiatedFeedback = Instantiate(coinFX, topPanel.transform.position, topPanel.transform.rotation) as GameObject;
            instantiatedFeedback.transform.SetParent(topPanel.transform);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
        }


        ///////////////////////////////////// CHECK DECORATIONS
        //if(coinsToAdd>0)
        //GetComponent<gardenManager>().CheckPurchasable();



        ///////////////////////////////////// CHECK TUTORIAL
        CheckTutorial();

    }


    void CheckTutorial()
    {
        /*
        int firstDecoPrice = balancingData.GetComponent<gardenData>().unlockPrice[0];
        if (firstDecoPrice <= currentCoins && saveManager.GetSavedInt("decorationState_0") == 0)
        {
            analyticsManager.ContinueFunnel("mainTutorial", "enoughMoney");
            tutorialManager.ShowTuto(5, true);
        }
        */


    }
    public void SpendCoins (int coinsToAdd)
    {
        int coinSaved = saveManager.GetSavedInt("currentCoins");
        currentCoins = coinSaved - coinsToAdd;
        SaveCoins(currentCoins);

        ///////////////////////////////////// UI
        UpdateUI();

        ///////////////////////////////////// UPDATE PRICES TEXTS
        //CheckPicturePrices(coinSaved, currentCoins);
        CheckTilesPrices(coinSaved, currentCoins);

        ///////////////////////////////////// CHECK NOTIFICATION
        //GetComponent<pictureManager>().UpdateNotification();

        ///////////////////////////////////// CHECK DECORATIONS
        //GetComponent<gardenManager>().CheckPurchasable();

    }

    
    public void CheckTilesPrices(int oldCoins, int newCoins)
    {
        grid0.CheckTilesPrices();
        //grid1.CheckTilesPrices();

    }

    void UpdateUI()
    {

        coinsText.text = currentCoins.ToString();

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    
    void SaveCoins(int coins)
    {
        saveManager.SaveInt("currentCoins", coins);
    }    
    void SaveFirstCoinGiven()
    {
        saveManager.SaveInt("isFirstCoinGiven", 1);
    }

}
