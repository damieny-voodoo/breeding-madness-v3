using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using PlayFab;
//using PlayFab.ClientModels;
using TMPro;

public class settingsManager : MonoBehaviour
{

    public GameObject settingsPopup;
    public GameObject[] languageFlags;
    public Toggle notifictionToggle;
    saveManager saveManager;
    public string playerId;
    public TextMeshProUGUI playerIdText;
    //public TextMeshProUGUI versionText;

    void Start()
    {
        saveManager = GetComponent<saveManager>();
        playerIdText.text = "v"+Application.version.ToString();
        playerIdText.text += "\n";
        playerIdText.GetComponent<autoSizeText>().RedoFontSize();
        //GetProfileId();
    }

    void GetProfileId()
    {

        //playerId = GameObject.Find("playfabLogin").GetComponent<playfabLogin>().playerId;
        playerId = saveManager.GetSavedString("playerId");
        playerIdText.GetComponent<autoSizeText>().RedoFontSize();

        if (playerId != "")
        {
            playerIdText.text += "UID: " + playerId;
            playerIdText.GetComponent<autoSizeText>().RedoFontSize();
        }
        else
        {
            playerIdText.text += "~";
            playerIdText.GetComponent<autoSizeText>().RedoFontSize();
        }

    }


    public void OpenSettings()
    {
        bool popupOpen = GetComponent<tapManager>().popupOpen;
        if (!popupOpen)
        {

            ///////////// POPUP OPEN
            settingsPopup.SetActive(true);
            GetComponent<tapManager>().OpenPopup();
            settingsPopup.GetComponent<GraphicRaycaster>().enabled = true;



            ///////////// ANIMATION
            /*
            bool gardenPopupOpen = GetComponent<gardenManager>().popupIsOpen;
            if (gardenPopupOpen)
                settingsPopup.GetComponent<Animation>().Play("settings_slowOpen");
            else
                settingsPopup.GetComponent<Animation>().Play("settings_open");
            */
            settingsPopup.GetComponent<Animation>().Play("settings_open");


            ///////////// NOTIFICATION STATUS
            int notificationBlocked = saveManager.GetSavedInt("notificationBlocked");
            if (notificationBlocked == 1)
                notifictionToggle.isOn = false;
            else
                notifictionToggle.isOn = true;



            ///////////// LANGUAGE STATUS
            int currentLanguage = saveManager.GetSavedInt("currentLanguage");
            PickLanguage(currentLanguage);



            // HIDE GARDEN POPUP
            /*
            if (gardenPopupOpen)
            {
                GetComponent<gardenManager>().HideOptionsPopup("openSettings");
            }
            */


            ///////////// GET PROFILE ID
            GetProfileId();

        }

    }


    public void ChangeNotificationToggle()
    {

        int notificationBlocked = saveManager.GetSavedInt("notificationBlocked");
        if (notificationBlocked == 0)
            SaveNotificationSettings(1);
        else
            SaveNotificationSettings(0);

        Debug.Log(" notification allowed: " + saveManager.GetSavedInt("notificationAllowed"));

    }


    public void PickLanguage(int languageSelected)
    {

        GetComponent<localizerManager>().SelectLanaguage(languageSelected);

        for (int i = 0; i < languageFlags.Length; i++)
        {
            if (i == languageSelected)
                languageFlags[i].GetComponent<flagController>().SelectLanguage();
            else
                languageFlags[i].GetComponent<flagController>().UnselectLanguage();
        }

    }

    public void CloseSettings()
    {
        GetComponent<tapManager>().ClosePopup();
        settingsPopup.GetComponent<GraphicRaycaster>().enabled = false;

        ///////////// ANIMATION
        settingsPopup.GetComponent<Animation>().Play("settings_close");

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    public void SaveNotificationSettings(int newSetting)
    {

        saveManager.SaveInt("notificationBlocked", newSetting); // save notifications settings

    }
}
