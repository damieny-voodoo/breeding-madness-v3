using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class feedbackManager : MonoBehaviour
{

    //[Header("MERGE --------------")]
    //public GameObject[] mergeFeedback;

    //int currentLevel;


    [Header("DRAG ---------------")]
    //public GameObject dragFeedback;
    public float dragDestroyTime;
    private float timeToDestroy;
    public GameObject lineCreated;


    [Header("SPAWNERS -----------")]
    public AnimationCurve tapSpawnerAnimation;
    public float spawnerStartSize;
    public float tapScale;
    public float animationTime;
    float startTapTime;
    GameObject spawnerTapped;

    [Header("PRICES -----------")]
    public Color picturePriceNotOk;
    public Color tilePriceNotOk;
    public Color priceOk;

    [Header("COINS -----------")]
    public GameObject coinAsset;
    public GameObject coinFollowObject;
    public int[] coinAmount;
    //public Transform coinParent;
    float rewardFxDelay;
    bool fxShouldSpawn = false;


    [Header("XP -----------")]
    public GameObject xpAsset;
    public GameObject xpFollowObject;
    public int[] xpAmount;
    public GameObject gardenObject;
    //public Transform coinParent;

    [Header("ENERGY -----------")]
    public GameObject energyAsset;
    public GameObject energyFollowObject;

    [Header("WATER -----------")]
    public GameObject waterAsset;
    public GameObject waterFollowObject;

    [Header("SUN -----------")]
    public GameObject sunAsset;
    public GameObject sunFollowObject;
    public int[] sunAmount;

    [Header("DESTRUCTION -----------")]
    public GameObject explosionFeedabck;

    //[Header("MISC -----------")]
    GameObject item1Sold;
    GameObject item2Sold;
    public GameObject coinFx;
    //public GameObject energyFx;
    Vector3 item1;
    Vector3 item2;


    [Header("UI REWARDS -----------")]
    public GameObject rewardParent;
    public int[] uiEnergyAmount;
    public int[] uiFertilizerAmount;
    public int[] uiDiamondsAmount;
    public float spawnPace;


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// MOVE FEEDBACK
    public void DragFeedbackStart(Transform objectFollow)
    {
    }

    public void DragFeedbackStop()
    {
        /// ----- pool section
        //Destroy(lineCreated);
        //if(lineCreated)
        //ObjectPool.SharedInstance.ReleaseObject(lineCreated);
        /// ----- pool section
    }

    public void MoveFeedback(Transform objectFollow)
    {
        // DUST VFX
        GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("spawnFeedback");
        newFeedback.SetActive(true);
        newFeedback.transform.position = objectFollow.position;
        // ANIM
        objectFollow.GetComponent<itemAnimationController>().SpawnItemAnimation();
    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SPAWN FEEDBACK
    public void SpawnFeedback(Transform objectFollow)
    {

        // VFX
        GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("spawnFeedback");
        newFeedback.transform.position = objectFollow.position;
        newFeedback.SetActive(true);
        // ANIM
        objectFollow.GetComponent<itemAnimationController>().SpawnItemAnimation();
    }



    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// MERGE FEEDBACK

    public void CreatePremergeFeedabck(GameObject objectFollow)
    {

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            string goFamily = go.GetComponent<itemController>().itemFamily;
            string family = objectFollow.GetComponent<itemController>().itemFamily;
            int goTier = go.GetComponent<itemController>().itemTier;
            int tier = objectFollow.GetComponent<itemController>().itemTier;
            if (goFamily == family && goTier == tier && go != objectFollow)
            {
                GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("premergeFeedback");
                newFeedback.transform.position = go.transform.position;
                newFeedback.SetActive(true);
            }

        }



    }

    public void StopPremergeFeedback()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("premergeFeedback");
        foreach (GameObject go in gos)
        {
            ObjectPool.SharedInstance.ReleaseObject(go);
        }

    }


    public void MergeFeedback(Transform objectFollow, int mergeTier)
    {
        // FX
        if (mergeTier > 5)
            mergeTier = 5;
        GameObject newFeedback = ObjectPool.SharedInstance.GetPooledObject("mergeFeedback"+ mergeTier.ToString());
        newFeedback.SetActive(true);
        newFeedback.transform.position = objectFollow.transform.position;

        // ANIM
        objectFollow.gameObject.GetComponent<itemAnimationController>().SpawnItemAnimation();

    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SPAWNER FEEDBACK
    public void TapSpawner( float tapTime, GameObject tappedSpawner)
    {
        startTapTime = tapTime;
        spawnerTapped = tappedSpawner;

    }
          


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TILES FEEDBACK
    public void UnlockTileFeedback(GameObject tileUnlocked)
    {

        //Debug.LogWarning("Tile unlocked feedback");

    }

    public void LockedTileFeedback(GameObject tileUnlocked)
    {

        Debug.LogWarning("Tile is locked");

    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// LEVEL UP
    /*
    public void LevelUp(int newLevel, int energyReward, int fertilizerReward)
    {
        /*
        startLevelTime = Time.time;
        currentLevel = newLevel;
        energyRewardText.text = "+" + energyReward.ToString();
        freeFertilizerText.text = "+" + fertilizerReward.ToString();
        
    }
    */

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// PRICES COLORS
    public void CheckPricePicture(TextMeshProUGUI textToCheck, int textPrice, int currentCoins)
    {

    }
    public void CheckPriceTile(TextMeshPro textToCheck, int textPrice, int currentCoins)
    {
        if (textPrice > currentCoins)
            textToCheck.color = tilePriceNotOk;
        else
            textToCheck.color = priceOk;
    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TRASH
    public void TrashItem( GameObject tilePlacement)
    {

        GameObject explosion = ObjectPool.SharedInstance.GetPooledObject("explosionFeedback");
        explosion.SetActive(true);
        explosion.transform.position = tilePlacement.transform.position;

    }
     

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// COINS AFTER ORDER
    public void CoinSpawn(int price, GameObject orderSold,  float delay, string rewardType)
    {

        ///////////////////// ADD DELAY TOS FX
        fxShouldSpawn = true;
        rewardFxDelay = Time.time + delay;


        ///////////////////// How many 3d objects to spawn
        int rewardsToSpawn = 1;
        bool amountPicked = false;
        if (rewardType == "coins")
        {
                for (int i = 0; i < coinAmount.Length; i++)
                {
                    if (price >= coinAmount[i] && !amountPicked)
                    {
                        rewardsToSpawn = i;
                    }
                }
                if (rewardsToSpawn == 0)
                    rewardsToSpawn = 1;
        }
        else if (rewardType == "xp")
        {
            for (int i = 0; i < coinAmount.Length; i++)
            {
                if (price >= xpAmount[i] && !amountPicked)
                {
                    rewardsToSpawn = i;
                }
            }
            if (rewardsToSpawn == 0)
                rewardsToSpawn = 1;
        }

        else if (rewardType == "energy")
            rewardsToSpawn = price;

        else if (rewardType == "water")
            rewardsToSpawn = price;

        else if (rewardType == "sun")
        {
            for (int i = 0; i < sunAmount.Length; i++)
            {
                if (price >= sunAmount[i] && !amountPicked)
                {
                    rewardsToSpawn = i;
                }
            }
            if (rewardsToSpawn == 0)
                rewardsToSpawn = 1;
        }


        //////////////////////////////////////////////////////////////////////////////////// INSTANTIATE EACH COIN
        int rewardsLeft = price;
        int coinsPerCoin = price / rewardsToSpawn;
        for (int i=0; i < rewardsToSpawn; i++)
        {
            ///////////////////// WHERE
            Transform spawnPoint = orderSold.transform;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////// CREATE ITEM
            GameObject instantiatedCoin = ObjectPool.SharedInstance.GetPooledObject(rewardType);
            
            if (rewardType == "xp")
            {
                instantiatedCoin.transform.SetParent(gardenObject.transform);
                instantiatedCoin.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            
            instantiatedCoin.SetActive(true);
            instantiatedCoin.transform.position = orderSold.transform.position;
            //if (rewardType == "xp")
            //    instantiatedCoin.transform.rotation = gardenObject.transform.rotation;
            instantiatedCoin.GetComponent<coin_positionAnim>().StartPop();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////// CREATE LINE
            GameObject instantiatedLine = ObjectPool.SharedInstance.GetPooledObject(rewardType+"Trail");
            instantiatedLine.SetActive(true);
            instantiatedLine.transform.position = instantiatedCoin.transform.position;

            instantiatedLine.GetComponent<followObject>().StartTrail(instantiatedCoin.transform);
            instantiatedLine.GetComponent<linePosition>().ResetLinePosition();
            instantiatedCoin.GetComponent<coin_positionAnim>().itemLine = instantiatedLine;
            /// ----- pool section

            ///////////////////////////////////////////////////////////////////////////////////////////////////////// HOW MANY FX
            if (i == rewardsToSpawn - 1)
                coinsPerCoin = rewardsLeft;

            rewardsLeft -= coinsPerCoin;
            if (rewardType == "coins")
                instantiatedCoin.GetComponent<coin_positionAnim>().coinsAssociated = coinsPerCoin;
            else if(rewardType == "xp")
                instantiatedCoin.GetComponent<coin_positionAnim>().coinsAssociated = coinsPerCoin;
            else if (rewardType == "energy")
                instantiatedCoin.GetComponent<coin_positionAnim>().coinsAssociated = 1;
            else if (rewardType == "water")
                instantiatedCoin.GetComponent<coin_positionAnim>().coinsAssociated = 1;
            else if (rewardType == "sun")
                instantiatedCoin.GetComponent<coin_positionAnim>().coinsAssociated = coinsPerCoin;

        }




    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 2D REWARDS
    public void UiReward(int rewardGiven, Vector2 startPos, string rewardType, string source)
    {
        
        ///////////////////// How many ASSETS
        int rewardsToSpawn = 1;
        bool amountPicked = false;
        int[] countList = new int[0];
        if (rewardType == "energy")
            countList = uiEnergyAmount;
        else if (rewardType == "fertilizer")
            countList = uiFertilizerAmount;
        else if (rewardType == "diamonds")
            countList = uiDiamondsAmount;

        for (int i = 0; i < countList.Length; i++)
        {
            if (rewardGiven >= countList[i] && !amountPicked)
                rewardsToSpawn = i;
        }
        if (rewardsToSpawn == 0)
            rewardsToSpawn = 1;


        //////////////////////////////////////////////////////////////////////////////////// INSTANTIATE EACH COIN
        int rewardsLeft = rewardGiven;
        int rewardsToGrant = rewardGiven / rewardsToSpawn;
        for (int i = 0; i < rewardsToSpawn; i++)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////// CREATE ITEM
            GameObject instantiatedReward = ObjectPool.SharedInstance.GetPooledObject("uiReward");
            instantiatedReward.SetActive(true);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////// REWARDS
            if (i == rewardsToSpawn - 1)
                rewardsToGrant = rewardsLeft;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////// SET VALUES
            instantiatedReward.transform.SetParent(rewardParent.transform);
            instantiatedReward.transform.position = new Vector3(0, 0, 0);
            instantiatedReward.GetComponent<resourceUiFeedback>().LaunchFeedback(rewardType, startPos, rewardsToGrant, i, source);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////// LOOP VALUES
            rewardsLeft -= rewardsToGrant;

        }




    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////// UPDATE && UPDATE

    void Update()
    {

        ////////////////////////////////////////////////////////// SPAWNER FEEDBACK
        float currentCurveValue = tapSpawnerAnimation.Evaluate((Time.time - startTapTime) / animationTime);
        float currentScale = spawnerStartSize - (tapScale * currentCurveValue);
        if (spawnerTapped)
            spawnerTapped.transform.localScale = new Vector3(spawnerStartSize, currentScale, spawnerStartSize);


        /*
        ////////////////////////////////////////////////////////// LEVEL UP
        levelFxText.text = currentLevel.ToString();
        if (Time.time < (startLevelTime + leveltextDelay))
        {
            levelText.text = (currentLevel - 1).ToString();
            levelText.ForceMeshUpdate();
        }
        else
        {
            levelText.text = currentLevel.ToString();
            levelText.ForceMeshUpdate();
        }
        */


        ////////////////////////////////////////////////////////// DELAY ON COIN EXPLOSION FEEDBACK
        
        if (fxShouldSpawn && Time.time >= rewardFxDelay)
        {
            fxShouldSpawn = false;
            if (item1Sold)
            {

                item1Sold.GetComponent<itemController>().DestroyItem(false, true);
                GameObject newFeedback = Instantiate(coinFx, item1Sold.transform.position, transform.rotation) as GameObject;
            }

            if (item2Sold)
            {
                item2Sold.GetComponent<itemController>().DestroyItem(false, true);
                GameObject newFeedback = Instantiate(coinFx, item2Sold.transform.position, transform.rotation) as GameObject;
            }
        }
        


    }
    

    GameObject MergeableItem()
    {
        GameObject mergeableItem = null;
        bool foundItem = false;

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<itemController>().canMerge)
            {
                foundItem = true;
                mergeableItem = go;
            }
        }

        if (foundItem)
            return mergeableItem;
        else
            return null;
    }
    


    Transform[] SoldableItem()
    {
        Transform[] soldableItem = new Transform[2];
        bool foundItem = false;

        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("item");
        foreach (GameObject go in gos)
        {
            if (go.GetComponent<itemController>().canSellItem)
            {
                foundItem = true;
                soldableItem[0] = go.transform;
                soldableItem[1] = go.GetComponent<itemController>().orderToCanSell.transform;
            }
        }

        if (foundItem)
            return soldableItem;
        else
            return null;
    }


}
