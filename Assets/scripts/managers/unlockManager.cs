using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class unlockManager : MonoBehaviour
{

    localizationData localizationData;
    analyticsManager analyticsManager;
    saveManager saveManager;
    adManager adManager;
    tapManager tapManager;
    localizerManager localizerManager;
    public unlockData unlockData;
    public GameObject unlockPopup;
    public GameObject[] unlockItemOnMap;
    public GameObject[] secondaryUnlockItemOnMap;

    public TextMeshProUGUI titleText;
    //int[] titleTexts;

    public Image mainPicture;
    //public Sprite[] mainPictures;

    public TextMeshProUGUI descriptionTitleText;
    //int[] descriptionTitleTexts;    

    public TextMeshProUGUI descriptionText;
    //int[] descriptionTexts;

    public Image descriptionPicture;
    //public Sprite[] descriptionPictures;

    private void Start()
    {
        GetUnlockData();
        //InitData();
    }

    void GetUnlockData()
    {
        saveManager = GetComponent<saveManager>();
        adManager = GetComponent<adManager>();
        tapManager = GetComponent<tapManager>();
        localizerManager = GetComponent<localizerManager>();
        unlockData = GameObject.Find("balancingData").GetComponent<unlockData>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();


        // CHECK ITEM FOR LIST 1
        unlockItemOnMap = new GameObject[unlockData.objectsOnMap.Length];
        for (int i = 0; i < unlockData.objectsOnMap.Length; i++)
        {
            string toFind = unlockData.objectsOnMap[i];
            if (GameObject.Find(toFind))
            {
                unlockItemOnMap[i] = GameObject.Find(toFind);
                SetObjectLocked(unlockItemOnMap[i], i + 1, unlockData.colliderBlock[i]);

            }
        }

    }

    void SetObjectLocked(GameObject lockedObject, int level, bool setLock)
    {
        unlockController newUnlock = lockedObject.AddComponent<unlockController>();
        newUnlock.levelUnlock = level;
        newUnlock.disableColliderOnUnlock = setLock;
        newUnlock.InitiateLock();

    }


    public void ShowUnlockPopup()
    {
        //Debug.Log("Show unlock popup");

        localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();
        tapManager.OpenPopup();
        unlockPopup.GetComponent<GraphicRaycaster>().enabled = true;
        unlockPopup.SetActive(true);
        unlockPopup.GetComponent<Animation>().Play("unlockPopup_in");


        // GET INFO FOR SPECIFIC LEVEL
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);
        int currentLanguage = saveManager.GetSavedInt("currentLanguage");


        // SHOW INFO FOR SPECIFIC LEVEL
        int titleId = unlockData.titleTexts[currentLevel-1];
        int descriptionTitleTextId = unlockData.descriptionTitleTexts[currentLevel - 1];
        int descriptionTextTextId = unlockData.descriptionTexts[currentLevel - 1];
        titleText.text = localizerManager.LocalizedText(titleId);
        descriptionTitleText.text = localizerManager.LocalizedText(descriptionTitleTextId);
        descriptionText.text = localizerManager.LocalizedText(descriptionTextTextId);

        // MAIN PICTURE
        string mainImgName = unlockData.mainImages[currentLevel-1];
        Sprite mainImgSprite = Resources.Load<Sprite>("UI/popups/unlockPopup/imagesPopup/main/" + mainImgName);
        if(mainImgName.Length>0)
            mainPicture.sprite = mainImgSprite;

        // DESC PICTURE
        string descImgName = unlockData.descImages[currentLevel - 1];
        if (descImgName.Length>0)
        {
            Sprite desImgSprite = Resources.Load<Sprite>("UI/popups/unlockPopup/imagesPopup/desc/" + descImgName);
            descriptionPicture.sprite = desImgSprite;
            descriptionPicture.color = new Vector4(1,1,1,1);
        }
        else
            descriptionPicture.color = new Vector4(1, 1, 1,0);

    }


    public bool ShouldSownUnlock()
    {
        bool shouldShow = false;

        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);

        if(unlockData.mainImages[currentLevel-1].Length>0)
            shouldShow = true;

        return shouldShow;
    }

    public void ClosePopup()
    {
        StartCoroutine(CloseRoutine());
    }

    IEnumerator CloseRoutine()
    {

        /////////// CLOSE POPUP AND SET LEVEL UP TO ENDED
        tapManager.ClosePopup();
        unlockPopup.GetComponent<GraphicRaycaster>().enabled = false;
        unlockPopup.GetComponent<Animation>().Play("unlockPopup_out");

        /////////// UNLOCK ITEMS ON MAP
        int currentLevel = GetComponent<xpManager>().currentLevel;
        if (unlockItemOnMap[currentLevel-1])
            unlockItemOnMap[currentLevel - 1].GetComponent<unlockController>().UnlockItem(true);


        GetComponent<xpManager>().EndLevel();
        //////// 
        CheckTuto();

        yield return new WaitForSeconds(48/30);

        adManager.ShowInterstitialVideoAd("unlock");

        yield return null;
    }

    void CheckTuto()
    {
        /*
        if (GetComponent<tutorialManager>().currentTuto == 15)
        {
            //GetComponent<tutorialManager>().HideTuto(15);
            GetComponent<tutorialManager>().ShowTuto(16, true);
            analyticsManager.ContinueFunnel("mainTutorial", "levelupDone");
        }
        */

    }


    
}
