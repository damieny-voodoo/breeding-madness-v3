using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class petShopManager : MonoBehaviour
{
    public GameObject petShopPanel;
    public GameObject shopOptionsPanel;

    public TextMeshProUGUI refreshText;

    public float cardOpeningFirstDelay;
    public float cardOpeningDelay;


    

    petBalancing petBalancing;
    petShopBalancing petShopBalancing;

    saveManager saveManager;
    timeNowManager timeNowManager;
    localizerManager localizerManager;

    void Awake()
    {

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        petShopBalancing = balancingData.GetComponent<petShopBalancing>();

        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        timeNowManager = gameProperties.GetComponent<timeNowManager>();
        localizerManager = gameProperties.GetComponent<localizerManager>();

    }

    public void OpenPopup()
    {

        // SET REFRESH
        bool newShop = false;
        int nextRefresh = saveManager.GetSavedInt("nextPetShopRefresh");
        int timeNow = timeNowManager.timeNow;
        if (timeNow > nextRefresh)
        {
            newShop = true;
            int refreshDuration = petShopBalancing.refreshDuration;
            SaveNewShoptime(timeNow + refreshDuration);
        }

        // SHOW REFRESH DATA
        nextRefresh = saveManager.GetSavedInt("nextPetShopRefresh");
        int timeRemaining = nextRefresh - timeNowManager.timeNow;
        refreshText.text = "Next refresh in: "+TimeLeft(timeRemaining);

        // SHOW CARDS
        StartCoroutine(ShowShop(newShop));


        // OPEN POPUP
        GetComponent<tapManager>().OpenPopup();
        petShopPanel.GetComponent<GraphicRaycaster>().enabled = true;
        petShopPanel.GetComponent<Animation>().Play("petShopPopup_in");

    }

    public void ClosePopup()
    {
        // Close popup
        GetComponent<tapManager>().ClosePopup();
        petShopPanel.GetComponent<GraphicRaycaster>().enabled = false;
        petShopPanel.GetComponent<Animation>().Play("petShopPopup_out");
    }



    IEnumerator ShowShop(bool m_newShop)
    {
        // HIDE ALL CARDS
        foreach (Transform p in shopOptionsPanel.transform)
            p.gameObject.SetActive(false);

        // PAUSE
        yield return new WaitForSeconds(cardOpeningFirstDelay);

        // SHOW CARDS
        int currentCount = 0;
        foreach( Transform p  in shopOptionsPanel.transform)
        {
            p.gameObject.SetActive(true);
            p.GetComponent<petShopItemController>().UpdateCard(currentCount, m_newShop);
            p.GetComponent<Animation>().Play("petShop_itemPop");
            currentCount++;

            yield return new WaitForSeconds(cardOpeningDelay);
        }

        yield return null;
    }
    string TimeLeft(int time)
    {
        string timeString = "";
        int currentLanguage = saveManager.GetSavedInt("currentLanguage");
        //TIMES
        int hourTime = Mathf.FloorToInt(time / 3600 * 1f);
        int minutesTime = Mathf.FloorToInt((time - (hourTime * 3600)) / 60);
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

    void SaveNewShoptime(int timetoSave)
    {

        saveManager.SaveInt("nextPetShopRefresh", timetoSave);

    }
}
