using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class energyManager : MonoBehaviour
{
    /*
    [Header("BALANCING")]
    public energyBalancing energyBalancing;

    [Header("CURRENT STATE")]
    public int currentEnergy;
    public int timeToMaxEnergy;
    public int timeLeftToMax;
    public int timeNow;

    public GameObject topPanel;
    public TextMeshProUGUI energyLeft;
    public TextMeshProUGUI timeToNextEnergyText;
    public GameObject energyFx;



    [Header("POPUP")]
    public GameObject noEnergyPopup;
    public GameObject adAvailableGroup;
    public GameObject noAdAvailableGroup;
    public GameObject adConfirmationPopup;
    //public int rewardedVideoEnergyReward;
    public TextMeshProUGUI waitText;
    public TextMeshProUGUI videoRewardText;
    public TextMeshProUGUI confirmationEnergyReward;
    public TextMeshProUGUI noEnergyReward;




    // MANAGERS
    tutorialManager tutoManager;
    saveManager saveManager;
    notificationManager notificationManager;
    public analyticsManager analyticsManager;
    public localizationData localizationData;
    int currentLanguage;
    bool energyIsOverflow;
    bool energyFirstInit = false;



    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// INIT
    private void Start()
    {
        energyBalancing = GameObject.Find("balancingData").GetComponent<energyBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();

        // GET COMPONENTS
        tutoManager = GetComponent<tutorialManager>();
        saveManager = GetComponent<saveManager>();
        notificationManager = GetComponent<notificationManager>();

        // Update languages
        UpdateLanguage();
        timeToNextEnergyText.GetComponent<autoSizeText>().RedoFontSize();


        // INITIATE TIME
        timeToMaxEnergy = PlayerPrefs.GetInt("timeToMaxEnergy");

        // POPUP
        InitializeNoEnergyPopup();


    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ADD-SPEND
    // Update is called once per frame
    public void SpendEnergy()
    {
        int maxEnergy = energyBalancing.energyMax;
        int energyRefreshRate = energyBalancing.energyRefillRate;
        ////////////////////////////// CASE: ENERGY = MAX
        if (currentEnergy == maxEnergy)
        {

            timeToMaxEnergy = timeNow + energyRefreshRate;
            energyIsOverflow = false;
            
            // NOTIFS
            notificationManager.UpdateEnergyNotification(timeLeftToMax);

            // RESIZE TEXTS
            UpdateEnergyText(energyRefreshRate);
            EnergyResize();

        }


        ////////////////////////////// CASE: ENERGY > MAX
        else if (currentEnergy > maxEnergy)
        {
            int newEnergy = PlayerPrefs.GetInt("currentOverflowEnergy") - 1;
            saveManager.SaveOverFlowEnergy(newEnergy);
        }


        ////////////////////////////// CASE ENERGY < MAX
        else
        {
            timeToMaxEnergy = timeToMaxEnergy + energyRefreshRate;

            // NOTIFS
            notificationManager.UpdateEnergyNotification(timeLeftToMax);
        }

        // Save
        saveManager.SaveEnergy(timeToMaxEnergy);
               

        ////////////////////////////////////////////// TUTORIAL
        CheckTutorial();


    }


    public void AddEnergy(int energyAdded)
    {
        // RECALCULATE TIME
        int maxEnergy = energyBalancing.energyMax;
        int energyRefreshRate = energyBalancing.energyRefillRate;

        timeToMaxEnergy = timeToMaxEnergy - (energyAdded * energyRefreshRate);
        timeLeftToMax -= energyAdded * energyRefreshRate;

        //////////////////////////////////////////////// ENERGY OVER MAX
        if (timeLeftToMax < 0)
        {
            energyIsOverflow = true;
            currentEnergy = currentEnergy + energyAdded;
            GetComponent<saveManager>().SaveOverFlowEnergy(currentEnergy);
            notificationManager.CancelAllNotifications();
        if (currentEnergy >= maxEnergy)
            EnergyResize();
        }


        //////////////////////////////////////////////// 
        else
        {
            GetComponent<saveManager>().SaveEnergy(timeToMaxEnergy);
            notificationManager.UpdateEnergyNotification(timeLeftToMax);
        }

        //////////////////////////////////////////////// ANIM
        energyLeft.GetComponent<Animation>().Stop("rewardText_anim");
        energyLeft.GetComponent<Animation>().Play("rewardText_anim");


    }


    void Update()
    {
        //if (energyBalancing.isInitialized)
        //{
            int maxEnergy = energyBalancing.energyMax;
            int energyRefreshRate = energyBalancing.energyRefillRate;
            int oldEnergy = currentEnergy;

            // CALCULATE TIME
            timeNow = TimeNow();
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
            {
                currentEnergy = PlayerPrefs.GetInt("currentOverflowEnergy");
            }


            ///////////////////// TEXTS
            energyLeft.text = currentEnergy.ToString();
            int timeToNextEnergy = (timeLeftToMax) % energyRefreshRate;

            if (timeToNextEnergy == 0)
            {
                timeToNextEnergy = energyRefreshRate;
            }

            ///////////////////// NEXT ENERGY TEXT WITH LOCALIZATION
            if (currentEnergy < maxEnergy)
            {
                UpdateEnergyText(timeToNextEnergy);
            }
            else
                timeToNextEnergyText.text = "";

            // REDO ENERGY SIZE when going from 99 to 100
            if (currentEnergy != oldEnergy && currentEnergy == (maxEnergy - 1))
                EnergyResize();
            else if (currentEnergy != oldEnergy && currentEnergy == maxEnergy)
                EnergyResize();
            else if (!energyFirstInit)
            {
                EnergyResize();
                energyFirstInit = true;
            }



        //}
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// POPUP 
    
    void InitializeNoEnergyPopup()
    {

        int rewardedVideoEnergyReward = energyBalancing.rewardedVideoEnergyReward;
        waitText.text = "Attendre 99s";
        waitText.GetComponent<autoSizeText>().RedoFontSize();

        videoRewardText.text = "+" + rewardedVideoEnergyReward.ToString();
        videoRewardText.GetComponent<autoSizeText>().RedoFontSize();

        confirmationEnergyReward.text = rewardedVideoEnergyReward.ToString();
        confirmationEnergyReward.GetComponent<autoSizeText>().RedoFontSize();


        noEnergyReward.text = "+"+rewardedVideoEnergyReward.ToString();
        noEnergyReward.GetComponent<autoSizeText>().RedoFontSize();

    }

    public void ShowNoEnergyPopup()
    {
        // BASIC VALUES
        noEnergyPopup.GetComponent<Animation>().Play("a_spawn");
        GetComponent<tapManager>().popupOpen = true;

        // AD VALUES
        if (GetComponent<adManager>().AdAvailable())
        {
            Debug.Log("Ad available");
            adAvailableGroup.SetActive(true);
            noAdAvailableGroup.SetActive(false);
        }
        else
        {
            //Debug.Log("No ad available");
            adAvailableGroup.SetActive(false);
            noAdAvailableGroup.SetActive(true);
        }


        // WAIT VALUES
        waitText.text = WaitText();


    }

    public void CloseNoEnergyPopup()
    {

        noEnergyPopup.GetComponent<Animation>().Play("a_close");
        GetComponent<tapManager>().popupOpen = false;

    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// AD
    public void StartAd()
    {
        if (Application.isEditor)
            ShowAdConfirmation();
        else
            GetComponent<adManager>().ShowRewardedVideo();
    }

    public void ShowAdConfirmation()
    {
        noEnergyPopup.GetComponent<Animation>().Play("a_hardClose");
        adConfirmationPopup.GetComponent<Animation>().Play("a_spawn");
        GetComponent<tapManager>().popupOpen = true;
    }

    public void CollectAdReward()
    {
        Debug.Log("Close ad confirmation popup");
        int rewardedVideoEnergyReward = energyBalancing.rewardedVideoEnergyReward;

        adConfirmationPopup.GetComponent<Animation>().Play("a_close");
        AddEnergy(rewardedVideoEnergyReward);
        GetComponent<tapManager>().popupOpen = false;

    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// MISC
    int TimeNow()
    {

        var newUnixTime = (System.DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        int unixTimeInt = Convert.ToInt32(newUnixTime);

        return unixTimeInt;

    }

    public bool HasEnergy()
    {
        if (currentEnergy > 0)
            return true;
        else
            return false;
    }
    
    void CheckTutorial()
    {
        int energySpent = PlayerPrefs.GetInt("energySpent");
        if (energySpent >= 2 && PlayerPrefs.GetInt("currentMergeCount") == 0)
        {
            tutoManager.HideTuto(8);
            tutoManager.ShowTuto(2, true);
            analyticsManager.ContinueFunnel("mainTutorial", 3);
        }

        else if (energySpent == 3)
        {
            tutoManager.HideTuto(4);
            tutoManager.ShowTuto(9, true);
            analyticsManager.ContinueFunnel("mainTutorial", 7);
        }
        else if (energySpent == 4)
        {
            tutoManager.HideTuto(9);
            tutoManager.ShowTuto(10, true);
            analyticsManager.ContinueFunnel("mainTutorial", 8);
        }
        else if (energySpent == 5)
        {
            tutoManager.HideTuto(10);
            tutoManager.ShowTuto(11, true);
            analyticsManager.ContinueFunnel("mainTutorial", 9);
        }
        else if (energySpent == 6)
        {
            tutoManager.HideTuto(11);
            tutoManager.ShowTuto(12, true);
            analyticsManager.ContinueFunnel("mainTutorial", 10);
        }
        else if (energySpent == 7)
        {
            tutoManager.HideTuto(7);
            analyticsManager.ContinueFunnel("mainTutorial", 14);
        }
    }



    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TEXTS
    void EnergyResize()
    {

        int maxEnergy = energyBalancing.energyMax;
        if (currentEnergy>=maxEnergy)
        {
            energyLeft.GetComponent<RectTransform>().anchorMin = new Vector2(.32f, .1f);
            energyLeft.GetComponent<RectTransform>().anchorMax = new Vector2( 1f, .9f);
        }
        else
        {
            energyLeft.GetComponent<RectTransform>().anchorMin = new Vector2(.32f, .27f);
            energyLeft.GetComponent<RectTransform>().anchorMax = new Vector2( 1f,  1f);
        }
        energyLeft.GetComponent<autoSizeText>().RedoFontSize();
    }

    public void UpdateEnergyText(int timeToNextEnergy)
    {

        if (currentLanguage == 0)
            timeToNextEnergyText.text = "+1 dans " + timeToNextEnergy.ToString() + "s";
        else if (currentLanguage == 1)
            timeToNextEnergyText.text = "+1 in " + timeToNextEnergy.ToString() + "s";

    }


    public string WaitText()
    {
        int energyRefreshRate = energyBalancing.energyRefillRate;

        int timeToNextEnergy = (timeLeftToMax) % energyRefreshRate;
        string waitString = "";
        if (timeToNextEnergy <= 2)
            timeToNextEnergy = energyRefreshRate;

        waitString = localizationData.localizationsKeys[81, currentLanguage] +" "+ timeToNextEnergy.ToString() + localizationData.localizationsKeys[82, currentLanguage];
        return waitString;

    }
    public void UpdateLanguage()
    {
        currentLanguage = PlayerPrefs.GetInt("currentLanguage");

    }
    */

}
