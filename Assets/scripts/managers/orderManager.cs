using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class orderManager : MonoBehaviour
{

    [Header("ORDER CREATION ------------")]
    //public bool isLevelingUp;
    public bool[] createOrder;

    [Header("BALANCING ------------")]
    public orderBalancing orderBalancing;
    public specialOrderBalancing specialOrderBalancing;
    public orderFamilyBalancing orderFamilyBalancing;
    public itemBalancing itemBalancing;
    public resourcesBalancing resourcesBalancing;
    public analyticsManager analyticsManager;
    public xpBalancing xpBalancing;
    public saveManager saveManager;
    public tutorialManager tutorialManager;
    public timeNowManager timeNowManager;
    int timeOrderLevelUnlock;
    int specialOrderLevelUnlock;

    // DATA FOR NEW ORDER
    int isTimeOrder;
    int isSpecialOrder;
    int specialOrderPicked;
    int rewardMultiplier;
    int maxTimer;
    int refreshTime;

    [Header("REWARDS ------------")]
    int rewardTypePicked;
    string rewardNamePicked;

    [Header("OBJECTS ------------")]
    public GameObject[] boats;

    [Header("FEEDBACK ------------")]
    public Vector3 sellFeedbackOffset;
    public int infoPopupRepeatCount;
    public int infoPopupMinLevel;

    /////////////////////////////// MISC
    float[] lastSold = new float[3];

    private int forcedOrderMax;




    private void Awake()
    {
        // BALANCING
        GameObject balancingData = GameObject.Find("balancingData");
        orderBalancing = balancingData.GetComponent<orderBalancing>();
        specialOrderBalancing = balancingData.GetComponent<specialOrderBalancing>();
        orderFamilyBalancing = balancingData.GetComponent<orderFamilyBalancing>();
        itemBalancing = balancingData.GetComponent<itemBalancing>();
        resourcesBalancing = balancingData.GetComponent<resourcesBalancing>();
        xpBalancing = balancingData.GetComponent<xpBalancing>();
        // ANALYTICS
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        // SAVE MANAGER
        saveManager = GetComponent<saveManager>();
        tutorialManager = GetComponent<tutorialManager>();
        timeNowManager = GetComponent<timeNowManager>();

        int lengthtoCheck = orderBalancing.forcedOrderId.Length;
        forcedOrderMax = orderBalancing.forcedOrderId[lengthtoCheck-1];
    }

    IEnumerator Start()
    {

        // GET DATA
        createOrder = new bool[orderBalancing.ordersUnlock.Length];
        lastSold = new float[orderBalancing.ordersUnlock.Length];
        boats = new GameObject[orderBalancing.ordersUnlock.Length];
        for (int i = 0; i < orderBalancing.ordersUnlock.Length; i++)
        {
            boats[i] = GameObject.Find("boatOrder" + i.ToString());
        }

        yield return new WaitUntil(() => 
         orderBalancing != null
        );
        timeOrderLevelUnlock = specialOrderBalancing.timeOrderUnlockLevel;
        specialOrderLevelUnlock = specialOrderBalancing.specialOrderUnlockLevel;

    }

    public void CheatOrder(int orderId)
    {
        SellOrder(GameObject.Find("boatOrder" + orderId.ToString()));
    }



    //////////////////////////////////////////////////////////////////////////////////////////////// CREATE ORDERS   

    public void CreateOrder(GameObject orderSelected, int orderId)
    {

        ///////////////////////////////////// REINIT SOLD ITEMS
        for (int i = 0; i < 2; i++)
        {
            SaveOrderSold(orderSelected, i, 0);
            orderSelected.GetComponent<boatOrderController>().isSold[i] = 0;
            orderSelected.GetComponent<boatOrderController>().family[i] = "";
        }

        ///////////////////////////////////// REINIT SOLD ITEMS
        createOrder[orderId] = false;

        ///////////////////////////////////  CHECK PREMADE ORDERS
        int orderCompleted = saveManager.GetSavedInt("orderCompleted");
        //Debug.Log("Order completed: " + orderCompleted);
        bool createPremade = false;
        if (orderCompleted < forcedOrderMax)
        {
            for(int i = 0; i < orderBalancing.forcedOrderId.Length; i++)
            {
                if (orderCompleted == orderBalancing.forcedOrderId[i])
                {
                    CreatePremadeOrder(i, orderSelected, orderCompleted);
                    createPremade = true;
                }
            }

            if(!createPremade)
                CreateRandomOrder(orderSelected);
        }

        ///////////////////////////////////  CREATE RANDOM ORDERS
        else
            CreateRandomOrder(orderSelected);

        ///////////////////////////////////  SAVE
        SaveTempOrder(orderSelected, 0);


    }


    public void CreatePremadeOrder(int orderIdPicked, GameObject orderSelected, int orderId)
    {

        /////////////////////////////////// GET VALUES
        // item count
        int itemCount = orderBalancing.forcedOrderItemCount[orderIdPicked];
        // family
        string[] familyPicked = new string[2];
        familyPicked[0] = orderBalancing.forcedOrderFamilyPicked[orderIdPicked, 0];
        if (itemCount > 1)
            familyPicked[1] = orderBalancing.forcedOrderFamilyPicked[orderIdPicked, 1];
        else
            familyPicked[1] = null;

        // tier
        int[] tierPicked = new int[2];
        tierPicked[0] = orderBalancing.forcedOrderTierPicked[orderIdPicked, 0];
        if (itemCount > 1)
            tierPicked[1] = orderBalancing.forcedOrderTierPicked[orderIdPicked, 1];
        else
            tierPicked[1] = 0;

        // price
        int price = orderBalancing.forcedOrderPrice[orderIdPicked];

        /////////////////////////////////// CREATE
        orderSelected.GetComponent<boatOrderController>().InitiateOrder(itemCount, familyPicked, tierPicked, price, rewardTypePicked, 0, 0, 0, 0, 1, 0);

        /////////////////////////////////// SAVE
        SaveOrder(itemCount, orderSelected, familyPicked[0], tierPicked[0], familyPicked[1], tierPicked[01], price, rewardTypePicked, 0, 0, 0, 0, 1, 0);


        ///////////////////////////////////  INFO POPUP TUTORIAL
        CheckInfoPopupTutorial(itemCount, tierPicked, familyPicked, orderSelected);
    }


    public void CreateRandomOrder(GameObject orderSelected)
    {
        //////////////////////////////////////////////// INIT VALUES
        int itemsInOrder = 0;
        string[] familyPicked = new string[2];
        int[] tierPicked = new int[2];
        int newPrice = 0;
        if (!resourcesBalancing)
            resourcesBalancing = GameObject.Find("balancingData").GetComponent<resourcesBalancing>();
        if (!itemBalancing)
            itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();

        //////////////////////////////////////////////// RANDOMIZE ORDER

        //////////////////////////// IS SPECIAL ORDER?
        CheckSpecialOrders();


        //////////////////////////// PICK NB OF ITEMS
        itemsInOrder = ItemCount() + 1;


        //////////////////////////// PICK REWARD TYPE
        int orderId = orderSelected.GetComponent<boatOrderController>().orderSlot;
        rewardTypePicked = RewardType(orderId);
        rewardNamePicked = resourcesBalancing.resourcesList[rewardTypePicked];

        for (int j = 0; j < itemsInOrder; j++)
        {
            //////////////////////////// PICK FAMILY
            int orderIsland = orderBalancing.boatOrderIsland[orderId];
            int familyIdPicked = PickFamily(orderIsland);
            familyPicked[j] = itemBalancing.familyNames[familyIdPicked];

            //////////////////////////// PICK TIER
            tierPicked[j] = PickTier(familyIdPicked);

            //////////////////////////// PRICE
            newPrice += PickPrice(familyIdPicked, tierPicked[j]);
        }

        //////////////////////////////////////////////// CREATE
        orderSelected.GetComponent<boatOrderController>().InitiateOrder(itemsInOrder, familyPicked, tierPicked, newPrice, rewardTypePicked, isTimeOrder, isSpecialOrder, refreshTime, maxTimer, rewardMultiplier, specialOrderPicked);

        //////////////////////////////////////////////// SAVE
        SaveOrder(itemsInOrder, orderSelected, familyPicked[0], tierPicked[0], familyPicked[1], tierPicked[1], newPrice, rewardTypePicked, isTimeOrder, isSpecialOrder, refreshTime, maxTimer, rewardMultiplier, specialOrderPicked);


        ///////////////////////////////////  INFO POPUP TUTORIAL
        CheckInfoPopupTutorial(itemsInOrder, tierPicked, familyPicked, orderSelected);




    }

    void CheckInfoPopupTutorial(int itemsInOrder, int[] tierPicked, string[] familyPicked, GameObject orderSelected)
    {
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);
        int alreadyShownTutorials = saveManager.GetSavedInt("orderTutoShown");

        if (alreadyShownTutorials < infoPopupRepeatCount)                                                                               // show tutorial X times
        {
            if (currentLevel >= infoPopupMinLevel)                                                                                      // only show past level X
            {
                for (int i = 0; i < itemsInOrder; i++)
                {
                    string itemName = familyPicked[i] + "_" + tierPicked[i].ToString();
                    for (int j = 0; j < (alreadyShownTutorials + 1); j++)                                                                  // check all previously shown items
                    {
                        string itemShown = saveManager.GetSavedString("orderTuto" + j.ToString());
                        if (itemShown != itemName)                                                                                       // do not show if item has already been shown
                        {
                            if (tierPicked[i] > 0)                                                                                      // do not show for item tier 0
                            {
                                int currentProgress = saveManager.GetSavedInt(familyPicked[i] + "_progress");
                                if (currentProgress < tierPicked[i] && !GetComponent<tapManager>().isGardenFocus)                       // show only if item has not been seen in the grid
                                {
                                    //Debug.Log("New item on boat " + orderSelected.name + ", item " + i);
                                    Transform itemNew = orderSelected.GetComponent<boatOrderController>().orderItems[i].transform;
                                    GetComponent<tutorialManager>().ShowInfoTuto(itemNew);
                                    SaveOrderTuto(itemName);
                                }
                            }

                        }
                    }
                }
            }

        }

    }



    //////////////////////////////////////////////////////////////////////////////////////////////// ALGO TO PICK ITEMS

    void CheckSpecialOrders()
    {

        ///////////////////////////////////////////////////// INIT DATA
        isTimeOrder = 0;
        isSpecialOrder = 0;
        specialOrderPicked = 0;
        rewardMultiplier = 1;
        maxTimer = 0;
        bool isPicked =false;

        ///////////////////////////////////////////////////// LEVEL CHECK
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);        

        // IS TIME ORDER?
        if(currentLevel >= timeOrderLevelUnlock)
        {
            isTimeOrder = 1;

            if(currentLevel>= specialOrderLevelUnlock)
            {

                int randomWeight = Random.Range(0, 100);
                //Debug.Log(randomWeight);

                for (int j = 0; j < specialOrderBalancing.specialOrderTime.Length ; j++)
                {
                    if (!isPicked)
                    {
                        int drop = specialOrderBalancing.specialOrderDropRate[currentLevel - 1, j];
                        if (randomWeight < drop)
                        {
                            isPicked = true;
                            isSpecialOrder = 1;
                            specialOrderPicked = j;
                            rewardMultiplier = specialOrderBalancing.specialOrderRewardMultiplier[j];
                            maxTimer = specialOrderBalancing.specialOrderTime[j]; 
                            CheckTimeTutorial("specialOrder");
                        }

                    }
                }

                if (!isPicked)
                {
                    CheckTimeTutorial("timeOrder");
                    maxTimer = specialOrderBalancing.timeOrderTime;
                }

            }
            else
            {
                CheckTimeTutorial("timeOrder");
                maxTimer = specialOrderBalancing.timeOrderTime;
            }

            refreshTime = timeNowManager.timeNow + maxTimer;
        }

        else
        {
            // REGULAR ORDER
        }




    }



    public int RewardType(int orderId)
    {
        // 0 = coins
        // 1 = water
        // 2 = sun

        int rewardPicked = 0;
        if (!orderBalancing)
            orderBalancing = GameObject.Find("balancingData").GetComponent<orderBalancing>();
        if (!resourcesBalancing)
            resourcesBalancing = GameObject.Find("balancingData").GetComponent<resourcesBalancing>();

        ///////////////////////////////////////////////////// LEVEL
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp) - 1;

        ///////////////////////////////////////////////////// WEIGHT CALC
        //int totalRewardTypes = 2;
        int totalTypeWeight = 0;
        for (int i = 0; i < resourcesBalancing.resourcesList.Length; i++)
            totalTypeWeight += orderBalancing.rewardDropRate[currentLevel, orderId, i];

        ///////////////////////////////////////////////////// RANDOM AMONG WEIGHT
        int randomReward = Random.Range(0, totalTypeWeight);
        int curr_totalCheck = 0;
        //int rewardId = 0;
        bool rewardIsPicked = false;
        for (int i = 0; i < resourcesBalancing.resourcesList.Length; i++)
        {
            curr_totalCheck += orderBalancing.rewardDropRate[currentLevel, orderId, i];
            if (randomReward < curr_totalCheck && !rewardIsPicked)
            {
                rewardPicked = i;
                rewardIsPicked = true;
            }
        }

        //Debug.Log("Reward type: " + rewardPicked);

        return rewardPicked;
    }
    
    public int ItemCount()
    {

        //InitOrderBalancing();
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp) - 1;
        if (!orderBalancing)
            orderBalancing = GameObject.Find("balancingData").GetComponent<orderBalancing>();


        // CALCULATE TOTAL
        int m_itemCount = 0;
        int totalWeight = 0;
        for (int i = 0; i < 2; i++)
        {
            totalWeight += orderBalancing.itemCountWeight[currentLevel, i];
        }

        int randomDrop = Random.Range(0, totalWeight);
        int currentWeightCheck = 0;
        bool picked = false;
        for (int i = 0; i < 2; i++)
        {
            currentWeightCheck += orderBalancing.itemCountWeight[currentLevel, i];
            if (randomDrop < currentWeightCheck && !picked)
            {
                m_itemCount = i;
                picked = true;
            }
        }

        return m_itemCount;

    }

    public int PickFamily(int islandPicked)
    {
        ///////////////////////////////////////////////////// GET VALUES
        if (!itemBalancing)
            itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
        if (!orderBalancing)
            orderBalancing = GameObject.Find("balancingData").GetComponent<orderBalancing>();
        if (!orderFamilyBalancing)
            orderFamilyBalancing = GameObject.Find("balancingData").GetComponent<orderFamilyBalancing>();

        ///////////////////////////////////////////////////// LEVEL
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp) - 1;


        ///////////////////////////////////////////////////// WEIGHT CALC
        int totalFamilies = itemBalancing.familyNames.Length;
        int totalFamilyWeight = 0;
        for (int i = 0; i < totalFamilies; i++)
        {
            //Debug.Log("Pick Family for level" + currentLevel + ", family id:" + i);
            int itemIsland = itemBalancing.itemIsland[i];

            // PICK ONLY IF THE FAMILY IS PRODUCED IN THE ISLAND OF THE BOAT
            if (itemIsland == islandPicked)
            {
                // PICK ONLY IF THE FAMILY CAN BE PICKED FOR THIS CURRENCY
                if (itemBalancing.itemResourceInOrder[rewardTypePicked, i])
                    totalFamilyWeight += orderFamilyBalancing.familyDrop[currentLevel, i];
            }
        }


        ///////////////////////////////////////////////////// RANDOM AMONG WEIGHT
        int randomFamily = Random.Range(0, totalFamilyWeight);
        int curr_totalCheck = 0;
        int familyId = 0;
        bool familyPicked = false;
        for (int i = 0; i < itemBalancing.familyNames.Length; i++)
        {
            curr_totalCheck += orderFamilyBalancing.familyDrop[currentLevel, i];
            bool compatibleResource = itemBalancing.itemResourceInOrder[rewardTypePicked, i];
            bool compatibleIsland = false;
            if (itemBalancing.itemIsland[i] == islandPicked)
                compatibleIsland = true;
            if (randomFamily < curr_totalCheck && !familyPicked && compatibleResource && compatibleIsland)
            {
                familyId = i;
                familyPicked = true;
            }
        }

        ///////////////////////////////////////////////////// RETURN
        return familyId;
    }

    public int PickPrice(int familyId, int tier)
    {
        //////////////////////////////////////////////////////// GET GENERIC DATA
        if (!orderBalancing)
            orderBalancing = GameObject.Find("balancingData").GetComponent<orderBalancing>();
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp) - 1;

        //////////////////////////////////////////////////////// GET THE DEFAULT PRICE
        float startingPrice = orderBalancing.startingPrices[rewardTypePicked, familyId];

        //////////////////////////////////////////////////////// RANDOMIZE A BIT
        float priceVariation = orderBalancing.priceVariation;
        float randomPrice = Random.Range(startingPrice * (1 - priceVariation), startingPrice * (1 + priceVariation));

        //////////////////////////////////////////////////////// INCREASE PRICE BY TIER UP
        for (int k = 0; k < tier; k++)
            randomPrice *= orderBalancing.tierMultiplier[familyId];

        //////////////////////////////////////////////////////// CHANGE PRICE DEPENDING ON LEVEL MULTIPLIER
        if (rewardTypePicked == 0)
        {
            float thisLevelMultiplier = orderBalancing.coinMultiplier[currentLevel];
            randomPrice = randomPrice * thisLevelMultiplier;
        }

        //////////////////////////////////////////////////////// APPLY SPECIAL ORDER MULTIPLIER
        float multipliedPrice = randomPrice * rewardMultiplier;

        //////////////////////////////////////////////////////// GIVE VALUE
        int finalPrice = Mathf.CeilToInt(multipliedPrice);
        return finalPrice;

    }

    public int PickTier(int familyPicked)
    {
        if (!orderBalancing)
            orderBalancing = GameObject.Find("balancingData").GetComponent<orderBalancing>();

        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp) - 1;

        int minTierToCheck = orderBalancing.minTier[currentLevel, familyPicked];
        int maxTierToCheck = orderBalancing.maxTier[currentLevel, familyPicked];

        int randomTier = Random.Range(minTierToCheck, maxTierToCheck + 1);


        return randomTier;
    }




    //////////////////////////////////////////////////////////////////////////////////////////////// SELL ORDER
    public void SellOrder(GameObject orderSold)
    {

        //Debug.Log("Sell order " + orderSold);
        int currentLevel = GetComponent<xpManager>().currentLevel;
        int orderReward = orderSold.GetComponent<boatOrderController>().price;
        int orderRewardType = orderSold.GetComponent<boatOrderController>().priceType;
        if (!resourcesBalancing)
            resourcesBalancing = GameObject.Find("balancingData").GetComponent<resourcesBalancing>();


        ////////////////// SAVE
        SaveOrderCount();


        ////////////////// CREATE COINS
        GetComponent<feedbackManager>().CoinSpawn(orderReward, orderSold, 0f, resourcesBalancing.resourcesList[orderRewardType]);


        ////////////////// FEEDBACK
        GameObject instantiatedFeedback = ObjectPool.SharedInstance.GetPooledObject("sellFX");
        instantiatedFeedback.SetActive(true);
        instantiatedFeedback.transform.position = orderSold.transform.position;


        ////////////////// CREATE NEW ORDER
        for (int i = 0; i < boats.Length; i++)
        {

            //Debug.Log("Create new order ?");
            if (orderSold == boats[i])
            {
                //Debug.Log("Create new order for " + orderSold);
                createOrder[i] = true;
                lastSold[i] = Time.time;
                SaveTempOrder(boats[i], 1);
            }
        }



        /////////////////// CHEK TUTORIAL
        CheckTutorial();


    }

    void CheckTutorial()
    {
        /*
        GetComponent<tutorialManager>().HideSlowDragTuto();

        if (saveManager.GetSavedInt("orderCompleted") == 1 && saveManager.GetSavedInt("energySpent") <= 4)
        {
            analyticsManager.ContinueFunnel("mainTutorial", "sellItem1");
            GetComponent<tutorialManager>().HideTuto(3);
            GetComponent<tutorialManager>().ShowTuto(4, true);

        }

        if (saveManager.GetSavedInt("orderCompleted") == 2 && saveManager.GetSavedInt("tutorialProgress") == 13)
            GetComponent<tutorialManager>().HideTuto(13);
        */

    }


    void CheckTimeTutorial(string source)
    {
        if( Time.time > 5)
        {
            if (source == "timeOrder")
            {
                if (saveManager.GetSavedInt("tutorialTimeOrderCompleted") == 0)
                {
                    Debug.Log("Show Time tuto");
                    tutorialManager.ShowTimeTuto();
                }

            }
            else if (source == "specialOrder")
            {
                if (saveManager.GetSavedInt("tutorialSpecialOrderCompleted") == 0)
                {
                    Debug.Log("Show Special tuto");
                    tutorialManager.ShowSpecialTuto();
                }

            }
        }
    }


    public void UnlockOrders(int newLevel)
    {
        int[] ordersUnlock = new int[orderBalancing.ordersUnlock.Length];

        for (int i = 0; i < ordersUnlock.Length; i++)
        {
            int unlockLevel = orderBalancing.ordersUnlock[i];
            if (newLevel == unlockLevel)
            {
                SaveUnlockOrder(i);
                createOrder[i] = true;
                lastSold[i] = Time.time;
            }

        }

    }




    void Update()
    {


        ////////////////////////////////// DELAY  
        //if (!isLevelingUp)
        //{
        for (int i = 0; i < boats.Length; i++)
        {
            if (createOrder[i])
            {
                if (Time.time > orderBalancing.sellTime[i] + lastSold[i])
                    CreateOrder(boats[i], i);
            }
        }
        //}


    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveOrderTuto(string itemName)
    {
        int currentProgress = saveManager.GetSavedInt("orderTutoShown");
        saveManager.SaveString("orderTuto" + currentProgress.ToString(), itemName);         // save ordertuto name
        saveManager.SaveInt("orderTutoShown", currentProgress + 1);                         // has tuto with id X has been shown
    }

    void SaveUnlockOrder(int i)
    {
        saveManager.SaveInt("boatOrder" + i.ToString() + "_isUnlocked", 1);                 // save if order is unlocked
    }

    void SaveOrder(int a, GameObject b, string c, int d, string e, int f, int g, int h, int i, int j, int k, int l, int m, int n)
    {
        saveManager.SaveInt(b.name + "_itemCount", a); // save how many items in order
        // item 1
        saveManager.SaveString(b.name + "_family_0", c); // save item 1 name
        saveManager.SaveInt(b.name + "_tier_0", d); // save item 1 tier
        // item 2
        saveManager.SaveString(b.name + "_family_1", e); // save item 2 name
        saveManager.SaveInt(b.name + "_tier_1", f); // save item 2 tier
        // Price
        saveManager.SaveInt(b.name + "_price", g); // save price amount
        saveManager.SaveInt(b.name + "_priceType", h); // save price type
        // TIME
        saveManager.SaveInt(b.name + "_isTimeOrder", i);
        saveManager.SaveInt(b.name + "_isSpecialOrder", j);
        saveManager.SaveInt(b.name + "_refreshTime", k);
        saveManager.SaveInt(b.name + "_maxTimer", l);
        saveManager.SaveInt(b.name + "_rewardMultiplier", m);
        saveManager.SaveInt(b.name + "_specialOrderPicked", n);

    }
   
    void SaveTempOrder(GameObject orderSold, int sold)
    {

        saveManager.SaveInt(orderSold.name + "_isWaiting", sold); // Save temp order

    }

    void SaveOrderCount()
    {
        int currentCount = saveManager.GetSavedInt("orderCompleted") + 1;
        saveManager.SaveInt("orderCompleted", currentCount); // save how many orderes have been sold

    }

    void SaveOrderSold(GameObject orderSelected, int i, int value)
    {
        if (!saveManager)
            saveManager = GetComponent<saveManager>();
        saveManager.SaveInt(orderSelected.name + "_isSold_" + i.ToString(), value); // save order is sold
    }



}
