using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gardenDecorationControler : MonoBehaviour
{
    [Header("OBJECTS TO ACTIVATE")]
    public GameObject[] objetsToActivate;

    [Header("DATA")]
    public int decorationId;
    public int decorationLevelUnlock;
    public int currentState;
    public int purchasePrice;
    public int xpReward;
    int decoCount;


    // OBJECTS
    public Transform centerViewTransform;
    GameObject colliders;
    GameObject[] selectionOutlines;
    GameObject[] decorationOptions;

    // FEEDBACK OBJECTS
    Transform feedbackAnchor;
    Transform artParent;
    GameObject purchaseCard;
    GameObject purchasableFeedback;
    GameObject notPurchasableFeedback;
    GameObject feedbackCollider;
    TextMeshPro purchaseText;


    [Header("FEEDBACK")]
    public float[] textPos;
    public float[] iconPos;

    public Color purchaseTextOk;
    public Color purchaseTextNotOk;

    GameObject gameProperties;
    gardenData gardenData;
    saveManager saveManager;



    public void InitDecoration()
    {
        // MAIN SETTINGS
        decoCount = 4;

        // ACTIVATE FEEDBACK AND COLLIDERS
        for(int i =0;i< objetsToActivate.Length; i++)
            objetsToActivate[i].SetActive(true);


        // GET PROPERTIES
        gameProperties = GameObject.Find("gameProperties");
        gardenData = GameObject.Find("balancingData").GetComponent<gardenData>();
        saveManager = gameProperties.GetComponent<saveManager>();


        // STATE
        currentState = saveManager.GetSavedInt("decorationState_" + decorationId.ToString());


        // GET OBJECTS
        GetObjects();


        // BALANCING
        purchasePrice = gardenData.unlockPrice[decorationId];
        xpReward = gardenData.xpReward[decorationId];


        // UNLOCK
        decorationLevelUnlock = gardenData.decorationLevelUnlock[decorationId];


        // SHOW VISUALS
        ShowOption(currentState);
        HideOptionsSelection();


        // Check feedback to create/delete
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = gameProperties.GetComponent<xpManager>().GetLevel(currentXp);
        currentState = saveManager.GetSavedInt("decorationState_" + decorationId.ToString());
        if (decorationLevelUnlock <= currentLevel && currentState == 0 )
            CreateFeedback();

        // Enable Disable Collider
        CheckCollider();

    }

    void GetObjects()
    {

        feedbackAnchor = transform.Find("feedbackAnchor");
        colliders = transform.Find("colliders").gameObject;
        centerViewTransform = transform.Find("centerView");
        artParent = transform.Find("artParent");
        decorationOptions = new GameObject[decoCount];
        selectionOutlines = new GameObject[decoCount];

        for (int i = 0; i < decoCount; i++)
        {
            decorationOptions[i] = artParent.Find("option" + i.ToString()).gameObject;
            selectionOutlines[i] = decorationOptions[i].transform.Find("selection").gameObject;
        }

        if(Application.isEditor)
        {
            for (int i = 1; i < decoCount; i++)
            {
                MeshRenderer[] selectionRenderers; 
                selectionRenderers = selectionOutlines[i].GetComponentsInChildren<MeshRenderer>();

                foreach (MeshRenderer s in selectionRenderers)
                {
                    if (s.enabled)
                    {
                        s.enabled = false;
                        Debug.LogWarning(" Renderer activated in " + gameObject.name + ", item " + i);
                    }
                }
            }

        }

    }

    ////////////////////////////////////////////////////////////////////////////////////////// TAP DECORATION
    public void CheckCollider()
    {
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = gameProperties.GetComponent<xpManager>().GetLevel(currentXp);
        if (decorationLevelUnlock <= currentLevel)
            colliders.SetActive(true);
        else
            colliders.SetActive(false);


    }


    public void Tap()
    {
        bool popupOpen = gameProperties.GetComponent<tapManager>().popupOpen;

        if(!popupOpen)
            TapDecoration();
    }

    public void TapDecoration()
    {
        //////////////////// CHECK TUTO
        bool tutoOk = true;
        int currentTuto = gameProperties.GetComponent<tutorialManager>().currentTuto;
        if (decorationId != 0 && (currentTuto == 6 || currentTuto == 15 || currentTuto == 16))
            tutoOk = false;
        else if (decorationId == 0 && (currentTuto == 15 || currentTuto == 16))
            tutoOk = false;

        /////////////////// TAP
        if (tutoOk)
        {
            int currentLevel = gameProperties.GetComponent<xpManager>().currentLevel;

            /////////////////// TAP LOCKED DECO
            if (currentLevel < decorationLevelUnlock)
            {
                //ShowLock();
            }
            /////////////////// TAP DECO
            else
            {
                gameProperties.GetComponent<gardenManager>().ShowOptionsPopup(gameObject, decorationId, currentState, purchasePrice, xpReward);
                currentState = saveManager.GetSavedInt("decorationState_" + decorationId.ToString());
            }
        }

        HideFeedback();

    }


    ////////////////////////////////////////////////////////////////////////////////////////// OPTIONS
    public void ShowOption(int optionToShow)
    {
        //Debug.Log("Show option " + optionToShow);
        for (int i = 0; i < decorationOptions.Length; i++)
        {
            decorationOptions[i].SetActive(false);
        }
        for (int i = 0; i < selectionOutlines.Length; i++)
        {
            if (selectionOutlines[i])
                selectionOutlines[i].SetActive(false);
        }

            decorationOptions[optionToShow].SetActive(true);
        if (selectionOutlines[optionToShow])
            selectionOutlines[optionToShow].SetActive(true);
        //decorationOptions[optionToShow].GetComponent<Animation>().Play("a_select");

    }

    public void HideOptionsSelection()
    {
        //Debug.Log("Hide All Selection of " + gameObject.name);
        for (int i = 0; i < selectionOutlines.Length; i++)
        {
            if (selectionOutlines[i])
            {

                //Debug.Log("Hide Selection of " + gameObject.name+", outline "+i);
                selectionOutlines[i].SetActive(false);
            }
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////// FEEDBACK
    public void CheckFeedback()
    {
        //Debug.Log("Check garden feedback");
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = gameProperties.GetComponent<xpManager>().GetLevel(currentXp);
        int currentCoins = saveManager.GetSavedInt("currentCoins");

        if (currentState == 0)
        {
            if (decorationLevelUnlock <= currentLevel)
            {
                if (purchasePrice <= currentCoins)
                {
                    SetPurchasable();
                }

                else
                {
                    SetNotPurchasable();
                }
            }
            else
            {
                SetLocked();
            }
        }
        else
        {
            SetPurchased();

        }
    }



    public void SetLocked()
    {
        if (feedbackCollider)
            feedbackCollider.SetActive(false);
        if (purchasableFeedback)
            purchasableFeedback.SetActive(false);
        if (notPurchasableFeedback)
            notPurchasableFeedback.SetActive(false);
        if (purchaseCard)
            purchaseCard.SetActive(false);
        if (selectionOutlines[0])
            selectionOutlines[0].SetActive(false);
    }

    public void SetNotPurchasable()
    {
        if (feedbackCollider)
            feedbackCollider.SetActive(true);
        if (purchasableFeedback)
            purchasableFeedback.SetActive(false);
        if (notPurchasableFeedback)
            notPurchasableFeedback.SetActive(true);
        if (purchaseCard)
            purchaseCard.SetActive(true);
        if (selectionOutlines[0])
            selectionOutlines[0].SetActive(true);

        if (purchaseText)
            purchaseText.color = purchaseTextNotOk;
    }

    public void SetPurchasable()
    {
        if (feedbackCollider)
            feedbackCollider.SetActive(true);
        if (purchasableFeedback)
            purchasableFeedback.SetActive(true);
        if (notPurchasableFeedback)
            notPurchasableFeedback.SetActive(false);
        if (purchaseCard)
            purchaseCard.SetActive(true);
        if (selectionOutlines[0])
            selectionOutlines[0].SetActive(true);

        if (!purchaseText)
            Debug.Log(gameObject.name);

            purchaseText.color = purchaseTextOk;
    }

    public void SetPurchased()
    {
        if(feedbackCollider)
            feedbackCollider.SetActive(false);
        if (purchasableFeedback)
            purchasableFeedback.SetActive(false);
        if (notPurchasableFeedback)
            notPurchasableFeedback.SetActive(false);
        if (purchaseCard)
            purchaseCard.SetActive(false);
        if (selectionOutlines[0])
            selectionOutlines[0].SetActive(false);
    }
    public void HideFeedback()
    {
        if (feedbackCollider)
            feedbackCollider.SetActive(false);
        if (purchasableFeedback)
            purchasableFeedback.SetActive(false);
        if (notPurchasableFeedback)
            notPurchasableFeedback.SetActive(false);
        if (purchaseCard)
            purchaseCard.SetActive(false);
        if (selectionOutlines[0])
            selectionOutlines[0].SetActive(false);
    }

    public void CreateFeedback()
    {


        // INSTANTIATE
        purchaseCard = ObjectPool.SharedInstance.GetPooledObject("feedback_gardenPriceCard");
        purchasableFeedback = ObjectPool.SharedInstance.GetPooledObject("feedback_purchasable");
        notPurchasableFeedback = ObjectPool.SharedInstance.GetPooledObject("feedback_notPurchasable");
        feedbackCollider = ObjectPool.SharedInstance.GetPooledObject("feedback_collider");

        // PARENT
        purchaseCard.transform.SetParent(feedbackAnchor);
        purchasableFeedback.transform.SetParent(feedbackAnchor);
        notPurchasableFeedback.transform.SetParent(feedbackAnchor);
        feedbackCollider.transform.SetParent(feedbackAnchor);

        // POSITION & ROTATION RESET
        purchaseCard.transform.localPosition = Vector3.zero;
        purchasableFeedback.transform.localPosition = Vector3.zero;
        notPurchasableFeedback.transform.localPosition = Vector3.zero;
        feedbackCollider.transform.localPosition = Vector3.zero;

        purchaseCard.transform.localEulerAngles = Vector3.zero;
        purchasableFeedback.transform.localEulerAngles = Vector3.zero;
        notPurchasableFeedback.transform.localEulerAngles = Vector3.zero;
        feedbackCollider.transform.localEulerAngles = Vector3.zero;

        // PRICE TEXT
        purchaseText = purchaseCard.GetComponentInChildren<TextMeshPro>();
        purchaseText.text = purchasePrice.ToString();

        // CARD SCALING
        CardScaling();

    }
    void CardScaling()
    {
        // CARD TO SHOW
        int cardCount = textPos.Length;
        int currScale = 100;
        int scalePick = 0;
        for (int i = 0; i < cardCount; i++)
        {
            if (purchasePrice >= currScale)
                scalePick = i+1;
            currScale *= 10;
        }
        for (int i = 0; i < cardCount; i++)
            purchaseCard.transform.Find("card_" + i.ToString()).gameObject.SetActive(false);
        purchaseCard.transform.Find("card_" + scalePick.ToString()).gameObject.SetActive(true);

        // TEXT POSITION
        purchaseText.transform.localPosition = new Vector3(textPos[scalePick], purchaseText.transform.localPosition.y, purchaseText.transform.localPosition.z);

        // ICON POSITION
        Transform coinIcon = purchaseCard.transform.Find("icon");
        coinIcon.localPosition = new Vector3(iconPos[scalePick], coinIcon.localPosition.y, coinIcon.localPosition.z);

    }

    public void DestroyFeedback()
    {
        ObjectPool.SharedInstance.ReleaseObject(purchaseCard);
        ObjectPool.SharedInstance.ReleaseObject(purchasableFeedback);
        ObjectPool.SharedInstance.ReleaseObject(notPurchasableFeedback);
        ObjectPool.SharedInstance.ReleaseObject(feedbackCollider);
    }



}
