using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using System;

public class analyticsManager : MonoBehaviour
{

    public bool isInitialized;


    public int firstDay;
    public int lastDay;
    public int daysPlayedCount;
    public string playerId;

    saveManager saveManager;

    bool newDay;


    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
        if (PlayerPrefs.GetInt("tutorialCompleted") == 0)
            StartFunnel("mainTutorial_v2");

    }

    public void InitA()
    {
        StartCoroutine(InitAnalytics());
    }

    IEnumerator InitAnalytics()
    {
        saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        yield return new WaitForSeconds(0);

        UpdatePlayerData();
        yield return new WaitForSeconds(0);

        if (newDay)
            TrackNewDay();
        yield return new WaitForSeconds(0);
    }


    /////////////////////////////////////////////////////////////////////////////// TUTORIAL
    public void StartFunnel(string tutorialId)
    {
        /*
        if (isInitialized)
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, tutorialId + "step_0", 1);
        */
    }

    public void ContinueFunnel( string tutorialId, string stepName)
    {
        string tutoVersion = "v3";
        if(!saveManager)
            saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        int tutoComplete = saveManager.GetSavedInt("tutorialCompleted");
        if (isInitialized && tutoComplete == 0)
        {
            string stepId = tutorialId +"_"+ tutoVersion + "_step_" + stepName;
            Debug.Log("Tuto step: " + stepId);

            //GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, stepId, 1);
        }

    }

    public void CompleteFunnel( string tutorialId)
    {

    }

    /////////////////////////////////////////////////////////////////////////////// LEVEL UP
    public void StartLevel(int levelStarted)
    {

        /////////////////// SEND EVENT
        if(!saveManager)
            saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        int energySent = saveManager.GetSavedInt("energySpent");
        //GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "levelUp_"+ levelStarted.ToString(), energySent);

    }

    /////////////////////////////////////////////////////////////////////////////// ENGAGEMENT
    void TrackNewDay()
    {
        /*
        if (newDay)
        {
            GameAnalytics.NewDesignEvent("playedToday", firstDay);
        }
        */
    }

    /////////////////////////////////////////////////////////////////////////////// SPEND DIAMONDS
    public void TrackDiamondsSpent(string source, int amount)
    {
        /*
        if(amount>0)
            GameAnalytics.NewResourceEvent(GAResourceFlowType.Sink, "diamonds", amount, source, source);
        */
    }
    public void TrackDiamondsEarned(string source, int amount)
    {
        /*
        if (amount > 0)
            GameAnalytics.NewResourceEvent(GAResourceFlowType.Source, "diamonds", amount, source, source);
        */
    }


    /////////////////////////////////////////////////////////////////////////////// COMMON DATA
    void UpdatePlayerData()
    {
        var current = (System.DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalDays;
        int currentInt = Convert.ToInt32(current);


        //////////////////////////////// FIRST DAY
        firstDay = saveManager.GetSavedInt("firstDayPlayed");

        if(firstDay == 0)
        {
            firstDay = currentInt;
            SaveFirstDay(firstDay);
        }

        //////////////////////////////// LAST DAY PLAYED
        lastDay = saveManager.GetSavedInt("lastDayPlayed");
        if(lastDay != currentInt)
        {
        //////////////////////////////// SAVE
        SaveLastDay(currentInt);

        //////////////////////////////// TRACK
        newDay = true;

        //////////////////////////////// DAYS PLAYED COUNT
            int currentDaysPlayedCount = saveManager.GetSavedInt("currentDaysPlayedcount");
        SaveDaysPlayed(currentDaysPlayedCount + 1);

        }


        //////////////////////////////// DAYS PLAYED COUNT
        playerId = SystemInfo.deviceUniqueIdentifier;


    }


    /////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveFirstDay(int day)
    {
        saveManager.SaveInt("firstDayPlayed", day);
    }
    void SaveLastDay(int day)
    {
        saveManager.SaveInt("lastDayPlayed", day);
    }
    void SaveDaysPlayed(int day)
    {
        saveManager.SaveInt("currentDaysPlayedcount", day);
    }












    /////////////////////////////////////////////////////////////////////////////// GAMEPLAY

    public void UseBomb(int playerLevel)
    {
        /*
        Analytics.CustomEvent("useBomb", new Dictionary<string, object>
        {
            {"playerLevel", playerLevel }
        });
        */

    }


    public void WrongSell(int playerLevel, string itemId, string itemToSell1, string itemToSell2)
    {
        /*
        Analytics.CustomEvent("wrongSell", new Dictionary<string, object>
        {
            {"playerLevel", playerLevel },
            {"itemId", itemId },
            {"itemInOrder1", itemToSell1 },
            {"itemInOrder2", itemToSell2 }
        });
        */

    }


}
