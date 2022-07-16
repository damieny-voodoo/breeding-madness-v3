using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class tileController : MonoBehaviour
{

    [Header("MISC")]
    public tileBalancing tileBalancing;
    saveManager saveManager;
    tutorialManager tutorialManager;
    spawnerController spawnerController;
    public necManager necManager;
    public bool isOrder;
    public bool isTrash;
    public Color[] tilesColors;
    public bool defaultTile;

    [Header("ID")]
    public int gridId;
    public int posX;
    public int posY;
    public string tileId;

    [Header("State")]
    public bool isOpen;
    public bool isUnlocked;
    public bool canBePurchased;
    public bool isPurchased;

    [Header("Item")]
    public GameObject itemIn;
    public string itemInFamily;
    public int itemInTier;

    [Header("Lock")]
    public int unlockLevel;
    public int currentLevel;
    public TextMeshPro lockText;
    public GameObject lockObject;


    [Header("Price")]
    public int unlockPrice;
    public Color notPurchasableColor;
    public TextMeshPro priceText;
    public GameObject purchaseObject;

    [Header("Feedback")]
    public GameObject levelLockFeedback;
    public TextMeshPro levelLockFeedbackText;
    
    public GameObject notEnoughCoinsFeedback;

    [Header("ADJACENT TILES")]
    public GameObject tileLeft;
    public GameObject tileRight;
    public GameObject tileUp;
    public GameObject tileDown;

    [Header("TREES")]
    public GameObject treeParent;
    /*
    public Transform[] trees;
    public float treeAnimTimeMin;
    public float treeAnimTimeMax;
    public AnimationCurve treeAnim;
    */


    [Header("FENCES")]
    public GameObject fenceLeft;
    public GameObject fenceRight;
    public GameObject fenceUp;
    public GameObject fenceDown;


    Transform cardPivot;
    GameObject gameProperties;

    //int[,] unlockTilePrice;

    void Start()
    {
        if(lockObject)
        cardPivot = lockObject.transform.Find("cardPivot");
        gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        tutorialManager = gameProperties.GetComponent<tutorialManager>();
        //InitTilesPrices();
        InitiateTile();
    }



    ///////////////////////////////////////////////////////// INITIATILZE ITEM AT START
    public void InitiateTile()
    {

        if (!isOrder && !isTrash)
        {
            ////////// BALANCING
            tileBalancing = GameObject.Find("balancingData").GetComponent<tileBalancing>();
            necManager = gameProperties.GetComponent<necManager>();
            unlockPrice = tileBalancing.tilePrices[gridId, posY, posX];
            priceText.text = unlockPrice.ToString();
            unlockLevel = tileBalancing.tilesLevelUnlock[gridId, posY, posX];
            lockText.text = unlockLevel.ToString();

            ////////// COLOR OF THE TILE
            int colorBool = (posX + posY) % 2;
            GetComponent<Renderer>().material.color = tilesColors[colorBool];


            ////////// CREATE ITEM IF NEEDED
            InitiateItem(posX, posY);


            ////////// LOCK
            CheckState(true);


        }


    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// STATE
    public void CheckState(bool initialCheck)
    {
        int purchasedInt = saveManager.GetSavedInt(tileId + "_isPurchased");
        int currentXp = saveManager.GetSavedInt("currentXp");
        currentLevel = gameProperties.GetComponent<xpManager>().GetLevel(currentXp);
        int currentCoins = saveManager.GetSavedInt("currentCoins");

        // IS OPEN
        if (CheckOpenState())
            SetOpenState(true);

        // LOCK STATE
        if (currentLevel >= unlockLevel)
            SetLockState(true);
        else
            SetLockState(false);


        // PURCHASE STATE
        if (defaultTile || purchasedInt > 0)
            SetPurchased();
        else if (currentCoins >= unlockPrice)
            SetPurchaseState(true);
        else
            SetPurchaseState(false);

        ////// SHOW HIDE CARDS
        if (!isOpen || isPurchased)
        {
            lockObject.SetActive(false);
            purchaseObject.SetActive(false);
        }
        else
        {
            if (isUnlocked)
            {
                lockObject.SetActive(false);
                purchaseObject.SetActive(true);
            }
            else
            {
                lockObject.SetActive(true);
                purchaseObject.SetActive(false);

            }

        }


        ////////// FENCES
        UpdateFences();

    }

    public void SetOpenState(bool openState)
    {
        bool tmp_open = isOpen;
        isOpen = openState;

        if (!tmp_open && isOpen)
        {
            lockObject.GetComponent<Animation>().Play("tile_Awake");
            purchaseObject.GetComponent<Animation>().Play("tile_Awake");

            // REMOVE TREES
            Destroy(treeParent);
        }


    }

    public void SetLockState(bool lockState)
    {
        // SET BOOL
        isUnlocked = lockState;

        // ACTIVATE
        lockObject.SetActive(lockState);


        // RANDOM ROTATION
        float randomRotation = Random.Range(-15f, 15f);
        cardPivot.eulerAngles = new Vector3(0, 0, randomRotation);

    }
    public void SetPurchaseState(bool can)
    {

        // SET BOOL
        bool tmp_canPurchase = canBePurchased;
        canBePurchased = can;

        // ACTIVATE
        purchaseObject.SetActive(can);

        // COLOR
        if (!can)
            priceText.color = notPurchasableColor;
        else
            priceText.color = Color.white;


        // RANDOM ROTATION
        if (!tmp_canPurchase && canBePurchased)
        {
            float randomRotation = Random.Range(-15f, 15f);
            purchaseObject.transform.Find("cardPivot").eulerAngles = new Vector3(0, 0, randomRotation);
            purchaseObject.GetComponent<Animation>().Play("tile_Pop");
        }

    }

    void SetPurchased()
    {
        isOpen = true;
        isUnlocked = true;
        canBePurchased = true;
        isPurchased = true;


        lockObject.SetActive(false);
        purchaseObject.SetActive(false);

        // REMOVE TREES
        Destroy(treeParent);

        //Destroy(GetComponent<Collider>());
        SaveTilePurchase(tileId, 1);

    }

    public bool CheckOpenState()
    {
        bool openState = false;
        if (tileLeft)
        {
            if (saveManager.GetSavedInt(tileLeft.GetComponent<tileController>().tileId + "_isPurchased") == 1 || tileLeft.GetComponent<tileController>().defaultTile)
                openState = true;
        }
        if (tileRight)
        {
            if (saveManager.GetSavedInt(tileRight.GetComponent<tileController>().tileId + "_isPurchased") == 1 || tileRight.GetComponent<tileController>().defaultTile)
                openState = true;
        }
        if (tileUp)
        {
            if (saveManager.GetSavedInt(tileUp.GetComponent<tileController>().tileId + "_isPurchased") == 1 || tileUp.GetComponent<tileController>().defaultTile)
                openState = true;
        }
        if (tileDown)
        {
            if (saveManager.GetSavedInt(tileDown.GetComponent<tileController>().tileId + "_isPurchased") == 1 || tileDown.GetComponent<tileController>().defaultTile)
                openState = true;
        }

        return openState;

    }

    ///////////////////////////////////////////////////////// ITEM ASSIGNMENT
    public void InitiateItem(int posX, int posY)
    {
        // DOES IT HAVE AN ITEM
        if (saveManager.GetSavedString(tileId + "_family").Length > 0)
        {
            string itemFamily = saveManager.GetSavedString(tileId + "_family");
            int itemFamilyID = saveManager.GetSavedInt(tileId + "_familyID");
            int itemTier = saveManager.GetSavedInt(tileId + "_tier");
            gameProperties.GetComponent<itemManager>().CreateItem(itemFamilyID, gameObject, itemFamily, itemTier, true);
        }

    }

    public void AssignItem(string family, int familyID, int tier, GameObject item)
    {
        itemIn = item;
        itemInFamily = family;
        itemInTier = tier;


        //saveManager.SaveTile(tileId, family, familyID, tier);
        SaveTile(tileId, family, familyID, tier);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PURCHASE
    public void TryPurchase()
    {

        if (!isOrder)
        {
            if (isOpen)
            {
                if (isUnlocked)
                {
                    if(canBePurchased)
                        PurchaseTile(unlockPrice);
                    else
                    {
                        necManager.ShowNec("coins");
                    }
                }

                else
                {
                    FeedbackLocked();
                }
            }

        }

    }

    public void PurchaseTile(int unlockTilePrice)
    {

        //////////////////////////////////////////////////////////// Spend Coins
        if(unlockTilePrice >0)
            gameProperties.GetComponent<coinManager>().SpendCoins(unlockTilePrice);
        
        //////////////////////////////////////////////////////////// Feedback
        if (purchaseObject)
            purchaseObject.GetComponent<Animation>().Play("tile_out");

        //////////////////////////////////////////////////////////// Unlock
        SetPurchased();

        //////////////////////////////////////////////////////////// UPDATE FENCES AND LOCK
        UpdateFences();

        if (tileRight)
        {
            tileRight.GetComponent<tileController>().UpdateFences();
            tileRight.GetComponent<tileController>().CheckState(false);
        }
        if (tileLeft)
        {
            tileLeft.GetComponent<tileController>().UpdateFences();
            tileLeft.GetComponent<tileController>().CheckState(false);
        }
        if (tileUp)
        {
            tileUp.GetComponent<tileController>().UpdateFences();
            tileUp.GetComponent<tileController>().CheckState(false);
        }
        if (tileDown)
        {
            tileDown.GetComponent<tileController>().UpdateFences();
            tileDown.GetComponent<tileController>().CheckState(false);
        }

        //////////////////////////////////////////////////////////// TUTORIALS
        int tutoProgress = saveManager.GetSavedInt("tutorialTileProgress");
        if (tutoProgress != 2)
        {
            SaveTileTutorialProgress();
            spawnerController = GameObject.Find("spawner_0").GetComponent<spawnerController>();
            spawnerController.tutorialTileProgress = 2;
            if (tutoProgress == 1)
                tutorialManager.HideTutoTile();
        }

    }



    public void FeedbackLocked()
    {
        levelLockFeedback.transform.position = transform.position;
        levelLockFeedbackText.text = unlockLevel.ToString();
        levelLockFeedback.GetComponent<Animation>().Stop("a_lockedFeedback");
        levelLockFeedback.GetComponent<Animation>().Play("a_lockedFeedback");
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FENCES
    public void UpdateFences()
    {
        /*
        if (isPurchased)
        {
            /////// FENCE LEFT
            if (!tileLeft)
                fenceLeft.SetActive(false);
            else
            {
                if (saveManager.GetSavedInt(tileLeft.GetComponent<tileController>().tileId + "_isPurchased") == 0 && !tileLeft.GetComponent <tileController>().defaultTile)
                    fenceLeft.SetActive(true);
                else
                    fenceLeft.SetActive(false);
            }
            /////// FENCE RIGHT
            if (!tileRight)
                fenceRight.SetActive(false);
            else
            {
                if (saveManager.GetSavedInt(tileRight.GetComponent<tileController>().tileId + "_isPurchased") == 0 && !tileRight.GetComponent<tileController>().defaultTile)
                    fenceRight.SetActive(true);
                else
                    fenceRight.SetActive(false);
            }
            /////// FENCE UP
            if (!tileUp)
                fenceUp.SetActive(false);
            else
            {
                if (saveManager.GetSavedInt(tileUp.GetComponent<tileController>().tileId + "_isPurchased") == 0 && !tileUp.GetComponent<tileController>().defaultTile)
                    fenceUp.SetActive(true);
                else
                    fenceUp.SetActive(false);
            }
            /////// FENCE DOWN
            if (!tileDown)
                fenceDown.SetActive(false);
            else
            {
                if (saveManager.GetSavedInt(tileDown.GetComponent<tileController>().tileId + "_isPurchased") == 0 && !tileDown.GetComponent<tileController>().defaultTile)
                    fenceDown.SetActive(true);
                else
                    fenceDown.SetActive(false);
            }
        }

        else
        {
            fenceLeft.SetActive(false);
            fenceRight.SetActive(false);
            fenceUp.SetActive(false);
            fenceDown.SetActive(false);
        }

        */

    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveTile(string tileName, string itemFamily, int itemFamilyID, int itemTier)
    {
        saveManager.SaveString(tileName + "_family", itemFamily);                                           // tile family
        saveManager.SaveInt(tileName + "_familyID", itemFamilyID);                                          // tile Family ID
        saveManager.SaveInt(tileName + "_tier", itemTier);                                                  // tile tier
    }

    void SaveTilePurchase(string tileId, int purchaseCode)
    {
        saveManager.SaveInt(tileId + "_isPurchased", purchaseCode);                                         // save if tile has been purchased
    }
    void SaveTileTutorialProgress()
    {
        saveManager.SaveInt("tutorialTileProgress", 2);                                         
    }

}
