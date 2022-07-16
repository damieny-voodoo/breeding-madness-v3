using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class spawnerController : MonoBehaviour
{
    public int spawnerId;
    public int gridId;

    [Header("BALANCING -------------------")]
    public int startId;
    public int waterPrice;
    public int sunPrice;
    public bool seedNeeded;
    public int seedId;


    [Header("POPUPS -------------------")]
    public GameObject error_noEnergy;
    public GameObject error_noSpace;
    public GameObject error_noWater; 
    public GameObject error_noSun;
    public TextMeshProUGUI error_noEnergy_text;
    public TextMeshProUGUI error_noSpace_text;
    public TextMeshProUGUI error_noSpaceDesc_text;
    //public TextMeshProUGUI error_noWater_text;
    public TextMeshProUGUI error_noSun_text;
    float tapErrorTime;
    float tapErrorDelay = 0.75f;


    [Header("MISC -------------------")]
    analyticsManager aManager;
    tutorialManager tutoManager;
    powerupManager powerupManager;
    saveManager saveManager;
    itemManager itemManager;
    petManager petManager;

    itemBalancing itemBalancing;
    spawnerBalancing spawnerBalancing;
    resourcesBalancing resourcesBalancing;
    powerupBalancing powerupBalancing;
    petBalancing petBalancing;
    gridController gridController;

    public int currentProgress;

    GameObject gameProperties;
    GameObject balancingData;
    GameObject grid;

    string familyPicked;
    int familyPickedID;
    int tierPicked;
    int freeTilesCount;

    [Header("TUTOS -------------------")]
    public int tutorialBombProgress;
    public int tutorialTileProgress;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);

        if (spawnerId == 0)
            CheckContextualTutorial();

        yield return null;
    }

    public void InitData()
    {

        gameProperties = GameObject.Find("gameProperties");
        tutoManager = gameProperties.GetComponent<tutorialManager>();
        petManager = gameProperties.GetComponent<petManager>();
        saveManager = gameProperties.GetComponent<saveManager>();
        itemManager = gameProperties.GetComponent<itemManager>();
        powerupManager = gameProperties.GetComponent<powerupManager>();
        balancingData = GameObject.Find("balancingData");
        itemBalancing = balancingData.GetComponent<itemBalancing>();
        spawnerBalancing = balancingData.GetComponent<spawnerBalancing>();
        resourcesBalancing = balancingData.GetComponent<resourcesBalancing>();
        powerupBalancing = balancingData.GetComponent<powerupBalancing>();
        petBalancing = balancingData.GetComponent<petBalancing>();
        gridController = GameObject.Find("grid0").GetComponent<gridController>();
        aManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();

        gridId = spawnerBalancing.gridId[spawnerId];
        seedNeeded = spawnerBalancing.seedsRequired[spawnerId];
        seedId = spawnerBalancing.seedsNeeded[spawnerId];
        startId = spawnerBalancing.startId[spawnerId];
        waterPrice = spawnerBalancing.waterPrice[spawnerId];
        sunPrice = spawnerBalancing.sunPrice[spawnerId];

        grid = GameObject.Find("grid"+ gridId.ToString());


        if (spawnerId == 0)
        {
            tutorialBombProgress = saveManager.GetSavedInt("tutorialBombProgress");
            tutorialTileProgress = saveManager.GetSavedInt("tutorialTileProgress");
        }
    }

    public void OnMouseDown()
    {

        bool popupOpen = gameProperties.GetComponent<tapManager>().popupOpen;
        bool isLocked = false;
        if (GetComponent<unlockController>())
            isLocked = GetComponent<unlockController>().isLocked;

        bool tutoOk = TutorialOk();

        if (!popupOpen && !isLocked && tutoOk)
            SpawnItem();

    }

    void SpawnItem()
    {
        // TUTORIAL CHECK
        CheckTutorial();

        // RESOURCES CHECK
        bool hasEnergy = gameProperties.GetComponent<resourcesManager>().HasEnergy();
        int currentWater = saveManager.GetSavedInt("currentWater");
        int currentSun = saveManager.GetSavedInt("currentSun");
        bool hasSeed = true;
        if (seedNeeded)
            hasSeed = gameProperties.GetComponent<resourcesManager>().HasSeed(seedId);

        // FEEDBACK
        gameProperties.GetComponent<feedbackManager>().TapSpawner(Time.time, gameObject);

        // IS A TILE AVAILABLE
        GameObject tileAssociated = ClosestTile();
        if (freeTilesCount == 1)
            gameProperties.GetComponent<tipsManager>().TriggerTip(3);



        ////////////////////////////////////////// SPAWN
        if (hasEnergy && tileAssociated != null && currentWater >= waterPrice && hasSeed && currentSun >= sunPrice)
        {
            //////////////////////////// CHOOSE ITEM

            // FORCED ITEM
            if (ForcedItem() == "none")
                PickRandomItem();

            // RANDOM ITEM
            else
                powerupManager.UsePowerUp();

            //////////////////////////// CREATE ITEM
            gameProperties.GetComponent<itemManager>().CreateItem(familyPickedID, tileAssociated, familyPicked, tierPicked, false);

            //////////////////////////// SPEND RESOURCES
            gameProperties.GetComponent<resourcesManager>().SpendEnergy();
            gameProperties.GetComponent<resourcesManager>().SpendWater(waterPrice);
            gameProperties.GetComponent<resourcesManager>().SpendSun(sunPrice);
            if (seedNeeded)
                gameProperties.GetComponent<resourcesManager>().SpendSeed(seedId);



            /////////////////////////// DO CONDITIONAL TUTORIAL
            if(spawnerId ==0)
            CheckContextualTutorial();

        }

        ////////////////////////// NO SEED ERROR
        else if (seedNeeded && !hasSeed)
        {
            if (Time.time > tapErrorTime + tapErrorDelay)
            {
                ShowError_NoSeed(seedId);
                tapErrorTime = Time.time;
            }
        }

        ////////////////////////// NO WATER ERROR
        else if (currentWater < waterPrice)
        {
            if (Time.time > tapErrorTime + tapErrorDelay)
            {
                ShowError_NoWater();
                tapErrorTime = Time.time;
            }
        }

        ////////////////////////// NO SUN ERROR
        else if (currentSun < sunPrice)
        {
            if (Time.time > tapErrorTime + tapErrorDelay)
            {
                ShowError_NoSun();
                tapErrorTime = Time.time;
            }
        }

        ////////////////////////// NO ENERGY ERROR
        else if (!hasEnergy)
        {
            if (Time.time > tapErrorTime + tapErrorDelay)
            {
                ShowError_NoEnergy();
                tapErrorTime = Time.time;
            }
        }

        ////////////////////////// NO SPACE ERROR
        else if (!tileAssociated)
        {
            if (Time.time > tapErrorTime + tapErrorDelay)
            {
                ShowError_NoSpace();
                tapErrorTime = Time.time;
            }
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// CONTECTUAL TUTORIAL
    void CheckContextualTutorial()
    {
        //Debug.Log("Check contextual tutorial");

        if (tutorialBombProgress != 2 || tutorialTileProgress != 2)
        {
            if (saveManager.GetSavedInt("tutorialCompleted") == 1)
            {
                if (AllItemsBlocked())
                {
                    if (CanPurchaseTile() && tutorialTileProgress != 2)
                    {
                        if (!ClosestTile())
                            tutoManager.TileTuto();
                    }
                    /*
                    else if (tutorialBombProgress != 2)
                    {
                        if(!ClosestTile())
                            tutoManager.BombTuto();
                    }
                    */
                }
                //else
                //    Debug.Log("At least one item is not blocked");
            }
            //else
            //    Debug.Log("main tutorial not completed yet");
        }
        //else
        //    Debug.Log("tutorials have been shown already");
    }


    bool AllItemsBlocked()
    {
        bool allBlocked = true;

        foreach (GameObject go in itemManager.itemList)
        {
            itemController co = go.GetComponent<itemController>();
            if (co.canSellItem || co.canMerge)
            {
                allBlocked = false;
                //Debug.Log("Item not blocked on tile: " + co.currentTile.name);
            }
        }

        return allBlocked;
    }

    bool CanPurchaseTile()
    {
        bool tileToPurchase = false;

        foreach (GameObject tile in gridController.tileList)
        {
            tileController co = tile.GetComponent<tileController>();
            if (co.canBePurchased && ! co.isPurchased)
                tileToPurchase = true;
        }


        return tileToPurchase;
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TUTORIAL
    bool TutorialOk()
    {
        bool tutorialOk = true;

        int currentTuto = tutoManager.currentTuto;

        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            if (currentTuto == 0 || currentTuto == 1 || currentTuto == 3 || currentTuto == 4 || currentTuto == 5|| currentTuto == 9)
                tutorialOk = false;
        }

        return tutorialOk;


    }

    void CheckTutorial()
    {
        if (saveManager.GetSavedInt("energySpent") ==0)
        {
            tutoManager.HideTuto(2);
            tutoManager.ShowTuto(3, true);
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ERRORS
    void ShowError_NoEnergy()
    {

        gameProperties.GetComponent<resourcesManager>().ShowNoEnergyPopup();

        error_noSpace.GetComponent<Animation>().Play("a_idle");
        error_noWater.GetComponent<Animation>().Play("a_idle");
        error_noSun.GetComponent<Animation>().Play("a_idle");

    }

    void ShowError_NoSpace()
    {

        error_noSpace_text.GetComponent<localizationManager>().UpdateText();
        error_noSpaceDesc_text.GetComponent<localizationManager>().UpdateText();


        error_noSpace.GetComponent<Animation>().Play("a_spawn");
        error_noWater.GetComponent<Animation>().Play("a_idle");
        error_noSun.GetComponent<Animation>().Play("a_idle");

    }

    void ShowError_NoWater()
    {

        //gameProperties.GetComponent<resourcesManager>().ShowNoEnergyPopup();

        error_noSpace.GetComponent<Animation>().Play("a_idle");
        error_noWater.GetComponent<Animation>().Play("a_spawn");
        error_noSun.GetComponent<Animation>().Play("a_idle");

    }

    void ShowError_NoSun()
    {

        //gameProperties.GetComponent<resourcesManager>().ShowNoEnergyPopup();

        error_noSpace.GetComponent<Animation>().Play("a_idle");
        error_noWater.GetComponent<Animation>().Play("a_idle");
        error_noSun.GetComponent<Animation>().Play("a_spawn");

    }

    void ShowError_NoSeed(int seedSpent)
    {

        gameProperties.GetComponent<resourcesManager>().ShowSeedRefillPopup(seedSpent, spawnerId);

        error_noSpace.GetComponent<Animation>().Play("a_idle");
        error_noWater.GetComponent<Animation>().Play("a_idle");
        error_noSun.GetComponent<Animation>().Play("a_idle");

    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PICK ITEM
    void PickRandomItem()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////// FAMILY
        List<GameObject> ownedPets = petManager.petList;
        List<int> foodAsked = new List<int>();
        List<int> foodWeight = new List<int>();
        int m_familyPicked = 0;
        int totalWeight = 0;
        int currentWeight = 0;
        bool isPicked = false;
        for (int i = 0; i < ownedPets.Count; i++)
        {
            petController petcontroller = ownedPets[i].GetComponent<petController>();
            // SELECT ONLY PETS FROM THE SAME AREA
            if(petBalancing.areaId[i] == gridId)
            {
                // SELECT ONLY PETS WHO WANT FOOD
                if (petcontroller.isOwned && !petcontroller.isEgg && !petcontroller.isHappy && !petcontroller.allBreedsUsed)
                {
                    // MAKE SURE IT's NOT ALREADY IN THE LIST
                    int[] thisPetFoodId = petcontroller.foodId;
                    for(int k = 0; k < petBalancing.possibleFoodOptions; k++)
                    {

                        bool isInList = false;
                        for (int j = 0; j < foodAsked.Count; j++)
                        {
                            if (foodAsked[j] == thisPetFoodId[k])
                                isInList = true;
                        }
                        // ADD TO LIST
                        if (!isInList)
                        {
                            foodAsked.Add(thisPetFoodId[k]);
                            int thisWeight = itemBalancing.dropWeight[thisPetFoodId[k]];
                            foodWeight.Add(thisWeight);
                            totalWeight += thisWeight;
                        }
                    }
                }
            }
        }
        int randomWeight = Random.Range(0, totalWeight);
        for(int i = 0; i < foodWeight.Count; i++)
        {
            if (!isPicked)
            {
                currentWeight += foodWeight[i];
                if (randomWeight < currentWeight)
                {
                    m_familyPicked = foodAsked[i];
                    isPicked = true;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////// TIER
        int m_tierPicked = 0;

        ////////////////////////////////////////////////////////////////////////////////////////////////////// ASSIGN
        familyPicked = itemBalancing.familyNames[m_familyPicked];
        familyPickedID = m_familyPicked;
        tierPicked = m_tierPicked;

    }

    string ForcedItem()
    {
        string forcedFamily = "none";

        if( powerupManager.powerupLeft > 0)
        {
            for (int i =0; i<powerupBalancing.source.Length;i++)
            {
                if(powerupManager.currentPowerup == i && powerupBalancing.source[i] == "spawner" && powerupBalancing.sourceId[i] == spawnerId)
                {
                    familyPicked = powerupBalancing.item[i];
                    familyPickedID = powerupBalancing.itemId[i];
                    forcedFamily = familyPicked;
                    tierPicked = 0;
                    Debug.Log("Force item " + forcedFamily);
                }
            }
        }

        return forcedFamily;
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TILE
    GameObject ClosestTile()
    {
        int energySpent = saveManager.GetSavedInt("energySpent");
        GameObject tileFound = null;

        //////////////////// FORCE FIRST TWO ITEMS TO GO ON TILE 1 AND 2
        if (energySpent == 0)
            tileFound = GameObject.Find("tile0_1");
        else if(energySpent == 1)
            tileFound = GameObject.Find("tile0_2");

        //////////////////// REGULAR BEHAVIOR        
        else
        {
            List<GameObject> availableTiles = new List<GameObject>();
            foreach (GameObject go in grid.GetComponent<gridController>().tileList)
            {
                bool isUnlocked = go.GetComponent<tileController>().isPurchased;
                if (go.GetComponent<tileController>().itemIn == null && go.name != "trash" && isUnlocked)
                    availableTiles.Add(go);
            }

            if (availableTiles.Count > 0)
            {
                int randomTile = Random.Range(0, availableTiles.Count);
                tileFound = availableTiles[randomTile];
            }
        }

        if (tileFound)
            return tileFound;
        else
            return null;

    }

}
