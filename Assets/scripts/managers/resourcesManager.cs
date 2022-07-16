using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class resourcesManager : MonoBehaviour
{
    [Header("COMMON ---------------------------------------------")]
    public int currentLanguage;
    public GameObject topPanel;
    public TextMeshProUGUI logText;
    public Color priceOk;
    public Color priceNotOk;

    [Header("ENERGY ---------------------------------------------")]
    //// CURRENT STATE
    public int maxEnergy;
    public int energyRefreshRate;
    public int currentEnergy;
    public int timeToMaxEnergy;
    public int timeLeftToMax;
    public int timeNow;
    public bool energyIsOverflow;
    bool energyFirstInit = false;

    public TextMeshProUGUI energyLeft;
    public TextMeshProUGUI timeToNextEnergyText;
    public GameObject energyFx;

    [Header("NO ENERGY POPUP")]
    public GameObject noEnergyPopup;
    // GROUPS
    public GameObject adAvailableGroup;
    public GameObject noAdAvailableGroup;
    // BUTTON 1
    public TextMeshProUGUI waitText1;
    public TextMeshProUGUI waitText2;
    // BUTTON 2
    public TextMeshProUGUI adRewardText;
    public GameObject adAvailablePanel;
    public GameObject adNotAvailablePanel;
    // BUTTON 3
    public TextMeshProUGUI noEnergyReward1;
    public TextMeshProUGUI noEnergyReward2;
    public TextMeshProUGUI energyPriceText1;
    public TextMeshProUGUI energyPriceText2;

    [Header("ENERGY AD CONFIRMATION POPUP")]
    public GameObject adConfirmationPopup;
    public TextMeshProUGUI confirmationRewardText;


    [Header("WATER ---------------------------------------------")]
    public int currentWater;
    public TextMeshProUGUI waterText;
    public GameObject waterFX;

    [Header("SUN ---------------------------------------------")]
    public int currentSun;
    public TextMeshProUGUI sunText;
    public GameObject sunFX;



    [Header("DIAMONDS ---------------------------------------------")]
    public int currentDiamonds;
    public TextMeshProUGUI diamondsText;
    public GameObject diamondsFX;

    [Header("DIAMONDS POPUP")]
    public GameObject noDiamondPopup;



    [Header("SEEDS ---------------------------------------------")]
    //// POPUP
    public RectTransform necFertilizer;
    public Image spawnerIcon;
    public int[] noSeedTextId;
    int currentSeedSelected;
    int currentSpawnerId;

    [Header("NO SEED POPUP")]
    public GameObject noSeedsPopup;
    public TextMeshProUGUI noSeedsRefill1AmountText;
    public TextMeshProUGUI noSeedsRefillAdAmountText;
    public TextMeshProUGUI noSeedsRefill1PriceText;
    public GameObject adButtonOn;
    public GameObject adButtonOff;
    public TextMeshProUGUI noSeedsDescText;
    public TextMeshProUGUI noSeedsWaitText;
    public TextMeshProUGUI noSeedsFullRefillAmountText;
    public TextMeshProUGUI noSeedsFullRefillPriceText;
    public GameObject refill1Panel;
    public GameObject refillAdPanel;

    //// 3D UI
    public TextMeshPro[] seedsLeftText;
    public GameObject[] seedsRefillBar;

    [Header("FERTILIZER ---------------------------------------------")]
    public int currentFertilizer;
    public TextMeshProUGUI fertilizerText;

    [Header("FERTILIZER POPUP")]
    public GameObject noFertilizerPopup;
    public TextMeshProUGUI[] noFertilizerPrices;



    //// BALANCING
    public int differentSeeds;
    public int[] seedsMax;
    public int[] refillPack1Amount;
    public int[] refillPack1Price;
    public int[] seedsFullRefillPrice;
    public int[] seedsRefill;
    public int[] seedsCurrent;
    public int[] seeds_timeToMax;
    public int[] seeds_timeLeftToMax;
    public int[] seeds_timeToNext;


    energyBalancing energyBalancing;
    resourcesBalancing resourcesBalancing;
    spawnerBalancing spawnerBalancing;
    iapBalancing iapBalancing;
    tapManager tapManager;
    tutorialManager tutoManager;
    saveManager saveManager;
    notificationManager notificationManager;
    localizerManager localizerManager;
    adManager adManager;
    analyticsManager analyticsManager;
    timeNowManager timeNowManager;
    localizationData localizationData;



    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// INIT
    private void Start()
    {
        /////////// GET COMPONENTS
        GameObject balancingData = GameObject.Find("balancingData");
        energyBalancing = balancingData.GetComponent<energyBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        timeNowManager = GetComponent<timeNowManager>();
        localizationData = balancingData.GetComponent<localizationData>();
        resourcesBalancing = balancingData.GetComponent<resourcesBalancing>();
        spawnerBalancing = balancingData.GetComponent<spawnerBalancing>();
        iapBalancing = balancingData.GetComponent<iapBalancing>();
        tutoManager = GetComponent<tutorialManager>();
        saveManager = GetComponent<saveManager>();
        tapManager = GetComponent<tapManager>();
        localizerManager = GetComponent<localizerManager>();
        adManager = GetComponent<adManager>();
        notificationManager = GetComponent<notificationManager>();

        /////////// Update languages
        currentLanguage = saveManager.GetSavedInt("currentLanguage");
        timeToNextEnergyText.GetComponent<autoSizeText>().RedoFontSize();


        /////////// INITIATE ENERGY
        InitialEnergy();

        /////////// INITIATE SEEDS
        differentSeeds = resourcesBalancing.seedsMax.Length;
        seedsMax = new int[differentSeeds];
        // shop
        refillPack1Amount = new int[differentSeeds];
        refillPack1Price = new int[differentSeeds];
        seedsFullRefillPrice = new int[differentSeeds];

        seedsRefill = new int[differentSeeds];
        seedsCurrent = new int[differentSeeds];
        seeds_timeToMax = new int[differentSeeds];
        seeds_timeLeftToMax = new int[differentSeeds];
        seeds_timeToNext = new int[differentSeeds];
        noSeedTextId = new int[differentSeeds];
        for (int i = 0; i < differentSeeds; i++)
        {
            seedsMax[i] = resourcesBalancing.seedsMax[i];
            refillPack1Amount[i] = resourcesBalancing.refillPack1Amount[i];
            refillPack1Price[i] = resourcesBalancing.refillPack1Price[i];
            seedsFullRefillPrice[i] = resourcesBalancing.seedsFullRefillPrice[i];
            seedsRefill[i] = resourcesBalancing.seedsRefill[i];
            seeds_timeToMax[i] = saveManager.GetSavedInt("seed" + i.ToString() + "_timeToMax");
            noSeedTextId[i] = spawnerBalancing.noSeedTextId[i];
        }

        /////////// POPUP
        InitializeNoEnergyPopup();

        /////////// INITIATE FERTILIZER
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
            currentFertilizer = resourcesBalancing.startFertilizer;
        else
            currentFertilizer = saveManager.GetSavedInt("currentFertilizer");

        /////////// INITIATE FDIAMONDS
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
            currentDiamonds = resourcesBalancing.startDiamonds;
        else
            currentDiamonds = saveManager.GetSavedInt("currentDiamonds");

        /////////// INITIALIZE WATER
        AddWater(0);
        AddSun(0);
        AddFertilizer(0);
        AddDiamonds(0, "init");

    }


    void Update()
    {
        //timeNow = TimeNow();

        EnergyUpdate();

        for (int i = 0; i < differentSeeds; i++)
            SeedUpdate(i);

    }

    void CheckTutorial(string source)
    {
        /*
        if (source == "energy")
        {
            int energySpent = saveManager.GetSavedInt("energySpent");
            if (energySpent >= 2 && saveManager.GetSavedInt("currentMergeCount") == 0)
            {
                tutoManager.HideTuto(8);
                tutoManager.ShowTuto(2, true);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot2");
            }

            else if (energySpent == 3)
            {
                tutoManager.HideTuto(4);
                tutoManager.ShowTuto(9, true);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot3");
            }
            else if (energySpent == 4)
            {
                tutoManager.HideTuto(9);
                tutoManager.ShowTuto(10, true);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot4");
            }
            else if (energySpent == 5)
            {
                tutoManager.HideTuto(10);
                tutoManager.ShowTuto(11, true);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot5");
            }
            else if (energySpent == 6)
            {
                tutoManager.HideTuto(11);
                tutoManager.ShowTuto(12, true);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot6");
            }
            
            else if (energySpent == 7)
            {
                tutoManager.HideTuto(7);
                analyticsManager.ContinueFunnel("mainTutorial", "getCarrot7");
            }
            else if (GetComponent<tutorialManager>().currentTuto == 17)
            {
                analyticsManager.CompleteFunnel("mainTutorial");
                tutoManager.HideTuto(17);
                tutoManager.ShowTuto(18, true);
            }

        }
        */
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ENERGY
    void InitialEnergy()
    {
        timeToMaxEnergy = saveManager.GetSavedInt("timeToMaxEnergy");
        maxEnergy = energyBalancing.energyMax;
        energyRefreshRate = energyBalancing.energyRefillRate;

        if (saveManager.GetSavedInt("energyIsOverflow") == 0)
            energyIsOverflow = false;
        else
            energyIsOverflow = true;


        if (energyIsOverflow)
            AddEnergy(0);
    }
    
    void EnergyUpdate()
    {
        /////////////////////////////////////////////////// ENERGY
        int oldEnergy = currentEnergy;

        // CALCULATE TIME
        timeNow = timeNowManager.timeNow;
        timeLeftToMax = timeToMaxEnergy - timeNow;

        // CALCULATE ENERGY REGULAR
        if (!energyIsOverflow)
        {
            float leftFloat = timeLeftToMax * 1f;
            float refreshFloat = energyRefreshRate * 1f;
            int energySpent = Mathf.CeilToInt(leftFloat / refreshFloat);

            if (timeToMaxEnergy > timeNow)
                currentEnergy = maxEnergy - energySpent;
            else
                currentEnergy = maxEnergy;
        }

        // GET ENERGY ON OVERFLOW
        else
            currentEnergy = saveManager.GetSavedInt("currentOverflowEnergy");

        // TEXTS
        energyLeft.text = currentEnergy.ToString();
        int timeToNextEnergy = (timeLeftToMax) % energyRefreshRate;

        if (timeToNextEnergy == 0)
        {
            timeToNextEnergy = energyRefreshRate;
        }

        // NEXT ENERGY TEXT WITH LOCALIZATION
        if (currentEnergy < maxEnergy)
        {
            timeToNextEnergyText.text = localizerManager.LocalizedText(98) + timeToNextEnergy.ToString() + localizerManager.LocalizedText(99);
        }
        else
            timeToNextEnergyText.text = "";

    }



    public void SpendEnergy()
    {

        ////////////////////////////// CASE: ENERGY = MAX
        if (currentEnergy == maxEnergy)
        {
            timeNow = timeNowManager.timeNow;
            timeToMaxEnergy = timeNow + energyRefreshRate;
            energyIsOverflow = false;
            SaveEnergyOverflowBool(0);

            // RESIZE TEXTS
            timeToNextEnergyText.text = localizerManager.LocalizedText(98) + energyRefreshRate.ToString() + localizerManager.LocalizedText(99);
            //EnergyResize();
        }


        ////////////////////////////// CASE: ENERGY > MAX
        else if (currentEnergy > maxEnergy)
        {
            int newEnergy = saveManager.GetSavedInt("currentOverflowEnergy") - 1;
            SaveEnergyOverflow(newEnergy);
            SaveEnergyOverflowBool(1);
        }


        ////////////////////////////// CASE ENERGY < MAX
        else
        {
            timeToMaxEnergy = timeToMaxEnergy + energyRefreshRate;
            //notificationManager.LaunchNotification();
            SaveEnergyOverflowBool(0);
        }

        // Save
        SaveEnergy(timeToMaxEnergy);


        ////////////////////////////////////////////// TUTORIAL
        CheckTutorial("energy");


    }


    public void AddEnergy(int energyAdded)
    {
        ////////////////////////////////////////////// RECALCULATE TIME
        //Debug.Log("Add "+ energyAdded +" energy");
        timeToMaxEnergy = timeToMaxEnergy - (energyAdded * energyRefreshRate);
        timeLeftToMax -= energyAdded * energyRefreshRate;


        ////////////////////////////////////////////// ENERGY OVER MAX
        if (timeLeftToMax < 0 || energyIsOverflow)
        {
            //Debug.Log("Add energy overflow");
            if(energyIsOverflow)
                currentEnergy = saveManager.GetSavedInt("currentOverflowEnergy");
            energyIsOverflow = true;
            currentEnergy = currentEnergy + energyAdded;
            SaveEnergyOverflow(currentEnergy);
            SaveEnergyOverflowBool(1);
            notificationManager.CancelAllNotifications();
            //if (currentEnergy >= maxEnergy)
            //    EnergyResize();
        }


        ////////////////////////////////////////////// 
        else
        {
            SaveEnergy(timeToMaxEnergy);
            SaveEnergyOverflowBool(0);
            //notificationManager.UpdateEnergyNotification(timeLeftToMax);
        }

        ////////////////////////////////////////////// ANIM
        energyLeft.GetComponent<Animation>().Stop("rewardText_anim");
        energyLeft.GetComponent<Animation>().Play("rewardText_anim");
    }


    //////////// POPUP 

    void InitializeNoEnergyPopup()
    {

        bool isAdActive = adManager.energyAdRefillActive;
        int rewardedVideoEnergyReward = adManager.energyAdRefillAmount;

        //IF ENERGY AD IS ACTIVE
        if (isAdActive)
        {
            adAvailableGroup.SetActive(true);
            noAdAvailableGroup.SetActive(false);

            // WAIT TEXT
            waitText1.text = "99s";
            waitText1.GetComponent<autoSizeText>().RedoFontSize();

            // AD REWARD
            adRewardText.text = "+" + rewardedVideoEnergyReward.ToString();
            adRewardText.GetComponent<autoSizeText>().RedoFontSize();

            // BUY BUTTON
            noEnergyReward1.text = "+" + iapBalancing.energy_rewards[3].ToString();
            noEnergyReward1.GetComponent<autoSizeText>().RedoFontSize();
            // PRICE
            energyPriceText1.text = iapBalancing.energy_prices[3].ToString();
            energyPriceText1.GetComponent<autoSizeText>().RedoFontSize();

        }
        else
        {
            adAvailableGroup.SetActive(false);
            noAdAvailableGroup.SetActive(true);

            // WAIT TEXT
            waitText1.text = "99s";
            waitText1.GetComponent<autoSizeText>().RedoFontSize();

            // BUY BUTTON
            noEnergyReward2.text = "+" + iapBalancing.energy_rewards[3].ToString();
            noEnergyReward2.GetComponent<autoSizeText>().RedoFontSize();
            // PRICE
            energyPriceText2.text = iapBalancing.energy_prices[3].ToString();
            energyPriceText2.GetComponent<autoSizeText>().RedoFontSize();

        }



        // AD CONFIRMATION
        confirmationRewardText.text = rewardedVideoEnergyReward.ToString();
        confirmationRewardText.GetComponent<autoSizeText>().RedoFontSize();
        



    }

    public void ShowNoEnergyPopup()
    {
        // PRICE TEXT COLOR
        int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
        int diamondPrice = iapBalancing.energy_prices[3];

        bool isAdActive = adManager.energyAdRefillActive;

        //IF ENERGY AD IS ACTIVE
        if (isAdActive)
        {
            // BUTTON 1
            waitText1.text = WaitText();

            // BUTTON 2
            bool isAdAvailable = adManager.IsAdAvailable("energyAdRefill");
            adAvailablePanel.SetActive(isAdAvailable);
            adNotAvailablePanel.SetActive(!isAdAvailable);

            // BUTTON 3
            if (diamondPrice > currentDiamonds)
                energyPriceText1.color = priceNotOk;
            else
                energyPriceText1.color = priceOk;

        }

        //IF ENERGY AD IS NOT ACTIVE
        else if (!isAdActive)
        {
            // BUTTON 1
            waitText2.text = WaitText();

            // BUTTON 3
            if (diamondPrice > currentDiamonds)
                energyPriceText2.color = priceNotOk;
            else
                energyPriceText2.color = priceOk;

        }


        // OPEN
        noEnergyPopup.GetComponent<Animation>().Play("a_spawn");
        noEnergyPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();


    }

    public void CloseNoEnergyPopup(string closeSource)
    {
        // CLOSE

        // DO ANIM COSE 1
        if (closeSource == "wait")
        {
            noEnergyPopup.GetComponent<Animation>().Play("a_close_1");
            noEnergyPopup.GetComponent<GraphicRaycaster>().enabled = false;
            tapManager.ClosePopup();
        }

        // DO ANIM COSE 1
        else if (closeSource == "showAd")
        {
            adManager.ShowRewardedVideoAd("energyAdRefill");
        }
        // DO ANIM COSE 1
        else if (closeSource == "showNotAvailableAd")
        {
            //
        }

        // DO ANIM LOSE 3
        else if (closeSource == "premium")
        {
            noEnergyPopup.GetComponent<Animation>().Play("a_close_3");
            noEnergyPopup.GetComponent<GraphicRaycaster>().enabled = false;
            tapManager.ClosePopup();

            // OPEN POPUP
            int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
            int diamondPrice = iapBalancing.energy_prices[3];
            if (currentDiamonds < diamondPrice)
            {
                ShowNoDiamondPopup();
            }
        }

    }


    //////////// AD
    /*
    public void StartAd()
    {
        if (Application.isEditor)
            ShowAdConfirmation();
        else
            GetComponent<adManager>().ShowRewardedVideo();
    }
    */
    /*
    public void ShowAdConfirmation()
    {
        noEnergyPopup.GetComponent<Animation>().Play("a_hardClose");
        adConfirmationPopup.GetComponent<Animation>().Play("a_spawn");
        adConfirmationPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();
    }
    */
    /*
    public void CollectAdReward()
    {
        Debug.Log("Close ad confirmation popup");
        int rewardedVideoEnergyReward = energyBalancing.rewardedVideoEnergyReward;

        adConfirmationPopup.GetComponent<Animation>().Play("a_close");
        Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
        GetComponent<feedbackManager>().UiReward(rewardedVideoEnergyReward, pos, "energy", "videoAd");
        adConfirmationPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

    }
    */
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


    //////////// MISC

    public bool HasEnergy()
    {
        if (currentEnergy > 0)
            return true;
        else
            return false;
    }


    //////////// TEXTS
    public string WaitText()
    {
        int energyRefreshRate = energyBalancing.energyRefillRate;
        int timeToNextEnergy = (timeLeftToMax) % energyRefreshRate;
        string waitString;
        if (timeToNextEnergy <= 2)
            timeToNextEnergy = energyRefreshRate;

        waitString = timeToNextEnergy.ToString() + " " + localizerManager.LocalizedText(82);
        return waitString;
    }



    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// WATER
    public void AddWater(int waterToAdd)
    {
        int waterSaved = saveManager.GetSavedInt("currentWater");
        currentWater = waterToAdd + waterSaved;
        SaveWater(currentWater);
        //saveManager.SaveWater(currentWater);

        // UI
        UpdateWaterUI();

        // CHECK NOTIFICATION
        // GetComponent<pictureManager>().UpdateNotification();

        // FX
        if (waterToAdd > 0)
        {
            GameObject instantiatedFeedback = Instantiate(waterFX, topPanel.transform.position, topPanel.transform.rotation) as GameObject;
            instantiatedFeedback.transform.SetParent(topPanel.transform);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
        }

        // ANIM
        waterText.GetComponent<Animation>().Stop("rewardText_anim");
        waterText.GetComponent<Animation>().Play("rewardText_anim");

    }
    public void SpendWater(int waterSpent)
    {
        int waterSaved = saveManager.GetSavedInt("currentWater");
        currentWater = waterSaved - waterSpent;
        SaveWater(currentWater);
        //saveManager.SaveWater(currentWater);

        // UI
        UpdateWaterUI();

    }

    void UpdateWaterUI()
    {

        waterText.text = currentWater.ToString();

    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SUN
    public void AddSun(int sunToAdd)
    {
        int sunSaved = saveManager.GetSavedInt("currentSun");
        currentSun = sunToAdd + sunSaved;
        SaveSun(currentSun);

        // UI
        UpdateSunUI();

        // FX
        if (sunToAdd > 0)
        {
            GameObject instantiatedFeedback = Instantiate(sunFX, topPanel.transform.position, topPanel.transform.rotation) as GameObject;
            instantiatedFeedback.transform.SetParent(topPanel.transform);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
        }

        // ANIM
        sunText.GetComponent<Animation>().Stop("rewardText_anim");
        sunText.GetComponent<Animation>().Play("rewardText_anim");

    }
    public void SpendSun(int sunSpent)
    {
        int sunSaved = saveManager.GetSavedInt("currentSun");
        currentSun = sunSaved - sunSpent;
        SaveSun(currentSun);

        // UI
        UpdateSunUI();

    }

    void UpdateSunUI()
    {

        sunText.text = currentSun.ToString();

    }





    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// DIAMONDS
    
    public void ShowNoDiamondPopup()
    {

        noDiamondPopup.GetComponent<Animation>().Play("a_spawn");
        noDiamondPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();

    }

    public void CloseNoDiamondPopup()
    {

        noDiamondPopup.GetComponent<Animation>().Play("a_close");
        noDiamondPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

    }


    public void AddDiamonds(int diamondsToAdd, string source)
    {
        int diamondsSaved = saveManager.GetSavedInt("currentDiamonds");
        currentDiamonds = diamondsToAdd + diamondsSaved;
        SaveDiamonds(currentDiamonds);

        //logText.text += string.Format("Diamonds Added: ", currentDiamonds, "\n");
        // UI
        UpdateDiamondsUI();

        // FX
        if (diamondsToAdd > 0)
        {
            GameObject instantiatedFeedback = Instantiate(diamondsFX, topPanel.transform.position, topPanel.transform.rotation) as GameObject;
            instantiatedFeedback.transform.SetParent(topPanel.transform);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
        }

        // ANIM
        diamondsText.GetComponent<Animation>().Stop("rewardText_anim");
        diamondsText.GetComponent<Animation>().Play("rewardText_anim");

        // UPDATE TEXTS COLORS
        GetComponent<iapStoreManager>().CheckDiamondsColors();

        // TRACK
        analyticsManager.TrackDiamondsEarned(source, diamondsToAdd);

    }
    public void SpendDiamonds(string source, int diamondsSpent)
    {
        int diamondsSaved = saveManager.GetSavedInt("currentDiamonds");
        currentDiamonds = diamondsSaved - diamondsSpent;
        SaveDiamonds(currentDiamonds);

        // UI
        UpdateDiamondsUI();

        // UPDATE TEXTS COLORS
        GetComponent<iapStoreManager>().CheckDiamondsColors();

        // TRACK
        analyticsManager.TrackDiamondsSpent(source, diamondsSpent);

    }

    void UpdateDiamondsUI()
    {

        diamondsText.text = currentDiamonds.ToString();

    }



    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SEEDS

    public bool HasSeed(int seedId)
    {
        if (seedsCurrent[seedId] > 0)
            return true;
        else
            return false;

    }
    
    public void RefillAllSeeds()
    {

        for (int i = 0; i < differentSeeds; i++)
            RefillSeed(i);

    }

    public void RefillSeed(int seedId)
    {

        timeNow = timeNowManager.timeNow;
        seeds_timeToMax[seedId] = timeNow;
        SaveSeed(seeds_timeToMax[seedId], seedId);

    }
    
    void SeedUpdate(int seedId)
    {
        /////////////////////////////////////////////////// OLD SEED
        //int oldSeed = seedsCurrent[seedId];

        // CALCULATE TIME
        timeNow = timeNowManager.timeNow;
        seeds_timeLeftToMax[seedId] = seeds_timeToMax[seedId] - timeNow;

        // CALCULATE SEEDS LEFT
        float leftFloat = seeds_timeLeftToMax[seedId] * 1f;
        float refreshFloat = seedsRefill[seedId] * 1f;
        int seedSpent = Mathf.CeilToInt(leftFloat / refreshFloat);

        if (seeds_timeToMax[seedId] > timeNow)
            seedsCurrent[seedId] = seedsMax[seedId] - seedSpent;
        else
            seedsCurrent[seedId] = seedsMax[seedId];


        // TEXT SEED LEFT
        if(seedsLeftText[seedId])
            seedsLeftText[seedId].text = seedsCurrent[seedId].ToString();



        // REFILL BAR
        seeds_timeToNext[seedId] = (seeds_timeLeftToMax[seedId]) % seedsRefill[seedId];
        if (seeds_timeToNext[seedId] < 0)
            seeds_timeToNext[seedId] = 0;
        float seedProportion = 1f - ((seeds_timeToNext[seedId] * 1f) / (seedsRefill[seedId] * 1f));
        if (seedsRefillBar[seedId])
            seedsRefillBar[seedId].transform.localScale = new Vector3(1, seedProportion, 1);

    }
         
    public void SpendSeed(int seedId)
    {

        ////////////////////////////// CASE: SEED = MAX
        timeNow = timeNowManager.timeNow;
        if (seedsCurrent[seedId] == seedsMax[seedId])
        {
            seeds_timeToMax[seedId] = timeNow + seedsRefill[seedId];
        }


        ////////////////////////////// CASE SEED < MAX
        else
        {
            seeds_timeToMax[seedId] = seeds_timeToMax[seedId] + seedsRefill[seedId];
        }

        ////////////////////////////// SAVE
        SaveSeed(seeds_timeToMax[seedId], seedId);


    }
    public void AddSeed(int seedId, int seedToAdd)
    {

        seeds_timeToMax[seedId] = seeds_timeToMax[seedId] - (seedsRefill[seedId]* seedToAdd);
        ////////////////////////////// SAVE
        SaveSeed(seeds_timeToMax[seedId], seedId);
    }

    public void ShowSeedRefillPopup(int seedSelected, int spawnerId)
    {

        ////////////////////////////////////////////////////////////////////////////////////////// OPEN
        noSeedsPopup.GetComponent<Animation>().Play("a_spawn");
        noSeedsPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();


        ////////////////////////////////////////////////////////////////////////////////////////// UPDATE SOME DATA
        currentFertilizer = saveManager.GetSavedInt("currentFertilizer");
        currentSeedSelected = seedSelected;
        currentSpawnerId = spawnerId;

        ////////////////////////////////////////////////////////////////////////////////////////// SPAWNER ICON
        spawnerIcon.sprite = GetComponent<spawnerManager>().spawnerImages[spawnerId];
        

        ////////////////////////////////////////////////////////////////////////////////////////// DESCRIPTION
        int descTextId = noSeedTextId[spawnerId];
        noSeedsDescText.text = localizerManager.LocalizedText(descTextId);
        noSeedsDescText.GetComponent<autoSizeText>().RedoFontSize();


        ////////////////////////////////////////////////////////////////////////////////////////// WAIT TEXT
        int shownTime;
        int timeValueId;
        // SHOW MINUTES IF TIME IF WAIT MORE THAN !@) SEC
        if (seeds_timeToNext[seedSelected] >= 120)
        {
            shownTime = Mathf.FloorToInt(seeds_timeToNext[seedSelected] / 60);
            timeValueId = 121;
        }
        // ELSE, SHOW SEC
        else
        {
            shownTime = seeds_timeToNext[seedSelected];
            timeValueId = 82;
        }

        noSeedsWaitText.text = shownTime.ToString() + " " + localizerManager.LocalizedText(timeValueId);
        noSeedsWaitText.GetComponent<autoSizeText>().RedoFontSize();


        ////////////////////////////////////////////////////////////////////////////////////////// PACK 1 AND AD
        // IF AD ACTIVE
        if (adManager.seedAdRefillActive)
        {
            refill1Panel.SetActive(false);
            refillAdPanel.SetActive(true);

            noSeedsRefillAdAmountText.text = "+" + adManager.seedAdRefillAmount[seedSelected].ToString();
            noSeedsRefillAdAmountText.GetComponent<autoSizeText>().RedoFontSize();
            bool isAvailable = adManager.IsAdAvailable("seedAdRefill");
            adButtonOn.SetActive(isAvailable);
            adButtonOff.SetActive(!isAvailable);
        }
        // IF AD NOT ACTIVE
        else
        {
            refill1Panel.SetActive(true);
            refillAdPanel.SetActive(false);

            noSeedsRefill1AmountText.text = "+" + refillPack1Amount[seedSelected].ToString();
            noSeedsRefill1AmountText.GetComponent<autoSizeText>().RedoFontSize();
            noSeedsRefill1PriceText.text = "x" + refillPack1Price[seedSelected].ToString();
            noSeedsRefill1PriceText.GetComponent<autoSizeText>().RedoFontSize();
        }



        ////////////////////////////////////////////////////////////////////////////////////////// PACK FULL
        noSeedsFullRefillAmountText.text = "(+" + seedsMax[seedSelected].ToString() + ")";
        noSeedsFullRefillAmountText.GetComponent<autoSizeText>().RedoFontSize();

        noSeedsFullRefillPriceText.text = "x" + seedsFullRefillPrice[seedSelected].ToString();
        noSeedsFullRefillPriceText.GetComponent<autoSizeText>().RedoFontSize();

    }
    
    public void CloseSeedRefillPopup(int closeId)
    {

        noSeedsPopup.GetComponent<Animation>().Play("a_close_"+ closeId);
        noSeedsPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

    }

    public void RefillPack1()
    {

        int price = refillPack1Price[currentSeedSelected];
        int refillAmount = refillPack1Amount[currentSeedSelected];
        CloseSeedRefillPopup(2);

        if (price <= currentFertilizer)
        {
            AddSeed(currentSeedSelected, refillAmount);
            SpendFertilizer(price);
            ////////////////////////////// FX
            GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("refillFx");
            newFeedback.SetActive(true);
            newFeedback.transform.position = GameObject.Find("spawner_" + currentSpawnerId.ToString()).transform.position;
        }
        else
        {
            ShowNoFertilizerPopup();
            GetComponent<necManager>().ShowNec("fertilizer");
        }

    }
    public void RefillPackAd()
    {
        Debug.Log("Refill seed with ad");

        ////////////////////////////// CLOSE
        CloseSeedRefillPopup(99);

        ////////////////////////////// REFILL
        int refillAmount = adManager.seedAdRefillAmount[currentSeedSelected];
        AddSeed(currentSeedSelected, refillAmount);

        ////////////////////////////// FX
        GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("refillFx");
        newFeedback.SetActive(true);
        newFeedback.transform.position = GameObject.Find("spawner_" + currentSpawnerId.ToString()).transform.position;


    }

    public void RefillPackFull()
    {
        int price = seedsFullRefillPrice[currentSeedSelected];
        CloseSeedRefillPopup(3);

        if (price <= currentFertilizer)
        {
            AddSeed(currentSeedSelected, seedsMax[currentSeedSelected]);
            SpendFertilizer(price);
            // FX
            GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("refillFx");
            newFeedback.SetActive(true);
            newFeedback.transform.position = GameObject.Find("spawner_" + currentSpawnerId.ToString()).transform.position;
        }
        else
        {
            ShowNoFertilizerPopup();
            GetComponent<necManager>().ShowNec("fertilizer");
        }

    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FERTILIZER
    public void SpendFertilizer(int fertilizertoSpend)
    {

        int fertilizerSaved = saveManager.GetSavedInt("currentFertilizer");
        currentFertilizer = fertilizerSaved - fertilizertoSpend;
        SaveFertilizer(currentFertilizer);
        fertilizerText.text = currentFertilizer.ToString();

    }


    public void AddFertilizer(int fertilizertoAdd)
    {

        int fertilizerSaved = saveManager.GetSavedInt("currentFertilizer");
        currentFertilizer = fertilizerSaved + fertilizertoAdd;
        SaveFertilizer(currentFertilizer);
        fertilizerText.text = currentFertilizer.ToString();

    }

    public void ShowNoFertilizerPopup()
    {
        // PRICES COLORS
        int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
        for (int i = 0; i < noFertilizerPrices.Length; i++)
        {
            int diamondPrice = iapBalancing.fertilizer_prices[i];
            if (diamondPrice > currentDiamonds)
                noFertilizerPrices[i].color = priceNotOk;
            else
                noFertilizerPrices[i].color = priceOk;
        }

        // OPEN
        noFertilizerPopup.GetComponent<Animation>().Play("a_spawn");
        noFertilizerPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();

    }

    public void CloseNoFertilizerPopup(int fertilizerPack)
    {

        noFertilizerPopup.GetComponent<Animation>().Play("a_close");
        noFertilizerPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

        if(fertilizerPack != 99)
        {
            int currentDiamonds = saveManager.GetSavedInt("currentDiamonds");
            int diamondPrice = iapBalancing.fertilizer_prices[fertilizerPack];

            // OPEN POPUP
            if (currentDiamonds < diamondPrice)
            {
                ShowNoDiamondPopup();
            }

        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveSun(int m_sunToSave)
    {
        saveManager.SaveInt("currentSun", m_sunToSave);
    }
    void SaveDiamonds(int m_diamondsToSave)
    {
        saveManager.SaveInt("currentDiamonds", m_diamondsToSave);
    }
    void SaveFertilizer(int m_currentFertilizer)
    {
        saveManager.SaveInt("currentFertilizer", m_currentFertilizer);
    }

    void SaveWater(int m_waterToSave)
    {

        saveManager.SaveInt("currentWater", m_waterToSave);
    }

    void SaveEnergy(int timeToMaxEnergy)
    {
        // totalSpent
        int currentSpent = saveManager.GetSavedInt("energySpent");
        saveManager.SaveInt("energySpent", currentSpent + 1); // Save total energy spent

        // EnergyValue
        saveManager.SaveInt("timeToMaxEnergy", timeToMaxEnergy); // save current energy value
    }

    void SaveEnergyOverflow(int energy)
    {
        saveManager.SaveInt("currentOverflowEnergy", energy); // save energy overflow
    }

    void SaveEnergyOverflowBool(int isOverflow)
    {
        saveManager.SaveInt("energyIsOverflow", isOverflow); // save if energy is overflow
    }
    public void SaveSeed(int timeToMaxSeed, int seedId)
    {
        saveManager.SaveInt("seed" + seedId.ToString() + "_timeToMax", timeToMaxSeed); // save seed
    }



    /*
    int TimeNow()
    {
        var newUnixTime = (System.DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        int unixTimeInt = Convert.ToInt32(newUnixTime);
        return unixTimeInt;
    }
    */
    /*
    void EnergyResize()
    {
        
        if (currentEnergy >= maxEnergy)
        {
            energyLeft.GetComponent<RectTransform>().anchorMin = new Vector2(.32f, .1f);
            energyLeft.GetComponent<RectTransform>().anchorMax = new Vector2(1f, .9f);
        }
        else
        {
            energyLeft.GetComponent<RectTransform>().anchorMin = new Vector2(.32f, .27f);
            energyLeft.GetComponent<RectTransform>().anchorMax = new Vector2(1f, 1f);
        }
        energyLeft.GetComponent<autoSizeText>().RedoFontSize();
        
    }
    */
}
