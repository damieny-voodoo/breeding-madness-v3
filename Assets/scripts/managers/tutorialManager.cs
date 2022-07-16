using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour
{
    [Header("REGULAR TUTO -------------------")]
    public int currentTuto;
    public int lastTutorialId;
    public GameObject[] tutorialObjects;
    public GameObject[] tutorialObjectsTextBoxes;
    public float[] handDelay;
    public float[] textDelay;

    [Header("OBSOLETE-------------------")]
    public GameObject contextualTutorialObject;
    public GameObject contextualTutorialSlowDragObject;
    public GameObject contextualPointObject;
    public GameObject contextualTapItem;
    public bool isIdle;

    public int tutorialToOpenBottomPanel;
    public GameObject bottomPanel;

    //[Header("ORDER TUTO -------------------")]
    public GameObject orderTuto;
    public GameObject orderTutoText;

    //[Header("TIME TUTO -------------------")]
    public bool timeOrderTutoOn;
    public GameObject timeOrderTutoText;

    //[Header("SPECIAL TUTO -------------------")]
    public bool specialOrderTutoOn;
    public GameObject specialOrderTutoText;


    //[Header("BOMB TUTO -------------------")]
    public GameObject bombTutoArrow;
    public GameObject bombTutoText;

    //[Header("TILE TUTO -------------------")]
    public GameObject tileTutoArrow;
    public GameObject tileTutoText;

    //[Header("Bomb -------------------")]
    public GameObject bombMaster;

    analyticsManager aManager;
    saveManager saveManager;
    spawnerController spawnerController;
    petBalancing petBalancing;
    resourcesBalancing resourcesBalancing;


    private void Awake()
    {
        aManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        saveManager = GetComponent<saveManager>();
        spawnerController = GameObject.Find("spawner_0").GetComponent<spawnerController>();

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        resourcesBalancing = balancingData.GetComponent<resourcesBalancing>();


        //////////////////// HARD RESTART IF TUTO NOT COMPLETED
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            // CLEAR PLAYER PREFS
            saveManager.DeleteAll();

            // SHOW FIRST TUTO
            ShowTuto(0, true);
            GetComponent<tapManager>().popupOpen = true;

            // APPLY VALUES FOR INITIAL SETUP
            //InitialSetup();

            // START FUNNEL
            /*
            if (!aManager)
            {
                aManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
                GameObject.Find("analyticsManager").GetComponent<analyticsManager>().ContinueFunnel("mainTutorial", "startTutorial");
                GameObject.Find("analyticsManager").GetComponent<analyticsManager>().StartLevel(1);
            }

            /////////// TRACKING
            else
            {
                aManager.ContinueFunnel("mainTutorial", "startTutorial");
                aManager.StartLevel(1);
            }
            */

        }
        else
        {
            HideTuto(0);
        }
        /*
        //////////////////// BOTTOM PANEL
        if (saveManager.GetSavedInt("bottomPanelOpen") == 1)
            OpenBottomPanel();
        else
            bottomPanel.GetComponent<Animation>().Play("bottomPanel_hide");
        */

    }


    private void Start()
    {
        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            InitialSetup();
        }

    }
    void InitialSetup()
    {
        // COINS
        int defaultCoins = resourcesBalancing.defaultCoins;
        GetComponent<coinManager>().AddCoins(defaultCoins);

        // CARROTS
        GetComponent<itemManager>().CreateItem(0, GameObject.Find("tile0_2"), "carrots", 0, true);
        GetComponent<itemManager>().CreateItem(0, GameObject.Find("tile0_5"), "carrots", 1, true);

        // PET
        int petId = 0;

        int[] stats = new int[petBalancing.totalStats];
        int[] baseStats = new int[petBalancing.totalStats];
        for (int i = 0; i < stats.Length; i++)
        {
            stats[i] = petBalancing.defaultStats[0, i];
            baseStats[i] = petBalancing.defaultStats[0, i];
        }

        int currentPetCount = saveManager.GetSavedInt("totalPetCount");


        GetComponent<petManager>().GetNewPet(petId, stats, baseStats, currentPetCount, false, 0, "");

    }
    public void BombTuto()
    {
        bombTutoArrow.SetActive(true);
        bombTutoText.transform.localScale = new Vector3(1, 1, 1);
        bombTutoText.GetComponent<Animation>().Play("tutorial_textBox");

        saveManager.SaveInt("tutorialBombProgress", 1);
        spawnerController.tutorialBombProgress = 1;
    }

    public void TileTuto()
    {
        /*
        tileTutoArrow.SetActive(true);
        tileTutoText.transform.localScale = new Vector3(1, 1, 1);
        tileTutoText.GetComponent<Animation>().Play("tutorial_textBox");

        saveManager.SaveInt("tutorialTileProgress", 1);
        spawnerController.tutorialTileProgress = 1;
        */
    }

    public void HideTutoBomb()
    {
        /*
       bombTutoArrow.SetActive(false);
       bombTutoText.GetComponent<Animation>().Stop();
       bombTutoText.transform.localScale = new Vector3(0, 0, 0);
        */
    }

    public void HideTutoTile()
    {
        /*
        tileTutoArrow.SetActive(false);
        tileTutoText.GetComponent<Animation>().Stop();
        tileTutoText.transform.localScale = new Vector3(0, 0, 0);
        */
    }


    public void TapTuto0()
    {
        // SHOW HIDE
        HideTuto(0);
        ShowTuto(1, true);
        //ShowTuto(1, true);
        //HideTuto(0);
        GetComponent<tapManager>().popupOpen = false;
    }

    public void ShowTuto(int tutoId, bool saveProgress)
    {

        currentTuto = tutoId;

        // SHOW ARROW
        if (tutorialObjects[tutoId])
            StartCoroutine(ShowHandTuto(tutoId));

        // SHOW TEXT
        if (tutorialObjectsTextBoxes[tutoId])
            StartCoroutine(ShowTextTuto(tutoId));

        // SAVE PROGRESS
        if (saveProgress)
            SaveTutorialProgress(tutoId);

        // COMPLETE IF NEEDED
        if (tutoId == lastTutorialId)
            CompleteTutorial();

    }

    IEnumerator ShowHandTuto(int tutoId)
    {
        yield return new WaitForSeconds(handDelay[tutoId]);

        if(currentTuto ==tutoId)
            tutorialObjects[tutoId].SetActive(true);

        yield return null;
    }    
    
    IEnumerator ShowTextTuto(int tutoId)
    {
        yield return new WaitForSeconds(textDelay[tutoId]);

        if (currentTuto == tutoId)
        {
            tutorialObjectsTextBoxes[tutoId].transform.localScale = new Vector3(1, 1, 1);
            tutorialObjectsTextBoxes[tutoId].GetComponent<Animation>().Play("tutorial_textBox");
        }

        yield return null;
    }

    void CompleteTutorial()
    {
        bombMaster.GetComponent<trashController>().CreateNewBomb();

        SaveCompleteTutorial();
    }


    public void HideTuto(int tutoToHide)
    {
        // HIDE ARROW
        if (tutorialObjects[tutoToHide])
            tutorialObjects[tutoToHide].SetActive(false);

        // HIDE TEXT
        if (tutorialObjectsTextBoxes[tutoToHide])
        {
            tutorialObjectsTextBoxes[tutoToHide].GetComponent<Animation>().Stop();
            tutorialObjectsTextBoxes[tutoToHide].transform.localScale = new Vector3(0, 0, 0);
        }
        /*
        if (tutoToHide == 13)
            contextualTapItem.SetActive(false);
        */
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////// ORDER TUTO
    public void ShowInfoTuto(Transform orderItem)
    {

        orderTuto.SetActive(true);
        orderTutoText.transform.localScale = new Vector3(1,1,1);
        orderTutoText.GetComponent<Animation>().Play("tutorial_textBox");
        orderTuto.transform.SetParent(orderItem);
        orderTuto.transform.localPosition = new Vector3(0, 0, 0);
        orderTuto.transform.localScale = new Vector3(.1f,.1f,.1f);

    }

    public void HideInfoTuto()
    {
        orderTuto.SetActive(false);
        orderTutoText.transform.localScale = new Vector3(0,0,0);
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////// TIME TUTO
    public void ShowTimeTuto()
    {
        timeOrderTutoOn = true;
        timeOrderTutoText.transform.localScale = new Vector3(1, 1, 1);
        timeOrderTutoText.GetComponent<Animation>().Play("tutorial_textBox");

        SaveTimeOrderTutoProgress();
    }

    public void HideTimeTuto()
    {
        timeOrderTutoOn = false;
        timeOrderTutoText.transform.localScale = new Vector3(0,0,0);
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////// SPECIAL TUTO
    public void ShowSpecialTuto()
    {
        specialOrderTutoOn = true;
        specialOrderTutoText.transform.localScale = new Vector3(1, 1, 1);
        specialOrderTutoText.GetComponent<Animation>().Play("tutorial_textBox");

        //SaveSpecialOrderTutoProgress();
    }
    public void HideSpecialTuto()
    {
        specialOrderTutoOn = false;
        specialOrderTutoText.transform.localScale = new Vector3(0,0,0);
    }




    ////////////////////////////////////////////////////////////////////////////////////////////////////// SLOW DRAG TUTO
    public void ShowSlowDragTuto(int tutoId, GameObject item1, GameObject item2)
    {
        //Debug.Log("Show slow drag tuto");

        if (saveManager.GetSavedInt("tutorialCompleted") == 0)
        {
            currentTuto = tutoId;
            // ACTIVATE CONTEXTUAL
            contextualTutorialSlowDragObject.SetActive(true);
            tutorialObjectsTextBoxes[3].GetComponent<Animation>().Play("tutorial_textBox");
            contextualTutorialSlowDragObject.GetComponent<contextualTutorial_drag>().StartAnimation(item1.transform.position, item2.transform.position);
        }
    }


    public void HideSlowDragTuto()
    {
        //Debug.Log("Hide slow drag tuto");

        contextualTutorialSlowDragObject.SetActive(false);
        tutorialObjectsTextBoxes[3].transform.localScale = new Vector3(0,0,0);
    }
     

    public void OpenBottomPanel()
    {
        //Debug.Log("Tuto - Open bottom panel");
        SaveBottomPanelOpen();
        bottomPanel.GetComponent<Animation>().Play("bottomPanel_show");

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE

    void SaveBottomPanelOpen()
    {
        saveManager.SaveInt("bottomPanelOpen", 1); // save bottom panel open
    }

    void SaveTutorialProgress(int tutorialProgress)
    {
        saveManager.SaveInt("tutorialProgress", tutorialProgress); // save progress in tutorial
    }
    void SaveCompleteTutorial()
    {
        saveManager.SaveInt("tutorialCompleted", 1);
        saveManager.SaveInt("islandMigrationDone", 1);
    }

    void SaveTimeOrderTutoProgress()
    {
        saveManager.SaveInt("tutorialTimeOrderCompleted", 1);
    }
    void SaveSpecialOrderTutoProgress()
    {
        saveManager.SaveInt("tutorialSpecialOrderCompleted", 1);
    }
}
