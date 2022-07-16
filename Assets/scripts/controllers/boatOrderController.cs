using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class boatOrderController : MonoBehaviour
{


    [Header("GENERAL ------------")]
    public bool orderReadyToSell;
    float creationStart;
    float readyDelay = 2f;
    public int orderSlot;
    public int itemsInOrder;

    [Header("ITEMS ------------")]
    public string[] family;
    public int[] tier;
    bool checkSellDone;

    [Header("UI ------------")]
    public GameObject[] objectsToHideAtFirstStart;
    public GameObject[] orderItems;
    public MeshRenderer[] itemImage;
    public Texture[] imageLoaded;
    public bool[] isSelling;
    // TIME UI
    public GameObject orderTimeObject;
    public Transform progressTransform;
    public TextMeshPro timeLeftText;
    public GameObject multiplierObject;
    public TextMeshPro multiplierText;


    [Header("SOLD FEEDBACK ------------")]
    public int[] isSold;


    [Header("PRICE ------------")]
    public int priceType;
    public int price;
    public TextMeshPro priceText;
    public GameObject[] priceIcons;
    public Color[] rewardTextColors;
    public Transform priceParent;
    public int[] pricePositionMilestones;
    public float[] pricePositions;

    [Header("TIME ------------")]
    public int isTimeOrder;
    public int isSpecialOrder;
    public int specialOrderPicked;
    public int refreshTime;
    public int maxTimer;
    public int rewardMultiplier;
    public GameObject[] rewardIcon;
    public int timeLeft;
    public Vector3[] rewardPosition;

    saveManager saveManager;
    timeNowManager timeNowManager;
    localizerManager localizerManager;


    void Start()
    {
        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        timeNowManager = gameProperties.GetComponent<timeNowManager>();
        localizerManager = gameProperties.GetComponent<localizerManager>();
        //Debug.LogWarning("Start");
        StartingOrder();
    }

    
    public void StartingOrder()
    {
        foreach(GameObject go in objectsToHideAtFirstStart)
            go.SetActive(false);
        string orderId = gameObject.name;


        /////////////////////////////////////////////////////////////////////    FETCH VALUES IF THE ORDER IS UNLOCKED AND ALREADY STARTED
        if (saveManager.GetSavedInt(orderId + "_isUnlocked") > 0 && saveManager.GetSavedInt(orderId + "_isWaiting") == 0)
        {
            foreach (GameObject go in objectsToHideAtFirstStart)
                go.SetActive(true);

            itemsInOrder = saveManager.GetSavedInt(orderId + "_itemCount");
            family[0] = saveManager.GetSavedString(orderId + "_family_0");
            family[1] = saveManager.GetSavedString(orderId + "_family_1");
            tier[0] = saveManager.GetSavedInt(orderId + "_tier_0");
            tier[1] = saveManager.GetSavedInt(orderId + "_tier_1");
            isSold[0] = saveManager.GetSavedInt(orderId + "_isSold_0");
            isSold[1] = saveManager.GetSavedInt(orderId + "_isSold_1");
            price = saveManager.GetSavedInt(orderId + "_price");
            priceType = saveManager.GetSavedInt(orderId + "_priceType");

            isTimeOrder = saveManager.GetSavedInt(orderId + "_isTimeOrder");
            isSpecialOrder = saveManager.GetSavedInt(orderId + "_isSpecialOrder");
            specialOrderPicked = saveManager.GetSavedInt(orderId + "_specialOrderPicked");
            refreshTime = saveManager.GetSavedInt(orderId + "_refreshTime");
            maxTimer = saveManager.GetSavedInt(orderId + "_maxTimer");
            rewardMultiplier = saveManager.GetSavedInt(orderId + "_rewardMultiplier");
            timeLeft = refreshTime - timeNowManager.timeNow;

            // CRETE NEW IF TIME IS ELAPSED
            if( timeLeft <0)
            GameObject.Find("gameProperties").GetComponent<orderManager>().CreateOrder(gameObject, orderSlot);

            // RESTART THE ORDER IF IT IS EMPTY
            if (family[0] == "" && family[1] == "" && tier[0] == 0 && tier[0] == 0)
                GameObject.Find("gameProperties").GetComponent<orderManager>().CreateOrder(gameObject, orderSlot);
            // CREATE THE ORDER NORMALLY
            else
                InitiateOrder(itemsInOrder, family, tier, price, priceType, isTimeOrder, isSpecialOrder, refreshTime, maxTimer, rewardMultiplier, specialOrderPicked);
        }

        /////////////////////////////////////////////////////////////////////    IF NO ORDER IS SET  BUT ORDER IS UNLOCKED, CATCH UP ON UNLOCK
        else if(saveManager.GetSavedInt(orderId + "_isUnlocked") > 0)
        {
            foreach (GameObject go in objectsToHideAtFirstStart)
                go.SetActive(true);
            GameObject.Find("gameProperties").GetComponent<orderManager>().CreateOrder(gameObject, orderSlot);
        }
        
        /////////////////////////////////////////////////////////////////////    ELSE IF NOT UNLOCKED ON PLAYER PREFS, DO THE UNLOCK
        else if (GetComponent<unlockController>())
        {
            if (saveManager.GetSavedInt(orderId + "_isUnlocked") == 0 && !GetComponent<unlockController>().isLocked)
                    UnlockOrder();
        }


    }


    public void InitiateOrder(int itemCount, string[] m_family, int[] m_tier, int m_price, int rewardType, int m_isTimeOrder, int m_isSpecialOrder, int m_refreshTime, int m_maxTimer, int m_rewardMultiplier, int m_specialOrderPicked)
    {

        //Debug.Log("Initiate order. Items: "+itemCount+ ". Item 1 sold: " + isSold[0] + ". Item 2 sold: " + isSold[1]);

        foreach (GameObject go in objectsToHideAtFirstStart)
            go.SetActive(true);

        ////////////////////////////////////////////////////////////////////////    ANIMS
        if (itemCount ==2 && isSold[0] ==0 && isSold[1] == 0)
            GetComponent<Animation>().Play("boat_in_2items");
        else if (itemCount == 1 || isSold[1] == 1)
            GetComponent<Animation>().Play("boat_in_item1");
        else if (itemCount == 2 && isSold[0] == 1)
            GetComponent<Animation>().Play("boat_in_item2");

        ////////////////////////////////////////////////////////////////////////    PRICE
        priceType = rewardType;
        price = m_price;
        priceText.text = price.ToString();
        priceText.color = rewardTextColors[priceType];
        bool positionFound = false;
        for(int i = 0; i < pricePositionMilestones.Length; i++)
        {
            if (m_price < pricePositionMilestones[i] && !positionFound)
            {
                priceParent.localPosition = new Vector3(pricePositions[i], 0.581f, -0.153f);
                positionFound = true;
            }
        }


        for (int i = 0; i < itemCount; i++)
        {
            ///////////////////////    UPDATE VALUES
            family[i] = m_family[i];
            tier[i] = m_tier[i];
            itemsInOrder = itemCount;


            ///////////////////////    ICONS
            imageLoaded[i] = Resources.Load<Texture>("UI/icons/items/" + family[i] + "_" + tier[i].ToString());
            itemImage[i].material.mainTexture  = imageLoaded[i];
        }

        //////////////////////////////////////////////////////////////////////// UPDATE REWARD
        for ( int i = 0; i < priceIcons.Length;i++)
        {
            if (i == priceType)
                priceIcons[i].SetActive(true);
            else
                priceIcons[i].SetActive(false);
        }



        //////////////////////////////////////////////////////////////////////// TIME
        isTimeOrder = m_isTimeOrder;
        isSpecialOrder = m_isSpecialOrder;
        specialOrderPicked = m_specialOrderPicked;
        refreshTime = m_refreshTime;
        maxTimer = m_maxTimer;
        rewardMultiplier = m_rewardMultiplier;

        // TIME ORDER
        if (isTimeOrder == 0)
        {
            orderTimeObject.SetActive(false);
        }
        else
        {
            orderTimeObject.SetActive(true);
            StartCoroutine(UpdateTimeLeft());
        }
        float posX = priceParent.localPosition.x;
        float posY = rewardPosition[isTimeOrder].y;
        float posZ = rewardPosition[isTimeOrder].z;
        priceParent.localPosition = new Vector3( posX, posY, posZ);

        // SPECIAL ORDER
        if (isSpecialOrder == 0)
        {
            multiplierObject.SetActive(false);
        }
        else
        {
            multiplierText.text = "x" + rewardMultiplier.ToString();
            multiplierObject.SetActive(true);
            for (int i = 0; i < rewardIcon.Length; i++)
                rewardIcon[i].SetActive(false);
            rewardIcon[specialOrderPicked].SetActive(true);
        }


        //////////////////////////////////////////////////////////////////////// START TIMER TO MAKE ORDER READY
        creationStart = Time.time;
        orderReadyToSell = false;


    }

    public void UnlockOrder()
    {

        SaveUnlockedOrder();
        StartingOrder();

    }


    public void SellItem(int itemToSell)
    {
        ////////////////////// SAVE IS SOLD
        isSold[itemToSell] = 1;
        SaveSoldOrder(itemToSell);


        ////////////////////// SELL ANIM
        if (CanCompleteOrder())
            GetComponent<Animation>().Play("boat_out");
        else if (itemToSell == 0)
            GetComponent<Animation>().Play("a_item_sell1");
        else
            GetComponent<Animation>().Play("a_item_sell2");


        ////////////////////// SELL ORDER
        if (CanCompleteOrder())
        {
            GameObject.Find("gameProperties").GetComponent<orderManager>().SellOrder(gameObject);
            creationStart = Mathf.Infinity;
            orderReadyToSell = false;
        }


        ////////////////////// CHECK IF ITEMS CAN BE SOLD
        CheckItemSell();
        //GameObject.Find("gameProperties").GetComponent<itemManager>().CheckItemsSell();
        //checkSellDone = false;


    }

    void CheckItemSell()
    {

        //GameObject.Find("gameProperties").GetComponent<itemManager>().CheckAllItemsSell();
        
    }

    bool CanCompleteOrder()
    {
        bool canSell = true;
        for(int i = 0; i < itemsInOrder; i++)
        {
            if (isSold[i] == 0)
                canSell = false;
        }

        return canSell;

    }
    
    private void Update()
    {
        if (Time.time > (creationStart + readyDelay) && !orderReadyToSell)
        {
            //Debug.Log("Check item sell");
            orderReadyToSell = true;
            CheckItemSell();
        }

    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////// TIME IN ORDER
    private void OnApplicationFocus(bool focus)
    {
        if (focus)
        {
            if (isTimeOrder == 1)
                StartCoroutine(UpdateTimeLeft());
        }
    }


    IEnumerator UpdateTimeLeft()
    {
        int refreshCooldown = 1;
        int timeLeftSimple = 1;
        float proportion = 1f;
        timeLeft = 1;

        while ( timeLeft > 0)
        {
            ////////////////////////// CALCULATE VALUES
            timeLeft = refreshTime - timeNowManager.timeNow;
                
            ////////////////////////// PROPORTION
            proportion = (timeLeft * 1f) / (maxTimer * 1f);
            progressTransform.localScale = new Vector3(proportion, 1f, 1f);

            ////////////////////////// hour formatting
            if (timeLeft > 3600)
            {
                // REFRESH
                timeLeftSimple = Mathf.CeilToInt(timeLeft / 3600f);
                if (timeLeft > 7200)
                    refreshCooldown = 3600; // if time left > 2h, refresh in 1h
                else
                    refreshCooldown = 600; // if time left < 2h, refresh in 10 min
                // APPLY
                timeLeftText.text = timeLeftSimple.ToString() + localizerManager.LocalizedText(198);
            }

            ////////////////////////// min formatting
            else if (timeLeft > 60)
            {
                // REFRESH
                timeLeftSimple = Mathf.CeilToInt(timeLeft / 60f);
                if (timeLeft > 120)
                    refreshCooldown = 60; // if time left > 2min, refresh in 1 min
                else
                    refreshCooldown = 1; // if time left < 2 min, refresh in 1 sec
                // APPLY
                timeLeftText.text = timeLeftSimple.ToString() + localizerManager.LocalizedText(205);
            }

            ////////////////////////// sec formatting
            else
            {
                // REFRESH
                timeLeftSimple = timeLeft;
                refreshCooldown = 1; // if time left < 2 min, refresh in 1 sec
                // APPLY
                timeLeftText.text = timeLeftSimple.ToString() + localizerManager.LocalizedText(99);
            }

            yield return new WaitForSeconds(refreshCooldown);
        }


        //// CREATE NEW ORDER AS THIS ONE IS OVER
        GetComponent<Animation>().Play("boat_out");
        creationStart = Mathf.Infinity;
        orderReadyToSell = false;

        yield return new WaitForSeconds(3f);
        GameObject.Find("gameProperties").GetComponent<orderManager>().CreateOrder(gameObject, orderSlot);



        yield return null;
    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveSoldOrder(int itemToSell)
    {
        saveManager.SaveInt(gameObject.name + "_isSold_" + itemToSell.ToString(), 1); // save if item is sold
    }

    void SaveUnlockedOrder()
    {
        saveManager.SaveInt(gameObject.name + "_isUnlocked", 1); // save if order is unlocked
    }


}
