using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class petManager : MonoBehaviour
{
    [Header("PETS -------------------")]
    public GameObject petParent;
    public List<GameObject> petList = new List<GameObject>();
    public GameObject[] ownedPets;

    [Header("PET TILES -------------------")]
    public Transform[] petTiles;
    public GameObject[] petInTile;
    public float petRandX;
    public float petRandZ;

    [Header("POPUP -------------------")]
    public GameObject petPopup;
    public GameObject selectedPet;
    public GameObject[] stat0_stars;
    public GameObject[] stat1_stars;
    public GameObject[] stat2_stars;
    public GameObject[] stat3_stars;
    public TextMeshProUGUI petName;
    public TextMeshProUGUI breedText;
    public TextMeshProUGUI petLevelText;
    public GameObject levelupButtonOn;
    public GameObject levelupButtonOff;
    public GameObject breedButtonOn;
    public GameObject breedButtonOff;
    public GameObject sellButtonOn;
    public GameObject sellButtonOff;
    public float breedListOpenDelay;
    public float breedCardMinDelay;
    public float breedCardMaxDelay;

    public Color colorOn;
    public Color colorOff;

    [Header("SELL -------------------")]
    public GameObject sellPopup;
    public TextMeshProUGUI sellRewardText;
    public float openSellDelay;
    public float cancelSellDelay;
    public float confirmSellZoomDelay;
    public float confirmSellDestroyDelay;



    [Header("egg -------------------")]
    public float eggOpen_eggDelay;
    public float eggOpen_artDelay;
    public float eggOpen_popupDelay;
    public float openEggStatFirstDelay;
    public float openEggStatRegularDelay;

    [Header("ERRORS -------------------")]
    public GameObject error_maxPets;
    public GameObject error_noBreed;
    public GameObject error_noHappy;
    public GameObject error_maxLevel;
    public GameObject error_needMaxLevel;

    private int statToIncrease =0;
    private int newStatValue =0;

    saveManager saveManager;
    collectionManager collectionManager;
    breedingManager breedingManager;
    tutorialManager tutorialManager;
    petBalancing petBalancing;
    petStatsBalancing petStatsBalancing;

    private void Start()
    {
        // GET DATA
        saveManager = GetComponent<saveManager>();
        breedingManager = GetComponent<breedingManager>();
        tutorialManager = GetComponent<tutorialManager>();
        collectionManager = GetComponent<collectionManager>();

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        petStatsBalancing = balancingData.GetComponent<petStatsBalancing>();

        petInTile = new GameObject[petTiles.Length];

        // SPAWN OWNED PETS
        int currentPetCount = saveManager.GetSavedInt("totalPetCount");
        if (currentPetCount > 0)
            GetSavedPets(currentPetCount);
    }

    ////////////////////////////////////////////////////////////////////// BASICS

    public void CheatPet()
    {
        GetFirstPet();
    }

    public void GetFirstPet()
    {
        // PET ID
        int petId = 0;

        // PET STATS
        int[] stats = new int[petBalancing.totalStats];
        int[] baseStats = new int[petBalancing.totalStats];
        for (int i = 0; i < stats.Length; i++)
        {
            stats[i] = petBalancing.defaultStats[0, i];
            baseStats[i] = petBalancing.defaultStats[0, i];
        }

        // PET COUNT
        int currentPetCount = saveManager.GetSavedInt("totalPetCount");


        GetNewPet(petId, stats, baseStats, currentPetCount, false, 0, "");
    }

    public void GetNewPet(int petId, int[] stats, int[] m_baseStats, int thisPetCount, bool isEgg, int breedUsed, string m_parentPetId)
    {
        Debug.Log("Breed - GetNewPet");

        // SAVE
        int currentPetCount = saveManager.GetSavedInt("totalPetCount");
        SaveNewPet(currentPetCount, petId, stats, m_baseStats, m_parentPetId);

        // SAVE
        int currentOwnedPets = saveManager.GetSavedInt("currentOwnedPets");
        SaveCurrentOwnedPets(currentOwnedPets);

        // THIS PET FAMILY SAVE
        string codename = petBalancing.codeName[petId];
        int totalOwned = saveManager.GetSavedInt(codename + "_totalOwned");
        SaveTotalOwnedPet(codename, totalOwned);
        if(petId == 0)
        {
            SaveUnlockState(codename, 2);
            collectionManager.UpdateTopUi("firstPet");
        }
        else if (totalOwned == 0)
        {
            SaveUnlockState(codename, 1);
        }

        // SPAWN
        SpawnPet(petId, stats, m_baseStats, thisPetCount, isEgg, breedUsed, m_parentPetId);

    }

    void GetSavedPets(int currentPetCount)
    {

        for (int i = 0; i < currentPetCount; i++)
        {
            int isSold = saveManager.GetSavedInt("pet_" + i.ToString() + "_isSold");
            if(isSold == 0)
            {
                //Debug.Log("Get data for pet " + i);
                string thisPetId = "pet_" + i.ToString();

                // PET COUNT
                int thisPetCount = saveManager.GetSavedInt(thisPetId + "_thisPetCount");

                // PET ID
                int petId = saveManager.GetSavedInt(thisPetId + "_thisPetId");

                // PET STATS
                int[] stats = new int[petBalancing.totalStats];
                for (int j = 0; j < stats.Length; j++)
                    stats[j] = saveManager.GetSavedInt(thisPetId + "_stat" + j.ToString());

                // PET BASE STATS
                int[] m_baseStats = new int[petBalancing.totalStats];
                for (int j = 0; j < stats.Length; j++)
                    m_baseStats[j] = saveManager.GetSavedInt(thisPetId + "_baseStat" + j.ToString());

                // BREED LEFT
                int breedUsed = saveManager.GetSavedInt(thisPetId + "_breedUsed");

                // parent ID
                string parentId = saveManager.GetSavedString(thisPetId + "_parentId");

                // SPAWN PET
                SpawnPet(petId, stats, m_baseStats, thisPetCount, false, breedUsed, parentId);
            }
        }

    }


    public void SpawnPet(int m_petId, int[] stats, int[] m_baseStats, int thisPetCount, bool isEgg, int breedUsed, string m_parentPetId)
    {

        // GET DATA
        string codeName = petBalancing.codeName[m_petId];

        // SPAWN
        GameObject spawnedPet;
        spawnedPet = ObjectPool.SharedInstance.GetPooledObject("pet");
        spawnedPet.transform.parent = petParent.transform;
        spawnedPet.SetActive(true);

        // ADD ART
        // release art object if there is one
        if(spawnedPet.GetComponent<petController>().spawnedArt)
            ObjectPool.SharedInstance.ReleaseObject(spawnedPet.GetComponent<petController>().spawnedArt);
        // pool new art object
        GameObject spawnedArt;
        spawnedArt = ObjectPool.SharedInstance.GetPooledObject(codeName);
        spawnedPet.GetComponent<petController>().spawnedArt = spawnedArt;
        // init art object
        spawnedArt.transform.parent = spawnedPet.GetComponent<petController>().artObject;
        spawnedArt.transform.localPosition = Vector3.zero;
        spawnedArt.transform.localEulerAngles = Vector3.zero;
        spawnedArt.SetActive(true);

        // APPLY STATS
        spawnedPet.GetComponent<petController>().InitPet(m_petId, thisPetCount, stats, m_baseStats, codeName, isEgg, breedUsed, m_parentPetId);

        // ADD TO ARRAY
        petList.Add(spawnedPet);
        ownedPets = new GameObject[petList.Count];
        for (int i = 0; i < petList.Count; i++)
            ownedPets[i] = petList[i];


    }


    ////////////////////////////////////////////////////////////////////// POPUP

    public void OpenPopup(GameObject m_selected, bool m_isEggOpening)
    {

        if (m_selected != null)
        {
            // tuto
            if (saveManager.GetSavedInt("tutorialCompleted") == 0)
            {
                if (tutorialManager.currentTuto == 5)
                {
                    tutorialManager.HideTuto(5);
                    tutorialManager.ShowTuto(6, true);

                }
            }

            // Select
            selectedPet = m_selected;
            petController controler = selectedPet.GetComponent<petController>();

            // Camera
            Camera.main.GetComponent<cameraAnimation>().ZoomIn(selectedPet.transform, false, 0);

            // Rotation
            controler.artObject.localEulerAngles = new Vector3(0, 150,0);

            // Name
            petName.text = controler.petDisplayName;

            // BREED BUTTON
            bool canBreed = false;
            if (controler.isMaxLevel && !controler.allBreedsUsed && controler.isHappy)
                canBreed = true;
            breedButtonOn.SetActive(canBreed);
            breedButtonOff.SetActive(!canBreed);

            // LEVEL UP BUTTON
            bool canLevelUp = false;
            if (controler.isHappy && !controler.isMaxLevel)
                canLevelUp = true;
            levelupButtonOn.SetActive(canLevelUp);
            levelupButtonOff.SetActive(!canLevelUp);

            // LEVEL TEXT
            petLevelText.text = "Level " + (controler.currentLevel + 1).ToString() + "/" + (controler.maxLevel + 1).ToString();

            // SELL BUTTON
            bool canSell = false;
            foreach( GameObject p in petList)
            {
                if( p!= selectedPet)
                {
                    petController petController = p.GetComponent<petController>();
                    if (petController.isOwned && !petController.allBreedsUsed)
                        canSell = true;
                }
            }
            sellButtonOn.SetActive(canSell);
            sellButtonOff.SetActive(!canSell);

            // STATS
            int[] stats;
            if (!m_isEggOpening)
                stats = controler.petStats;
            else
            {
                stats = new int [petBalancing.totalStats];
                for(int i =0;i<stats.Length;i++)
                stats[i] = 0;
            }
            for (int i = 0; i < stat0_stars.Length; i++)
            {
                if (stats[0] > i)
                    ShowStar(stat0_stars[i], true);
                else
                    ShowStar(stat0_stars[i], false);
            }
            for (int i = 0; i < stat1_stars.Length; i++)
            {
                if (stats[1] > i)
                    ShowStar(stat1_stars[i], true);
                else
                    ShowStar(stat1_stars[i], false);
            }
            for (int i = 0; i < stat2_stars.Length; i++)
            {
                if (stats[2] > i)
                    ShowStar(stat2_stars[i], true);
                else
                    ShowStar(stat2_stars[i], false);
            }
            for (int i = 0; i < stat3_stars.Length; i++)
            {
                if (stats[3] > i)
                    ShowStar(stat3_stars[i], true);
                else
                    ShowStar(stat3_stars[i], false);
            }
        }
            

        // OPEN POPUP
        GameObject.Find("gameProperties").GetComponent<tapManager>().OpenPopup();
        petPopup.GetComponent<GraphicRaycaster>().enabled = true;
        petPopup.GetComponent<Animation>().Play("petPopup_in");

    }


    public void OpenEgg(GameObject m_selected)
    {
        if (m_selected != null)
        {
            StartCoroutine(OpenEggSequence(m_selected, true));
        }
    }

    IEnumerator OpenEggSequence(GameObject m_selected, bool m_isEggOpening)
    {            
        // tuto
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            if (tutorialManager.currentTuto == 9)
                tutorialManager.HideTuto(9);
        }

        // Select
        selectedPet = m_selected;
        petController controler = selectedPet.GetComponent<petController>();

        // Camera
        Camera.main.GetComponent<cameraAnimation>().ZoomIn(selectedPet.transform, true, 0f);

        // EGG ANIM
        yield return new WaitForSeconds(eggOpen_eggDelay);
        controler.eggObject.GetComponent<Animation>().Play("a_egg_open");

        // SHOW PET
        yield return new WaitForSeconds(eggOpen_artDelay);
        controler.artPopFeedback.Play();
        controler.feedUi.SetActive(true);
        controler.InitFood();
        controler.artObject.GetComponentInChildren<Animator>().SetInteger("animation", 3);
        controler.artObject.GetComponent<Animation>().Play("a_art_pop");

        // UPDATE COLLECTION
        collectionManager.UpdateStamp("newPet");

        // PUT PET ANIM TO IDLE
        yield return new WaitForSeconds(.1f);
        controler.artObject.GetComponentInChildren<Animator>().SetInteger("animation", 0);

        // Set data
        controler.isEgg = false;
        controler.eggObject.SetActive(false);
        controler.artObject.gameObject.SetActive(true);
        controler.RandomRotation();

        // SHOW POPUP
        yield return new WaitForSeconds(eggOpen_popupDelay);
        Camera.main.GetComponent<cameraAnimation>().ZoomIn(selectedPet.transform, false, 0f);
        OpenPopup(m_selected, true); // open popup from egg opening

        // SHOW STARS FOR EGGS
        if (m_isEggOpening)
        {
            yield return new WaitForSeconds(openEggStatFirstDelay);
            //int parentStat = 0;
            int controlerStat = 0;

            // stat 0
            //parentStat = saveManager.GetSavedInt(controler.parentId + "_stat0");
            controlerStat = controler.petStats[0];
            for(int j= 0;j< controlerStat; j++)
            {
                stat0_stars[j].GetComponent<Animation>().Play("petPopup_starPop");
                yield return new WaitForSeconds(.2f);
                ShowStar(stat0_stars[j], true);
                yield return new WaitForSeconds(openEggStatRegularDelay);
            }
            // stat 1
            controlerStat = controler.petStats[1];
            for(int j= 0;j< controlerStat; j++)
            {
                stat1_stars[j].GetComponent<Animation>().Play("petPopup_starPop");
                yield return new WaitForSeconds(.2f);
                ShowStar(stat1_stars[j], true);
                yield return new WaitForSeconds(openEggStatRegularDelay);
            }
            // stat 2
            controlerStat = controler.petStats[2];
            for(int j= 0; j< controlerStat; j++)
            {
                stat2_stars[j].GetComponent<Animation>().Play("petPopup_starPop");
                yield return new WaitForSeconds(.2f);
                ShowStar(stat2_stars[j], true);
                yield return new WaitForSeconds(openEggStatRegularDelay);
            }
            // stat 3
            controlerStat = controler.petStats[3];
            for(int j= 0; j< controlerStat; j++)
            {
                stat3_stars[j].GetComponent<Animation>().Play("petPopup_starPop");
                yield return new WaitForSeconds(.2f);
                ShowStar(stat3_stars[j], true);
                yield return new WaitForSeconds(openEggStatRegularDelay);
            }

        }


        yield return null;
    }

    public void ClosePopup(string closeSource)
    {
        bool isTutoOk = true;
        if (saveManager.GetSavedInt("tutorialCompleted") == 0 && tutorialManager.currentTuto != 7)
            isTutoOk = false;



        petController petController = selectedPet.GetComponent<petController>();

        // RE APPLY HAPPY BEHAVIOR
        selectedPet.GetComponent<petBehavior>().StopAll();
        if (petController.isHappy)
        {
            selectedPet.GetComponent<petBehavior>().DoJump(100);
            petController.artObject.transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            selectedPet.GetComponent<petBehavior>().StartIdle();
            petController.RandomRotation();
        }


        if (isTutoOk || closeSource == "breed")
        {

            // SHOW ORDER
            if (closeSource == "close" && !petController.isHappy && !petController.allBreedsUsed)
                petController.AnimOrderUi();

            // Camera
            if (closeSource == "close")
                Camera.main.GetComponent<cameraAnimation>().ZoomOut();

            // Unselect
            if (closeSource == "close")
                selectedPet = null;

            // Close popup
            GetComponent<tapManager>().ClosePopup();
            petPopup.GetComponent<GraphicRaycaster>().enabled = false;
            petPopup.GetComponent<Animation>().Play("petPopup_out");


            if (tutorialManager.currentTuto == 7)
            {
                tutorialManager.HideTuto(7);
                tutorialManager.ShowTuto(8, true);
            }
        }


    }

    public void TapBreedButton()
    {
        StartCoroutine(TapBreedSequence());

    }

    public void TapBreedButtonOff()
    {
        petController controler = selectedPet.GetComponent<petController>();
        int currentOwnedPets = saveManager.GetSavedInt("currentOwnedPets");
        int maxPets = petStatsBalancing.maxPets;

        if (currentOwnedPets == maxPets)
            ShowError_MaxPets();      
        
        else if (controler.allBreedsUsed)
            ShowError_NoBreed();
        
        else if (!controler.isMaxLevel)
            ShowError_NoMaxLevel();

        else if (!controler.isHappy)
            ShowError_NoHappy();

    }

    IEnumerator TapBreedSequence()
    {
        ClosePopup("breed");
        yield return new WaitForSeconds(breedListOpenDelay);

        // open popup
        breedingManager.OpenPopup();

        // show Cards
        foreach (breedingOptionController b in breedingManager.mateList)
        {
            float randomWait = Random.Range(breedCardMinDelay, breedCardMaxDelay);
            b.ShowCard(randomWait);
        }

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

    ////////////////////////////////////////////////////////////////////// SELL 
    public void Levelup()
    {
        petController controler = selectedPet.GetComponent<petController>();
        if (!controler.isMaxLevel && controler.isHappy)
        {
            StartCoroutine(LevelUpSequence());
        }
        else if (controler.isMaxLevel)
            ShowError_MaxLevel();
        else if (!controler.isHappy)
            ShowError_NoHappy();

    }


    IEnumerator LevelUpSequence()
    {
        petController controler = selectedPet.GetComponent<petController>();

        // TUTO
        if (tutorialManager.currentTuto == 6)
        {
            tutorialManager.HideTuto(6);
            tutorialManager.ShowTuto(7, true);

            // -----------------------> PAUSE
            yield return new WaitForSeconds(.5f);
        }

        // UPDATE BUTTONS
        levelupButtonOn.SetActive(false);
        levelupButtonOff.SetActive(true);

        // HIDE LEVEL UP PARTICLE
        controler.SetHappy(false, 0);

        // ANIMATE LEVEL UP TEXT
        petLevelText.transform.parent.GetComponent<Animation>().Play("petPopup_levelup");
        
        // -----------------------> PAUSE
        yield return new WaitForSeconds(.25f);

        // CHANGE LEVEL
        controler.currentLevel++;
        controler.CheckMaxLevel();
        UpdateLevelText();

        // -----------------------> PAUSE
        yield return new WaitForSeconds(.75f);

        // PICK STAT
        GameObject starToAnimate = StarToAnimate();
        starToAnimate.GetComponent<Animation>().Play("petPopup_starPop");

        // -----------------------> PAUSE
        yield return new WaitForSeconds(.2f);


        // SHOW STAR
        ShowStar(starToAnimate, true);

        // CREATE FOOD ORDER
        controler.CreateFoodOrder();


        // SAVE
        SavePetLevelUp(controler.thisPetId, controler.currentLevel, statToIncrease, newStatValue);


        yield return null;
    }

    GameObject StarToAnimate()
    {

        GameObject starToAnimate = null;
        petController controler = selectedPet.GetComponent<petController>();

        bool statPicked = false;
        statToIncrease = 0;
        newStatValue = 0;
        while (!statPicked)
        {
            int randomStat = Random.Range(0, petBalancing.totalStats);
            if (controler.petStats[randomStat] < 5)
            {
                statPicked = true;
                statToIncrease = randomStat;
            }
        }
        newStatValue = controler.petStats[statToIncrease] + 1;
        controler.petStats[statToIncrease] = newStatValue;
        controler.totalStars++;

        // DO ANIM
        if (statToIncrease == 0)
            starToAnimate = stat0_stars[newStatValue - 1];
        else if (statToIncrease == 1)
            starToAnimate = stat1_stars[newStatValue - 1];
        else if (statToIncrease == 2)
            starToAnimate = stat2_stars[newStatValue - 1];
        else if (statToIncrease == 3)
            starToAnimate = stat3_stars[newStatValue - 1];


        return starToAnimate;
    }

    void UpdateLevelText()
    {
        petController controler = selectedPet.GetComponent<petController>();
        petLevelText.text = "Level " + (controler.currentLevel + 1).ToString() + "/" + (controler.maxLevel + 1).ToString();
    }

    void ShowStar(GameObject star, bool activate)
    {
        if (activate)
            star.GetComponent<Image>().color = colorOn;
        else
            star.GetComponent<Image>().color = colorOff;
    }

    ////////////////////////////////////////////////////////////////////// SELL 
    public void TapSellButton()
    {
        bool canSell = false;
        foreach (GameObject p in petList)
        {
            if (p != selectedPet)
            {
                petController petController = p.GetComponent<petController>();
                if (petController.isOwned && !petController.allBreedsUsed)
                    canSell = true;
            }
        }
        if(canSell)
            StartCoroutine(SellPopupSequence());
        else
            GetComponent<necManager>().ShowNec("onePetLeft");
    }    
    public void ConfirmSell()
    {
        StartCoroutine(ConfirmSellSequence());
    }    
    public void CancelSell()
    {
        StartCoroutine(CancelSellSequence());
    }

    IEnumerator SellPopupSequence()
    {
        // close
        ClosePopup("sell");

        // zoom
        Camera.main.GetComponent<cameraAnimation>().ZoomIn(selectedPet.transform, true, 0);

        // open
        yield return new WaitForSeconds(openSellDelay);
        GameObject.Find("gameProperties").GetComponent<tapManager>().OpenPopup();
        sellPopup.GetComponent<GraphicRaycaster>().enabled = true;
        sellPopup.GetComponent<Animation>().Play("petSellPopup_in");

        // get data
        int petGameId = selectedPet.GetComponent<petController>().petId;
        int petTotalStars = selectedPet.GetComponent<petController>().totalStars;
        sellRewardText.text = petBalancing.sellPrice[petGameId, petTotalStars].ToString();
    }

    IEnumerator ConfirmSellSequence()
    {
        // close popup
        GameObject.Find("gameProperties").GetComponent<tapManager>().ClosePopup();
        sellPopup.GetComponent<GraphicRaycaster>().enabled = false;
        sellPopup.GetComponent<Animation>().Play("petSellPopup_out");

        // zoom out
        yield return new WaitForSeconds(confirmSellZoomDelay);
        Camera.main.GetComponent<cameraAnimation>().ZoomOut();

        yield return new WaitForSeconds(confirmSellDestroyDelay);

        // give coins
        int petGameId = selectedPet.GetComponent<petController>().petId;
        int petTotalStars = selectedPet.GetComponent<petController>().totalStars;
        int sellPrice = petBalancing.sellPrice[petGameId, petTotalStars];
        GetComponent<feedbackManager>().CoinSpawn(sellPrice, selectedPet, 0f, "coins");

        // destroy
        selectedPet.GetComponent<petController>().isOwned = false;
        petList.Remove(selectedPet); ownedPets = new GameObject[petList.Count];
        for (int i = 0; i < petList.Count; i++)
            ownedPets[i] = petList[i];
        ObjectPool.SharedInstance.ReleaseObject(selectedPet);

        // save
        int currentOwnedPets = saveManager.GetSavedInt("currentOwnedPets");
        SaveSoldPet(selectedPet.GetComponent<petController>().thisPetId, currentOwnedPets);


        yield return null;
    }    
    
    IEnumerator CancelSellSequence()
    {        
        // close popup
        GameObject.Find("gameProperties").GetComponent<tapManager>().ClosePopup();
        sellPopup.GetComponent<GraphicRaycaster>().enabled = false;
        sellPopup.GetComponent<Animation>().Play("petSellPopup_out");

        // OPEN POPUP
        yield return new WaitForSeconds(cancelSellDelay);
        OpenPopup(selectedPet, false);


        yield return null;
    }

    ////////////////////////////////////////////////////////////////////// ERRORS 
    public void ShowError_MaxPets()
    {
        error_maxPets.GetComponent<Animation>().Play("a_spawn");
    }      
    void ShowError_NoBreed()
    {
        error_noBreed.GetComponent<Animation>().Play("a_spawn");
    }      
    void ShowError_MaxLevel()
    {
        error_maxLevel.GetComponent<Animation>().Play("a_spawn");
    }    
    void ShowError_NoHappy()
    {
        error_noHappy.GetComponent<Animation>().Play("a_spawn");
    }   
    void ShowError_NoMaxLevel()
    {
        error_needMaxLevel.GetComponent<Animation>().Play("a_spawn");
    }


    ////////////////////////////////////////////////////////////////////// SAVE  
    void SavePetLevelUp(string thisPetId, int newLevel, int statToIncrease, int newStatValue)
    {
        saveManager.SaveInt(thisPetId + "_currentLevel", newLevel);
        saveManager.SaveInt(thisPetId + "_stat" + statToIncrease.ToString(), newStatValue);
    }
  
    void SaveNewPet(int petCount, int petId, int[] stats, int[] baseStats, string m_parentId)
    {
        string thisPetId = "pet_" + petCount.ToString();

        // thisPetCount
        saveManager.SaveInt(thisPetId+"_thisPetCount", petCount);

        // id
        saveManager.SaveInt(thisPetId + "_thisPetId", petId);

        // parent id
        saveManager.SaveString(thisPetId + "_parentId", m_parentId);

        // stats
        for(int i=0;i<stats.Length;i++)
            saveManager.SaveInt(thisPetId + "_stat"+i.ToString(), stats[i]);

        // stats
        for(int i=0;i<stats.Length;i++)
            saveManager.SaveInt(thisPetId + "_baseStat" + i.ToString(), baseStats[i]);


        // PET COUNT
        saveManager.SaveInt("totalPetCount", petCount+1);
    }

    void SaveCurrentOwnedPets(int owned)
    {
        saveManager.SaveInt("currentOwnedPets", owned + 1);
    }

    void SaveSoldPet(string thisPetId, int owned)
    {
        saveManager.SaveInt(thisPetId + "_isSold", 1);
        saveManager.SaveInt("currentOwnedPets", owned - 1);

    }    
    
    void SaveTotalOwnedPet(string m_codeName, int owned)
    {
        saveManager.SaveInt(m_codeName + "_totalOwned", owned+1);
    }

    void SaveUnlockState(string codeName, int unlockState)
    {
        saveManager.SaveInt(codeName + "_unlockState", unlockState);
    }

    void SaveBreedUsed(string codeName, int breedsUsed)
    {
        saveManager.SaveInt(codeName + "_breedsUsed", breedsUsed);
    }

}
