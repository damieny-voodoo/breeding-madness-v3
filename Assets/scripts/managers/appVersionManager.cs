using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using UnityEngine.SceneManagement;

public class appVersionManager : MonoBehaviour
{
    public float playerVersion;
    public float latestVersion;
    public bool forceUpdate;
    public bool popupIsOpen;

    public GameObject forceUpdatePopup;

    technicalData technicalData;

    void Start()
    {
        technicalData = GameObject.Find("balancingData").GetComponent<technicalData>();
        CheckVersion();
    }

    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            CheckVersion();
        }

    }


    public void CheckVersion()
    {
        latestVersion = float.Parse(technicalData.latestStoreVersion);
        playerVersion = float.Parse(Application.version);
        forceUpdate = technicalData.forceUpdate;
        //Debug.Log("App version:" + Application.version + ", latest version: " + latestVersion + ", force update: " + forceUpdate);

        if (forceUpdate && !popupIsOpen)
        {
            if (playerVersion != latestVersion)
            {
                ShowUpdatePopup();
            }

        }
        else if (popupIsOpen)
        {

            if (playerVersion == latestVersion)
                HideUpdatePopup();

        }


    }

    public void ShowUpdatePopup()
    {
        GetComponent<tutorialManager>().HideTuto(14);
        popupIsOpen = true;
        GetComponent<tapManager>().popupOpen = true;
        forceUpdatePopup.GetComponent<Animation>().Play("update_open");
    }

    public void OpenStore()
    {
        string storeUrl = technicalData.ggpLink;
        Application.OpenURL(storeUrl);

    }

    public void HideUpdatePopup()
    {

        SceneManager.LoadScene("loading");
        /*
        popupIsOpen = false;
        GetComponent<tapManager>().popupOpen = false;
        forceUpdatePopup.GetComponent<Animation>().Play("update_close");
        */
    }

}
