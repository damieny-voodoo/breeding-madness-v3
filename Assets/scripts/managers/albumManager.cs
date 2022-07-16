using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class albumManager : MonoBehaviour
{
    [Header("MAIN PANELS")]
    public GameObject albumPopup;
    public GameObject contentParent;

    [Header("COLLECT DATA")]
    public energyBalancing energyBalancing;
    public itemBalancing itemBalancing;
    public albumBalancing albumBalancing;
    public GameObject notification;
    //public int[] rewardsMilestones;
    //public int[] rewardAmount;
    public int[] rewardsMilestonesStatus;
    public TextMeshProUGUI milestoneTitle;
    public TextMeshProUGUI progressText;
    public Image progressBar;
    public GameObject collectPanel;
    public GameObject collectPanelAd;
    public GameObject adButtonOn;
    public GameObject adButtonOff;
    public GameObject progressPanel;
    public GameObject progressionPanel;
    public int nextMilestoneToCollect;
    public Color progressbarLocked;
    public Color progressbarUnlocked;
    public TextMeshProUGUI rewardText;
    public TextMeshProUGUI rewardTextAd;
    public bool canCollectReward;
    public int totalItemsDiscovered;


    [Header("COLLECTION")]
    public Color[] familyColors;
    public GameObject[] albumItems;
   // int totalUnlocked;

    /////////////////// DATA FOR POSITION
    int itemsPerRow = 4;
    float widthToHeight = 1.4f;
    //int[] maxItems;
    float contentSize;

    /////////////////// GENERAL DATA
    //string[] familyIds;
    //string[,] familyNames;

    saveManager saveManager;
    adManager adManager;


    void Awake()
    {

    }

    void Start()
    {

        // GET MANAGERS
        saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        adManager = GameObject.Find("gameProperties").GetComponent<adManager>();
        energyBalancing = GameObject.Find("balancingData").GetComponent<energyBalancing>();
        itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
        albumBalancing = GameObject.Find("balancingData").GetComponent<albumBalancing>();


        // GET SAVED GAME
        rewardsMilestonesStatus  = new int[albumBalancing.rewardsMilestones.Length];
        for (int i=0;i< rewardsMilestonesStatus.Length;i++)
            rewardsMilestonesStatus[i] = saveManager.GetSavedInt("albumReward_milestone" + i.ToString());
        totalItemsDiscovered = saveManager.GetSavedInt("total_progress");


        // INITIALIZE
        PositionAlbum();
        InitiateAlbum();
        CheckCollect();

    }


    /////////////////////////// INITIATE THE VALUE FOR EVERY ITEM
    void PositionAlbum()
    {
        int currentFamily = 0;
        int currentTier = 0;
        int totalRows = Mathf.CeilToInt((float)albumItems.Length / (float)itemsPerRow);
        float itemwidth = (Screen.safeArea.width * 0.8f) / (float)itemsPerRow;
        float itemHeight = itemwidth * widthToHeight;
        contentSize = itemHeight * totalRows;


        // STOP WHEN FINDING LAST ITEM
        bool allItemsChecked = false;
        int currentId = 0;
        int totalFamilies = itemBalancing.familyNames.Length - 1;
        int lastItemMaxTier = itemBalancing.maxTier[totalFamilies];

        while (!allItemsChecked)
        {

            if (currentFamily == totalFamilies && currentTier == lastItemMaxTier)
                allItemsChecked = true;

            int currentRow = totalRows - Mathf.FloorToInt((float)currentId / (float)itemsPerRow);
            int currentColumn = currentId % itemsPerRow;
            string familyName = itemBalancing.familyNames[currentFamily];
            if (familyName != "noname")
            {
                //Debug.Log(currentId+": "+ "album_" + familyName + "_" + currentTier);
                albumPictureController albumC = albumItems[currentId].GetComponent<albumPictureController>();

                // name
                albumItems[currentId].name = "album_" + familyName + "_" + currentTier;

                // color of the background
                string colorValue = "#"+itemBalancing.familyColors[currentFamily];
                Color newCol;
                if (ColorUtility.TryParseHtmlString(colorValue, out newCol))
                    albumC.bgColorUnlocked = newCol;

                // image
                albumC.itemImage.sprite = Resources.Load<Sprite>("UI/icons/items/" + familyName + "_" + currentTier);

                //position
                albumItems[currentId].GetComponent<RectTransform>().anchorMin = new Vector2((float)currentColumn / itemsPerRow, ((float)currentRow - 1) / (float)totalRows);
                albumItems[currentId].GetComponent<RectTransform>().anchorMax = new Vector2(((float)currentColumn + 1) / (float)itemsPerRow, (float)currentRow / (float)totalRows);
                albumItems[currentId].GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
                albumItems[currentId].GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);

                // Set locked/unlocked
                albumC.family = familyName;
                albumC.familyID = currentFamily;
                albumC.tier = currentTier;


                // Set locked/unlocked
                albumC.SetImageLocked();

                // Increment
                currentId++;

                // update values
                if ((currentTier) == itemBalancing.maxTier[currentFamily])
                {
                    currentFamily++;
                    currentTier = 0;
                }
                else
                    currentTier++;

            }
            else
                currentFamily++;        
        }

    }


    /////////////////////////// HARD RESET ON GAME START
    public void RestartFamilyProgress()
    {

        if (!itemBalancing)
            itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
        if (!saveManager)
            saveManager = GetComponent<saveManager>();

        for (int i = 0; i < itemBalancing.familyNames.Length; i++)
            SaveRestartFamilyProgress(i);

    }





    /////////////////////////// UPDATE THE VALUES IN THE UI AND SHOW IT
    public void ShowAlbum()
    {

        UpdateCollectionUI();

        GameObject.Find("gameProperties").GetComponent<tapManager>().OpenPopup();
        albumPopup.GetComponent<GraphicRaycaster>().enabled = true;

        albumPopup.GetComponent<Animation>().Play("album_popup_open");

        foreach (GameObject go in albumItems)
            go.GetComponent<Animation>().Play("albumPicture_anim");

        contentParent.GetComponent<RectTransform>().sizeDelta = new Vector2(0, contentSize);

    }



    /////////////////////////// CLOSE THE UI
    public void CloseAlbum()
    {

        GameObject.Find("gameProperties").GetComponent<tapManager>().ClosePopup();
        albumPopup.GetComponent<GraphicRaycaster>().enabled = false;

        albumPopup.GetComponent<Animation>().Play("album_popup_close");

    }
    

    /////////////////////////// COLLECT A MILESTIONE
    public void CollectMilestone()
    {

        // ADD ENERGY
        int reward = energyBalancing.albumRewards[nextMilestoneToCollect];
        Vector2 pos = new Vector2(TapPosition().x / Screen.width, TapPosition().y / Screen.height);
        GetComponent<feedbackManager>().UiReward(reward, pos, "energy", "albumReward");


        // UPDATE STATUS
        rewardsMilestonesStatus[nextMilestoneToCollect] = 2;
        SaveAlbumMilestone(nextMilestoneToCollect.ToString(), 2);

        // UPDATE COLLECT STATE
        CheckCollect();

        // ANIMATION
        if (canCollectReward)
            progressionPanel.GetComponent<Animation>().Play("album_collect_double");
        else
            progressionPanel.GetComponent<Animation>().Play("album_collect");

        // UPDATE
        UpdateCollectionUI();
    }
       

    /////////////////////////// INIT 
    void InitiateAlbum()
    {
        foreach (GameObject go in albumItems)
        {
            albumPictureController albumC = go.GetComponent<albumPictureController>();
            string itemFamily = albumC.family;
            int itemTier = albumC.tier;
            int currentProgress = saveManager.GetSavedInt(itemFamily + "_progress");
            if (currentProgress >= itemTier)
                albumC.SetImageUnlocked();
        }

        bool isAdActivated = adManager.energyAdCollectionActive;
        //Debug.Log("Is ad active? " + isAdActivated);
        collectPanelAd.SetActive(isAdActivated);
        collectPanel.SetActive(!isAdActivated);

    }



    /////////////////////////// DISCOVER NEW ITEM
    public void DiscoverNewItem(string familyId, int newItemTier, int currentFamilyProgress)
    {
        //Debug.Log("discover new item");
        /////////////////// SAVE THE DATA
        totalItemsDiscovered += newItemTier - currentFamilyProgress;
        SaveFamilyProgress(familyId, newItemTier);
        SaveAlbumProgress(totalItemsDiscovered);

        ////////////////// CHECK STATUS
        for (int i = 0; i < rewardsMilestonesStatus.Length; i++)
        {
            if (totalItemsDiscovered >= albumBalancing.rewardsMilestones[i] && rewardsMilestonesStatus[i] == 0)
            {
                rewardsMilestonesStatus[i] = 1;
                SaveAlbumMilestone(i.ToString(), 1);
                CheckCollect();
            }
        }


    }

    public void UpdateAlbum(int familyToUpdate, int newItemTier)
    {
        foreach (GameObject go in albumItems)
        {
            albumPictureController albumC = go.GetComponent<albumPictureController>();
            if (familyToUpdate == albumC.familyID && newItemTier >= albumC.tier)
            {
                albumC.SetImageUnlocked();

            }
        }


    }


    void UpdateCollectionUI()
    {

        ////////////////////////// Collect reward panel
        milestoneTitle.text = CollectTitle();
        progressText.text = totalItemsDiscovered.ToString() + "/" + albumBalancing.rewardsMilestones[nextMilestoneToCollect].ToString();
        rewardText.text = energyBalancing.albumRewards[nextMilestoneToCollect].ToString();
        rewardTextAd.text = energyBalancing.albumRewards[nextMilestoneToCollect].ToString();

       //Debug.Log("Can collect = "+ canCollectReward);
        // BUTTONS
        if (canCollectReward)
        {
            progressPanel.transform.localScale = new Vector3(0, 0, 0);
            collectPanel.transform.localScale = new Vector3(1, 1, 1);
            collectPanelAd.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            progressPanel.transform.localScale = new Vector3(1, 1, 1);
            collectPanel.transform.localScale = new Vector3(0, 0, 0);
            collectPanelAd.transform.localScale = new Vector3(0, 0, 0);
        }
        bool isAdAvailable = adManager.IsAdAvailable("energyAdCollection");
        adButtonOn.SetActive(isAdAvailable);
        adButtonOff.SetActive(!isAdAvailable);


        // PROGRESS BAR
        float proportion = 0f;
        if (nextMilestoneToCollect == 0)
            proportion = (float)totalItemsDiscovered / (float)albumBalancing.rewardsMilestones[0];
        else
            proportion = ((float)totalItemsDiscovered - (float)albumBalancing.rewardsMilestones[nextMilestoneToCollect - 1]) / ((float)albumBalancing.rewardsMilestones[nextMilestoneToCollect] - (float)albumBalancing.rewardsMilestones[nextMilestoneToCollect - 1]);
        progressBar.fillAmount = proportion;

        if (canCollectReward)
            progressBar.color = progressbarUnlocked;
        else
            progressBar.color = progressbarLocked;
    }


    public void CheckCollect()
    {
        //Debug.Log("Check Collect");
        canCollectReward = false;
        nextMilestoneToCollect = 0;


        //////////////////////  SET VALUES TO COLLECT
        for (int i = 0; i < albumBalancing.rewardsMilestones.Length; i++)
        {
            if (!canCollectReward)
            {
                if (rewardsMilestonesStatus[i] == 1 )
                {
                    canCollectReward = true;
                    nextMilestoneToCollect = i;
                }
                else if (rewardsMilestonesStatus[i] == 2)
                    nextMilestoneToCollect = i + 1;

            }
        }


        ///////////////////// UPDATE UI

        ///////////////////// Show Notif
        notification.SetActive(canCollectReward);


    }

    string CollectTitle()
    {
        string collectText = "";
        int currentLanguage = saveManager.GetSavedInt("currentLanguage");

        if (currentLanguage == 0)
            collectText = "Decouvre " + albumBalancing.rewardsMilestones[nextMilestoneToCollect].ToString() + " legumes";
        else if (currentLanguage == 1)
            collectText = "Discover " + albumBalancing.rewardsMilestones[nextMilestoneToCollect].ToString() + " items";


        return collectText;
    }

    Vector2 TapPosition()
    {
        Vector2 tapPos = new Vector2(0, 0);

        if (Application.isEditor)
            tapPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        else
        {
            if (Input.touchCount > 0)
                tapPos = new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y);
        }

        return tapPos;

    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveFamilyProgress(string familyId, int newItemTier)
    {
         saveManager.SaveInt(familyId + "_progress", newItemTier);                  // save family progress
    }

    void SaveRestartFamilyProgress(int i)
    {
        saveManager.SaveInt(itemBalancing.familyNames[i] + "_progress", -1);        // restart family Progress
    }

    void SaveAlbumMilestone(string nextMilestoneToCollect, int progress)
    {
        saveManager.SaveInt("albumReward_milestone" + nextMilestoneToCollect, progress);        // save album milestone
    }

    void SaveAlbumProgress(int totalProgress)
    {
        saveManager.SaveInt("total_progress", totalProgress);        // save album total progress
    }
}
