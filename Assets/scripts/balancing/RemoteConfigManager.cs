using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Unity.RemoteConfig;
using UnityEngine.SceneManagement;
using TMPro;
using System.Globalization;
//using GameAnalyticsSDK;

public class RemoteConfigManager : MonoBehaviour
{
    //public bool allDataLoaded = false;
    [Header("SETTINGS ------------")]
    public string environmentId;
    public struct userAttributes { }
    public struct appAttributes { }

    [Header("LOADING TEXTS ------------")]
    public TextMeshProUGUI loadingTitle;
    public TextMeshProUGUI loadingDesc;

    [Header("DEBUG ------------")]
    public TextMeshProUGUI logText;
    public TextMeshProUGUI playerIdText;
    public TextMeshProUGUI gameVersionText;


    public static bool created = false;
    public string playerId;


    [Header("LOADING BAR ------------")]
    public Image loadingBar;
    public Image loadingBarOverlay;
    float refSizeMin = 40f;
    float refSizeMax = 648f;
    float refScreenWidth = 1440;
    float maxProgress = 19;
    float currentProgress;
    float sizeProportion;

    float refSizeOverlay = 600f;

    [Header("FADE ------------")]
    public Image filter;
    public AnimationCurve fadeOutAnim;
    public float animTime;
    public float animStartTime;

    void Awake()
    {
        TinySauce.OnGameStarted();
        TinySauce.OnGameFinished(0);

        sizeProportion = Screen.width / refScreenWidth;
        AddLoadingProgress(0);

        playerIdText.text = SystemInfo.deviceUniqueIdentifier;
        gameVersionText.text = "v" + Application.version.ToString();


        DontDestroyOnLoad(gameObject);

        if (!created)
        {
            ReloadData();
            created = true;
        }

    }

    public void LoadGame()
    {
        SceneManager.LoadScene("main");
    }
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////////// DATA

    void AddLoadingProgress(int progressAdded)
    {
        currentProgress += progressAdded;
        float proportion = currentProgress / maxProgress;

        float barSize = (refSizeMin + (refSizeMax - refSizeMin) * proportion) * sizeProportion;
        float overlaySzie = (refSizeOverlay * proportion) * sizeProportion;

        if (loadingBar)
            loadingBar.GetComponent<RectTransform>().sizeDelta = new Vector2(barSize, 14);
        if (loadingBarOverlay)
            loadingBarOverlay.GetComponent<RectTransform>().sizeDelta = new Vector2(overlaySzie, 0);


    }

    IEnumerator FadeOut()
    {
        animStartTime = Time.time;

        while (Time.time <animStartTime + animTime)
        {
            filter.GetComponent<Animation>().Play("a_show");

            float proportion = (Time.time - animStartTime) / animTime;
            float evaluation = fadeOutAnim.Evaluate(proportion);
            var tempColor = filter.color;
            tempColor.a = evaluation;
            if(filter)
                filter.color = tempColor;
            yield return null;
        }


        yield return null;
    }



    ////////////////////////////////////////////////////////////////////////////////////////////////////////// DATA
    public void ReloadData()
    {

        ConfigManager.FetchCompleted += ApplyRemoteSettings;

        ConfigManager.SetCustomUserID("some-user-id");

        ConfigManager.SetEnvironmentID(environmentId);


        // Fetch configuration setting from the remote service:
        ConfigManager.FetchConfigs<userAttributes, appAttributes>(new userAttributes(), new appAttributes());

    }
    void ApplyRemoteSettings(ConfigResponse configResponse)
    {

        // Conditionally update settings, depending on the response's origin:
        switch (configResponse.requestOrigin)
        {
            case ConfigOrigin.Default:
                //logText.text =("No settings loaded this session; using default values.");
                break;
            case ConfigOrigin.Cached:
                //logText.text = ("No settings loaded this session; using cached values from a previous session.");
                break;
            case ConfigOrigin.Remote:
                //logText.text = ("New settings loaded this session; update values accordingly.");
                StartCoroutine(FetchAllBalancing());

                break;
        }
    }


    IEnumerator FetchAllBalancing()
    {
        float waitTime = 0.0f;

        //Debug.Log("Fetch Balancing");


        ApplyLocalizationSettings();
        //feedbackText.text += "\ntechincal fetched";
        yield return new WaitForSeconds(waitTime);


        AddLoadingProgress(1);

        ApplyTileSettings();
        //feedbackText.text += "\ntiles fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyEnergySettings();
        //feedbackText.text += "\nenergy fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyXpSettings();
        //feedbackText.text += "\nxp fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyItemsSettings();
        //feedbackText.text += "\nitems fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyPictureSettings();
        //feedbackText.text += "\npicture fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyOrdersSettings();
        //feedbackText.text += "\norders fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyOrderFamilySettings();
        //feedbackText.text += "\norders fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplySpecialOrderSettings();
        //feedbackText.text += "\norders fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);


        ApplyResourcesSettings();
        //feedbackText.text += "\nresources fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyAlbumSettings();
        //feedbackText.text += "\nalbum fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplySpawnerSettings();
        //feedbackText.text += "\nspawners fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyBirdSettings();
        //feedbackText.text += "\nsBirds fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyTechnicalSettings();
        //feedbackText.text += "\ntechincal fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyUnlockSettings();
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyGardenSettings();
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyStoreSettings();
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyIslandSettings();
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyAdSettings();
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyPetsSettings();
        //feedbackText.text += "\nitems fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyPetsStatsSettings();
        //feedbackText.text += "\nitems fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);

        ApplyPetsShopSettings();
        //feedbackText.text += "\nitems fetched";
        yield return new WaitForSeconds(waitTime);
        AddLoadingProgress(1);


        yield return null;

        LoadGame();



    }

    IEnumerator HideClouds()
    {
        var tempColor = filter.color;
        tempColor.a = 0;
        if (filter)
            filter.color = tempColor;

        filter.GetComponent<Animation>().Play("a_hide");

        yield return null;
    }

    void ApplyLocalizationSettings()
    {
        loading loading = GameObject.Find("loading").GetComponent<loading>();

        if (loading)
        {
            /////////////////////////////////// LANGUAGE
            int currentLanguage;
            if (PlayerPrefs.GetInt("firstStart") == 0)
            {
                if (Application.systemLanguage == SystemLanguage.French)
                    currentLanguage = 0;
                else if (Application.systemLanguage == SystemLanguage.English)
                    currentLanguage = 1;
                else
                    currentLanguage = 1;
            }
            else
                currentLanguage = PlayerPrefs.GetInt("currentLanguage");

            /////////////////////////////////// LOADING TEXT
            int randomText = Random.Range(0, loading.descriptionsIds.Length);
            int randomId = loading.descriptionsIds[randomText];


            localizationData localizationData = GetComponent<localizationData>();
            /////////////////////////////////// FR
            string locaData_FR = ConfigManager.appConfig.GetString("localizationData_fr");
            string[] localizationsKeys_fr = locaData_FR.Split('|');

            for (int i = 0; i < localizationsKeys_fr.Length; i++)
            {
                if (i == 0)
                    localizationData.localizationsKeys_fr = new string[localizationsKeys_fr.Length];
                localizationData.localizationsKeys_fr[i] = localizationsKeys_fr[i];


                if (i == 66 && currentLanguage == 0)
                {
                    loadingTitle.text = localizationsKeys_fr[i];
                }
                // LOADING DESC
                if (i == randomId && currentLanguage == 0)
                {
                    loadingDesc.text = localizationsKeys_fr[randomId];
                }
            }

            /////////////////////////////////// EN
            string locaData_EN = ConfigManager.appConfig.GetString("localizationData_en");
            string[] localizationsKeys_en= locaData_EN.Split('|');

            for (int i = 0; i < localizationsKeys_en.Length; i++)
            {
                if (i == 0)
                    localizationData.localizationsKeys_en = new string[localizationsKeys_en.Length];
                localizationData.localizationsKeys_en[i] = localizationsKeys_en[i];


                if (i == 66 && currentLanguage == 1)
                {
                    loadingTitle.text = localizationsKeys_en[i];
                }
                if (i == randomId && currentLanguage == 1)
                {
                    loadingDesc.text = localizationsKeys_en[randomId];
                }
            }


            // OLD
            /*
            for (int i = 0; i < splitString.Length; i++)
            {
                string[] loca_split1 = splitString[i].Split('/');
                for (int j = 0; j < loca_split1.Length; j++)
                {
                    if (i == 0 && j == 0)
                        localizationData.localizationsKeys = new string[splitString.Length, loca_split1.Length];
                    localizationData.localizationsKeys[i, j] = loca_split1[j];

                    // LOADING TITLE
                    if (i == 66 && j == currentLanguage)
                    {
                        if (loadingText)
                        {
                            loadingText.text = loca_split1[j];
                        }
                    }
                    // LOADING DESC
                    if (i == randomId && j == currentLanguage)
                    {
                        loading.loadingDesc.text = localizationData.localizationsKeys[randomId, currentLanguage];
                        //loading.loadingDesc.GetComponent<autoSizeText>().RedoFontSize();
                    }
                }
            }
            */
        }



    }


    void ApplyEnergySettings()
    {

        energyBalancing energyBalancing = GetComponent<energyBalancing>();
        string energyData = ConfigManager.appConfig.GetString("energyData");
        string[] splitString = energyData.Split(',');


        // BASIC VALLUES
        energyBalancing.energyMax = int.Parse(splitString[0].Trim());
        energyBalancing.energyRefillRate = int.Parse(splitString[1].Trim());
        energyBalancing.rewardedVideoEnergyReward = int.Parse(splitString[2].Trim());


        // LEVEL UP REWARDS
        string lvlupRewardsString = splitString[3].Trim();
        string[] lvlupRewardsString_split = lvlupRewardsString.Split('|');
        energyBalancing.levelupReward = new int[lvlupRewardsString_split.Length];
        for (int i=0; i < lvlupRewardsString_split.Length; i++)
            energyBalancing.levelupReward[i] = int.Parse(lvlupRewardsString_split[i].Trim());



        // ALBUM REWARDS
        string albumrewardsString = splitString[4].Trim();
        string[] albumRewardsString_split = albumrewardsString.Split('|');
        energyBalancing.albumRewards = new int[albumRewardsString_split.Length];
        for (int i = 0; i < albumRewardsString_split.Length; i++)
            energyBalancing.albumRewards[i] = int.Parse(albumRewardsString_split[i].Trim());


        // DESTROY REWARDS
        string destroyRewards = splitString[5].Trim();
        string[] destroyRewards_split = destroyRewards.Split('|');
        energyBalancing.destroyRewards = new int[destroyRewards_split.Length];
        for (int i = 0; i < destroyRewards_split.Length; i++)
            energyBalancing.destroyRewards[i] = int.Parse(destroyRewards_split[i].Trim());


    }

    
    void ApplyXpSettings()
    {
        xpBalancing xpBalancing = GetComponent<xpBalancing>();
        string xpData = ConfigManager.appConfig.GetString("xpData");
        string[] splitString = xpData.Split(',');

        // XP REQUIREMENTS
        string xpRequirements = splitString[0].Trim();
        string[] xpRequirements_split = xpRequirements.Split('|');
        xpBalancing.xpRequirements = new int[xpRequirements_split.Length];

        for (int i = 0; i < xpRequirements_split.Length; i++)
        {
            xpBalancing.xpRequirements[i] = int.Parse(xpRequirements_split[i].Trim());
        }


        // XP MULTIPLIER
        string xpMultiplier = splitString[1].Trim();
        xpBalancing.xpMultiplier = float.Parse(xpMultiplier.Trim(), new CultureInfo("en-US").NumberFormat);

        // XP REQUIREMENTS
        string oldXp = splitString[0].Trim();
        string[] oldXp_split = oldXp.Split('|');
        xpBalancing.oldXp = new int[oldXp_split.Length];

        for (int i = 0; i < oldXp_split.Length; i++)
        {
            xpBalancing.oldXp[i] = int.Parse(oldXp_split[i].Trim());
        }

    }


    void ApplyItemsSettings()
    {
        itemBalancing itemBalancing = GetComponent<itemBalancing>();
        string itemData = ConfigManager.appConfig.GetString("itemsData");
        int currentCheck = 0;


        string[] splitString = itemData.Split(',');

        // Max Tier
        string maxTierSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] maxTierSplit_split = maxTierSplit.Split('|');
        itemBalancing.maxTier = new int[maxTierSplit_split.Length];
        for (int i = 0; i < maxTierSplit_split.Length; i++)
        {
            itemBalancing.maxTier[i] = int.Parse(maxTierSplit_split[i].Trim());
        }

        // Family Names
        string namesSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] namesSplit_split = namesSplit.Split('|');
        itemBalancing.familyNames = new string[namesSplit_split.Length];
        for (int i = 0; i < namesSplit_split.Length; i++)
        {
            itemBalancing.familyNames[i] = namesSplit_split[i].Trim();
        }

        // Branching names
        // - carrots
        string branchingSplit1 = splitString[currentCheck].Trim();
        currentCheck++;
        string[] branchingSplit1_split = branchingSplit1.Split('|');
        itemBalancing.carrotBranchingFamilies = new int[branchingSplit1_split.Length];
        for (int i = 0; i < branchingSplit1_split.Length; i++)
            itemBalancing.carrotBranchingFamilies[i] = int.Parse(branchingSplit1_split[i].Trim());
        // - apple
        string branchingSplit2 = splitString[currentCheck].Trim();
        currentCheck++;
        string[] branchingSplit2_split = branchingSplit2.Split('|');
        itemBalancing.appleBranchingFamilies = new int[branchingSplit2_split.Length];
        for (int i = 0; i < branchingSplit2_split.Length; i++)
            itemBalancing.appleBranchingFamilies[i] = int.Parse(branchingSplit2_split[i].Trim());
        // - raspberry
        string branchingSplit3 = splitString[currentCheck].Trim();
        currentCheck++;
        string[] branchingSplit3_split = branchingSplit3.Split('|');
        itemBalancing.raspberryBranchingFamilies = new int[branchingSplit3_split.Length];
        for (int i = 0; i < branchingSplit3_split.Length; i++)
            itemBalancing.raspberryBranchingFamilies[i] = int.Parse(branchingSplit3_split[i].Trim());

        // Carrot Branching
        currentCheck++;

        // Apple Branching
        currentCheck++;

        // Raspberry Branching
        currentCheck++;

        // SPAWNERS
        string spawners = splitString[currentCheck].Trim();
        currentCheck++;
        string[] spawners_split = spawners.Split('|');
        itemBalancing.spawners = new int[spawners_split.Length];
        for (int i = 0; i < spawners_split.Length; i++)
        {
            itemBalancing.spawners[i] = int.Parse(spawners_split[i].Trim());
        }


        // LOCALIZATION
        string localizationKey = splitString[currentCheck].Trim();
        currentCheck++;
        string[] localizationKey_split = localizationKey.Split('|');
        itemBalancing.localizationKey = new int[localizationKey_split.Length];
        for (int i = 0; i < localizationKey_split.Length; i++)
        {
            itemBalancing.localizationKey[i] = int.Parse(localizationKey_split[i].Trim());
        }


        // COLORS
        string familyColors = splitString[currentCheck].Trim();
        currentCheck++;
        string[] familyColors_split = familyColors.Split('|');
        itemBalancing.familyColors = new string[familyColors_split.Length];
        for (int i = 0; i < familyColors_split.Length; i++)
        {
            itemBalancing.familyColors[i] = familyColors_split[i].Trim();
        }

        //  SOY BRANCHING
        // Names
        string soyBranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] soyBranchingFamilies_split = soyBranchingFamilies.Split('|');
        itemBalancing.soyBranchingFamilies = new int[soyBranchingFamilies_split.Length];
        for (int i = 0; i < soyBranchingFamilies_split.Length; i++)
            itemBalancing.soyBranchingFamilies[i] = int.Parse(soyBranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // CHOCOLATE BRANCHING
        // Names
        string chocolateBranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] chocolateBranchingFamilies_split = chocolateBranchingFamilies.Split('|');
        itemBalancing.chocolateBranchingFamilies = new int[chocolateBranchingFamilies_split.Length];
        for (int i = 0; i < chocolateBranchingFamilies_split.Length; i++)
            itemBalancing.chocolateBranchingFamilies[i] = int.Parse(chocolateBranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // COFFEE BRANCHING
        // Names
        string coffeeBranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] coffeeBranchingFamilies_split = coffeeBranchingFamilies.Split('|');
        itemBalancing.coffeeBranchingFamilies = new int[coffeeBranchingFamilies_split.Length];
        for (int i = 0; i < coffeeBranchingFamilies_split.Length; i++)
            itemBalancing.coffeeBranchingFamilies[i] = int.Parse(coffeeBranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // BRONZE BRANCHING
        // Names
        string bronzeBranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] bronzeBranchingFamilies_split = bronzeBranchingFamilies.Split('|');
        itemBalancing.bronzeBranchingFamilies = new int[bronzeBranchingFamilies_split.Length];
        for (int i = 0; i < bronzeBranchingFamilies_split.Length; i++)
            itemBalancing.bronzeBranchingFamilies[i] = int.Parse(bronzeBranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // SILVER1 BRANCHING
        // Names
        string silver1BranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] silver1BranchingFamilies_split = silver1BranchingFamilies.Split('|');
        itemBalancing.silver1BranchingFamilies = new int[silver1BranchingFamilies_split.Length];
        for (int i = 0; i < silver1BranchingFamilies_split.Length; i++)
            itemBalancing.silver1BranchingFamilies[i] = int.Parse(silver1BranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // GOLD1 BRANCHING
        // Names
        string gold1BranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] gold1BranchingFamilies_split = gold1BranchingFamilies.Split('|');
        itemBalancing.gold1BranchingFamilies = new int[gold1BranchingFamilies_split.Length];
        for (int i = 0; i < gold1BranchingFamilies_split.Length; i++)
            itemBalancing.gold1BranchingFamilies[i] = int.Parse(gold1BranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // CACTUS1 BRANCHING
        // Names
        string cactus1BranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] cactus1BranchingFamilies_split = cactus1BranchingFamilies.Split('|');
        itemBalancing.cactus1BranchingFamilies = new int[cactus1BranchingFamilies_split.Length];
        for (int i = 0; i < cactus1BranchingFamilies_split.Length; i++)
            itemBalancing.cactus1BranchingFamilies[i] = int.Parse(cactus1BranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // CACTUS2 BRANCHING
        // Names
        string cactus2BranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] cactus2BranchingFamilies_split = cactus2BranchingFamilies.Split('|');
        itemBalancing.cactus2BranchingFamilies = new int[cactus2BranchingFamilies_split.Length];
        for (int i = 0; i < cactus2BranchingFamilies_split.Length; i++)
            itemBalancing.cactus2BranchingFamilies[i] = int.Parse(cactus2BranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // PINEAPPLE1 BRANCHING
        // Names
        string pineapple1BranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] pineapple1BranchingFamilies_split = pineapple1BranchingFamilies.Split('|');
        itemBalancing.pineapple1BranchingFamilies = new int[pineapple1BranchingFamilies_split.Length];
        for (int i = 0; i < pineapple1BranchingFamilies_split.Length; i++)
            itemBalancing.pineapple1BranchingFamilies[i] = int.Parse(pineapple1BranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // BANANA BRANCHING
        // Names
        string bananaBranchingFamilies = splitString[currentCheck].Trim();
        currentCheck++;
        string[] bananaBranchingFamilies_split = bananaBranchingFamilies.Split('|');
        itemBalancing.bananaBranchingFamilies = new int[bananaBranchingFamilies_split.Length];
        for (int i = 0; i < bananaBranchingFamilies_split.Length; i++)
            itemBalancing.bananaBranchingFamilies[i] = int.Parse(bananaBranchingFamilies_split[i].Trim());
        // Branching
        currentCheck++;

        // ITEM ISLAND
        string itemIslandSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] itemIsland_split = itemIslandSplit.Split('|');
        itemBalancing.itemIsland = new int[itemIsland_split.Length];
        for (int i = 0; i < itemIsland_split.Length; i++)
        {
            itemBalancing.itemIsland[i] = int.Parse(itemIsland_split[i].Trim());
        }

        // ITEM AND CURRENCIS
        string itemResourceInOrder = splitString[currentCheck].Trim();
        currentCheck++;
        string[] itemResourceInOrder_split1 = itemResourceInOrder.Split('|');
        for (int i = 0; i < itemResourceInOrder_split1.Length; i++)
        {
            string[] itemResourceInOrder_split2 = itemResourceInOrder_split1[i].Split('/');
            if (i == 0)
                itemBalancing.itemResourceInOrder = new bool[itemResourceInOrder_split1.Length, itemResourceInOrder_split2.Length];
            for (int j = 0; j < itemResourceInOrder_split2.Length; j++)
            {
                itemBalancing.itemResourceInOrder[i, j] = bool.Parse(itemResourceInOrder_split2[j].Trim());
            }
        }

        // levelUnlock
        string levelUnlockSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] levelUnlock_split = levelUnlockSplit.Split('|');
        itemBalancing.levelUnlock = new int[levelUnlock_split.Length];
        for (int i = 0; i < levelUnlock_split.Length; i++)
        {
            itemBalancing.levelUnlock[i] = int.Parse(levelUnlock_split[i].Trim());
        }

        // isBranchItem
        string isBranchItemSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] isBranchItem_split = isBranchItemSplit.Split('|');
        itemBalancing.isBranchItem = new bool[isBranchItem_split.Length];
        for (int i = 0; i < isBranchItem_split.Length; i++)
        {
            itemBalancing.isBranchItem[i] = bool.Parse(isBranchItem_split[i].Trim());
        }

        // spawnerWeight_lv1
        string spawnerWeight_lv1Split = splitString[currentCheck].Trim();
        currentCheck++;
        string[] spawnerWeight_lv1_split = spawnerWeight_lv1Split.Split('|');
        itemBalancing.spawnerWeight_lv1 = new int[spawnerWeight_lv1_split.Length];
        for (int i = 0; i < spawnerWeight_lv1_split.Length; i++)
        {
            itemBalancing.spawnerWeight_lv1[i] = int.Parse(spawnerWeight_lv1_split[i].Trim());
        }

        // spawnerWeight
        string spawnerWeightSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] spawnerWeight_split = spawnerWeightSplit.Split('|');
        itemBalancing.spawnerWeight = new int[spawnerWeight_split.Length];
        for (int i = 0; i < spawnerWeight_split.Length; i++)
        {
            itemBalancing.spawnerWeight[i] = int.Parse(spawnerWeight_split[i].Trim());
        }

        // branchingWeight_lv1
        string branchingWeight_lv1Split = splitString[currentCheck].Trim();
        currentCheck++;
        string[] branchingWeight_lv1_split = branchingWeight_lv1Split.Split('|');
        itemBalancing.branchingWeight_lv1 = new int[branchingWeight_lv1_split.Length];
        for (int i = 0; i < branchingWeight_lv1_split.Length; i++)
        {
            itemBalancing.branchingWeight_lv1[i] = int.Parse(branchingWeight_lv1_split[i].Trim());
        }

        // branchingWeight_regular
        string branchingWeight_regularSplit = splitString[currentCheck].Trim();
        currentCheck++;
        string[] branchingWeight_regular_split = branchingWeight_regularSplit.Split('|');
        itemBalancing.branchingWeight_regular = new int[branchingWeight_regular_split.Length];
        for (int i = 0; i < branchingWeight_regular_split.Length; i++)
        {
            itemBalancing.branchingWeight_regular[i] = int.Parse(branchingWeight_regular_split[i].Trim());
        }

        // dropWeight
        string dropWeight = splitString[currentCheck].Trim();
        currentCheck++;
        string[] dropWeight_split = dropWeight.Split('|');
        itemBalancing.dropWeight = new int[dropWeight_split.Length];
        for (int i = 0; i < dropWeight_split.Length; i++)
        {
            itemBalancing.dropWeight[i] = int.Parse(dropWeight_split[i].Trim());
        }      

    }


    void ApplyPictureSettings()
    {
        // INITIALIZE
        pictureBalancing pictureBalancing = GetComponent<pictureBalancing>();
        string pictureData = ConfigManager.appConfig.GetString("pictureData");
        string[] splitString = pictureData.Split(',');

        // LEVEL UP REWARDS
        string pictureSplit = splitString[0].Trim();
        string[] pictureSplit_split = pictureSplit.Split('|');
        pictureBalancing.picturePrices = new int[pictureSplit_split.Length];
        for (int i = 0; i < pictureSplit_split.Length; i++)
        {
            pictureBalancing.picturePrices[i] = int.Parse(pictureSplit_split[i].Trim());
        }

    }


    void ApplyTileSettings()
    {
        // INITIALIZE
        tileBalancing tileBalancing = GetComponent<tileBalancing>();
        string tileData = ConfigManager.appConfig.GetString("tilesData");
        //Debug.Log("tileData [" + tileData + "]");

        string[] splitString = tileData.Split(',');

        // PRICE
        string tileSplit = splitString[0].Trim();

        string[] tileSplit_split1 = tileSplit.Split('|');
        for (int i = 0; i < tileSplit_split1.Length; i++)
        {
            string[] tileSplit_split2 = tileSplit_split1[i].Split('/');

            for (int j = 0; j < tileSplit_split2.Length; j++)
            {

                string[] tileSplit_split3 = tileSplit_split2[j].Split('-');
                if (i == 0 && j==0)
                    tileBalancing.tilePrices = new int[tileSplit_split1.Length, tileSplit_split2.Length, tileSplit_split3.Length];

                for (int k = 0; k < tileSplit_split3.Length; k++)
                {
                    tileBalancing.tilePrices[i, j, k] = int.Parse(tileSplit_split3[k].Trim(), new CultureInfo("en-US").NumberFormat);
                }
            }            
        }

        // LEVEL
        string unlockSplit = splitString[1].Trim();
        string[] unlockSplit_split1 = unlockSplit.Split('|');
        for (int i = 0; i < unlockSplit_split1.Length; i++)
        {
            string[] unlockSplit_split2 = unlockSplit_split1[i].Split('/');

            for (int j = 0; j < unlockSplit_split2.Length; j++)
            {
                string[] unlockSplit_split3 = unlockSplit_split2[j].Split('-');
                if (i == 0 && j == 0)
                    tileBalancing.tilesLevelUnlock = new int[unlockSplit_split1.Length, unlockSplit_split2.Length, unlockSplit_split3.Length];

                for (int k = 0; k < unlockSplit_split3.Length; k++)
                {
                    //Debug.Log("tile level unlock -" + i.ToString() + " " + j.ToString() + " " + k.ToString() + ": " + int.Parse(unlockSplit_split3[k]));
                    tileBalancing.tilesLevelUnlock[i, j, k] = int.Parse(unlockSplit_split3[k].Trim());
                }
            }

        }

    }


    void ApplyOrdersSettings()
    {

        orderBalancing orderBalancing = GetComponent<orderBalancing>();
        string orderData = ConfigManager.appConfig.GetString("orderData");
        string[] splitString = orderData.Split(',');
        int currentCheck = 0;

        // PRICE VARIATION
        orderBalancing.priceVariation = float.Parse(splitString[0].Trim(), new CultureInfo("en-US").NumberFormat);

        // STARTING PRICES
        currentCheck++;
        string startingPrices = splitString[currentCheck];
        currentCheck++;
        string[] startingPrices_split1 = startingPrices.Split('|');

        for (int i = 0; i < startingPrices_split1.Length; i++)
        {
            string[] startingPrices_split2 = startingPrices_split1[i].Split('/');

            if (i == 0)
                orderBalancing.startingPrices = new float[startingPrices_split1.Length, startingPrices_split2.Length];


            for (int j = 0; j < startingPrices_split2.Length; j++)
                orderBalancing.startingPrices[i, j] = float.Parse(startingPrices_split2[j].Trim(), new CultureInfo("en-US").NumberFormat);

        }

        // TIER MULTIPLIER
        string tierMultiplier = splitString[currentCheck];
        currentCheck++;
        string[] tierMultiplier_split1 = tierMultiplier.Split('|');
        orderBalancing.tierMultiplier = new float[tierMultiplier_split1.Length];
        for (int i = 0; i < tierMultiplier_split1.Length; i++)
        {
            //Debug.LogError("tierMultiplier - " + i + "= " + float.Parse(tierMultiplier_split1[i].Trim()));
            orderBalancing.tierMultiplier[i] = float.Parse(tierMultiplier_split1[i].Trim(), new CultureInfo("en-US").NumberFormat);
        }

        // ITEM COUNT WEIGHT
        string itemCount = splitString[currentCheck];
        currentCheck++;
        string[] itemCount_split1 = itemCount.Split('|');

        for (int i = 0; i < itemCount_split1.Length; i++)
        {
            string[] itemCount_split2 = itemCount_split1[i].Split('/');

            if (i == 0)
                orderBalancing.itemCountWeight = new int[itemCount_split1.Length, itemCount_split2.Length];

            for (int j = 0; j < itemCount_split2.Length; j++)
            {
                //Debug.LogError("itemCountWeight - " + i + " - " + j + "= " + int.Parse(itemCount_split2[j].Trim()));
                orderBalancing.itemCountWeight[i, j] = int.Parse(itemCount_split2[j].Trim());
            }

        }

        // SELL TIME
        string sellTime = splitString[currentCheck];
        currentCheck++;
        string[] sellTime_split1 = sellTime.Split('|');
        orderBalancing.sellTime = new float[sellTime_split1.Length];
        for (int i = 0; i < sellTime_split1.Length; i++)
        {
            //Debug.LogError("sellTime - " + i + "= " + float.Parse(sellTime_split1[i].Trim()));
            orderBalancing.sellTime[i] = float.Parse(sellTime_split1[i].Trim());
        }



        // MIN TIER
        string minTier = splitString[currentCheck];
        currentCheck++;
        string[] minTier_split1 = minTier.Split('|');

        for (int i = 0; i < minTier_split1.Length; i++)
        {
            string[] minTier_split2 = minTier_split1[i].Split('/');

            if (i == 0)
                orderBalancing.minTier = new int[minTier_split1.Length, minTier_split2.Length];

            for (int j = 0; j < minTier_split2.Length; j++)
            {
                //Debug.LogError("minTier - " + i + " - " + j + "= " + int.Parse(minTier_split2[j].Trim()));
                orderBalancing.minTier[i, j] = int.Parse(minTier_split2[j].Trim());
            }

        }

        // MAX TIER
        string maxTier = splitString[currentCheck];
        currentCheck++;
        string[] maxTier_split1 = maxTier.Split('|');

        for (int i = 0; i < maxTier_split1.Length; i++)
        {
            string[] maxTier_split2 = maxTier_split1[i].Split('/');

            if (i == 0)
                orderBalancing.maxTier = new int[maxTier_split1.Length, maxTier_split2.Length];

            for (int j = 0; j < maxTier_split2.Length; j++)
            {
                //Debug.LogError("maxTier - " + i + " - " + j + "= " + int.Parse(maxTier_split2[j].Trim()));
                orderBalancing.maxTier[i, j] = int.Parse(maxTier_split2[j].Trim());
            }

        }
        // REWARD DROP RATE
        string rewardDropRate = splitString[currentCheck];
        currentCheck++;
        string[] rewardDropRate_split1 = rewardDropRate.Split('|');

        for (int i = 0; i < rewardDropRate_split1.Length; i++)
        {
            string[] rewardDropRate_split2 = rewardDropRate_split1[i].Split('/');

            for (int j = 0; j < rewardDropRate_split2.Length; j++)
            {
                string[] rewardDropRate_split3 = rewardDropRate_split2[j].Split('-');
                if (i == 0 && j == 0)
                    orderBalancing.rewardDropRate = new int[rewardDropRate_split1.Length, rewardDropRate_split2.Length, rewardDropRate_split3.Length];

                for (int k = 0; k < rewardDropRate_split3.Length; k++)
                {
                    //Debug.LogError("rewardDropRate - " + i + " - " + j + " - " + k + "= " + int.Parse(rewardDropRate_split3[k].Trim()));
                    orderBalancing.rewardDropRate[i, j, k] = int.Parse(rewardDropRate_split3[k].Trim());
                }
            }

        }


        // ORDERS UNLOCK
        string ordersUnlock = splitString[currentCheck];
        currentCheck++;
        string[] ordersUnlock_split1 = ordersUnlock.Split('|');
        orderBalancing.ordersUnlock = new int[ordersUnlock_split1.Length];
        for (int i = 0; i < ordersUnlock_split1.Length; i++)
        {
            //Debug.LogError("ordersUnlock - " + i + "= " + int.Parse(ordersUnlock_split1[i].Trim()));
            orderBalancing.ordersUnlock[i] = int.Parse(ordersUnlock_split1[i].Trim());
        }


        // TIER MULTIPLIER
        string coinMultiplier = splitString[currentCheck];
        currentCheck++;
        string[] coinMultiplier_split1 = coinMultiplier.Split('|');
        orderBalancing.coinMultiplier = new float[coinMultiplier_split1.Length];
        for (int i = 0; i < coinMultiplier_split1.Length; i++)
        {
            //Debug.LogError("coinMultiplier - " + i + "= " + float.Parse(coinMultiplier_split1[i].Trim()));
            orderBalancing.coinMultiplier[i] = float.Parse(coinMultiplier_split1[i].Trim(), new CultureInfo("en-US").NumberFormat);
        }

        // ORDERS ISLAND
        string boatOrderIsland = splitString[currentCheck];
        currentCheck++;
        string[] boatOrderIsland_split1 = boatOrderIsland.Split('|');
        orderBalancing.boatOrderIsland = new int[boatOrderIsland_split1.Length];
        for (int i = 0; i < boatOrderIsland_split1.Length; i++)
            orderBalancing.boatOrderIsland[i] = int.Parse(boatOrderIsland_split1[i].Trim());

        // forcedOrderId
        string forcedOrderId = splitString[currentCheck];
        currentCheck++;
        string[] forcedOrderId_split1 = forcedOrderId.Split('|');
        orderBalancing.forcedOrderId = new int[forcedOrderId_split1.Length];
        for (int i = 0; i < forcedOrderId_split1.Length; i++)
            orderBalancing.forcedOrderId[i] = int.Parse(forcedOrderId_split1[i].Trim());

        // forcedOrderItemCount
        string forcedOrderItemCount = splitString[currentCheck];
        currentCheck++;
        string[] forcedOrderItemCount_split1 = forcedOrderItemCount.Split('|');
        orderBalancing.forcedOrderItemCount = new int[forcedOrderItemCount_split1.Length];
        for (int i = 0; i < forcedOrderItemCount_split1.Length; i++)
            orderBalancing.forcedOrderItemCount[i] = int.Parse(forcedOrderItemCount_split1[i].Trim());

        // forcedOrderFamilyPicked
        string forcedOrderFamilyPicked = splitString[currentCheck].Trim();
        currentCheck++;
        string[] forcedOrderFamilyPicked_split1 = forcedOrderFamilyPicked.Split('|');
        for (int i = 0; i < forcedOrderFamilyPicked_split1.Length; i++)
        {
            string[] forcedOrderFamilyPicked_split2 = forcedOrderFamilyPicked_split1[i].Split('/');
            if (i == 0)
                orderBalancing.forcedOrderFamilyPicked = new string[forcedOrderFamilyPicked_split1.Length, forcedOrderFamilyPicked_split2.Length];
            for (int j = 0; j < forcedOrderFamilyPicked_split2.Length; j++)
                orderBalancing.forcedOrderFamilyPicked[i, j] = forcedOrderFamilyPicked_split2[j];
        }

        // forcedOrderTierPicked
        string forcedOrderTierPicked = splitString[currentCheck].Trim();
        currentCheck++;
        string[] forcedOrderTierPicked_split1 = forcedOrderTierPicked.Split('|');
        for (int i = 0; i < forcedOrderTierPicked_split1.Length; i++)
        {
            string[] forcedOrderTierPicked_split2 = forcedOrderTierPicked_split1[i].Split('/');
            if (i == 0)
                orderBalancing.forcedOrderTierPicked = new int[forcedOrderTierPicked_split1.Length, forcedOrderTierPicked_split2.Length];
            for (int j = 0; j < forcedOrderTierPicked_split2.Length; j++)
                orderBalancing.forcedOrderTierPicked[i, j] = int.Parse(forcedOrderTierPicked_split2[j].Trim());
        }

        // forcedOrderPrice
        string forcedOrderPrice = splitString[currentCheck];
        currentCheck++;
        string[] forcedOrderPrice_split1 = forcedOrderPrice.Split('|');
        orderBalancing.forcedOrderPrice = new int[forcedOrderPrice_split1.Length];
        for (int i = 0; i < forcedOrderPrice_split1.Length; i++)
            orderBalancing.forcedOrderPrice[i] = int.Parse(forcedOrderPrice_split1[i].Trim());

    }

    void ApplyOrderFamilySettings()
    {
        orderFamilyBalancing orderFamilyBalancing = GetComponent<orderFamilyBalancing>();
        string orderFamilyData = ConfigManager.appConfig.GetString("orderFamilyData");
        string[] splitString = orderFamilyData.Split(',');

        // FAMILY DROP
        string familyDrop = splitString[0];
        string[] familyDrop_split1 = familyDrop.Split('|');

        for (int i = 0; i < familyDrop_split1.Length; i++)
        {
            string[] familyDrop_split2 = familyDrop_split1[i].Split('/');

            for (int j = 0; j < familyDrop_split2.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    orderFamilyBalancing.familyDrop = new int[familyDrop_split1.Length, familyDrop_split2.Length];

                };
                //Debug.Log("Family drop weight - " + " level " + i + ", family id " + j);
                orderFamilyBalancing.familyDrop[i, j] = int.Parse(familyDrop_split2[j].Trim());
            }

        }

    } 
    
    void ApplySpecialOrderSettings()
    {
        specialOrderBalancing specialOrderBalancing = GetComponent<specialOrderBalancing>();
        string specialOrderData = ConfigManager.appConfig.GetString("specialOrderData");
        string[] splitString = specialOrderData.Split(',');
        int currentCheck = 0;

        // timeOrderUnlockLevel
        string timeOrderUnlockLevel = splitString[currentCheck];
        currentCheck++;
        specialOrderBalancing.timeOrderUnlockLevel = int.Parse(timeOrderUnlockLevel.Trim());


        // timeOrderTime
        string timeOrderTime = splitString[currentCheck];
        currentCheck++;
        specialOrderBalancing.timeOrderTime = int.Parse(timeOrderTime.Trim());


        // specialOrderUnlockLevel
        string specialOrderUnlockLevel = splitString[currentCheck];
        currentCheck++;
        specialOrderBalancing.specialOrderUnlockLevel = int.Parse(specialOrderUnlockLevel.Trim());


        // specialOrderMinMultiplier
        string specialOrderMinMultiplier = splitString[currentCheck];
        currentCheck++;
        specialOrderBalancing.specialOrderMinMultiplier = int.Parse(specialOrderMinMultiplier.Trim());


        // specialOrderMaxMultiplier
        string specialOrderMaxMultiplier = splitString[currentCheck];
        currentCheck++;
        specialOrderBalancing.specialOrderMaxMultiplier = int.Parse(specialOrderMaxMultiplier.Trim());


        // specialOrderDropRate   
        string specialOrderDropRate = splitString[currentCheck];
        currentCheck++;
        string[] specialOrderDropRate_split1 = specialOrderDropRate.Split('|');

        for (int i = 0; i < specialOrderDropRate_split1.Length; i++)
        {
            string[] specialOrderDropRate_split2 = specialOrderDropRate_split1[i].Split('/');

            if (i == 0)
                specialOrderBalancing.specialOrderDropRate = new int[specialOrderDropRate_split1.Length, specialOrderDropRate_split2.Length];

            for (int j = 0; j < specialOrderDropRate_split2.Length; j++)
            {
                //Debug.LogError("itemCountWeight - " + i + " - " + j + "= " + int.Parse(itemCount_split2[j].Trim()));
                specialOrderBalancing.specialOrderDropRate[i, j] = int.Parse(specialOrderDropRate_split2[j].Trim());
            }

        }


        // specialOrderTime
        string specialOrderTime = splitString[currentCheck];
        currentCheck++;
        string[] specialOrderTime_split1 = specialOrderTime.Split('|');
        specialOrderBalancing.specialOrderTime = new int[specialOrderTime_split1.Length];
        for (int i = 0; i < specialOrderTime_split1.Length; i++)
        {
            //Debug.LogError("specialOrderTime - " + i + "= " + int.Parse(specialOrderTime_split1[i].Trim()));
            specialOrderBalancing.specialOrderTime[i] = int.Parse(specialOrderTime_split1[i].Trim());
        }

        // specialOrderRewardMultiplier
        string specialOrderRewardMultiplier = splitString[currentCheck];
        currentCheck++;
        string[] specialOrderRewardMultiplier_split1 = specialOrderRewardMultiplier.Split('|');
        specialOrderBalancing.specialOrderRewardMultiplier = new int[specialOrderRewardMultiplier_split1.Length];
        for (int i = 0; i < specialOrderRewardMultiplier_split1.Length; i++)
        {
            //Debug.LogError("specialOrderRewardMultiplier - " + i + "= " + int.Parse(specialOrderRewardMultiplier[i].Trim()));
            specialOrderBalancing.specialOrderRewardMultiplier[i] = int.Parse(specialOrderRewardMultiplier_split1[i].Trim());
        }


    }


    void ApplyResourcesSettings()
    {

        resourcesBalancing resourcesBalancing = GetComponent<resourcesBalancing>();
        string resourcesData = ConfigManager.appConfig.GetString("resourcesData");
        string[] splitString = resourcesData.Split(',');

        // RESROUCES LIST
        string resourcesList = splitString[0].Trim();
        string[] resourcesList_split = resourcesList.Split('|');
        resourcesBalancing.resourcesList = new string[resourcesList_split.Length];
        for (int i = 0; i < resourcesList_split.Length; i++)
        {
            resourcesBalancing.resourcesList[i] = resourcesList_split[i];
        }

        // SEEDS MAX
        string seedsMax = splitString[1].Trim();
        string[] seedsMax_split = seedsMax.Split('|');
        resourcesBalancing.seedsMax = new int[seedsMax_split.Length];
        for (int i = 0; i < seedsMax_split.Length; i++)
        {
            resourcesBalancing.seedsMax[i] = int.Parse(seedsMax_split[i].Trim());
        }


        // SEED REFILL TIME
        string seedsRefill = splitString[2].Trim();
        string[] seedsRefill_split = seedsRefill.Split('|');
        resourcesBalancing.seedsRefill = new int[seedsRefill_split.Length];
        for (int i = 0; i < seedsRefill_split.Length; i++)
        {
            resourcesBalancing.seedsRefill[i] = int.Parse(seedsRefill_split[i].Trim());
        }

        // SEEDS  refill Pack1 Amount
        string refillPack1Amount = splitString[3].Trim();
        string[] refillPack1Amount_split = refillPack1Amount.Split('|');
        resourcesBalancing.refillPack1Amount = new int[refillPack1Amount_split.Length];
        for (int i = 0; i < refillPack1Amount_split.Length; i++)
        {
            resourcesBalancing.refillPack1Amount[i] = int.Parse(refillPack1Amount_split[i].Trim());
        }

        // SEEDS  refill Pack1 Price
        string refillPack1Price = splitString[4].Trim();
        string[] refillPack1Price_split = refillPack1Price.Split('|');
        resourcesBalancing.refillPack1Price = new int[refillPack1Price_split.Length];
        for (int i = 0; i < refillPack1Price_split.Length; i++)
        {
            resourcesBalancing.refillPack1Price[i] = int.Parse(refillPack1Price_split[i].Trim());
        }

        // SEEDS  FULLE REFILL PRICE
        string seedsFullRefillPrice = splitString[5].Trim();
        string[] seedsFullRefillPrice_split = seedsFullRefillPrice.Split('|');
        resourcesBalancing.seedsFullRefillPrice = new int[seedsFullRefillPrice_split.Length];
        for (int i = 0; i < seedsRefill_split.Length; i++)
        {
            resourcesBalancing.seedsFullRefillPrice[i] = int.Parse(seedsFullRefillPrice_split[i].Trim());
        }

        // START FERTILIZER
        string startFertilizer = splitString[6].Trim();
        resourcesBalancing.startFertilizer = int.Parse(startFertilizer.Trim());


        // FERTILIZER LEVEL UP REWARD
        string freeFertilizer = splitString[7].Trim();
        string[] freeFertilizer_split = freeFertilizer.Split('|');
        resourcesBalancing.freeFertilizer = new int[freeFertilizer_split.Length];
        for (int i = 0; i < freeFertilizer_split.Length; i++)
        {
            resourcesBalancing.freeFertilizer[i] = int.Parse(freeFertilizer_split[i].Trim());
        }

        // START DIAMONDS
        string startDiamonds = splitString[8].Trim();
        resourcesBalancing.startDiamonds = int.Parse(startDiamonds.Trim());


        // DIAMONDS LEVEL UP REWARD
        string freeDiamonds = splitString[9].Trim();
        string[] freeDiamonds_split = freeDiamonds.Split('|');
        resourcesBalancing.freeDiamonds = new int[freeDiamonds_split.Length];
        for (int i = 0; i < freeDiamonds_split.Length; i++)
        {
            resourcesBalancing.freeDiamonds[i] = int.Parse(freeDiamonds_split[i].Trim());
        }

        // defaultCoins
        string defaultCoins = splitString[10].Trim();
        resourcesBalancing.defaultCoins = int.Parse(defaultCoins.Trim());
    }

    void ApplyAlbumSettings()
    {

        albumBalancing albumBalancing = GetComponent<albumBalancing>();
        string albumData = ConfigManager.appConfig.GetString("albumData");
        string[] splitString = albumData.Split(',');

        // RESROUCES LIST
        string rewardsMilestones = splitString[0].Trim();
        string[] rewardsMilestones_split = rewardsMilestones.Split('|');
        albumBalancing.rewardsMilestones = new int[rewardsMilestones_split.Length];
        for (int i = 0; i < rewardsMilestones_split.Length; i++)
        {
            albumBalancing.rewardsMilestones[i] = int.Parse(rewardsMilestones_split[i].Trim());
        }

    }

    void ApplySpawnerSettings()
    {
        spawnerBalancing spawnerBalancing = GetComponent<spawnerBalancing>();
        string spawnerData = ConfigManager.appConfig.GetString("spawnerData");
        string[] splitString = spawnerData.Split(',');
        int rowChecked = 0;

        // FAMILY DROP ID
        string familyDropID = splitString[rowChecked];
        rowChecked++;
        string[] familyDropID_split1 = familyDropID.Split('|');

        for (int i = 0; i < familyDropID_split1.Length; i++)
        {
            string[] familyDropID_split1_split2 = familyDropID_split1[i].Split('/');

            if (i == 0)
                spawnerBalancing.familyDropID = new int[familyDropID_split1.Length, familyDropID_split1_split2.Length];


            for (int j = 0; j < familyDropID_split1_split2.Length; j++)
            {
                spawnerBalancing.familyDropID[i, j] = int.Parse(familyDropID_split1_split2[j].Trim());
            }

        }


        // FAMILY COUNT
        string familyCount = splitString[rowChecked];
        rowChecked++;
        spawnerBalancing.familyCount = int.Parse(familyCount.Trim());

        // WEIGHT
        //string weight = splitString[rowChecked];
        rowChecked++;
        /*
        string[] weight_split1 = weight.Split('|');

        for (int i = 0; i < weight_split1.Length; i++)
        {
            string[] weight_split2 = weight_split1[i].Split('/');

            for (int j = 0; j < weight_split2.Length; j++)
            {
                string[] weight_split3 = weight_split2[j].Split('-');
                if (i == 0 && j == 0)
                    spawnerBalancing.weight = new int[weight_split1.Length, weight_split2.Length, weight_split3.Length];
               // Debug.Log("Create weight balancing with size: "+weight_split1.Length + ", " + weight_split2.Length + ", " + weight_split3.Length );

                for (int k = 0; k < weight_split3.Length; k++)
                    spawnerBalancing.weight[i, j, k] = int.Parse(weight_split3[k].Trim());
            }

        }
        */
        // KILLED VALUES
        rowChecked++;


        // DOES REQUIRE SEED?
        string seedsRequired = splitString[rowChecked].Trim();
        rowChecked++;
        string[] seedsRequired_split = seedsRequired.Split('|');
        spawnerBalancing.seedsRequired = new bool[seedsRequired_split.Length];
        for (int i = 0; i < seedsRequired_split.Length; i++)
            spawnerBalancing.seedsRequired[i] = bool.Parse(seedsRequired_split[i].Trim());

        // WHICH SEED
        string seedsNeeded = splitString[rowChecked].Trim();
        rowChecked++;
        string[] seedsNeeded_split = seedsNeeded.Split('|');
        spawnerBalancing.seedsNeeded = new int[seedsNeeded_split.Length];
        for (int i = 0; i < seedsNeeded_split.Length; i++)
            spawnerBalancing.seedsNeeded[i] = int.Parse(seedsNeeded_split[i].Trim());

        // NO SEED DESC
        string noSeedTextId = splitString[rowChecked].Trim();
        rowChecked++;
        string[] noSeedTextId_split = noSeedTextId.Split('|');
        spawnerBalancing.noSeedTextId = new int[noSeedTextId_split.Length];
        for (int i = 0; i < noSeedTextId_split.Length; i++)
            spawnerBalancing.noSeedTextId[i] = int.Parse(noSeedTextId_split[i].Trim());

        // SPAWNER OBJECTS
        string spawnerIds = splitString[rowChecked].Trim();
        rowChecked++;
        string[] spawnerIds_split = spawnerIds.Split('|');
        spawnerBalancing.spawnerIds = new string[spawnerIds_split.Length];
        for (int i = 0; i < spawnerIds_split.Length; i++)
            spawnerBalancing.spawnerIds[i] = spawnerIds_split[i];

        // START ID
        string startId = splitString[rowChecked].Trim();
        rowChecked++;
        string[] startId_split = startId.Split('|');
        spawnerBalancing.startId = new int[startId_split.Length];
        for (int i = 0; i < startId_split.Length; i++)
            spawnerBalancing.startId[i] = int.Parse(startId_split[i].Trim());

        // WATER PRICE
        string waterPrice = splitString[rowChecked].Trim();
        rowChecked++;
        string[] waterPrice_split = waterPrice.Split('|');
        spawnerBalancing.waterPrice = new int[waterPrice_split.Length];
        for (int i = 0; i < waterPrice_split.Length; i++)
            spawnerBalancing.waterPrice[i] = int.Parse(waterPrice_split[i].Trim());

        // GRID ID
        string gridId = splitString[rowChecked].Trim();
        rowChecked++;
        string[] gridId_split = gridId.Split('|');
        spawnerBalancing.gridId = new int[gridId_split.Length];
        for (int i = 0; i < gridId_split.Length; i++)
            spawnerBalancing.gridId[i] = int.Parse(gridId_split[i].Trim());

        // SUN PRICE
        string sunPrice = splitString[rowChecked].Trim();
        rowChecked++;
        string[] sunPrice_split = sunPrice.Split('|');
        spawnerBalancing.sunPrice = new int[sunPrice_split.Length];
        for (int i = 0; i < sunPrice_split.Length; i++)
            spawnerBalancing.sunPrice[i] = int.Parse(sunPrice_split[i].Trim());

    }



    void ApplyBirdSettings()
    {
        birdBalancing birdBalancing = GetComponent<birdBalancing>();
        string birdData = ConfigManager.appConfig.GetString("birdData");
        string[] splitString = birdData.Split(',');

        // MILESTONES
        string energyThresholds = splitString[0].Trim();
        string[] energyThresholds_split = energyThresholds.Split('|');
        birdBalancing.energyThresholds = new int[energyThresholds_split.Length];
        for (int i = 0; i < energyThresholds_split.Length; i++)
            birdBalancing.energyThresholds[i] = int.Parse(energyThresholds_split[i].Trim());

        // PROGRESS
        string progressToAdd = splitString[1].Trim();
        string[] progressToAdd_split = progressToAdd.Split('|');
        birdBalancing.progressToAdd = new int[progressToAdd_split.Length];
        for (int i = 0; i < progressToAdd_split.Length; i++)
            birdBalancing.progressToAdd[i] = int.Parse(progressToAdd_split[i].Trim());

        // PROGRESS
        string maxBirds = splitString[2].Trim();
        birdBalancing.maxBirds = int.Parse(maxBirds.Trim());


    }

    void ApplyTechnicalSettings()
    {

        technicalData technicalData = GetComponent<technicalData>();
        string technicalString = ConfigManager.appConfig.GetString("technicalData");
        string[] splitString = technicalString.Split(',');


        technicalData.latestStoreVersion = splitString[0];

        technicalData.forceUpdate = bool.Parse(splitString[1].Trim());

        technicalData.cheatEnabled = bool.Parse(splitString[2].Trim());

        technicalData.ggpLink = splitString[3];

        technicalData.restartId = splitString[4];

        technicalData.xpMultiplier = float.Parse(splitString[5].Trim(), new CultureInfo("en-US").NumberFormat);

        technicalData.forceRestart = bool.Parse(splitString[6].Trim());


    }


    void ApplyUnlockSettings()
    {


        unlockData unlockData = GetComponent<unlockData>();
        string unlockString = ConfigManager.appConfig.GetString("unlockData");
        string[] splitString = unlockString.Split(',');


        // OBJECTS ON MAP
        string objectsOnMap = splitString[0].Trim();
        string[] objectsOnMap_split = objectsOnMap.Split('|');
        unlockData.objectsOnMap = new string[objectsOnMap_split.Length];
        for (int i = 0; i < objectsOnMap_split.Length; i++)
            unlockData.objectsOnMap[i] = objectsOnMap_split[i];

        // OBJECTS ON MAP
        string objectsOnMap2 = splitString[1].Trim();
        string[] objectsOnMap2_split = objectsOnMap2.Split('|');
        unlockData.objectsOnMap2 = new string[objectsOnMap2_split.Length];
        for (int i = 0; i < objectsOnMap2_split.Length; i++)
            unlockData.objectsOnMap2[i] = objectsOnMap2_split[i];

        // collider bool
        string colliderBlock = splitString[2].Trim();
        string[] colliderBlock_split = colliderBlock.Split('|');
        unlockData.colliderBlock = new bool[colliderBlock_split.Length];
        for (int i = 0; i < colliderBlock_split.Length; i++)
            unlockData.colliderBlock[i] = bool.Parse(colliderBlock_split[i]);


        // MAIN IMAGES
        string mainImages = splitString[3].Trim();
        string[] mainImages_split = mainImages.Split('|');
        unlockData.mainImages = new string[mainImages_split.Length];
        for (int i = 0; i < mainImages_split.Length; i++)
            unlockData.mainImages[i] = mainImages_split[i];


        // DESC IMAGES
        string descImages = splitString[4].Trim();
        string[] descImages_split = descImages.Split('|');
        unlockData.descImages = new string[descImages_split.Length];
        for (int i = 0; i < descImages_split.Length; i++)
            unlockData.descImages[i] = descImages_split[i];


        // titleTexts
        string titleTexts = splitString[5].Trim();
        string[] titleTexts_split = titleTexts.Split('|');
        unlockData.titleTexts = new int[titleTexts_split.Length];
        for (int i = 0; i < titleTexts_split.Length; i++)
            unlockData.titleTexts[i] = int.Parse(titleTexts_split[i].Trim());


        // DESC TITLE
        string descriptionTitleTexts = splitString[6].Trim();
        string[] descriptionTitleTexts_split = descriptionTitleTexts.Split('|');
        unlockData.descriptionTitleTexts = new int[descriptionTitleTexts_split.Length];
        for (int i = 0; i < descriptionTitleTexts_split.Length; i++)
            unlockData.descriptionTitleTexts[i] = int.Parse(descriptionTitleTexts_split[i].Trim());


        // DESC ITEXT
        string descriptionTexts = splitString[7].Trim();
        string[] descriptionTexts_split = descriptionTexts.Split('|');
        unlockData.descriptionTexts = new int[descriptionTexts_split.Length];
        for (int i = 0; i < descriptionTexts_split.Length; i++)
        {
            unlockData.descriptionTexts[i] = int.Parse(descriptionTexts_split[i].Trim());
        }




    }
    void ApplyGardenSettings()
    {
        gardenData gardenData = GetComponent<gardenData>();
        string gardenDataString = ConfigManager.appConfig.GetString("gardenData");
        string[] splitString = gardenDataString.Split(',');

        // LEVEL UNLOCK
        string decorationLevelUnlock = splitString[0].Trim();
        string[] decorationLevelUnlock_split = decorationLevelUnlock.Split('|');
        gardenData.decorationLevelUnlock = new int[decorationLevelUnlock_split.Length];

        for (int i = 0; i < decorationLevelUnlock_split.Length; i++)
        {
            gardenData.decorationLevelUnlock[i] = int.Parse(decorationLevelUnlock_split[i].Trim());
        }

        // PURCHASE PRICE
        string unlockPrice = splitString[1].Trim();
        string[] unlockPrice_split = unlockPrice.Split('|');
        gardenData.unlockPrice = new int[unlockPrice_split.Length];

        for (int i = 0; i < unlockPrice_split.Length; i++)
        {
            gardenData.unlockPrice[i] = int.Parse(unlockPrice_split[i].Trim());
        }

        // PXP Reward
        string xpReward = splitString[2].Trim();
        string[] xpReward_split = xpReward.Split('|');
        gardenData.xpReward = new int[xpReward_split.Length];

        for (int i = 0; i < xpReward_split.Length; i++)
        {
            gardenData.xpReward[i] = int.Parse(xpReward_split[i].Trim());
        }


    }
    void ApplyStoreSettings()
    {
        iapBalancing iapBalancing = GetComponent<iapBalancing>();
        string storeDataString = ConfigManager.appConfig.GetString("storeData");
        string[] splitString = storeDataString.Split(',');

        ///////////////// IAPS
        int index = 0;
        string iap_ids = splitString[index].Trim();
        string[] iap_ids_split = iap_ids.Split('|');
        iapBalancing.iap_ids = new string[iap_ids_split.Length];
        for (int i = 0; i < iap_ids_split.Length; i++)
            iapBalancing.iap_ids[i] = iap_ids_split[i];

        index++;
        string iap_TID = splitString[index].Trim();
        string[] iap_TID_split = iap_TID.Split('|');
        iapBalancing.iap_TID = new int[iap_TID_split.Length];
        for (int i = 0; i < iap_TID_split.Length; i++)
            iapBalancing.iap_TID[i] = int.Parse(iap_TID_split[i].Trim());

        index++;
        string iap_rewards = splitString[index].Trim();
        string[] iap_rewards_split = iap_rewards.Split('|');
        iapBalancing.iap_rewards = new int[iap_rewards_split.Length];
        for (int i = 0; i < iap_rewards_split.Length; i++)
            iapBalancing.iap_rewards[i] = int.Parse(iap_rewards_split[i].Trim());

        ///////////////// ENERGY
        index++;
        string energy_ids = splitString[index].Trim();
        string[] energy_ids_split = iap_ids.Split('|');
        iapBalancing.energy_ids = new string[energy_ids_split.Length];
        for (int i = 0; i < energy_ids_split.Length; i++)
            iapBalancing.energy_ids[i] = energy_ids_split[i];


        index++;
        string energy_TID = splitString[index].Trim();
        string[] energy_TID_split = energy_TID.Split('|');
        iapBalancing.energy_TID = new int[energy_TID_split.Length];
        for (int i = 0; i < energy_TID_split.Length; i++)
            iapBalancing.energy_TID[i] = int.Parse(energy_TID_split[i].Trim());

        index++;
        string energy_prices = splitString[index].Trim();
        string[] energy_prices_split = energy_prices.Split('|');
        iapBalancing.energy_prices = new int[energy_prices_split.Length];
        for (int i = 0; i < energy_prices_split.Length; i++)
            iapBalancing.energy_prices[i] = int.Parse(energy_prices_split[i].Trim());

        index++;
        string energy_rewards = splitString[index].Trim();
        string[] energy_rewards_split = energy_rewards.Split('|');
        iapBalancing.energy_rewards = new int[energy_rewards_split.Length];
        for (int i = 0; i < energy_rewards_split.Length; i++)
            iapBalancing.energy_rewards[i] = int.Parse(energy_rewards_split[i].Trim());

        ///////////////// FERTILIZER
        index++;
        string fertilizer_ids = splitString[index].Trim();
        string[] fertilizer_ids_split = iap_ids.Split('|');
        iapBalancing.fertilizer_ids = new string[fertilizer_ids_split.Length];
        for (int i = 0; i < fertilizer_ids_split.Length; i++)
            iapBalancing.fertilizer_ids[i] = fertilizer_ids_split[i];


        index++;
        string fertilizer_TID = splitString[index].Trim();
        string[] fertilizer_TID_split = fertilizer_TID.Split('|');
        iapBalancing.fertilizer_TID = new int[fertilizer_TID_split.Length];
        for (int i = 0; i < fertilizer_TID_split.Length; i++)
            iapBalancing.fertilizer_TID[i] = int.Parse(fertilizer_TID_split[i].Trim());

        index++;
        string fertilizer_prices = splitString[index].Trim();
        string[] fertilizer_prices_split = fertilizer_prices.Split('|');
        iapBalancing.fertilizer_prices = new int[fertilizer_prices_split.Length];
        for (int i = 0; i < fertilizer_prices_split.Length; i++)
            iapBalancing.fertilizer_prices[i] = int.Parse(fertilizer_prices_split[i].Trim());

        index++;
        string fertilizer_rewards = splitString[index].Trim();
        string[] fertilizer_rewards_split = fertilizer_rewards.Split('|');
        iapBalancing.fertilizer_rewards = new int[fertilizer_rewards_split.Length];
        for (int i = 0; i < fertilizer_rewards_split.Length; i++)
            iapBalancing.fertilizer_rewards[i] = int.Parse(fertilizer_rewards_split[i].Trim());

        index++;
        string freeEnergyTimer = splitString[index].Trim();
        iapBalancing.freeEnergyTimer = int.Parse(freeEnergyTimer.Trim());

    }

    void ApplyIslandSettings()
    {
        islandBalancing islandBalancing = GetComponent<islandBalancing>();
        string islandData = ConfigManager.appConfig.GetString("islandData");
        string[] splitString = islandData.Split(',');

        // Island Count
        string islandCountData = splitString[0].Trim();
        islandBalancing.islandCount = int.Parse(islandCountData.Trim());

        // TEXT ID
        string islandWelcomeTextId = splitString[1].Trim();
        string[] islandWelcomeTextId_split = islandWelcomeTextId.Split('|');
        islandBalancing.islandWelcomeTextId = new int[islandWelcomeTextId_split.Length];

        for (int i = 0; i < islandWelcomeTextId_split.Length; i++)
        {
            islandBalancing.islandWelcomeTextId[i] = int.Parse(islandWelcomeTextId_split[i].Trim());
        }

        // LEVEL UNLOCK
        string islandLevelUnlock = splitString[2].Trim();
        string[] islandLevelUnlock_split = islandLevelUnlock.Split('|');
        islandBalancing.islandLevelUnlock = new int[islandLevelUnlock_split.Length];

        for (int i = 0; i < islandLevelUnlock_split.Length; i++)
        {
            islandBalancing.islandLevelUnlock[i] = int.Parse(islandLevelUnlock_split[i].Trim());
        }

        // LLOCK TEXT
        string lockText = splitString[3].Trim();
        string[] lockText_split = lockText.Split('|');
        islandBalancing.lockText = new int[lockText_split.Length];

        for (int i = 0; i < lockText_split.Length; i++)
        {
            islandBalancing.lockText[i] = int.Parse(lockText_split[i].Trim());
        }


    }
    void ApplyPowerupSettings()
    {
        powerupBalancing powerupBalancing = GetComponent<powerupBalancing>();
        string powerupData = ConfigManager.appConfig.GetString("powerupData");
        string[] splitString = powerupData.Split(',');
        int currentCheck = 0;

        // Item
        string item = splitString[currentCheck].Trim();
        currentCheck++;
        string[] item_split = item.Split('|');
        powerupBalancing.item = new string[item_split.Length];
        for (int i = 0; i < item_split.Length; i++)
            powerupBalancing.item[i] = item_split[i].Trim();

        // Item ID
        string itemId = splitString[currentCheck].Trim();
        currentCheck++;
        string[] itemId_split = itemId.Split('|');
        powerupBalancing.itemId = new int[itemId_split.Length];
        for (int i = 0; i < item_split.Length; i++)
            powerupBalancing.itemId[i] = int.Parse(itemId_split[i].Trim());

        // source
        string source = splitString[currentCheck].Trim();
        currentCheck++;
        string[] source_split = source.Split('|');
        powerupBalancing.source = new string[source_split.Length];
        for (int i = 0; i < source_split.Length; i++)
            powerupBalancing.source[i] = source_split[i].Trim();

        // sourceId
        string sourceId = splitString[currentCheck].Trim();
        currentCheck++;
        string[] sourceId_split = sourceId.Split('|');
        powerupBalancing.sourceId = new int[sourceId_split.Length];
        for (int i = 0; i < sourceId_split.Length; i++)
            powerupBalancing.sourceId[i] = int.Parse(sourceId_split[i].Trim());

        // sourceBranching
        string sourceBranching = splitString[currentCheck].Trim();
        currentCheck++;
        string[] sourceBranching_split = sourceBranching.Split('|');
        powerupBalancing.sourceBranching = new string[sourceBranching_split.Length];
        for (int i = 0; i < sourceBranching_split.Length; i++)
            powerupBalancing.sourceBranching[i] = sourceBranching_split[i].Trim();

        // sourceBranchingLevel
        string sourceBranchingLevel = splitString[currentCheck].Trim();
        currentCheck++;
        string[] sourceBranchingLevel_split = sourceBranchingLevel.Split('|');
        powerupBalancing.sourceBranchingLevel = new int[sourceBranchingLevel_split.Length];
        for (int i = 0; i < sourceBranchingLevel_split.Length; i++)
            powerupBalancing.sourceBranchingLevel[i] = int.Parse(sourceBranchingLevel_split[i].Trim());

        // iconId
        string iconId = splitString[currentCheck].Trim();
        currentCheck++;
        string[] iconId_split = iconId.Split('|');
        powerupBalancing.iconId = new string[iconId_split.Length];
        for (int i = 0; i < iconId_split.Length; i++)
            powerupBalancing.iconId[i] = iconId_split[i].Trim();

        // levelUnlock
        string levelUnlock = splitString[currentCheck].Trim();
        currentCheck++;
        string[] levelUnlock_split = levelUnlock.Split('|');
        powerupBalancing.levelUnlock = new int[levelUnlock_split.Length];
        for (int i = 0; i < levelUnlock_split.Length; i++)
            powerupBalancing.levelUnlock[i] = int.Parse(levelUnlock_split[i].Trim());

        // price
        string price = splitString[currentCheck].Trim();
        currentCheck++;
        string[] price_split = price.Split('|');
        powerupBalancing.price = new int[price_split.Length];
        for (int i = 0; i < price_split.Length; i++)
            powerupBalancing.price[i] = int.Parse(price_split[i].Trim());

        // price
        string amount = splitString[currentCheck].Trim();
        currentCheck++;
        string[] amount_split = amount.Split('|');
        powerupBalancing.amount = new int[amount_split.Length];
        for (int i = 0; i < amount_split.Length; i++)
            powerupBalancing.amount[i] = int.Parse(amount_split[i].Trim());

    }
    void ApplyAdSettings()
    {
        adBalancing adBalancing = GetComponent<adBalancing>();
        string adData = ConfigManager.appConfig.GetString("adData");
        string[] splitString = adData.Split(',');
        int currentCheck = 0;


        // min level
        adBalancing.forcedAdMinLevel = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // time
        adBalancing.forcedAdTime = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // forcedAdActive
        adBalancing.forcedAdActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // forcedAdNewItemActive
        adBalancing.forcedAdNewItemActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // forcedAdTravelActive
        adBalancing.forcedAdTravelActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // forcedAdUnlockActive
        adBalancing.forcedAdUnlockActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // energyAdRefillActive
        adBalancing.energyAdRefillActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // energyAdRefillAmount
        adBalancing.energyAdRefillAmount = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // seedAdRefillActive
        adBalancing.seedAdRefillActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // seedAdRefillAmount
        string seedAdRefillAmount = splitString[currentCheck].Trim();
        string[] seedAdRefillAmount_split = seedAdRefillAmount.Split('|');
        adBalancing.seedAdRefillAmount = new int[seedAdRefillAmount_split.Length];
        for (int i = 0; i < seedAdRefillAmount_split.Length; i++)
            adBalancing.seedAdRefillAmount[i] = int.Parse(seedAdRefillAmount_split[i].Trim());
        currentCheck++;

        // seedAdRefillActive
        adBalancing.energyAdCollectionActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // seedAdRefillActive
        adBalancing.energyAdShopActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // idleAdTime
        adBalancing.idleAdTime = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // idleAdActive
        adBalancing.idleAdActive = bool.Parse(splitString[currentCheck].Trim());
        currentCheck++;


    }
    void ApplyPetsSettings()
    {
        petBalancing petBalancing = GetComponent<petBalancing>();
        string petData = ConfigManager.appConfig.GetString("petData");
        string[] splitString = petData.Split(',');
        int currentCheck = 0;


        // id
        string id = splitString[currentCheck].Trim();
        string[] id_split = id.Split('|');
        petBalancing.id = new int[id_split.Length];
        for (int i = 0; i < id_split.Length; i++)
            petBalancing.id[i] = int.Parse(id_split[i].Trim());
        currentCheck++;        
        
        // family
        string family = splitString[currentCheck].Trim();
        string[] family_split = family.Split('|');
        petBalancing.family = new string[family_split.Length];
        for (int i = 0; i < family_split.Length; i++)
            petBalancing.family[i] = family_split[i];
        currentCheck++;

        // codeName
        string codeName = splitString[currentCheck].Trim();
        string[] codeName_split = codeName.Split('|');
        petBalancing.codeName = new string[codeName_split.Length];
        for (int i = 0; i < codeName_split.Length; i++)
            petBalancing.codeName[i] = codeName_split[i];
        currentCheck++;

        // locaId
        string locaId = splitString[currentCheck].Trim();
        string[] locaId_split = locaId.Split('|');
        petBalancing.locaId = new int[locaId_split.Length];
        for (int i = 0; i < locaId_split.Length; i++)
            petBalancing.locaId[i] = int.Parse(locaId_split[i].Trim());
        currentCheck++;

        // totalStats
        petBalancing.totalStats = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // defaultStats
        string defaultStats = splitString[currentCheck];
        string[] defaultStats_split1 = defaultStats.Split('|');

        for (int i = 0; i < defaultStats_split1.Length; i++)
        {
            string[] defaultStats_split2 = defaultStats_split1[i].Split('/');

            if (i == 0)
                petBalancing.defaultStats = new int[defaultStats_split1.Length, defaultStats_split2.Length];

            for (int j = 0; j < defaultStats_split2.Length; j++)
                petBalancing.defaultStats[i, j] = int.Parse(defaultStats_split2[j].Trim());
        }
        currentCheck++;

        // itemId
        string itemId = splitString[currentCheck].Trim();

        string[] itemId_split1 = itemId.Split('|');
        for (int i = 0; i < itemId_split1.Length; i++)
        {
            string[] itemId_split2 = itemId_split1[i].Split('/');

            for (int j = 0; j < itemId_split2.Length; j++)
            {
                string[] itemId_split3 = itemId_split2[j].Split('-');
                if (i == 0 && j == 0)
                    petBalancing.itemId = new int[itemId_split1.Length, itemId_split2.Length, itemId_split3.Length];

                for (int k = 0; k < itemId_split3.Length; k++)
                {
                    petBalancing.itemId[i, j, k] = int.Parse(itemId_split3[k].Trim(), new CultureInfo("en-US").NumberFormat);
                }
            }
        }
        currentCheck++;


        // itemMinTier
        string itemMinTier = splitString[currentCheck];
        string[] itemMinTier_split1 = itemMinTier.Split('|');

        for (int i = 0; i < itemMinTier_split1.Length; i++)
        {
            string[] itemMinTier_split2 = itemMinTier_split1[i].Split('/');

            if (i == 0)
                petBalancing.itemMinTier = new int[itemMinTier_split1.Length, itemMinTier_split2.Length];

            for (int j = 0; j < itemMinTier_split2.Length; j++)
                petBalancing.itemMinTier[i, j] = int.Parse(itemMinTier_split2[j].Trim());
        }
        currentCheck++;

        // itemMaxTier
        string itemMaxTier = splitString[currentCheck];
        string[] itemMaxTier_split1 = itemMaxTier.Split('|');

        for (int i = 0; i < itemMaxTier_split1.Length; i++)
        {
            string[] itemMaxTier_split2 = itemMaxTier_split1[i].Split('/');

            if (i == 0)
                petBalancing.itemMaxTier = new int[itemMaxTier_split1.Length, itemMaxTier_split2.Length];

            for (int j = 0; j < itemMaxTier_split2.Length; j++)
                petBalancing.itemMaxTier[i, j] = int.Parse(itemMaxTier_split2[j].Trim());
        }
        currentCheck++;

        // happyChance
        string happyChance = splitString[currentCheck];
        string[] happyChance_split1 = happyChance.Split('|');

        for (int i = 0; i < happyChance_split1.Length; i++)
        {
            string[] happyChance_split2 = happyChance_split1[i].Split('/');

            if (i == 0)
                petBalancing.happyChance = new int[happyChance_split1.Length, happyChance_split2.Length];

            for (int j = 0; j < happyChance_split2.Length; j++)
                petBalancing.happyChance[i, j] = int.Parse(happyChance_split2[j].Trim());
        }
        currentCheck++;

        // maxBreed
        string maxBreed = splitString[currentCheck].Trim();
        string[] maxBreed_split = maxBreed.Split('|');
        petBalancing.maxBreed = new int[maxBreed_split.Length];
        for (int i = 0; i < maxBreed_split.Length; i++)
            petBalancing.maxBreed[i] = int.Parse(maxBreed_split[i].Trim());
        currentCheck++;

        // breedPrice
        string breedPrice = splitString[currentCheck];
        string[] breedPrice_split1 = breedPrice.Split('|');

        for (int i = 0; i < breedPrice_split1.Length; i++)
        {
            string[] breedPrice_split2 = breedPrice_split1[i].Split('/');

            if (i == 0)
                petBalancing.breedPrice = new int[breedPrice_split1.Length, breedPrice_split2.Length];

            for (int j = 0; j < breedPrice_split2.Length; j++)
                petBalancing.breedPrice[i, j] = int.Parse(breedPrice_split2[j].Trim());
        }
        currentCheck++;

        // sellPrice
        string sellPrice = splitString[currentCheck];
        string[] sellPrice_split1 = sellPrice.Split('|');

        for (int i = 0; i < sellPrice_split1.Length; i++)
        {
            string[] sellPrice_split2 = sellPrice_split1[i].Split('/');

            if (i == 0)
                petBalancing.sellPrice = new int[sellPrice_split1.Length, sellPrice_split2.Length];

            for (int j = 0; j < sellPrice_split2.Length; j++)
                petBalancing.sellPrice[i, j] = int.Parse(sellPrice_split2[j].Trim());
        }
        currentCheck++;

        // offspringOptions
        string offspringOptions = splitString[currentCheck];
        string[] offspringOptions_split1 = offspringOptions.Split('|');

        for (int i = 0; i < offspringOptions_split1.Length; i++)
        {
            string[] offspringOptions_split2 = offspringOptions_split1[i].Split('/');

            if (i == 0)
                petBalancing.offspringOptions = new int[offspringOptions_split1.Length, offspringOptions_split2.Length];

            for (int j = 0; j < offspringOptions_split2.Length; j++)
                petBalancing.offspringOptions[i, j] = int.Parse(offspringOptions_split2[j].Trim());
        }
        currentCheck++;

        // offspringChance
        string offspringChance = splitString[currentCheck].Trim();
        string[] offspringChance_split = offspringChance.Split('|');
        petBalancing.offspringChance = new int[offspringChance_split.Length];
        for (int i = 0; i < offspringChance_split.Length; i++)
            petBalancing.offspringChance[i] = int.Parse(offspringChance_split[i].Trim());
        currentCheck++;

        // offspringTotalStatsRequired
        string offspringTotalStatsRequired = splitString[currentCheck];
        string[] offspringTotalStatsRequired_split1 = offspringTotalStatsRequired.Split('|');

        for (int i = 0; i < offspringTotalStatsRequired_split1.Length; i++)
        {
            string[] offspringTotalStatsRequired_split2 = offspringTotalStatsRequired_split1[i].Split('/');

            if (i == 0)
                petBalancing.offspringTotalStatsRequired = new int[offspringTotalStatsRequired_split1.Length, offspringTotalStatsRequired_split2.Length];

            for (int j = 0; j < offspringTotalStatsRequired_split2.Length; j++)
                petBalancing.offspringTotalStatsRequired[i, j] = int.Parse(offspringTotalStatsRequired_split2[j].Trim());
        }
        currentCheck++;

        // offspringMinStatRequired
        string offspringMinStatRequired = splitString[currentCheck];
        string[] offspringMinStatRequired_split1 = offspringMinStatRequired.Split('|');

        for (int i = 0; i < offspringMinStatRequired_split1.Length; i++)
        {
            string[] offspringMinStatRequired_split2 = offspringMinStatRequired_split1[i].Split('/');

            if (i == 0)
                petBalancing.offspringMinStatRequired = new int[offspringMinStatRequired_split1.Length, offspringMinStatRequired_split2.Length];

            for (int j = 0; j < offspringMinStatRequired_split2.Length; j++)
                petBalancing.offspringMinStatRequired[i, j] = int.Parse(offspringMinStatRequired_split2[j].Trim());
        }
        currentCheck++;

        // areaId
        string areaId = splitString[currentCheck].Trim();
        string[] areaId_split = areaId.Split('|');
        petBalancing.areaId = new int[areaId_split.Length];
        for (int i = 0; i < areaId_split.Length; i++)
            petBalancing.areaId[i] = int.Parse(areaId_split[i].Trim());
        currentCheck++;

        // descriptionText
        string descriptionText = splitString[currentCheck].Trim();
        string[] descriptionText_split = descriptionText.Split('|');
        petBalancing.descriptionText = new string[descriptionText_split.Length];
        for (int i = 0; i < descriptionText_split.Length; i++)
            petBalancing.descriptionText[i] = descriptionText_split[i].Trim();
        currentCheck++;

        // maxLevel
        string maxLevel = splitString[currentCheck].Trim();
        string[] maxLevel_split = maxLevel.Split('|');
        petBalancing.maxLevel = new int[maxLevel_split.Length];
        for (int i = 0; i < maxLevel_split.Length; i++)
            petBalancing.maxLevel[i] = int.Parse(maxLevel_split[i].Trim());
        currentCheck++;

        // titleText
        string titleText = splitString[currentCheck].Trim();
        string[] titleText_split = titleText.Split('|');
        petBalancing.titleText = new string[titleText_split.Length];
        for (int i = 0; i < titleText_split.Length; i++)
            petBalancing.titleText[i] = titleText_split[i].Trim();
        currentCheck++;

        // minHappinessRequirement
        string minHappinessRequirement = splitString[currentCheck];
        string[] minHappinessRequirement_split1 = minHappinessRequirement.Split('|');

        for (int i = 0; i < minHappinessRequirement_split1.Length; i++)
        {
            string[] minHappinessRequirement_split2 = minHappinessRequirement_split1[i].Split('/');

            if (i == 0)
                petBalancing.minHappinessRequirement = new int[minHappinessRequirement_split1.Length, minHappinessRequirement_split2.Length];

            for (int j = 0; j < minHappinessRequirement_split2.Length; j++)
                petBalancing.minHappinessRequirement[i, j] = int.Parse(minHappinessRequirement_split2[j].Trim());
        }
        currentCheck++;

        // happinessIncrease
        string happinessIncrease = splitString[currentCheck];
        string[] happinessIncrease_split1 = happinessIncrease.Split('|');

        for (int i = 0; i < happinessIncrease_split1.Length; i++)
        {
            string[] happinessIncrease_split2 = happinessIncrease_split1[i].Split('/');

            if (i == 0)
                petBalancing.happinessIncrease = new int[happinessIncrease_split1.Length, happinessIncrease_split2.Length];

            for (int j = 0; j < happinessIncrease_split2.Length; j++)
                petBalancing.happinessIncrease[i, j] = int.Parse(happinessIncrease_split2[j].Trim());
        }
        currentCheck++;

        // maxPets
        petBalancing.possibleFoodOptions = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

        // petTier
        string petTier = splitString[currentCheck].Trim();
        string[] petTier_split = petTier.Split('|');
        petBalancing.petTier = new int[petTier_split.Length];
        for (int i = 0; i < petTier_split.Length; i++)
            petBalancing.petTier[i] = int.Parse(petTier_split[i].Trim());
        currentCheck++;

        // isCollectionPet
        string isCollectionPet = splitString[currentCheck].Trim();
        string[] isCollectionPet_split = isCollectionPet.Split('|');
        petBalancing.isCollectionPet = new bool[isCollectionPet_split.Length];
        for (int i = 0; i < isCollectionPet_split.Length; i++)
            petBalancing.isCollectionPet[i] = bool.Parse(isCollectionPet_split[i].Trim());
        currentCheck++;
    }


    void ApplyPetsStatsSettings()
    {
        petStatsBalancing petStatsBalancing = GetComponent<petStatsBalancing>();
        string petData = ConfigManager.appConfig.GetString("petStatsData");
        string[] splitString = petData.Split(',');
        int currentCheck = 0;


        // parentCurrentStatsMofifier
        string parentCurrentStatsMofifier = splitString[currentCheck].Trim();
        string[] parentCurrentStatsMofifier_split = parentCurrentStatsMofifier.Split('|');
        petStatsBalancing.parentCurrentStatsMofifier = new float[parentCurrentStatsMofifier_split.Length];
        for (int i = 0; i < parentCurrentStatsMofifier_split.Length; i++)
            petStatsBalancing.parentCurrentStatsMofifier[i] = float.Parse(parentCurrentStatsMofifier_split[i].Trim(), new CultureInfo("en-US").NumberFormat);

        currentCheck++;

        // starUpChance
        string starUpChance = splitString[currentCheck];
        string[] starUpChance_split1 = starUpChance.Split('|');

        for (int i = 0; i < starUpChance_split1.Length; i++)
        {
            string[] starUpChance_split2 = starUpChance_split1[i].Split('/');

            if (i == 0)
                petStatsBalancing.starUpChance = new float[starUpChance_split1.Length, starUpChance_split2.Length];

            for (int j = 0; j < starUpChance_split2.Length; j++)
                petStatsBalancing.starUpChance[i,j] = float.Parse(starUpChance_split2[j].Trim(), new CultureInfo("en-US").NumberFormat);
        }
        currentCheck++;



        // ownerNames
        string ownerNames = splitString[currentCheck].Trim();
        string[] ownerNames_split = ownerNames.Split('|');
        petStatsBalancing.ownerNames = new string[ownerNames_split.Length];
        for (int i = 0; i < ownerNames_split.Length; i++)
            petStatsBalancing.ownerNames[i] = ownerNames_split[i];
        currentCheck++;

        // maxPets
        petStatsBalancing.maxPets = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

    }
    void ApplyPetsShopSettings()
    {
        petShopBalancing petShopBalancing = GetComponent<petShopBalancing>();
        string petShopData = ConfigManager.appConfig.GetString("petShopData");
        string[] splitString = petShopData.Split(',');
        int currentCheck = 0;


        // petId
        string petId = splitString[currentCheck].Trim();
        string[] petId_split = petId.Split('|');
        petShopBalancing.petId = new int[petId_split.Length];
        for (int i = 0; i < petId_split.Length; i++)
            petShopBalancing.petId[i] = int.Parse(petId_split[i].Trim());
        currentCheck++;

        // forcedSlot
        string forcedSlot = splitString[currentCheck].Trim();
        string[] forcedSlot_split = forcedSlot.Split('|');
        petShopBalancing.forcedSlot = new int[forcedSlot_split.Length];
        for (int i = 0; i < forcedSlot_split.Length; i++)
            petShopBalancing.forcedSlot[i] = int.Parse(forcedSlot_split[i].Trim());
        currentCheck++;

        // randomAppearance
        string randomAppearance = splitString[currentCheck].Trim();
        string[] randomAppearance_split = randomAppearance.Split('|');
        petShopBalancing.randomAppearance = new bool[randomAppearance_split.Length];
        for (int i = 0; i < randomAppearance_split.Length; i++)
            petShopBalancing.randomAppearance[i] = bool.Parse(randomAppearance_split[i].Trim());
        currentCheck++;

        // petCodeName
        string petCodeName = splitString[currentCheck].Trim();
        string[] petCodeName_split = petCodeName.Split('|');
        petShopBalancing.petCodeName = new string[petCodeName_split.Length];
        for (int i = 0; i < petCodeName_split.Length; i++)
            petShopBalancing.petCodeName[i] = petCodeName_split[i];
        currentCheck++;

        // petStats
        string petStats = splitString[currentCheck];
        string[] petStats_split1 = petStats.Split('|');

        for (int i = 0; i < petStats_split1.Length; i++)
        {
            string[] petStats_split2 = petStats_split1[i].Split('/');

            if (i == 0)
                petShopBalancing.petStats = new int[petStats_split1.Length, petStats_split2.Length];

            for (int j = 0; j < petStats_split2.Length; j++)
                petShopBalancing.petStats[i, j] = int.Parse(petStats_split2[j].Trim());
        }
        currentCheck++;

        // price
        string price = splitString[currentCheck].Trim();
        string[] price_split = price.Split('|');
        petShopBalancing.price = new int[price_split.Length];
        for (int i = 0; i < price_split.Length; i++)
            petShopBalancing.price[i] = int.Parse(price_split[i].Trim());
        currentCheck++;

        // refreshDuration
        petShopBalancing.refreshDuration = int.Parse(splitString[currentCheck].Trim());
        currentCheck++;

    }
}
