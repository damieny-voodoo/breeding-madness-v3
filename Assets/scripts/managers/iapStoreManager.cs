using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class iapStoreManager : MonoBehaviour
{

    iapBalancing iapBalancing;
    resourcesManager resourcesManager;
    adManager adManager;
    tutorialManager tutorialManager;
    feedbackManager feedbackManager;
    saveManager saveManager;
    tapManager tapManager;
    xpManager xpManager;
    notificationManager notificationManager;
    localizerManager localizerManager;
    localizationData localizationData;
    iapManager iapManager;
    public GameObject storePopup;
    public RectTransform contentPanel;
    public TextMeshProUGUI logText;

    public Color diamondsOk;
    public Color diamondsNotOk;

    [Header("IAPS ------------")]
    Vector2 lastTapPosition;
    public TextMeshProUGUI[] iapsPrices;
    public TextMeshProUGUI[] iapsRewards;
    public TextMeshProUGUI[] iapsPricesPopup;
    public TextMeshProUGUI[] iapsRewardsPopup;
    public Image[] iapsImages;

    [Header("ENERGY ------------")]
    public TextMeshProUGUI[] energyPrices;
    public TextMeshProUGUI[] energyRewards;
    public Image[] energyImages;

    public TextMeshProUGUI energyPopupPrice;
    public TextMeshProUGUI energyPopupReward;

    [Header("FERTILIZER ------------")]
    public TextMeshProUGUI[] fertilizerPrices;
    public TextMeshProUGUI[] fertilizerRewards;
    public TextMeshProUGUI[] fertilizerPricesPopup;
    public TextMeshProUGUI[] fertilizerRewardsPopup;
    public Image[] fertilizerImages;

    [Header("FREE ENERGY ------------")]
    // AVAILABILITY
    public bool freeEnergyAvailable = false;
    public bool popupIsOpen;
    // BUTTONS
    public GameObject freeEnergyButtonOn;
    public GameObject freeEnergyButtonOff;
    public GameObject freeEnergyButtonAdOn;
    public GameObject freeEnergyButtonAdOff;
    // NOTIFS
    public GameObject freeEnergyNotifMain;
    public GameObject freeEnergyNotifCard;
    // TIME
    public GameObject timeLeftObject;
    public TextMeshProUGUI timeLeftText;
    int nextFreeEnergyTime;
    public int nextFreeEnergyTimeLeft;
    

    GameObject gameProperties;

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// INIT
    private void Awake()
    {

        saveManager = GetComponent<saveManager>();
    }


    public void InitializeStore()
    {
        gameProperties = GameObject.Find("gameProperties");
        iapManager = GetComponent<iapManager>();
        resourcesManager = GetComponent<resourcesManager>();
        adManager = GetComponent<adManager>();
        feedbackManager = GetComponent<feedbackManager>();
        tutorialManager = GetComponent<tutorialManager>();
        tapManager = GetComponent<tapManager>();
        xpManager = GetComponent<xpManager>();
        notificationManager = GetComponent<notificationManager>();
        localizerManager = GetComponent<localizerManager>();
        localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();
        iapBalancing = GameObject.Find("balancingData").GetComponent<iapBalancing>();

        InitIaps();
        InitEnergy();
        InitFertilizer();
        InitFreeEnergy();

    }


    void InitIaps()
    {
        /*
        int tmpIndex = 0;
        foreach (var item in iapManager.m_StoreController.products.all)
        {
            iapsPrices[tmpIndex].text = item.metadata.localizedPriceString;
            iapsPricesPopup[tmpIndex].text = item.metadata.localizedPriceString;

            iapsPrices[tmpIndex].GetComponent<autoSizeText>().RedoFontSize();
            iapsPricesPopup[tmpIndex].GetComponent<autoSizeText>().RedoFontSize();

            iapsRewards[tmpIndex].text = iapBalancing.iap_rewards[tmpIndex].ToString();
            iapsRewardsPopup[tmpIndex].text = iapBalancing.iap_rewards[tmpIndex].ToString();

            iapsRewards[tmpIndex].GetComponent<autoSizeText>().RedoFontSize();
            iapsRewardsPopup[tmpIndex].GetComponent<autoSizeText>().RedoFontSize();

            tmpIndex++;
        }
        */

    }

    void InitEnergy()
    {
        for( int i =0;i< energyPrices.Length; i++)
        {
            if (i != 0)
            {
                energyPrices[i].text = iapBalancing.energy_prices[i].ToString();
                energyPrices[i].GetComponent<autoSizeText>().RedoFontSize();
            }
            energyRewards[i].text = iapBalancing.energy_rewards[i].ToString();
            energyRewards[i].GetComponent<autoSizeText>().RedoFontSize();
            // PUT IMAGES
        }

        energyPopupPrice.text = iapBalancing.energy_prices[3].ToString();
        energyPopupPrice.GetComponent<autoSizeText>().RedoFontSize();
        energyPopupReward.text = "+"+ iapBalancing.energy_rewards[3].ToString();
        energyPopupReward.GetComponent<autoSizeText>().RedoFontSize();

    }

    void InitFertilizer()
    {
        for (int i = 0; i < fertilizerPrices.Length; i++)
        {
            fertilizerPrices[i].text = iapBalancing.fertilizer_prices[i].ToString();
            fertilizerRewards[i].text = iapBalancing.fertilizer_rewards[i].ToString();
            fertilizerPricesPopup[i].text = iapBalancing.fertilizer_prices[i].ToString();
            fertilizerRewardsPopup[i].text = iapBalancing.fertilizer_rewards[i].ToString();
            // PUT IMAGES
        }
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PURCHASE
    public void TryPurchase( iapStoreController productDef)
    {
        if (productDef.productType == "iap")
            TryPurchaseIap(productDef.productIndex);

        else if (productDef.productType == "energy")
            TryPurchaseEnergy(productDef.productIndex);

        else if (productDef.productType == "fertilizer")
            TryPurchaseFertilizer(productDef.productIndex);

    }

    void TryPurchaseIap(int productIndex)
    {
        lastTapPosition = TapPosition();
        //GetComponent<iapManager>().BuyProductID(productIndex);
    }

    public void ConfirmIapPurchase( int productIndex)
    {
        int diamondReward = iapBalancing.iap_rewards[productIndex];

        Vector2 pos = new Vector2(lastTapPosition.x / Screen.width, lastTapPosition.y / Screen.height);
        feedbackManager.UiReward(diamondReward, pos, "diamonds", "iapPurchase");
        logText.text += "Diamonds added: " + diamondReward + "\n";
    }

    void TryPurchaseEnergy(int productIndex)
    {
        int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
        int diamondPrice = iapBalancing.energy_prices[productIndex];
        int energyReward = iapBalancing.energy_rewards[productIndex];

        if (productIndex == 0)
            GetFreeEnergy(productIndex);
        else
        {

            if (diamondPrice <= currentDiamonds)
            {
                //Debug.Log("Enough diamonds to pruchase energy");
                Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
                feedbackManager.UiReward(energyReward, pos, "energy", "iapPurchase");
                resourcesManager.SpendDiamonds("energy", diamondPrice);
            }
            else
            {
                GetComponent<necManager>().ShowNec("diamonds");
            }

        }
    }

    void TryPurchaseFertilizer(int productIndex)
    {
        int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
        int diamondPrice = iapBalancing.fertilizer_prices[productIndex];
        int fertilizerReward = iapBalancing.fertilizer_rewards[productIndex];

        if (diamondPrice <= currentDiamonds)
        {
            Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
            feedbackManager.UiReward(fertilizerReward, pos, "fertilizer", "iapPurchase");
            resourcesManager.SpendDiamonds("fertilizer", diamondPrice);
        }
        else
        {
            GetComponent<necManager>().ShowNec("diamonds");            
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FREE ENERGY
    void InitFreeEnergy()
    {
        // START TIMER
        StartCoroutine(CheckFreeEnergyRoutine());

        // Set as not available
        freeEnergyAvailable = false;

        // UI
        UpdateFreeEnergy(false);

        // TIME LEFT
        nextFreeEnergyTime = saveManager.GetSavedInt("nextFreeEnergyTime");
    }



    IEnumerator CheckFreeEnergyRoutine()
    {
        // GET TIME
        while (!freeEnergyAvailable)
        {

            //////////////////// ENABLE FREE ENERGY
            if (TimeNow() > nextFreeEnergyTime)
            {
                // ENABLE
                freeEnergyAvailable = true;
                // UI
                UpdateFreeEnergy(true);
            }

            ////////// FEEDBACK WHEN DISABLED
            else
            {
                // TIMER FEEDBACK
                if (popupIsOpen)
                {
                    nextFreeEnergyTimeLeft = nextFreeEnergyTime - TimeNow();
                    string timeString = TimeLeft(nextFreeEnergyTimeLeft);
                    timeLeftText.text = timeString;
                    timeLeftText.GetComponent<autoSizeText>().RedoFontSize();
                }

            }

             yield return new WaitForSeconds(3);
        }

    }

    public void GetFreeEnergy(int productIndex)
    {

        // UPDATE TIMER
        nextFreeEnergyTime = TimeNow() + iapBalancing.freeEnergyTimer;
        freeEnergyAvailable = false;
        SaveNextFreeEnergy(nextFreeEnergyTime);

        // UPDATE UI
        UpdateFreeEnergy(false);

        // RESTART TIMER
        StartCoroutine(CheckFreeEnergyRoutine());

        // GIVE RESOURCES
        int energyReward = iapBalancing.energy_rewards[productIndex];
        Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
        feedbackManager.UiReward(energyReward, pos, "energy", "freeEnergy");

        //NOTIFICATION
        //notificationManager.LaunchFreeEnergyNotification();

    }

    public void NoFreeEnergy()
    {

    }

    void UpdateFreeEnergy(bool enabled)
    {

        // BUTTONS
        if (enabled)
        {
            bool isAdActive = adManager.IsAdAvailable("energyAdShop");
            if (isAdActive)
            {
                freeEnergyButtonAdOn.SetActive(true);

                freeEnergyButtonOn.SetActive(false);
                freeEnergyButtonOff.SetActive(false);
                freeEnergyButtonAdOff.SetActive(false);
            }
            else
            {
                freeEnergyButtonAdOff.SetActive(true);

                freeEnergyButtonOn.SetActive(false);
                freeEnergyButtonOff.SetActive(false);
                freeEnergyButtonAdOn.SetActive(false);
            }
        }
        else
        {
            freeEnergyButtonOff.SetActive(true);
            freeEnergyButtonOn.SetActive(false);
            freeEnergyButtonAdOn.SetActive(false);
            freeEnergyButtonAdOn.SetActive(false);
        }

        // NOTIFICATIONS
        CheckNotifs();

        // TIME LEFT
        timeLeftObject.SetActive(!enabled);

    }

    public void CheckNotifs()
    {
        int currentLevel = xpManager.currentLevel;
        if (currentLevel >= 3)
        {
            bool isAdActive = adManager.IsAdAvailable("energyAdShop");
            if ( freeEnergyAvailable && isAdActive)
            {
                freeEnergyNotifMain.SetActive(true);
                freeEnergyNotifCard.SetActive(true);
            }
            else
            {
                freeEnergyNotifMain.SetActive(false);
                freeEnergyNotifCard.SetActive(false);
            }
        }

    }

    int TimeNow()
    {
        var newUnixTime = (System.DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        int unixTimeInt = Convert.ToInt32(newUnixTime);
        return unixTimeInt;
    }

    string TimeLeft( int time)
    {
        string timeString = "";
        int currentLanguage = saveManager.GetSavedInt("currentLanguage");
        //TIMES
        int hourTime = Mathf.FloorToInt(time / 3600*1f);
        int minutesTime = Mathf.FloorToInt((time -(hourTime*3600))/60);
        int secondsTime = time - (hourTime * 3600) - minutesTime * 60;

        // LOCAS
        string hours = localizerManager.LocalizedText(198);
        string minutes = localizerManager.LocalizedText(121);
        string seconds = localizerManager.LocalizedText(82);

        // Time bigger than 1 hour
        if (time > 3600)
            timeString = hourTime + hours + " " + minutesTime + minutes; // 2h32min
        // Time bigger than 
        else if (time > 60)
            timeString = minutesTime + minutes + " " + secondsTime + seconds; // 32 min
        else
            timeString = secondsTime + " " + seconds; // 47 sec

        return timeString;
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// POPUP
    public void ShowPopup()
    {
        if (TutorialOk())
        {
            storePopup.GetComponent<Animation>().Play("store_popup_open");
            storePopup.GetComponent<GraphicRaycaster>().enabled = true;
            tapManager.OpenPopup();
            popupIsOpen = true;
            //contentPanel.offsetMin = new Vector2(0, 0);
            //contentPanel.offsetMax = new Vector2(0, 0);
        }

    }
    public void HidePopup()
    {

        storePopup.GetComponent<Animation>().Play("store_popup_close");
        storePopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();
        popupIsOpen = false;

    }

    public void CheckDiamondsColors()
    {
        int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
        if(!iapBalancing)
            iapBalancing = GameObject.Find("balancingData").GetComponent<iapBalancing>();

        /// ENERGY GROUP
        for (int i = 0; i < energyPrices.Length; i++)
        {
            if (currentDiamonds >= iapBalancing.energy_prices[i])
                energyPrices[i].color = diamondsOk;
            else
                energyPrices[i].color = diamondsNotOk;
        }


        /// FERTILIZER GROUP
        for (int i = 0; i < fertilizerPrices.Length; i++)
        {
            if (currentDiamonds >= iapBalancing.fertilizer_prices[i])
                fertilizerPrices[i].color = diamondsOk;
            else
                fertilizerPrices[i].color = diamondsNotOk;
        }

        /// ENERGY POPUP
        if (currentDiamonds >= iapBalancing.energy_prices[0])
            energyPrices[0].color = diamondsOk;
        else
            energyPrices[0].color = diamondsNotOk;


    }

    Vector2 TapPosition()
    {
        Vector2 tapPos = new Vector2(0, 0);

        if (Application.isEditor)
            tapPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        else
        {
            if (Input.touchCount > 0)
                tapPos = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
        }

        return tapPos;

    }
    bool TutorialOk()
    {
        bool tutorialOk = true;

        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
            tutorialOk = false;


        return tutorialOk;


    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveNextFreeEnergy( int time)
    {
        saveManager.SaveInt("nextFreeEnergyTime", time);

    }
}
