using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class breedingManager : MonoBehaviour
{

    [Header("BREED LIST POPUP ------------")]
    public GameObject breedListPopup;
    public GameObject optionsContainer;
    public breedingOptionController[] mateList;
    public int mateRefreshCooldown;
    public float petPopupOpenDelay;

    [Header("BREED POPUP ------------")]
    public GameObject breedPopup;
    public breedingOptionController mateSelected;
    public Image petImage;
    public Image mateImage;

    public Image[] stat0Pet;
    public Image[] stat1Pet;
    public Image[] stat2Pet;
    public Image[] stat3Pet;

    public Image[] stat0Mate;
    public Image[] stat1Mate;
    public Image[] stat2Mate;
    public Image[] stat3Mate;

    public float breedPopupOpenDelay;
    public float breedPopup_OpenListDelay;
    public float breedPopup_CameraZoomDelay;
    public float breedPopup_EggPopDelay;
    public float breedPopup_petFoodDelayy;
    public float breedPopup_RefreshBreed;

    public GameObject breedButtonOn;
    public GameObject breedButtonOff;
    public TextMeshProUGUI priceTextOn;
    public TextMeshProUGUI priceTextOff;

    Color colorOn;
    Color colorOff;


    [Header("MATES ------------")]
    public int[] thisMateGameId;
    public string[] thisMateId;
    public int[,] mateStats;
    public int[] totalStars;
    public string[] owner;
    public int[] price;

    timeNowManager timeNowManager;
    tapManager tapManager;
    saveManager saveManager;
    tutorialManager tutorialManager;
    petManager petManager;
    petBalancing petBalancing;
    public petStatsBalancing petStatsBalancing;

    ////////////////////////////////////////////////////////////////////// START
    private void Start()
    {
        timeNowManager = GetComponent<timeNowManager>();
        tapManager = GetComponent<tapManager>();
        saveManager = GetComponent<saveManager>();
        tutorialManager = GetComponent<tutorialManager>();
        petManager = GetComponent<petManager>();

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        petStatsBalancing = balancingData.GetComponent<petStatsBalancing>();

        colorOn = petManager.colorOn;
        colorOff = petManager.colorOff;

        InitPopup();
        InitBreedPopup();
    }
    void InitPopup()
    {
        mateList = optionsContainer.GetComponentsInChildren<breedingOptionController>();
    }

    void InitBreedPopup()
    {


    }


    ////////////////////////////////////////////////////////////////////// BREED LIST
    
    public void OpenPopup()
    {
        CheckMateStatus();

        // OPEN POPUP
        tapManager.OpenPopup();
        breedListPopup.GetComponent<GraphicRaycaster>().enabled = true;
        breedListPopup.GetComponent<Animation>().Play("breedListPopup_in");

        // tuto
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            if (tutorialManager.currentTuto == 6)
            {
                tutorialManager.HideTuto(6);
                tutorialManager.ShowTuto(7, true);
            }
        }

    }

    public void ClosePopup()
    {

        if (saveManager.GetSavedInt("tutorialCompleted") == 1)
            StartCoroutine(ClosePopupSequence());

    }

    IEnumerator ClosePopupSequence()
    {
        tapManager.ClosePopup();
        breedListPopup.GetComponent<GraphicRaycaster>().enabled = false;
        breedListPopup.GetComponent<Animation>().Play("breedListPopup_out");
        yield return new WaitForSeconds(petPopupOpenDelay);

        petManager.OpenPopup(null, false);
        yield return null;
    }
    
    void CheckMateStatus()
    {
        int now = timeNowManager.timeNow;
        int lastRefresh = saveManager.GetSavedInt("lastMateRefresh");

        if ((now - lastRefresh) > mateRefreshCooldown)
            RedoMates();
    }

    public void RedoMates()
    {
        int mateCount = mateList.Length;

        // INIT LISTS;
        thisMateGameId = new int[mateCount];
        thisMateId = new string[mateCount];
        mateStats = new int[mateCount, petBalancing.totalStats];
        totalStars = new int[mateCount];
        owner = new string[mateCount];
        price = new int[mateCount];


        // CREATE RANDOM
        for (int i = 0; i < mateCount; i++)
        {
            /////////////////////////// id
            thisMateGameId[i] = petManager.selectedPet.GetComponent<petController>().petId;
            mateList[i].petId = thisMateGameId[i];
            /////////////////////////// name id
            thisMateId[i] = petBalancing.codeName[thisMateGameId[i]];
            mateList[i].thisPetId = thisMateId[i];

            /////////////////////////// stats
            // random count
            int statCount = petBalancing.totalStats;
            int selectedStars = petManager.selectedPet.GetComponent<petController>().totalStars;
            int currentMaxStars = selectedStars + 3;
            int randomTotalStars = Random.Range(selectedStars, currentMaxStars + 2);
            if (randomTotalStars < statCount)
                randomTotalStars = statCount;
            else if (randomTotalStars > 20)
                randomTotalStars = 20;
            totalStars[i] = randomTotalStars;
            int statUp = randomTotalStars - statCount;
            // reset stats
            for (int j = 0; j < statCount; j++)
                mateStats[i, j] = 1;
            // apply to a random stat
            for (int j =0;j< statUp;j++)
            {
                bool statFound = false;
                while (!statFound)
                {
                    int randomStatPicked = Random.Range(0, statCount);
                    int currentStat = mateStats[i, randomStatPicked];
                    if (currentStat < 5)
                    {
                        mateStats[i, randomStatPicked] = currentStat + 1;
                        statFound = true;
                    }

                }
            }
            // apply stat data
            for (int j = 0; j < statCount; j++)
                mateList[i].stats[j] = mateStats[i, j];


            /////////////////////////// owner
            int nameCount = petStatsBalancing.ownerNames.Length;
            int randomOnwer = Random.Range(0, nameCount);
            owner[i] = petStatsBalancing.ownerNames[randomOnwer];
            mateList[i].ownerName = owner[i];

            /////////////////////////// price
            price[i] = petBalancing.breedPrice[thisMateGameId[i], totalStars[i]];
            mateList[i].price = price[i];


        }

        // UPDATE UI
        for (int i = 0; i < mateList.Length;i++)
        {
            mateList[i].RefreshUi();
        }


        SaveLastMateRefresh();
    }



    ////////////////////////////////////////////////////////////////////// BREED POPUP
    
    public void OpenBreedPopup(breedingOptionController m_mateSelected)
    {
        mateSelected = m_mateSelected;

        ///////////////////// SET IMAGES
        Sprite imageLoaded;
        string petId = petManager.selectedPet.GetComponent<petController>().petGameId;
        imageLoaded = Resources.Load<Sprite>("UI/icons/pets/" + petId);
        petImage.sprite = imageLoaded;
        imageLoaded = Resources.Load<Sprite>("UI/icons/pets/" + mateSelected.GetComponent<breedingOptionController>().thisPetId);
        mateImage.sprite = imageLoaded;

        ///////////////////// SET PRICE
        int currentCoins = saveManager.GetSavedInt("currentCoins");
        int price = mateSelected.GetComponent<breedingOptionController>().price;
        if (price > currentCoins)
        {
            breedButtonOn.SetActive(false);
            breedButtonOff.SetActive(true);
            priceTextOff.text = price.ToString();
        }
        else
        {
            breedButtonOn.SetActive(true);
            breedButtonOff.SetActive(false);
            priceTextOn.text = price.ToString();
        }


        ///////////////////// SET STATS
        int maxStarCount = stat0Pet.Length;
        for(int i = 0; i < maxStarCount; i++)
        {
            int stat = 0;
            // Stat 0
            stat =  petManager.selectedPet.GetComponent<petController>().petStats[0];
            if (stat > i)
                ShowStar(stat0Pet[i], true);
            else
                ShowStar(stat0Pet[i], false);
            // Stat 1
            stat =  petManager.selectedPet.GetComponent<petController>().petStats[1];
            if (stat > i)
                ShowStar(stat1Pet[i], true);
            else
                ShowStar(stat1Pet[i], false);
            // Stat 2
            stat =  petManager.selectedPet.GetComponent<petController>().petStats[2];
            if (stat > i)
                ShowStar(stat2Pet[i], true);
            else
                ShowStar(stat2Pet[i], false);
            // Stat 3
            stat =  petManager.selectedPet.GetComponent<petController>().petStats[3];
            if (stat > i)
                ShowStar(stat3Pet[i], true);
            else
                ShowStar(stat3Pet[i], false);


            // Stat 0
            stat = mateSelected.GetComponent<breedingOptionController>().stats[0];
            if (stat > i)
                ShowStar(stat0Mate[i], true);
            else
                ShowStar(stat0Mate[i], false);
            // Stat 1
            stat = mateSelected.GetComponent<breedingOptionController>().stats[1];
            if (stat > i)
                ShowStar(stat1Mate[i], true);
            else
                ShowStar(stat1Mate[i], false);
            // Stat 2
            stat = mateSelected.GetComponent<breedingOptionController>().stats[2];
            if (stat > i)
                ShowStar(stat2Mate[i], true);
            else
                ShowStar(stat2Mate[i], false);
            // Stat 3
            stat = mateSelected.GetComponent<breedingOptionController>().stats[3];
            if (stat > i)
                ShowStar(stat3Mate[i], true);
            else
                ShowStar(stat3Mate[i], false);
        }


        ///////////////////// DO ANIMS
        StartCoroutine(OpenBreedSequence());
    }

    void ShowStar(Image star, bool isActive)
    {
        if (isActive)
            star.color = colorOn;
        else
            star.color = colorOff;
    }

    IEnumerator OpenBreedSequence()
    {
        breedListPopup.GetComponent<GraphicRaycaster>().enabled = false;
        breedListPopup.GetComponent<Animation>().Play("breedListPopup_out");



        yield return new WaitForSeconds(breedPopupOpenDelay);
        breedPopup.GetComponent<GraphicRaycaster>().enabled = true;
        breedPopup.GetComponent<Animation>().Play("breedPopup_in");

        // tuto
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            if (tutorialManager.currentTuto == 7)
            {
                tutorialManager.HideTuto(7);
                tutorialManager.ShowTuto(8, true);
            }
        }




        yield return null;
    }

    public void PickMate( breedingOptionController m_mateSelected)
    {

        mateSelected = m_mateSelected;

        if (saveManager.GetSavedInt("tutorialCompleted") == 1)
            StartCoroutine(CloseBreedSequence("breed"));
    }

    public void CloseBreedPopup(string closeSource)
    {

        if (saveManager.GetSavedInt("tutorialCompleted") == 1 || closeSource =="breed")
            StartCoroutine(CloseBreedSequence(closeSource));

    }
    IEnumerator CloseBreedSequence(string closeSource)
    {
        Debug.Log("Breed - CloseBreedSequence");

        breedListPopup.GetComponent<GraphicRaycaster>().enabled = false;
        breedListPopup.GetComponent<Animation>().Play("breedListPopup_out");

        int currentCoins = saveManager.GetSavedInt("currentCoins");
        int price = mateSelected.GetComponent<breedingOptionController>().price;
        if (price <= currentCoins)
        {

            // CLOSE POPUP
            tapManager.ClosePopup();
            tapManager.popupOpen = false;

            // MOVE CAM
            yield return new WaitForSeconds(breedPopup_CameraZoomDelay);
            Camera.main.GetComponent<cameraAnimation>().ZoomOut();


            // CREATE EGG
            yield return new WaitForSeconds(breedPopup_EggPopDelay);
            CreateBreededPet();

            // SPEND COINS
            GetComponent<coinManager>().SpendCoins(price);

            // RESET VALUES ON PET
            yield return new WaitForSeconds(breedPopup_petFoodDelayy);
            petManager.selectedPet.GetComponent<petController>().SetHappy(false, 0);
            petManager.selectedPet.GetComponent<petController>().UseBreed();

        }
        else
            GetComponent<necManager>().ShowNec("coins");



        yield return null;
    }

    ////////////////////////////////////////////////////////////////////// BREED ALGO

    void CreateBreededPet()
    {
        Debug.Log("Breed - CreateBreededPet");
        petController selectedController = petManager.selectedPet.GetComponent<petController>();
        breedingOptionController mateController = mateSelected.GetComponent<breedingOptionController>();

        // PET ID
        int petId = NewEggId(selectedController.petId, mateController.petId);
        bool isNewBreed = true;
        if (petId == selectedController.petId && petId == mateController.petId)
            isNewBreed = false;

        // PET STATS
        int[] eggStats = NewEggStats(isNewBreed, petId);

        // PET COUNT
        int currentPetCount = saveManager.GetSavedInt("totalPetCount");

        // SPAWN PET
        string parentPetId = selectedController.thisPetId;
        petManager.GetNewPet(petId, eggStats, eggStats, currentPetCount, true, 0, parentPetId);
    }
    int NewEggId(int m_playerPetId, int m_mateId) 
    {
        int eggId = 0;
        List<int> tmp_Options = new List<int>();
        List<bool> tmp_OptionsBool = new List<bool>();
        int totalWeight = 0;

        // CHECK POSSIBLE OFFSPRINGS FROM PLAYER
        int playerPetTier = petBalancing.petTier[m_playerPetId];
        for (int i = 0; i < petBalancing.offspringOptions.GetLength(1); i++)
        {
            // add to options
            int newOption = petBalancing.offspringOptions[m_playerPetId, i];
            if( newOption != 999 && petBalancing.petTier[newOption] >= playerPetTier)
            {
                Debug.Log("Add pet from player with id " + newOption);
                tmp_Options.Add(newOption);
                tmp_OptionsBool.Add(true);
            }
        }        
        for(int i = 0; i < petBalancing.offspringOptions.GetLength(1); i++)
        {
            // add to options
            int newOption = petBalancing.offspringOptions[m_mateId, i];
            if (newOption != 999 && petBalancing.petTier[newOption] >= playerPetTier)
            {
                Debug.Log("Add pet from mate with id " + newOption);
                tmp_Options.Add(newOption);
                tmp_OptionsBool.Add(true);
            }
        }

        // REMOVE ROM LIST IF NOT MEETING REQUIREMENT
        petController selectedController = petManager.selectedPet.GetComponent<petController>();
        breedingOptionController mateController = mateSelected.GetComponent<breedingOptionController>();
        for (int i = 0; i < tmp_Options.Count; i++)
        {
            // check total stats
            bool isTotalStatCompliant = true;
            for (int j = 0; j < petBalancing.totalStats; j++)
            {
                int totalStats = 0;
                totalStats += selectedController.totalStars;
                totalStats += mateController.totalStats;
                int requiredStat = petBalancing.offspringTotalStatsRequired[tmp_Options[i], j];
                if (totalStats < requiredStat)
                    isTotalStatCompliant = false;
            }
            if (!isTotalStatCompliant)
                tmp_OptionsBool[i] =false;

            // check top stat
            bool isMaxStatCompliant = true;
            for (int j = 0; j < petBalancing.totalStats; j++)
            {
                if (isMaxStatCompliant)
                {
                    int maxStat = 0;
                    int maxStatRequirement = petBalancing.offspringMinStatRequired[tmp_Options[i], j];                    
                    if (selectedController.petStats[j] > maxStat)
                        maxStat = selectedController.petStats[j];
                    if (mateController.stats[j] > maxStat)
                        maxStat = mateController.stats[j];

                    if (maxStat < maxStatRequirement)
                        isMaxStatCompliant = false;
                }

            }
            if (!isMaxStatCompliant)
                tmp_OptionsBool[i] = false;
        }


        // CREATE FINAL LIST
        List<int> finalOptions = new List<int>();
        List<int> optionsWeight = new List<int>();
        for (int i = 0; i < tmp_Options.Count; i++)
        {
            if(tmp_OptionsBool[i] == true)
            {
                Debug.Log("Final list, add: " + tmp_Options[i]);
                int thisPetChance = petBalancing.offspringChance[tmp_Options[i]];
                finalOptions.Add(tmp_Options[i]);
                optionsWeight.Add(thisPetChance);
                totalWeight += thisPetChance;
            }
        }

        // GET RANDOM DEPENDING ON WEIGHT
        int currentWeight = 0;
        int randomWeight = Random.Range(0, totalWeight);
        bool isPicked = false;
        for (int i = 0; i < finalOptions.Count; i++)
        {
            if (!isPicked)
            {
                currentWeight += optionsWeight[i];
                if (randomWeight < currentWeight)
                {
                    isPicked = true;
                    eggId = finalOptions[i];
                }
            }
        }

        return eggId;
    }


    int[] NewEggStats(bool m_isNewBreed, int m_petId)
    {

        petController selectedControler = petManager.selectedPet.GetComponent<petController>();
        int[]  eggStats = new int[selectedControler.petStats.Length];

        // TAKE DEFAULT STATS IF IT'S A MUTATION
        if (m_isNewBreed)
        {
            for (int i = 0; i < eggStats.Length; i++)
                eggStats[i] = petBalancing.defaultStats[m_petId, i];
        }

        // ELSE, GIVE NEW STATS
        else
        {
            //////////////// get parent stats
            selectedControler = petManager.selectedPet.GetComponent<petController>();
            eggStats = new int[selectedControler.baseStats.Length];
            int parentTotalStats = 0;
            for (int i = 0; i < eggStats.Length; i++)
            {
                eggStats[i] = selectedControler.baseStats[i];
                parentTotalStats += selectedControler.baseStats[i];
            }
            Debug.Log(" NEW EGG parentTotalStats " + parentTotalStats);

            if (parentTotalStats < 20)
            {
                //////////////// How many stars up
                int starsUp = 0;
                float[] thisStarUpChance;
                float parentMultiplier;

                // Get chances from data
                int diff = mateSelected.totalStats - selectedControler.totalStars;
                thisStarUpChance = new float[petStatsBalancing.starUpChance.GetLength(1)];
                parentMultiplier = petStatsBalancing.parentCurrentStatsMofifier[selectedControler.totalStars];
                for (int i = 0; i < thisStarUpChance.Length; i++)
                {
                    thisStarUpChance[i] = petStatsBalancing.starUpChance[diff + 16, i] * parentMultiplier;
                }
                // PICK RANDOM STAT
                float randomChance = Random.Range(0f, 1f);
                bool isPicked = false;
                for (int i = 0; i < thisStarUpChance.Length; i++)
                {
                    if (!isPicked)
                    {
                        if (randomChance <= thisStarUpChance[i])
                        {
                            starsUp = i + 1;
                            isPicked = true;
                        }
                    }
                }
                if ((parentTotalStats + starsUp) > 20)
                    starsUp = 20 - parentTotalStats;

                Debug.Log(" NEW EGG starsUp " + starsUp);


                // PICK RANDOM STATS
                int[] statsChosen = new int[starsUp];
                for (int i = 0; i < starsUp; i++)
                {
                    // total weight
                    int totalWeight = 0;
                    for (int j = 0; j < mateSelected.stats.Length; j++)
                    {
                        if (eggStats[j] < 5)
                        {
                            totalWeight += mateSelected.stats[j];
                            totalWeight += selectedControler.petStats[j];
                        }
                    }
                    // random pick
                    bool statPicked = false;
                    int currentWeight = 0;
                    int randomPick = Random.Range(0, totalWeight);
                    for (int j = 0; j < mateSelected.stats.Length; j++)
                    {
                        if (!statPicked)
                        {
                            currentWeight += mateSelected.stats[j];
                            currentWeight += selectedControler.petStats[j];
                            if (randomPick < currentWeight)
                            {
                                statPicked = true;
                                statsChosen[i] = j;
                                eggStats[j] = eggStats[j] + 1;
                            }
                        }
                    }
                }
            }

        }

        return eggStats;
    }

    ////////////////////////////////////////////////////////////////////// SAVE
    void SaveMate(int mateId)
    {
        string name = "mate" + mateId.ToString() + "_";
    }

    void SaveLastMateRefresh()
    {
        saveManager.SaveInt("lastMateRefresh",timeNowManager.timeNow);

    }
}
