using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Monetization;
//using UnityEngine.Advertisements;
using UnityEngine.UI;


public class adManager : MonoBehaviour//, IUnityAdsListener
{


    string gameId;
    public bool testMode;

    [Header("FORCED - GENERAL VALUES")]
    public bool forcedAdActive;
    public bool forcedAdBlocked;
    public int forcedAdMinLevel;
    public int forcedAdTime;
    float forcedAdStartTime;
    public float forcedAdElapsedTime;


    [Header("FORCED - SPECIFIC VALUES")]
    public bool forcedAdNewItemActive;
    public bool forcedAdTravelActive;
    public bool forcedAdUnlockActive;

    [Header("FORCED - IDLE ADS")]
    public int idleAdTime;
    public bool idleAdActive;
    public bool idleAdBlocked = true;
    float idleAdStartTime;
    public float idleAdElapsedTime;


    [Header("REWARDED - ENERGY REFILL")]
    public bool energyAdRefillActive;
    public GameObject noEnergyPopup;
    public GameObject adConfirmEnergyRefillPopup;
    public int energyAdRefillAmount;

    [Header("REWARDED - SEED REFILL")]
    public bool seedAdRefillActive;
    public GameObject noSeedPopup;
    public int[] seedAdRefillAmount;

    [Header("REWARDED - ENERGY COLLECTION")]
    public bool energyAdCollectionActive;

    [Header("REWARDED - ENERGY SHOP")]
    public bool energyAdShopActive;
    public iapStoreController energyAdStoreController;




    saveManager saveManager;
    resourcesManager resourcesManager;
    adBalancing adBalancing;
    tapManager tapManager;
    albumManager albumManager;
    iapStoreManager iapStoreManager;


    private void Awake()
    {
        saveManager = GetComponent<saveManager>();
        resourcesManager = GetComponent<resourcesManager>();
        tapManager = GetComponent<tapManager>();
        albumManager = GetComponent<albumManager>();
        iapStoreManager = GetComponent<iapStoreManager>();
        GameObject balancingData = GameObject.Find("balancingData");
        adBalancing = balancingData.GetComponent<adBalancing>();

        //////////////// LISTEN
        //Advertisement.AddListener(this);

        ////////////////
        if (Application.platform == RuntimePlatform.Android)
            gameId = "4102693";
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
            gameId = "4102692";
        else if (Application.platform == RuntimePlatform.WindowsEditor)
            gameId = "4102693";


        //Advertisement.Initialize(gameId, testMode);


        //////////////// GET VALUES
        forcedAdMinLevel = adBalancing.forcedAdMinLevel;
        forcedAdTime = adBalancing.forcedAdTime;
        forcedAdActive = adBalancing.forcedAdActive;
        forcedAdNewItemActive = adBalancing.forcedAdNewItemActive;
        forcedAdTravelActive = adBalancing.forcedAdTravelActive;
        forcedAdUnlockActive = adBalancing.forcedAdUnlockActive;

        idleAdTime = adBalancing.idleAdTime;
        idleAdActive = adBalancing.idleAdActive;

        energyAdRefillActive = adBalancing.energyAdRefillActive;
        energyAdRefillAmount = adBalancing.energyAdRefillAmount;

        seedAdRefillActive = adBalancing.seedAdRefillActive;
        seedAdRefillAmount = adBalancing.seedAdRefillAmount;

        energyAdCollectionActive = adBalancing.energyAdCollectionActive;

        energyAdShopActive = adBalancing.energyAdShopActive;

        // START TIMERS
        RestartForcedAd();
        RestartIdleAd();

    }

    void Update()
    {


        // IDLE ADS
        idleAdElapsedTime = Time.time - idleAdStartTime;

        if (idleAdElapsedTime > idleAdTime)
        {
            bool popupOpen = tapManager.popupOpen;
            if (!popupOpen)
            {
                idleAdBlocked = false;
                ShowInterstitialVideoAd("idle");
            }
            else
                idleAdBlocked = true;
        }
        else
            idleAdBlocked = true;

        // FORCED ADS
        forcedAdElapsedTime = Time.time - forcedAdStartTime;

        if (forcedAdElapsedTime > forcedAdTime)
            forcedAdBlocked = false;
        else
            forcedAdBlocked = true;


    }

    void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            RestartForcedAd();
            RestartIdleAd();
        }
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// MAIN FUNCTIONS

    public void ShowRewardedVideoAd(string placementId)
    {

        if (IsAdAvailable(placementId))
        {
            forcedAdBlocked = true;
            GetComponent<startupManager>().isWatchingAd = true;
            //Advertisement.Show(placementId);
        }

    }


    public void ShowInterstitialVideoAd(string placementId)
    {
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);

        if(currentLevel >= forcedAdMinLevel)
        {
            if (forcedAdActive)
            {
                bool available = false;
                if (placementId == "newItem")
                    available = forcedAdNewItemActive;
                else if (placementId == "travel")
                    available = forcedAdTravelActive;
                else if (placementId == "unlocked")
                    available = forcedAdUnlockActive;
                else if (placementId == "idle")
                    available = idleAdActive;
                /*
                if (available)
                {
                    // BLOCK INTERSTITIAL AD BY TIMER
                    if (!forcedAdBlocked && placementId != "idle")
                    {
                        if (Advertisement.IsReady(placementId))
                        {
                            forcedAdBlocked = true;
                            GetComponent<startupManager>().isWatchingAd = true;
                            Advertisement.Show(placementId);
                        }
                    }
                    // SHOW IDLE AD
                    else if (!idleAdBlocked && placementId == "idle")
                    {
                        if (Advertisement.IsReady(placementId))
                        {
                            forcedAdBlocked = true;
                            GetComponent<startupManager>().isWatchingAd = true;
                            Advertisement.Show(placementId);
                        }
                    }
                    else
                        Debug.Log("Ad "+ placementId+" blocked by timer");
                }
                else
                    Debug.Log("Ad " + placementId + " blocked by data");
                */
            }
            else
                Debug.Log("ALL ADS BLOCKED BY CONFIG");
        }
        //else
        //    Debug.Log("Interstitial ad blocked by level");

    }

    void RestartForcedAd()
    {
        forcedAdStartTime = Time.time;
    }

    void RestartIdleAd()
    {
        Debug.Log("Start idle ad timer");
        idleAdStartTime = Time.time;
    }




    /*
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// CONFIRMATION
    public void OnUnityAdsDidFinish(string placementId, UnityEngine.Advertisements.ShowResult showResult)
    {

        if (showResult == UnityEngine.Advertisements.ShowResult.Finished)
        {
            ConfirmAdEnd(placementId);

            RestartIdleAd();
            RestartForcedAd();
        }
            
    }
    */

    void ConfirmAdEnd ( string placementId)
    {
        Debug.Log("Ad shown with Id " + placementId);

        if (placementId == "energyAdRefill")
            ConfirmEnergyAdRefill();
        else if (placementId == "seedAdRefill")
            ConfirmSeedAdRefill();
        else if (placementId == "energyAdCollection")
            ConfirmEnergyAdCollection();
        else if (placementId == "energyAdShop")
            ConfirmEnergyAdShop();
    }

    void ConfirmEnergyAdRefill()
    {
        // CLOSE
        noEnergyPopup.GetComponent<Animation>().Play("a_hardClose");
        noEnergyPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

        // OPEN
        adConfirmEnergyRefillPopup.GetComponent<Animation>().Play("a_spawn");
        adConfirmEnergyRefillPopup.GetComponent<GraphicRaycaster>().enabled = true;
        tapManager.OpenPopup();
        
    }

    void ConfirmSeedAdRefill()
    {
        CollectSeedAdRefill();
    }

    void ConfirmEnergyAdCollection()
    {
        CollectSeedAdCollection();
    }

    void ConfirmEnergyAdShop()
    {
        iapStoreManager.TryPurchase(energyAdStoreController);
    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// COLLECT

    public void CollectEnergyAdRefill()
    {
        Debug.Log("Close ad confirmation popup");

        // GIVE REWARD
        Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
        GetComponent<feedbackManager>().UiReward(energyAdRefillAmount, pos, "energy", "videoAd");

        // CLOSE
        adConfirmEnergyRefillPopup.GetComponent<Animation>().Play("a_close");
        adConfirmEnergyRefillPopup.GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();

    }
    void CollectSeedAdRefill()
    {
        resourcesManager.RefillPackAd();
    }

    void CollectSeedAdCollection()
    {
        albumManager.CollectMilestone();
    }

    void CollectEnergyAdShop()
    {

    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// CHEAT POPUP
    public void StartCheatRewardedAd()
    {

        ShowRewardedVideoAd("cheatRewardedAd");

    }
    public void StartCheatInterstitialAd()
    {

        ShowInterstitialVideoAd("cheatInterstitialAd");

    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// UTILS
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

    public bool IsAdAvailable(string placementId)
    {
        bool isAvailable = false;

        /*
        if (Advertisement.IsReady(placementId))
            isAvailable = true;
        */
        return isAvailable;

    }


    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// LISTENINGS
    public void OnUnityAdsReady(string newPlacementId)
    {
    }

    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnDestroy()
    {
        //Advertisement.RemoveListener(this);
    }

}
