using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class xpManager : MonoBehaviour
{

    xpBalancing xpBalancing;
    energyBalancing energyBalancing;
    resourcesBalancing resourcesBalancing;
    analyticsManager analyticsManager;
    saveManager saveManager;
    tapManager tapManager;

    [Header("PLAYER STATE")]
    public int currentXp;
    public int currentXpShown;
    public int currentLevel;

    [Header("UI")]
    public Text xpText;
    public TextMeshProUGUI levelText;
    public float progressPercent;
    public Image progress;

    [Header("TOOLTIP")]
    public GameObject tooltip;
    public TextMeshProUGUI values;
    public TextMeshProUGUI descText;
    public TextMeshProUGUI xpLeft;



    [Header("LEVEL UP")]
    bool unlockPopupToShow = false;
    public GameObject levelupPopup;
    public GameObject unlockPopup;

    [Header("LEVEL UP TIMIMGS")]
    public float levelNumberChangeTime;
    public float levelNumberChangeTimeDelay;
    public float energyShowTiming;
    public float energyPopTiming;
    public float fertilizerShowTiming;
    public float fertilizerPopTiming;
    public float diamondsShowTiming;
    public float diamondsPopTiming;
    public float buildginsShowTiming;
    public float levelHideStartTiming;
    public float levelHideEndTiming;

    [Header("LEVEL UP POPUP")]
    // positions
    public Vector2 energyPos;
    public Vector2 fertilizerPos;
    public Vector2 diamondsPos;
    // animations
    public Animation energyReward;
    public Animation freeFertilizer;
    public Animation freeDiamonds;
    public Animation buildingsRefill;
    // texs
    public TextMeshProUGUI levelupText;
    public TextMeshProUGUI energyRewardText;
    public TextMeshProUGUI freeFertilizerText;
    public TextMeshProUGUI freeDiamondsText;
    int energyRewardValue;
    int diamondsRewardValue;
    int fertilizerRewardValue;



    [Header("UNLOCK")]
    public bool unlockPopupIn;


    [Header("MISC")]
    public TextMeshProUGUI logText;

    void Start()
    {
        xpBalancing = GameObject.Find("balancingData").GetComponent<xpBalancing>();
        energyBalancing = GameObject.Find("balancingData").GetComponent<energyBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        resourcesBalancing = GameObject.Find("balancingData").GetComponent<resourcesBalancing>();
        saveManager = GetComponent<saveManager>();
        tapManager = GetComponent<tapManager>();

        InitXp();
    }



    public void InitXp()
    {

        // Get total XP
        currentXp = saveManager.GetSavedInt("currentXp");

        // UPDATE LEVEL
        currentLevel = GetLevel(currentXp);

        // Update UI
        UpdateUI();

    }


    public void ShowTooltip()
    {
        //Debug.Log("Tap Button");
        currentXp = saveManager.GetSavedInt("currentXp");
        tooltip.GetComponent<Animation>().Play("a_spawn");
        int current = currentXp - xpBalancing.xpRequirements[currentLevel-1];
        int next = xpBalancing.xpRequirements[currentLevel];
        int left = next - currentXp;

        values.text = current.ToString() + "/" + next.ToString();
        xpLeft.text = left.ToString();

        values.GetComponent<autoSizeText>().RedoFontSize();
        descText.GetComponent<autoSizeText>().RedoFontSize();
        xpLeft.GetComponent<autoSizeText>().RedoFontSize();
    }

    
    
    public void AddXp(int xpToAdd)
    {
        // XP BEFORE ADDING
        int tmpLevel = currentLevel;

        // UPDATE NEW XP
        int xpPrefs = saveManager.GetSavedInt("currentXp");
        currentXp = xpPrefs + xpToAdd;
        Save(currentXp); 

        // UPDATE LVEL
        currentLevel = GetLevel(currentXp);        
        if (tmpLevel < currentLevel)
            StartCoroutine(LevelupSequence());

    
        // Update UI
        UpdateUI();


    }

    IEnumerator LevelupSequence()
    {

        //////////////////////////// LEVEL UP VALUES
        LevelupValues();


        //////////////////////////// TRACKING
        analyticsManager.StartLevel(currentLevel);

        //////////////////////////// SCALE 0 FOR REWARDS
        energyReward.transform.localScale = Vector3.zero;
        freeFertilizer.transform.localScale = Vector3.zero;
        freeDiamonds.transform.localScale = Vector3.zero;
        buildingsRefill.transform.localScale = Vector3.zero;


        //////////////////////////// SHOW POPUP
        tapManager.OpenPopup();
        float levelTiming;
        if (GetComponent<gardenManager>().popupIsOpen)
        {            
            levelTiming = levelNumberChangeTimeDelay;
            levelupPopup.GetComponent<Animation>().Play("levelup_spawn_delay");
        }
        else
        {
            levelTiming = levelNumberChangeTime;
            levelupPopup.GetComponent<Animation>().Play("levelup_spawn");
        }


        //////////////////////////// UPDATE LEVEL NUMBER
        levelupText.text = (currentLevel -1).ToString();
        yield return new WaitForSeconds(levelTiming);
        levelupText.text = (currentLevel).ToString();


        //////////////////////////// ENERGY
        //SHOW
        yield return new WaitForSeconds(energyShowTiming);
        energyReward.Play("levelText_show");
        //POP
        yield return new WaitForSeconds(energyPopTiming);
        GetComponent<feedbackManager>().UiReward(energyRewardValue, energyPos, "energy", "levelup");

        // FERTILIZER
        //SHOW
        yield return new WaitForSeconds(fertilizerShowTiming);
        freeFertilizer.Play("levelText_show");
        //POP
        yield return new WaitForSeconds(fertilizerPopTiming);
        GetComponent<feedbackManager>().UiReward(fertilizerRewardValue, fertilizerPos, "fertilizer", "levelup");

        // DIAMONDS
        //SHOW
        yield return new WaitForSeconds(diamondsShowTiming);
        freeDiamonds.Play("levelText_show");
        //POP
        yield return new WaitForSeconds(diamondsPopTiming);
        GetComponent<feedbackManager>().UiReward(diamondsRewardValue, diamondsPos, "diamonds", "levelup");


        // BUILDINGS REFILL
        yield return new WaitForSeconds(buildginsShowTiming);
        GetComponent<resourcesManager>().RefillAllSeeds();
        buildingsRefill.Play("levelText_show");


        // FINISH LEVEL UP POPUP
        yield return new WaitForSeconds(levelHideStartTiming);
        levelupPopup.GetComponent<Animation>().Play("levelup_hide");
        tapManager.ClosePopup();

        // CHECK SHOP NOTIFS
        if (currentLevel == 3)
            GetComponent<iapStoreManager>().CheckNotifs();

        // SHOW UNLOCK POPUP    
        yield return new WaitForSeconds(levelHideEndTiming);
        if (unlockPopupToShow)
            GetComponent<unlockManager>().ShowUnlockPopup();
        else
            EndLevel();


        yield return null;
    }

    public void EndLevel()
    {
        unlockPopupToShow = false;
        GetComponent<tapManager>().popupOpen = false;

        ////////////// CHECK DECORATIONS
        //StartCoroutine(GetComponent<gardenManager>().CheckAllFeedbackAndColliders());
    }



    public void LevelupValues()
    {

        /////////////////////////////////// REWARDS      
        int offset;
        if (currentLevel - 1 > energyBalancing.levelupReward.Length)
            offset = 1;
        else
            offset = 2;
        energyRewardValue = energyBalancing.levelupReward[currentLevel - offset];
        diamondsRewardValue = resourcesBalancing.freeDiamonds[currentLevel - offset];
        fertilizerRewardValue = resourcesBalancing.freeFertilizer[currentLevel - offset];
        energyRewardText.text = "+" + energyRewardValue.ToString();
        freeFertilizerText.text = "+" + fertilizerRewardValue.ToString();
        freeDiamondsText.text = "+" + diamondsRewardValue.ToString();
        

        ///////////////////////////////////// HIDE GARDEN POPUP
        /*
        if (GetComponent<gardenManager>().popupIsOpen)
            GetComponent<gardenManager>().HideOptionsPopup("levelup");
        */

        ///////////////// SHOW UNLOCK POPUP?
        bool toShow = GetComponent<unlockManager>().ShouldSownUnlock();
        unlockPopupToShow = toShow;


        ////////////// BLOCK TAPS
        GetComponent<tapManager>().popupOpen = true;



        ////////////// Unlock orders
        GetComponent<orderManager>().UnlockOrders(currentLevel);


        ////////////// UNLOCK TILES        
        GameObject.Find("grid0").GetComponent<gridController>().CheckTilesLock(currentLevel);
        GameObject.Find("grid1").GetComponent<gridController>().CheckTilesLock(currentLevel);

    }



    public int GetLevel(int xp)
    {
        int level = 0;

        // Update level
        if(!xpBalancing)
        xpBalancing = GameObject.Find("balancingData").GetComponent<xpBalancing>();

        for (int i = 0; i < xpBalancing.xpRequirements.Length; i++)
        {
            if (xp >= xpBalancing.xpRequirements[i])
            {
                level = i + 1;
                currentXpShown = xp - xpBalancing.xpRequirements[i];
                float xpLeft = 1f * (xpBalancing.xpRequirements[i + 1] - xpBalancing.xpRequirements[i]);
                progressPercent = (1f * currentXpShown) / (1f * xpLeft);
            }
        }

        return level;
    }


    public void UpdateUI()
    {
       // xpText.text = currentXpShown.ToString();
        levelText.text = currentLevel.ToString();
        progress.fillAmount = progressPercent;

    }

    public void CheatLevel()
    {
        int xpRemaining = xpBalancing.xpRequirements[currentLevel + 1] - currentXp;
        AddXp(xpRemaining);


    }

    void Save(int m_currentXp)
    {

        saveManager.SaveInt("currentXp", m_currentXp);

    }

}
