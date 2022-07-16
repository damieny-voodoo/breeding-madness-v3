using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{
    public itemBalancing itemBalancing;
    powerupBalancing powerupBalancing;

    saveManager saveManager;
    analyticsManager analyticsManager;
    powerupManager powerupManager;
    petManager petManager;

    GameObject itemPrefab;
    public bool mergePossible;
    public GameObject mergeItem1;
    public GameObject mergeItem2;
    public GameObject[] orderBoats;
    //public int[] maxTier;
    //string[] familyNames;
    int m_familyId;

    int itemFamilIdAfterBranching;

    // for tutorial
    tapManager tapManager;
    tutorialManager tutorialManager;

    GameObject poolParent;
    ObjectPool objectPool;

    public List<GameObject> itemList;
    //public GameObject[] orders;

    private void Awake()
    {
        poolParent = GameObject.Find("pool");
        objectPool = poolParent.GetComponent<ObjectPool>();
        orderBoats = GetComponent<orderManager>().boats;

        //InitMaxTier();
    }
    private void Start()
    {

        //Debug.LogWarning("Start");
        itemPrefab = Resources.Load("map/item/item") as GameObject;
        //InitBranching();
        tapManager = GetComponent<tapManager>();
        tutorialManager = GetComponent<tutorialManager>();
        saveManager = GetComponent<saveManager>();
        powerupManager = GetComponent<powerupManager>();
        petManager = GetComponent<petManager>();

        GameObject balancingData = GameObject.Find("balancingData");
        itemBalancing = balancingData.GetComponent<itemBalancing>();
        powerupBalancing = balancingData.GetComponent<powerupBalancing>();

        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();

    }

    //////////////////////////////////////////////////// LIST
    public void AddItemToList(GameObject newItem)
    {
        itemList.Add(newItem);
        //CheckItemsSell(newItem); 
        CheckMergeable();
    }
    public void RemoveItemFromList(GameObject newItem)
    {
        itemList.Remove(newItem);

        CheckMergeable();
    }



    //////////////////////////////////////////////////// SELLABLE
    public void CheckItemsSell(GameObject itemToCheck, bool forceFalse)
    {

        /*
        bool canSell = false;
        itemController itemController = itemToCheck.GetComponent<itemController>();

        for (int i = 0; i < petManager.ownedPets.Length; i++)
        {
            if (!canSell)
            {
                petController petController = petManager.ownedPets[i].GetComponent<petController>();
                if (!petController.isHappy && itemController.itemFamily == petController.foodFamily && itemController.itemTier == petController.currentFoodTier)
                    canSell = true;
            }
        }

        if (canSell)
            itemController.SetSell();
        else
            itemController.SetUnsell();
        */

    }
    public void CheckAllItemsSell(bool forceFalse)
    {

        foreach (GameObject go in itemList)
        {
            go.GetComponent<itemController>().CheckSell(forceFalse);
        }

    }


    //////////////////////////////////////////////////// MERGEABLE
    public void CheckMergeable()
    {
        /*
        foreach (GameObject go in itemList)
            go.GetComponent<itemController>().SetUnmerge();


        if (itemList.Count >= 2)
        {
            for (int i = 0; i < itemList.Count; i++)
            {
                itemController itemI = itemList[i].GetComponent<itemController>();
                //Debug.Log("Check merge for the " + itemI.itemFamily + itemI.itemTier);
                if (itemI.itemTier < itemI.itemMaxTier)
                {
                    for (int j = i; j < itemList.Count; j++)
                    {
                        if(itemList[i] != itemList[j])
                        {
                            itemController itemJ = itemList[j].GetComponent<itemController>();
                            //Debug.Log("Check merge for the " + itemI.itemFamily + itemI.itemTier + "     versus     " + itemJ.itemFamily + itemJ.itemTier);
                            if (itemJ.itemFamily == itemI.itemFamily && itemI.itemTier == itemJ.itemTier)
                            {
                                itemI.SetMerge(itemList[j]);
                                itemJ.SetMerge(itemList[i]);
                            }

                        }
                    }
                }
            }
        }
        */

    }




    //////////////////////////////////////////////////// CREATE
    public void CreateItem(int itemFamilyId, GameObject tileToAssign, string itemFamily, int itemTier, bool initialItem)
    {

        /////////////////////////////////////////////////////// POOL
        GameObject newItem = ObjectPool.SharedInstance.GetPooledObject("item");
        newItem.SetActive(true);


        // order and position
        newItem.transform.parent = tileToAssign.transform;
        newItem.transform.position = new Vector3( tileToAssign.transform.position.x, 0, tileToAssign.transform.position.z);


        // tile - item association
        newItem.GetComponent<itemController>().currentTile = tileToAssign;
        newItem.GetComponent<itemController>().initialItem = initialItem;
        tileToAssign.GetComponent<tileController>().AssignItem(itemFamily, itemFamilyId, itemTier, newItem);


        // item setup
        newItem.GetComponent<itemController>().itemFamily = itemFamily;
        newItem.GetComponent<itemController>().itemFamilyId = itemFamilyId;
        newItem.GetComponent<itemController>().itemTier = itemTier;
        if(!itemBalancing)
        itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
        newItem.GetComponent<itemController>().itemMaxTier = itemBalancing.maxTier[FamilyId(itemFamily)];
        newItem.GetComponent<itemController>().InitiateItem();


        // FEEDBACK
        if(!initialItem)
        GameObject.Find("gameProperties").GetComponent<feedbackManager>().SpawnFeedback(newItem.transform);

        // Add to list
        AddItemToList(newItem);
       

    }


    public void CreateItemMerge(int itemFamilyId, string itemFamily, int itemTier, GameObject item1, GameObject item2, GameObject currentTile, GameObject newTile)
    {

        /////////////////////////////////////////////////////// POOL
        GameObject newItem = ObjectPool.SharedInstance.GetPooledObject("item");
        newItem.SetActive(true);


        /////////////////////////////////////////////////////// CHECK BRANCHING
        m_familyId = itemFamilyId;
        string newFamily = CheckBranching(itemFamily, itemTier);
        for(int i = 0; i < itemBalancing.familyNames.Length; i++)
        {
            if (newFamily == itemBalancing.familyNames[i])
                m_familyId = i;
        }

        /////////////////////////////////////////////////////// DESTROY ITEMS
        item1.GetComponent<itemController>().DestroyItem(false, false);
        item2.GetComponent<itemController>().DestroyItem(false, false);


        /////////////////////////////////////////////////////// POSITION AND PARENT
        newItem.transform.parent = newTile.transform;
        newItem.transform.position = newTile.transform.position;


        /////////////////////////////////////////////////////// TILE ASSOCIATION
        newItem.GetComponent<itemController>().currentTile = newTile;
        newTile.GetComponent<tileController>().AssignItem(newFamily, m_familyId, itemTier+1, newItem);
        currentTile.GetComponent<tileController>().AssignItem("",0, 0, null);



        /////////////////////////////////////////////////////// SETUP
        newItem.GetComponent<itemController>().itemFamily = newFamily;
        newItem.GetComponent<itemController>().itemFamilyId = m_familyId;
        newItem.GetComponent<itemController>().itemTier = itemTier + 1;
        newItem.GetComponent<itemController>().itemMaxTier = itemBalancing.maxTier[FamilyId(newFamily)];
        newItem.GetComponent<itemController>().initialItem = false;
        newItem.GetComponent<itemController>().InitiateItem();



        /////////////////////////////////////////////////////// MERGE FEEDBACK
        GameObject.Find("gameProperties").GetComponent<feedbackManager>().MergeFeedback(newItem.transform, itemTier);



        /////////////////////////////////////////////////////// CREATE FIRST ORDER AFTER THE FIRST MERGE
        /*
        if (saveManager.GetSavedInt("currentMergeCount") == 0)
        {
            orderBoats[0].GetComponent<boatOrderController>().UnlockOrder();
            GetComponent<orderManager>().CreateOrder(orderBoats[0], 0);
        }
        */

        /////////////////////////////////////////////////////// SAVE
        SaveMergeCount();

        /////////////////////////////////////////////////////// TUTORIAL
        CheckTuto();

        // Add to list
        AddItemToList(newItem);

    }





    ////////////////////////////////////////////////////////////////////////////// MISC FUNCTIONS
    void CheckTuto()
    {
        if(saveManager.GetSavedInt("currentMergeCount") == 1)
        {
            tutorialManager.HideTuto(3);
            tutorialManager.ShowTuto(4, true);
        }
    }

    string CheckBranching(string itemFamily, int itemTier)
    {
        string familyPicked = itemFamily;
        bool picked = false;
        int currentLevel = GetComponent<xpManager>().currentLevel;
        bool forceBranching = false;
        string forceBranchingId ="";


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   POWER UP MERGE
        if (powerupManager.powerupLeft > 0)
        {
            int currentPowerup = powerupManager.currentPowerup;
            if (powerupBalancing.source[currentPowerup] == "branching" && powerupBalancing.sourceBranching[currentPowerup] == itemFamily && powerupBalancing.sourceBranchingLevel[currentPowerup] == itemTier)
            {
                forceBranching = true;
                forceBranchingId = powerupBalancing.item[currentPowerup];
            }
        }

        if (forceBranching)
        {
            powerupManager.UsePowerUp();
            familyPicked = forceBranchingId;
            picked = true;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   REGULAR MERGE
        else
        {
            ////////////////////////////////////////////////////////////////   CARROTS -> RADDISH
            if (itemFamily == "carrots" && itemTier == 0)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.carrotBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.carrotBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.carrotBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.carrotBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.carrotBranchingFamilies[i]];
                }

                //
                int randomDrop = Random.Range(0, totalWeight);
                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.carrotBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.carrotBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.carrotBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.carrotBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.carrotBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.carrotBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   SOY -> RICE
            if (itemFamily == "soy" && itemTier == 0)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.soyBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.soyBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.soyBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.soyBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.soyBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.soyBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.soyBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.soyBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.soyBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.soyBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.soyBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   APPLES -> LEMON
            else if (itemFamily == "apple" && itemTier == 1)
            {
                    int totalWeight = 0;
                for (int i = 0; i < itemBalancing.appleBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.appleBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.appleBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.appleBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.appleBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.appleBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.appleBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.appleBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.appleBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.appleBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.appleBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   RASPBERRY -> BLUEBERRY
            else if (itemFamily == "raspberry" && itemTier == 0)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.raspberryBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.raspberryBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.raspberryBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.raspberryBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.raspberryBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.raspberryBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.raspberryBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.raspberryBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.raspberryBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.raspberryBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.raspberryBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   COCONUT  ->  BANANA 
            else if (itemFamily == "coconut" && itemTier == 1)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.bananaBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.bananaBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.bananaBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.bananaBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.bananaBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.bananaBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.bananaBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.bananaBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.bananaBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.bananaBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.bananaBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   AVOCADO  ->  CHOCOLATE
            else if (itemFamily == "avocado" && itemTier == 1)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.chocolateBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.chocolateBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.chocolateBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.chocolateBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.chocolateBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.chocolateBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.chocolateBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.chocolateBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.chocolateBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.chocolateBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.chocolateBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   CHOCOLATE -> COFFEE
            else if (itemFamily == "chocolate" && itemTier == 2)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.coffeeBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.coffeeBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.coffeeBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.coffeeBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.coffeeBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.coffeeBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.coffeeBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.coffeeBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.coffeeBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.coffeeBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.coffeeBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   BRONZE -> SILVER AND GOLD
            else if (itemFamily == "bronze" && itemTier == 0)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.bronzeBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.bronzeBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.bronzeBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.bronzeBranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.bronzeBranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.bronzeBranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.bronzeBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.bronzeBranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.bronzeBranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.bronzeBranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.bronzeBranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   SILVER  ->  SILVER 1
            else if (itemFamily == "silver" && itemTier == 3)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.silver1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.silver1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.silver1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.silver1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.silver1BranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.silver1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.silver1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.silver1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.silver1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.silver1BranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.silver1BranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   GOLD  ->  GOLD 1
            else if (itemFamily == "gold" && itemTier == 3)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.gold1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.gold1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.gold1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.gold1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.gold1BranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.gold1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.gold1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.gold1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.gold1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.gold1BranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.gold1BranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   CACTUS -> CACTUS 1
            else if (itemFamily == "cactus" && itemTier == 1)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.cactus1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.cactus1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.cactus1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.cactus1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.cactus1BranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.cactus1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.cactus1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.cactus1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.cactus1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.cactus1BranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.cactus1BranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   CACTUS1  -> CACTUS2
            else if (itemFamily == "cactus1" && itemTier == 2)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.cactus2BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.cactus2BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.cactus2BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.cactus2BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.cactus2BranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.cactus2BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.cactus2BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.cactus2BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.cactus2BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.cactus2BranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.cactus2BranchingFamilies[i]];
                        picked = true;
                    }
                }
            }

            ////////////////////////////////////////////////////////////////   PINEAPPLE -> PINEAPPLE1
            else if (itemFamily == "pineapple" && itemTier == 2)
            {
                int totalWeight = 0;
                for (int i = 0; i < itemBalancing.pineapple1BranchingFamilies.Length; i++) {

                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.pineapple1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_lv1[itemBalancing.pineapple1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.pineapple1BranchingFamilies[i]])
                        totalWeight += itemBalancing.branchingWeight_regular[itemBalancing.pineapple1BranchingFamilies[i]];
                }

                int randomDrop = Random.Range(0, totalWeight);

                int currentWeightCheck = 0;
                for (int i = 0; i < itemBalancing.pineapple1BranchingFamilies.Length; i++)
                {
                    if (currentLevel == itemBalancing.levelUnlock[itemBalancing.pineapple1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_lv1[itemBalancing.pineapple1BranchingFamilies[i]];
                    else if (currentLevel > itemBalancing.levelUnlock[itemBalancing.pineapple1BranchingFamilies[i]])
                        currentWeightCheck += itemBalancing.branchingWeight_regular[itemBalancing.pineapple1BranchingFamilies[i]];
                    if (randomDrop < currentWeightCheck && !picked)
                    {
                        familyPicked = itemBalancing.familyNames[itemBalancing.pineapple1BranchingFamilies[i]];
                        picked = true;
                    }
                }
            }


        }





        if (!picked)
        {
            for (int i = 0; i < itemBalancing.familyNames.Length; i++)
            {
                if (familyPicked == itemBalancing.familyNames[i])
                    m_familyId = i;
            }

        }

        return familyPicked;

    }


    int FamilyId(string familyName)
    {
        int familyId = 3;
        for(int i=0; i < itemBalancing.familyNames.Length; i++)
        {
            if (familyName == itemBalancing.familyNames[i])
                familyId = i;
        }

        return familyId;

    }

    GameObject SpecificItem(string itemFamily, int itemTier)
    {
        GameObject foundItem = null;
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<itemController>().itemFamily == itemFamily && go.GetComponent<itemController>().itemTier == itemTier)
                foundItem = go;

        }


        return foundItem;



    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveMergeCount()
    {
        int currentMergeCount = saveManager.GetSavedInt("currentMergeCount");
        saveManager.SaveInt("currentMergeCount", currentMergeCount + 1);  // save merge count
    }


}
