using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemController : MonoBehaviour
{
    [Header("DEFINITION ------------")]
    public bool isBomb = false;
    public GameObject associatedTrash;
    public bool initialItem = false;
    public string itemFamily;
    public int itemFamilyId;
    public int itemTier;


    [Header("STATUS ------------")]
    public bool isMoving = false;


    [Header("LINKS ------------")]
    public GameObject currentTile;
    public GameObject artParent;

    [Header("MERGE ------------")]
    public int itemMaxTier;
    public bool canMerge;
    public GameObject mergeableItem;
    public GameObject mergeFeedback;

    [Header("SELL ------------")]
    public bool canSellItem;       
    public GameObject orderToCanSell;
    public int slotToSell;
    public bool isSelling = false; // used for quick sell
    GameObject petToFeed;
    public float quickSellHeightOffset;
    public GameObject lineFeedback;

    [Header("ENERGY REWARD ------------")]
    public int energyReward;
    public GameObject energyRewardCard;
    public TextMeshPro energyRewardText;
    public float[] destructionBgWidth;
    public float[] destructionRewardPosition;
    public GameObject destructionBg;
    public GameObject desctructionRewardParent;
    energyBalancing energyBalancing;
    analyticsManager analyticsManager;
    petManager petManager;
    saveManager saveManager;
    //int[] energyRewardList;


    /// ///////////// MISC
    float moveStartTime;
    float moveTapDelay = 1.0f;
    public GameObject newArt;

    float smoothTime = 0.035f;
    float destroyDistance = 1.5f;

    bool DebugOn = false;

    tipsManager tipManager;
    tutorialManager tutorialManager;
    GameObject gameProperties;


    //public bool IsAssigned;
    //public float dragHeight;

    private void Awake()
    {
        gameProperties = GameObject.Find("gameProperties");
        tutorialManager = gameProperties.GetComponent<tutorialManager>();
        saveManager = gameProperties.GetComponent<saveManager>();
        petManager = gameProperties.GetComponent<petManager>();
    }


    void OnEnable()
    {

        isSelling = false;

        if (energyRewardCard)
            energyRewardCard.transform.localScale = new Vector3(0, 0, 0);

    }

    public void InitiateItem()
    {
        if(!gameProperties)
            gameProperties = GameObject.Find("gameProperties");
        energyBalancing = GameObject.Find("balancingData").GetComponent<energyBalancing>();
        tipManager = gameProperties.GetComponent<tipsManager>();
        saveManager = gameProperties.GetComponent<saveManager>();
        tutorialManager = gameProperties.GetComponent<tutorialManager>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();

        if (!isBomb)
        {
            //if(DebugOn)
            //Debug.Log("Create " + itemFamily + "_" + itemTier);


            newArt = ObjectPool.SharedInstance.GetPooledObject(itemFamily + "_" + itemTier);
            newArt.SetActive(true);
            newArt.transform.parent = artParent.transform;
            newArt.transform.position = artParent.transform.position;
            GetComponent<itemAnimationController>().artObject = newArt;
            GetComponent<itemAnimationController>().itemAnimation = newArt.GetComponent<Animation>();


            ////////////////////////////// UPDATE VALUE OF ENERGY REWARD
            energyReward = energyBalancing.destroyRewards[itemTier];
            energyRewardText.text = energyReward.ToString();
            SetDestructionCardSizes(energyReward);
            energyRewardText.GetComponent<autoSizeText>().RedoFontSize();

            /*
            int itemFamilyCurrentTier = saveManager.GetSavedInt(itemFamily + "_progress");
            if (!initialItem && itemTier > itemFamilyCurrentTier)
            {
                //////////////////////////////  UPDATE THE ALBUM
                gameProperties.GetComponent<albumManager>().UpdateAlbum(itemFamilyId, itemTier);
                gameProperties.GetComponent<albumManager>().DiscoverNewItem(itemFamily, itemTier, itemFamilyCurrentTier);

            //////////////////////////////  SHOW THE NEW ITEM POPUP
            //int ok;
                if (!(itemFamily == "carrots" && itemTier == 0))
                    gameProperties.GetComponent<newItemManager>().ShowPopup(itemFamily, itemFamilyId, itemTier);
                //Debug.Log("-");
                //else
                //    GameObject.Find("gameProperties").GetComponent<newItemManager>().ShowPopup(itemFamily, itemFamilyId, itemTier);
            }
            */

            //////////////////////////////  CHECK IF IT CAN BE SOLD
            CheckSell(false);


        }

    }

    void SetDestructionCardSizes(int rewardAmount)
    {
        bool sizeFound = false;
        int currentSizeCheck = 10;
        for(int i =0; i< destructionBgWidth.Length; i++)
        {
            if (!sizeFound && rewardAmount < currentSizeCheck)
            {
                destructionBg.transform.localScale = new Vector3(destructionBgWidth[i], destructionBg.transform.localScale.y, destructionBg.transform.localScale.z);
                desctructionRewardParent.transform.localPosition = new Vector3(desctructionRewardParent.transform.localPosition.x, desctructionRewardParent.transform.localPosition.y, destructionRewardPosition[i]);
                sizeFound = true;
            }
            else
                currentSizeCheck = currentSizeCheck*10;
        }


    }


    public void OnMouseDown()
    {
        if (!isMoving)
        {
            moveStartTime = Time.time;
            isMoving = true;

            if (DebugOn)
                Debug.Log("Start moving item: "+Time.time);
        }

    }

    public void MoveItem()
    {

        Plane plane = new Plane(Vector3.up, 0);
        Vector3 worldPosition;
        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
            float posX = worldPosition.x;
            float posY = worldPosition.y;
            float posZ = worldPosition.z;

            transform.position = new Vector3(posX, posY, posZ);
        }


    }

    public void StopMoving(RaycastHit stopHit)
    {

        Debug.Log("stop move item");
        isMoving = false;

        GameObject hitObject = null;
        if (stopHit.collider)
        {
            hitObject = stopHit.collider.gameObject;
            Debug.Log(gameObject.name + " stops move on "+ hitObject.name);
        }


        //////////////////////////////////////////////////////////////////////////////////////////////// BOMB
        if (isBomb)
        {
            if (hitObject)
            {
                if (hitObject.tag == "item")
                {
                    // DESTROY ITEMS
                    hitObject.GetComponent<itemController>().DestroyItem(true, false);
                    /*
                    int currentLevel = saveManager.GetSavedInt("currentLevel");
                    if (!analyticsManager)
                        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
                    analyticsManager.UseBomb(currentLevel);
                    */
                    DestroyItem(false, false);

                    // CREATE A NEW BOMB
                    associatedTrash.GetComponent<trashController>().CreateNewBomb();

                    // FEEDBACK
                    gameProperties.GetComponent<feedbackManager>().TrashItem(hitObject);

                    // BLOCK TIPS FOR THE BOMB
                    //gameProperties.GetComponent<tipsManager>().CompleteTip(3);

                    //////////////////////////////////////////////////////////// TUTORIALS
                    /*
                    int tutoProgress = saveManager.GetSavedInt("tutorialBombProgress");
                    if (tutoProgress != 2)
                    {
                        SaveBombTutorialProgress();
                        spawnerController spawnerController = GameObject.Find("spawner_0").GetComponent<spawnerController>();
                        spawnerController.tutorialBombProgress = 2;
                        if (tutoProgress == 1)
                            tutorialManager.HideTutoBomb();
                    }
                    */
                }
                else
                    transform.position = associatedTrash.transform.position;
            }
            else
                transform.position = associatedTrash.transform.position;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////// REGULAR ITEM
        //////////////////////////////////////////////////// CREATE A MERGE
        else
        {
            if (hitObject)
            {
                if (hitObject.tag == "item")
                {
                    //////////////////////////////////////////////////// MERGE ITEMS
                    if (itemTier < itemMaxTier && hitObject.GetComponent<itemController>().itemFamily == itemFamily && hitObject.GetComponent<itemController>().itemTier == itemTier && currentTile != hitObject)
                    {
                        MergeItem(hitObject, hitObject.GetComponent<itemController>().currentTile);
                    }
                    //////////////////////////////////////////////////// SWAP ITEMS
                    else
                    {
                        Debug.Log("Swap items");
                        GameObject m_currentTile = currentTile;
                        GameObject m_newtile = hitObject.GetComponent<itemController>().currentTile;
                        MoveItemToTile(m_newtile, true);
                        hitObject.GetComponent<itemController>().MoveItemToTile(m_currentTile, true);
                        tipManager.TriggerTip(1);
                    }
                }

                else if (hitObject.tag == "tile")
                {
                    //////////////////////////////////////////////////// TRY QUICK SELL
                    if (hitObject == currentTile && Time.time < moveStartTime + moveTapDelay)
                    {
                        bool canSell = false;
                        GameObject selectedPet = null;

                        for (int i = 0; i < petManager.ownedPets.Length; i++)
                        {
                            if (!canSell)
                            {
                                petController petController = petManager.ownedPets[i].GetComponent<petController>();
                                //if (petController.isOwned && !petController.isEgg && !petController.allBreedsUsed && !petController.isHappy && itemFamily == petController.foodFamily && itemTier == petController.currentFoodTier)
                                if (petController.isOwned && !petController.isEgg && !petController.isHappy  && !petController.allBreedsUsed && itemFamily == petController.currentFoodFamily && itemTier == petController.currentFoodTier)
                                {
                                    canSell = true;
                                    selectedPet = petManager.ownedPets[i];
                                }
                            }
                        }

                        if (canSell)
                        {
                            StartSellingItem(selectedPet);
                        }
                        else
                        {
                            MoveItemToTile(hitObject, false);
                        }
                    }
                    else
                        MoveItemToTile(hitObject, false);
                }

                //////////////////////////////////////////////////// SELL ON PET BY DRAGGING
                else if (hitObject.tag == "pet")
                {
                    petController petController = hitObject.transform.parent.GetComponent<petController>();
                    //if (!petController.isEgg && !petController.isHappy && !petController.allBreedsUsed && itemFamily == petController.foodFamily && itemTier == petController.currentFoodTier)
                    if (!petController.isEgg && !petController.isHappy && itemFamily == petController.currentFoodFamily && itemTier == petController.currentFoodTier)
                    {
                        SellItem(petController);
                        tipManager.TriggerTip(0);
                    }
                    else
                    {
                        MoveItemToTile(currentTile, false);
                    }
                }

            }
            else
                MoveItemToTile(currentTile, false);

        }

    }
    


    void StartSellingItem(GameObject m_petToFeed)
    {
        isSelling = true;
        petToFeed = m_petToFeed;
        //slotToSell = orderSlot;

        if (DebugOn)
            Debug.Log("Start selling item");


    }
    void SellItem(petController petController)
    {
        if (DebugOn)
            Debug.Log("sell item: " + itemFamily + " " + itemTier);
        petController.FeedPet();
        DestroyItem(false, true);

    }


    public void DestroyItem(bool isBombDestroyed, bool isOrderDestroyed)
    {

        // REMOVE FROM TILE
        if (currentTile && (isBombDestroyed || isOrderDestroyed))
            currentTile.GetComponent<tileController>().AssignItem("",0, 0, null);

        // DESTROY
        ObjectPool.SharedInstance.ReleaseObject(gameObject);
        if (newArt)
        {
            ObjectPool.SharedInstance.ReleaseObject(newArt);
            newArt = null;
        }

        if (isBombDestroyed)
            DestroyByBomb();

        // Remove Item From List
        gameProperties.GetComponent<itemManager>().RemoveItemFromList(gameObject);

    }

    void DestroyByBomb()
    {
        /*
        if(energyReward>0)
            gameProperties.GetComponent<feedbackManager>().CoinSpawn(energyReward, gameObject, 0f, "coins");
        */
    }

    public void MergeItem(GameObject mergingItem, GameObject closestTile)
    {
        gameProperties.GetComponent<itemManager>().CreateItemMerge(itemFamilyId, itemFamily, itemTier, gameObject, mergingItem, currentTile, closestTile);
    }

    void MoveItemToTile(GameObject targetTile, bool isSwap)
    {
        Debug.Log("Move item to tile " + targetTile.name);

        // UNASSIGN PREVIOUS TILE
        if (!isSwap)
        {
            if (currentTile)
                currentTile.GetComponent<tileController>().AssignItem("", 0, 0, null);
            else
                Debug.LogWarning("Moving item while item has no current tile");
        }

        // ASSIGN TO NEW TILE
        targetTile.GetComponent<tileController>().AssignItem(itemFamily, itemFamilyId, itemTier, gameObject);
        currentTile = targetTile;
        transform.position = targetTile.transform.position;
        transform.parent = targetTile.transform;

        // feedback
        //gameProperties.GetComponent<feedbackManager>().MoveFeedback(transform);
    }


    GameObject ClosestTile()
    {
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        // CHECK TILES
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("tile");
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }

        // CHECK PETS
        GameObject[] gos2;
        gos2 = GameObject.FindGameObjectsWithTag("pet");
        foreach (GameObject go2 in gos2)
        {
            Vector3 diff = go2.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go2;
                distance = curDistance;
            }
        }



        return closest;

    }


    void Update()
    {
        //////////////////////////////////////////////////////////////////////////////////////////////// QUICK SELL

        if (isSelling)
        {
            //////////////// SMOOTH GO TO BOAT
            Vector3 targetPosition = new Vector3(petToFeed.transform.position.x, petToFeed.transform.position.y + quickSellHeightOffset, petToFeed.transform.position.z);
            Vector3 velocity = Vector3.zero;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);



            //////////////// SELL TO BOAT
            Vector3 diff = petToFeed.transform.position - transform.position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < destroyDistance)
            {
                SellItem(petToFeed.GetComponent<petController>());
            }
        }

        
        else if (!isBomb)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////// CHECK MERGE
            //CheckMerge();

            //////////////////////////////////////////////////////////////////////////////////////////////// CHECK SELL
            //CheckSell();
        }
        
    }


    ///////////////////////////////////////////////////////////////////////// MERGEABLE ITEM
    public void CheckMerge()
    {
        /*
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        bool mergeFound = false;

        if (itemTier < itemMaxTier)
        {
            foreach (GameObject go in gos)
            {
                itemController controller = go.GetComponent<itemController>();
                if (!controller.isBomb && go != gameObject)
                {
                    if (controller.itemTier == itemTier && controller.itemFamily == itemFamily)
                    {
                        if (!mergeFound)
                        {
                            mergeFound = true;
                            SetMerge(go);
                        }
                    }
                }
            }
        }

        if (!mergeFound)
                SetUnmerge();
        */

    }

    public void SetMerge(GameObject mergingItem)
    {
        canMerge = true;
        mergeableItem = mergingItem;
        if(isMoving)
            mergeFeedback.SetActive(false);
        else
        mergeFeedback.SetActive(true);
    }

    public void SetUnmerge()
    {
        canMerge = false;
        mergeFeedback.SetActive(false);
        mergeableItem = null;

    }

    ///////////////////////////////////////////////////////////////////////// SELLABLE ITEM
    public void CheckSell(bool forceFalse)
    {

        bool canSellItem = false;

        if (forceFalse)
            canSellItem = false;

        else
        {
            List<GameObject> petList = petManager.petList;

            foreach (GameObject go in petList)
            {
                petController controller = go.GetComponent<petController>();
                if (controller.isOwned)
                {
                    if (!controller.isEgg)
                    {
                        if (!controller.isHappy)
                        {
                            if (!controller.allBreedsUsed)
                            {
                                if (itemFamily == controller.currentFoodFamily && itemTier == controller.currentFoodTier)
                                    canSellItem = true;
                            }
                        }
                    }
                }
            }
        }


        SetSell(canSellItem);

    }

    public void SetSell(bool m_canSell)
    {
        //Debug.Log("Set sell as = " + m_canSell);


        canSellItem = m_canSell;
        //orderToCanSell = order;
        //slotToSell = item;
        GetComponent<itemAnimationController>().canSell = m_canSell;

    }

    public void SetUnsell()
    {

        canSellItem = false;
        GetComponent<itemAnimationController>().canSell = false;

    }


    /////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveBombTutorialProgress()
    {
        saveManager.SaveInt("tutorialBombProgress", 2);

    }
}
