using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class petController : MonoBehaviour
{
    [Header("BASICS -------------------")]
    public bool isOwned;
    public string thisPetId;
    public string parentId;
    public string petGameId;
    public int thisPetCount;
    public int petId;
    public string petDisplayName;
    public int petTier;

    [Header("LEVEL -------------------")]
    public bool isMaxLevel;
    public int currentLevel;
    public int maxLevel;
    public GameObject isHappyFeedback;

    public Transform associatedTile;
    [Header("EGG -------------------")]
    public bool isEgg;
    public GameObject eggObject;
    public ParticleSystem artPopFeedback;

    [Header("STATS -------------------")]
    public int[] petStats;
    public int[] baseStats;
    public int totalStars;


    [Header("FEED -------------------")]
    public int[] foodId;
    public string[] foodFamily;
    public int foodMinTier;
    public int foodMaxTier;

    public int currentFoodId;
    public string currentFoodFamily;
    public int currentFoodTier;

    [Header("FEED VISUALS -------------------")]
    public MeshRenderer itemImage;
    public GameObject feedUi;
    Animation feedAnimation;
    public ParticleSystem happyParticle;
    Texture imageLoaded;

    [Header("HAPPINESS -------------------")]
    public bool isHappy;
    public int currentHappiness;
    public int happychance;
    public GameObject isSuperHappyFeedback;

    [Header("BREED -------------------")]
    public bool allBreedsUsed;


    [Header("POSITION -------------------")]
    public Vector2 positionX;
    public Vector2 positionZ;
    public Transform artObject;
    public GameObject spawnedArt;

    saveManager saveManager;
    tutorialManager tutorialManager;
    petManager petManager;
    itemManager itemManager;
    localizerManager localizerManager;

    petBalancing petBalancing;
    petStatsBalancing petStatsBalancing;
    itemBalancing itemBalancing;

    petBehavior petBehavior;


    ////////////////////////////////////////////////////////////////////// INIT
    private void Awake()
    {
        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        tutorialManager = gameProperties.GetComponent<tutorialManager>();
        petManager = gameProperties.GetComponent<petManager>();
        itemManager = gameProperties.GetComponent<itemManager>();
        localizerManager = gameProperties.GetComponent<localizerManager>();

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        petStatsBalancing = balancingData.GetComponent<petStatsBalancing>();
        itemBalancing = balancingData.GetComponent<itemBalancing>();

        petBehavior = GetComponent<petBehavior>();

        feedAnimation = feedUi.GetComponentInChildren<Animation>();

    }

    public void InitPet(int m_petId,  int m_thisPetCount, int[] m_stats, int[] m_baseStats, string m_gameId, bool m_isEgg, int m_breedUsed, string m_parentId)
    {
        InitData(m_petId, m_thisPetCount, m_stats, m_baseStats, m_gameId, m_isEgg, m_breedUsed, m_parentId);

        InitHappiness();

        if(!isHappy && !isEgg && !allBreedsUsed)
            InitFood();

        InitTransform(m_thisPetCount);

    }

    void InitData(int m_petId, int m_thisPetCount, int[] m_stats, int[] m_baseStats, string m_gameId, bool m_isEgg, int m_breedUsed, string m_parentId)
    {
        

        // set as owned
        isOwned = true;

        // parent ID
        parentId = m_parentId;

        // Pet ID
        petId = m_petId;

        // Is Egg?
        isEgg = m_isEgg;
        eggObject.SetActive(isEgg);
        artObject.gameObject.SetActive(!isEgg);

        // Game Id
        petGameId = m_gameId;

        // pet count
        thisPetCount = m_thisPetCount;
        thisPetId = "pet_" + thisPetCount.ToString();

        // Display name
        petDisplayName = localizerManager.LocalizedText(petBalancing.locaId[petId]);

        // tier
        petTier = petBalancing.petTier[petId];

        // breed used
        if (m_breedUsed > 0)
            allBreedsUsed = true;
        else
            allBreedsUsed = false;


        // stats
        petStats = m_stats;
        totalStars = 0;
        for (int i = 0; i < m_stats.Length; i++)
            totalStars += petStats[i];


        // currentL Level
        currentLevel = saveManager.GetSavedInt(thisPetId + "_currentLevel");
        maxLevel = petBalancing.maxLevel[petId];
        int starstoMaxStars = 5 * m_stats.Length - totalStars - maxLevel;
        if (starstoMaxStars > m_stats.Length * 5)
            maxLevel = 5 * m_stats.Length - starstoMaxStars;
        CheckMaxLevel();


        // baseStats
        baseStats = m_baseStats;

        // Update max stars
        int currentMaxStars = saveManager.GetSavedInt("maxPetStars");
        if (totalStars > currentMaxStars)
            SaveMaxStars(totalStars);

        // Food data
        RefreshFoodNeeds(m_isEgg);

    }

    public void RefreshFoodNeeds(bool m_isEgg)
    {
        // stats
        int m_totalStars = 0;
        for (int i = 0; i < petStats.Length; i++)
            m_totalStars += petStats[i];

        feedUi.SetActive(!m_isEgg);

        foodId = new int[petBalancing.possibleFoodOptions];
        foodFamily = new string[petBalancing.possibleFoodOptions];

        for (int i = 0; i < foodId.Length; i++)
        {
            Debug.Log("Checking food for pet id"+ petId+" with " + m_totalStars + " stars, option "+i.ToString());
            foodId[i] = petBalancing.itemId[petId, m_totalStars, i];
            foodFamily[i] = itemBalancing.familyNames[foodId[i]];
        }
        foodMinTier = petBalancing.itemMinTier[petId, m_totalStars];
        foodMaxTier = petBalancing.itemMaxTier[petId, m_totalStars];
    }

    public void InitFood()
    {
        // food orders created
        int foodOrderCreated = saveManager.GetSavedInt(thisPetId + "_foodOrderCreated");
        Debug.Log(thisPetId + " foodOrderCreated " + foodOrderCreated);

        if (foodOrderCreated == 0)
            CreateFoodOrder();
        else
            GetSavedOrder();

        AnimOrderUi();
    }

    void InitHappiness()
    {
        
        //if (!allBreedsUsed)
        //{
            int isHappyInt = saveManager.GetSavedInt(thisPetId + "_isHappy");
            currentHappiness = saveManager.GetSavedInt(thisPetId + "_currentHappiness");
            if (isHappyInt == 0)
                isHappy = false;
            else
                isHappy = true;
            SetHappy(isHappy, currentHappiness);
        //}
        //else
        //    SetHappy(false, currentHappiness);



    }

    void InitTransform(int m_thisPetCount)
    {
        if(m_thisPetCount == 0 && saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            associatedTile = petManager.petTiles[2];
            petManager.petInTile[2] = gameObject;
            transform.localPosition = new Vector3(.5f, 0, 0);
        }        
        else if(m_thisPetCount == 1 && saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            associatedTile = petManager.petTiles[6];
            petManager.petInTile[6] = gameObject;
            transform.localPosition = new Vector3(-.5f, 0, 2f);
        }
        else
        {
            bool tileFound = false;
            int totalTiles = petManager.petTiles.Length;

            while (!tileFound)
            {
                int randomTileInt = Random.Range(0, totalTiles);
                if (petManager.petInTile[randomTileInt] == null)
                {
                    tileFound = true;
                    associatedTile = petManager.petTiles[randomTileInt];
                    petManager.petInTile[randomTileInt] = gameObject;
                    float randomX = Random.Range(0, petManager.petRandX);
                    float randomZ = Random.Range(0, petManager.petRandZ);
                    float posX = randomX + petManager.petTiles[randomTileInt].localPosition.x;
                    float posZ = randomZ + petManager.petTiles[randomTileInt].localPosition.z;
                    transform.localPosition = new Vector3(posX, 0, posZ);
                }
            }
        }
        


        // pet rotation
        RandomRotation();

    }

    public void RandomRotation()
    {
        float randomRotation = Random.Range(0, 360);
        transform.localEulerAngles = Vector3.zero;
        artObject.localEulerAngles = new Vector3(0, randomRotation, 0);

    }

    ////////////////////////////////////////////////////////////////////// FOOD
    
    void GetSavedOrder()
    {
        currentFoodId = saveManager.GetSavedInt(thisPetId + "_foodId");
        currentFoodFamily = itemBalancing.familyNames[currentFoodId];
        currentFoodTier = saveManager.GetSavedInt(thisPetId + "_foodTier");
        UpdateOrderUI();
        AnimOrderUi();
    }

    public void CreateFoodOrder()
    {
        int foodOrderCreated = saveManager.GetSavedInt(thisPetId + "_foodOrderCreated");

        // RFRESH THE FOOD DATA
        RefreshFoodNeeds(false);

        // FAMILY
        currentFoodId = itemFamily();
        currentFoodFamily = itemBalancing.familyNames[currentFoodId];

        // TIER
        currentFoodTier = itemTier();

        // Save order
        SavePetOrder(currentFoodTier, currentFoodId, foodOrderCreated);

        // Update UI
        UpdateOrderUI();

    }

    int itemTier()
    {
        int tier = 0;

        // CREATE TUTORIAL ORDER
        if(thisPetId == "pet_0")
        {
            int foodOrderCreated = saveManager.GetSavedInt("pet_0_foodOrderCreated");
            if (foodOrderCreated == 0)
                tier = 1;
            else if (foodOrderCreated == 1)
                tier = 1;
            else
            tier = Random.Range(foodMinTier, foodMaxTier + 1);
        }

        // CREATE REGULAR ORDER
        else
            tier = Random.Range(foodMinTier, foodMaxTier + 1);

        // MAKE SURE TIER IS NOT GREATER THAN ITEM MAX TIER
        int maxItemTier = itemBalancing.maxTier[currentFoodId];
        if (tier > maxItemTier)
            tier = maxItemTier;

        // RETURN
        return tier;
    }    
    
    int itemFamily()
    {
        int family = 0;
        int randomPick = 0;

        if(thisPetId == "pet_0")
        {
            int foodOrderCreated = saveManager.GetSavedInt("pet_0_foodOrderCreated");
            if (foodOrderCreated == 0)
                randomPick = 0;
            else if (foodOrderCreated == 1)
                randomPick = 0;
            else
                randomPick = Random.Range(0, petBalancing.possibleFoodOptions);
        }
        else
            randomPick = Random.Range(0, petBalancing.possibleFoodOptions);


        family = petBalancing.itemId[petId, totalStars, randomPick];

        return family;
    }

    private void UpdateOrderUI()
    {
        Debug.Log("UI/icons/items/" + currentFoodFamily + "_" + currentFoodTier.ToString());
        Debug.Log("UI/icons/items/" + currentFoodFamily + "_" + currentFoodTier.ToString());
        imageLoaded = Resources.Load<Texture>("UI/icons/items/" + currentFoodFamily + "_" + currentFoodTier.ToString());
        itemImage.material.mainTexture = imageLoaded;
    }

    public void AnimOrderUi()
    {
        float angleDiff = 15f;
        float randomAngle = Random.Range(-angleDiff, angleDiff);
        feedUi.transform.localEulerAngles = new Vector3(0, 0, randomAngle);
        feedAnimation.Play("a_pet_orderFeed");
    }

    public void FeedPet()
    {

        // CHECK TUTO
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
            CheckTuto();

        // HAPPINESS
        CalculateHappiness();

        // DO ANIM
        StartCoroutine(FeedPetSequence());

        // NEW ORDER
        if (!isHappy)
            CreateFoodOrder();



    }

    IEnumerator FeedPetSequence()
    {
        yield return new WaitForSeconds(0f);

        // ANIM JUMP
        petBehavior.StopAll();
        if(isHappy)
            petBehavior.DoJump(100);
        else
            petBehavior.DoJump(1);

        // SELL FEEDBACK
        itemManager.CheckAllItemsSell(true);

        // HIDE
        feedAnimation.transform.localScale = Vector3.zero;
        yield return new WaitForSeconds(0f);

        // PARTICLES
        happyParticle.Play();
        yield return new WaitForSeconds(.5f);


        // ANIMATE UI
        if (!isHappy)
        {
            AnimOrderUi();
            itemManager.CheckAllItemsSell(false);
        }

        yield return null;
    }

    ////////////////////////////////////////////////////////////////////// HAPPINESS

    void CalculateHappiness()
    {
        int randomHappy = Random.Range(0, 100);
        currentHappiness++;

        happychance = saveManager.GetSavedInt(thisPetId + "_currentHappyChance");

        if (randomHappy < happychance)
            SetHappy(true, currentHappiness);
        else
            SetHappy(false, currentHappiness);
    }

    public void SetHappy(bool happy, int m_currentHappiness)
    {
        // SHOW HIDE FEEDBACK
        isHappy = happy;
        if (isHappy)
        {
            if (isMaxLevel)
            {
                isHappyFeedback.SetActive(false);
                isSuperHappyFeedback.SetActive(true);
                isSuperHappyFeedback.GetComponent<ParticleSystem>().Play();
            }
            else
            {
                isHappyFeedback.SetActive(true);
                isSuperHappyFeedback.SetActive(false);
                isHappyFeedback.GetComponent<ParticleSystem>().Play();
            }
        }
        else
        {
            isHappyFeedback.SetActive(false);
            isSuperHappyFeedback.SetActive(false);
        }

        // ANIM
        if (isHappy)
        {
            petBehavior.StopAll();
            petBehavior.DoJump(100);
            artObject.transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            petBehavior.StopAll();
            petBehavior.StartIdle();
            RandomRotation();
        }


        // UPDATE HAPPINESS
        currentHappiness = m_currentHappiness;

        // RESET HAPPY CHANCE
        if (currentHappiness == 0)
            happychance = 0;
        else if (currentHappiness >= petBalancing.minHappinessRequirement[petId, totalStars])
            happychance += petBalancing.happinessIncrease[petId, totalStars];


        // SAVE
        int happyInt;
        if (isHappy)
            happyInt = 1;
        else
            happyInt = 0;

        SaveHappiness(happyInt, m_currentHappiness, happychance);
    }

    ////////////////////////////////////////////////////////////////////// BREED
    public void CheckMaxLevel()
    {
        if (currentLevel >= maxLevel)
            isMaxLevel = true;
        else
            isMaxLevel = false;
    }


    ////////////////////////////////////////////////////////////////////// BREED
    public void UseBreed()
    {
        int currentUsedBreed = saveManager.GetSavedInt(thisPetId + "_breedUsed");
        SaveBreedUsed(currentUsedBreed + 1);

        allBreedsUsed = true;

    }

    ////////////////////////////////////////////////////////////////////// TAP
    public void TapPet()
    {
        if (!isEgg)
        {
            if (saveManager.GetSavedInt("tutorialCompleted") == 1 || (tutorialManager.currentTuto == 5))
                petManager.OpenPopup(gameObject, false);
        }
        else
            petManager.OpenEgg(gameObject);

    }

    ////////////////////////////////////////////////////////////////////// TUTO
    void CheckTuto()
    {

        if (tutorialManager.currentTuto == 1)
        {
            tutorialManager.HideTuto(1);
            tutorialManager.ShowTuto(2, true);
        }        
        else if (tutorialManager.currentTuto == 4)
        {
            tutorialManager.HideTuto(4);
            tutorialManager.ShowTuto(5, true);
        }

    }


    ////////////////////////////////////////////////////////////////////// SAVE
    void SavePetOrder(int m_foodTier, int m_foodId, int foodOrderCreated)
    {
        saveManager.SaveInt(thisPetId + "_foodOrderCreated", foodOrderCreated +1);
        saveManager.SaveInt(thisPetId + "_foodTier", m_foodTier);
        saveManager.SaveInt(thisPetId + "_foodId", m_foodId);
    }
    

    void SaveHappiness( int isHappy, int currentHappiness, int currentHappyChance)
    {
        saveManager.SaveInt(thisPetId + "_isHappy", isHappy);
        saveManager.SaveInt(thisPetId + "_currentHappiness", currentHappiness);
        saveManager.SaveInt(thisPetId + "_currentHappyChance", currentHappyChance);
        Debug.Log(" happy chance: " + happychance);
    }

    void SaveMaxStars(int stars)
    {
        saveManager.SaveInt("maxPetStars", stars);
    }

    void SaveBreedUsed(int newBreedUsed)
    {
        saveManager.SaveInt(thisPetId + "_breedUsed", newBreedUsed);

    }



}
