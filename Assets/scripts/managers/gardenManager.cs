using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gardenManager : MonoBehaviour
{
    [Header("START ROTATION ------------")]
    public Transform rotationGuide;
    public Transform decorationTransform;
    public Transform surroundingsTransform;


    [Header("MOVEMENT ------------")]
    public GameObject garden;
    public GameObject gardenMoveMaster;
    public float gardenMoveSpeed;

    // MIN AND MAX POSITIONS
    public Transform minXObject;
    public Transform maxXObject;
    public Transform minYObject;
    public Transform maxYObject;
    public float minPositionsOffset;

    // POSITIONS
    float posX;
    float posY;
    float posZ;
    float startPosX;
    float startPosY;
    float startPosZ;
    Vector3 gardenStartPosition;

    // SMOOTHNESS
    public float smoothness = 0;
    public float timeToRegularSmoothness;
    public float regularSmoothness;
    public float releaseSmoothness;
    float startTapTime;
    bool isMoving = false;
    private Vector3 velocity = Vector3.zero;

    [Header("PINCH ZOOM ------------")]
    public TextMeshProUGUI logText;
    public bool isZooming;
    public float zoomSensibility;
    public float minZoom;
    public float hardMinZoom;
    public float maxZoom;
    public float hardMaxZoom;
    public float zoomBackTime;
    public AnimationCurve clampAnimation;
    float startPinchDistance;
    float startCameraZoom;



    [Header("DECORATION ZOOM ------------")]
    public float defaultCamSize;
    public float focusCamSize;
    public float focusDelayIn;
    public float focusDelayOut;
    public float animTimeIn;
    public float animTimeOut;
    public AnimationCurve focusAnimIn;
    public AnimationCurve focusAnimOut;

    [Header("SWITCH ISLAND GARDEN ------------")]
    public GameObject filterObject;
    public float switchTime;
    public AnimationCurve mapMoveCurve;
    public float zoomOutSize;
    public float zoomInSize;
    public AnimationCurve mapZoomInCurve;
    public AnimationCurve mapZoomOutCurve;
    public float gardenOffset;
    public GameObject mapObject;
    public GameObject bottomPanel;
    public GameObject gardenButton;
    public GameObject islandButton;

    [Header("DECORATIONS ------------")]
    public float feedbackPopPace;
    public int currentlySelectedDecoration;
    public Transform decorationsParent;
    public gardenDecorationControler[] decorations;
    public GameObject selectedDecoration;

    [Header("OPTIONS POPUP ------------")]
    public bool popupIsOpen = false;
    // MOVE CAM
    public GameObject anchorCenter;
    public float translationTime;
    public AnimationCurve translateAnim;
    public GameObject optionsPopup;
    // BUTTONS
    public GameObject closeButton;
    public GameObject purchaseButton;
    public GameObject selectButton;
    public GameObject closeButtonTitle;
    public GameObject selectButtonTitle;
    // COINS
    public GameObject coinIcon;
    public TextMeshProUGUI purchasePriceText;
    // XP
    public GameObject xpIcon;
    public TextMeshProUGUI xpRewardText;
    // OPTIONS
    //public GameObject[] optionImages;
    public GameObject[] optionImagesSelection;
    int currentlySelectedOption;
    public RectTransform necCoins;


    [Header("FEEDBACK ------------")]
    public GameObject purchasableDecoration;
    public GameObject purchaseNotification;



    gardenData gardenData;
    saveManager saveManager;
    analyticsManager analyticsManager;
    adManager adManager;

    private void Awake()
    {
        saveManager = GetComponent<saveManager>();
    }

    void Start()
    {
        gardenData = GameObject.Find("balancingData").GetComponent<gardenData>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        adManager = GetComponent<adManager>();

        decorationTransform.rotation = rotationGuide.rotation;
        surroundingsTransform.rotation = rotationGuide.rotation;


        InitData();
        CheckPurchasable();
    }

    void InitData()
    {

        decorations = decorationTransform.GetComponentsInChildren<gardenDecorationControler>();
        for(int i = 0; i < decorations.Length; i++)
        {
            decorations[i].GetComponent<gardenDecorationControler>().decorationId = i;
            decorations[i].GetComponent<gardenDecorationControler>().InitDecoration();
            decorations[i].GetComponent<gardenDecorationControler>().CheckFeedback();
        }
    }


    private void Update()
    {
        logText.text = Camera.main.orthographicSize.ToString();
        ///////////////////////////////////////////////////  CALCULATE SMOOTHNESS
        smoothness = regularSmoothness;

        ///////////////////////////////////////////////////  FORCE MIN AND MAX
        if (isMoving)
        {
            if (gardenMoveMaster.transform.position.x <= minXObject.position.x)
                gardenMoveMaster.transform.position = new Vector3(minXObject.position.x, gardenMoveMaster.transform.position.y, gardenMoveMaster.transform.position.z);
            else if (gardenMoveMaster.transform.position.x >= maxXObject.position.x)
                gardenMoveMaster.transform.position = new Vector3(maxXObject.position.x, gardenMoveMaster.transform.position.y, gardenMoveMaster.transform.position.z);
            if (gardenMoveMaster.transform.position.z <= minYObject.position.z)
                gardenMoveMaster.transform.position = new Vector3(gardenMoveMaster.transform.position.x, gardenMoveMaster.transform.position.y, minYObject.position.z);
            else if (gardenMoveMaster.transform.position.z >= maxYObject.position.z)
                gardenMoveMaster.transform.position = new Vector3(gardenMoveMaster.transform.position.x, gardenMoveMaster.transform.position.y, maxYObject.position.z);

        }

    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// MOVING
    public void StartTappingGarden()
    {
        if (!isZooming)
        {
            Plane plane = new Plane(Vector3.up, 0);
            Vector3 worldPosition;
            float distance;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (plane.Raycast(ray, out distance))
            {
                worldPosition = ray.GetPoint(distance);
                startPosX = worldPosition.x;
                startPosY = worldPosition.y;
                startPosZ = worldPosition.z;

                gardenStartPosition = gardenMoveMaster.transform.position;
            }


            startTapTime = Time.time;
            isMoving = true;
        }

    }

    public void StopMovingGarden()
    {

        isMoving = false;

        ///////////////////////////////////////////////////  SMOOTH GO BACK IF CLOSE TO LIMITS
        if (gardenMoveMaster.transform.position.x <= (minXObject.position.x + minPositionsOffset))
            gardenMoveMaster.transform.position = new Vector3(minXObject.position.x + minPositionsOffset, gardenMoveMaster.transform.position.y, gardenMoveMaster.transform.position.z);
        else if (gardenMoveMaster.transform.position.x >= (maxXObject.position.x - minPositionsOffset))
            gardenMoveMaster.transform.position = new Vector3(maxXObject.position.x - minPositionsOffset, gardenMoveMaster.transform.position.y, gardenMoveMaster.transform.position.z);
        if (gardenMoveMaster.transform.position.z <= (minYObject.position.z + minPositionsOffset))
            gardenMoveMaster.transform.position = new Vector3(gardenMoveMaster.transform.position.x, gardenMoveMaster.transform.position.y, minYObject.position.z + minPositionsOffset);
        else if (gardenMoveMaster.transform.position.z >= (maxYObject.position.z - minPositionsOffset))
            gardenMoveMaster.transform.position = new Vector3(gardenMoveMaster.transform.position.x, gardenMoveMaster.transform.position.y, maxYObject.position.z - minPositionsOffset);

    }

    public void MoveGarden()
    {

        if (!popupIsOpen)
        {
            // CHECK TUTO
            bool tutoOk = true;
            int currentTuto = GetComponent<tutorialManager>().currentTuto;
            if (currentTuto == 6 || currentTuto == 15 || currentTuto == 16)
                tutoOk = false;

            // MOVE IF TUTO OK
            if (tutoOk)
            {
                Plane plane = new Plane(Vector3.up, 0);
                Vector3 worldPosition;
                float distance;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (plane.Raycast(ray, out distance))
                {
                    worldPosition = ray.GetPoint(distance);
                    posX = (worldPosition.x - startPosX) * gardenMoveSpeed;
                    posY = (worldPosition.y - startPosY) * gardenMoveSpeed;
                    posZ = (worldPosition.z - startPosZ) * gardenMoveSpeed;

                    Vector3 translation = new Vector3(posX, posY, posZ);
                    gardenMoveMaster.transform.position = gardenStartPosition + translation;
                }
            }
        }

    }



    void LateUpdate()
    {

        Vector3 targetPosition = gardenMoveMaster.transform.position;
        garden.transform.position = Vector3.SmoothDamp(garden.transform.position, targetPosition, ref velocity, smoothness);

    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ZOOM
    public void StartZoom(Vector2 finger1, Vector2 finger2)
    {
        isZooming = true;
        isMoving = false;
        startPinchDistance = currentPinchDistance(finger1, finger2);
        startCameraZoom = Camera.main.orthographicSize;
    }

    public void StopZoom()
    {
        if (isZooming)
        {
            isZooming = false;
            if (Camera.main.orthographicSize <= minZoom)
                StartCoroutine(ClampZoom(minZoom));
            else if (Camera.main.orthographicSize >= maxZoom)
                StartCoroutine(ClampZoom(maxZoom));

        }
    }


    public void Zooming(Vector2 finger1, Vector2 finger2)
    {

        if (!popupIsOpen)
        {
            float currentDistance = currentPinchDistance(finger1, finger2);
            float percentDiff = (currentDistance - startPinchDistance) / Screen.width;
            float offsetToApply = percentDiff * zoomSensibility;
            float newZoom = startCameraZoom - offsetToApply;
            if (newZoom <= hardMinZoom)
                newZoom = hardMinZoom;
            else if (newZoom >= hardMaxZoom)
                newZoom = hardMaxZoom;
            Camera.main.orthographicSize = newZoom;
        }

    }


    IEnumerator ClampZoom(float targetSize)
    {
        float startTime = Time.time;
        float startSize = Camera.main.orthographicSize;

        while (Time.time < startTime + zoomBackTime)
        {
            float proportion = (Time.time - startTime) / zoomBackTime;
            float evaluation = clampAnimation.Evaluate(proportion);
            float cameraSize = startSize + (targetSize - startSize) * evaluation;

            Camera.main.orthographicSize = cameraSize;

            yield return null;
        }
    }

    float currentPinchDistance(Vector2 finger1, Vector2 finger2)
    {

        float distance = Vector2.Distance(finger1, finger2);
        logText.text = "Current distance: " + distance;

        return distance;
    }



    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SWITCH ISLAND <-> GARDEN
    public void GoToGarden()
    {
        bool tutoOk = true;
        //int currentTuto = GetComponent<tutorialManager>().currentTuto;
        //if (currentTuto == 17)
        //    tutoOk = false;

        GetComponent<tutorialManager>().HideInfoTuto();

        if (tutoOk)
        {
            GetComponent<tapManager>().isGardenFocus = true;
            if(saveManager.GetSavedInt("tutorialCompleted")!=0)
                GetComponent<islandManager>().HideArrows();
            bottomPanel.GetComponent<Animation>().Play("bottomPanel_hide");
            StartCoroutine(MoveMap(gardenOffset, true));
            StartCoroutine(CameraAnimation());
        }

        //// CHECK TUTO
        CheckTuto("goToGarden");
    }

    public void GoToIsland()
    {
        bool tutoOk = true;
        int currentTuto = GetComponent<tutorialManager>().currentTuto;
        int currentLevel = GetComponent<xpManager>().currentLevel;
        if (currentTuto == 6 || currentTuto == 15 || currentLevel ==1)
            tutoOk = false;

        if (tutoOk)
        {
            GetComponent<tapManager>().isGardenFocus = false;
            bottomPanel.GetComponent<Animation>().Play("bottomPanel_hide");
            StartCoroutine(MoveMap(0f, false));
            StartCoroutine(CameraAnimation());

            //// CHECK TUTO
            CheckTuto("goToIsland_direct");

        }



    }

    IEnumerator MoveMap(float targetPosition, bool goingToGarden) 
    {
        /////////////////////////////////////FILTER
        filterObject.GetComponent<Animation>().Play("a_filterTransition");


        float startTime = Time.time;
        float startPosition = mapObject.transform.position.z;

        while (Time.time < startTime + switchTime)
        {
            //////////////////////////////////// MOVE MAP
            float proportion = (Time.time - startTime) / switchTime;
            float evaluation = mapMoveCurve.Evaluate(proportion);
            float position = startPosition + (targetPosition - startPosition) * evaluation;
            mapObject.transform.position = new Vector3(mapObject.transform.position.x, mapObject.transform.position.y, position);

            yield return null;
        }



        //////////////////////////////////// ACTIVATE DEACTIVATE BUTTONS
        gardenButton.SetActive(!goingToGarden);
        islandButton.SetActive(goingToGarden);


        //////////////////////////////////// MOVE BUTTONS BACK
        bottomPanel.GetComponent<Animation>().Play("bottomPanel_show");
        yield return new WaitForSeconds(51/60);

    }

    IEnumerator CameraAnimation()
    {

        yield return new WaitForSeconds(switchTime/2);

        //////////////////////////////////// CAMERA
        Camera.main.orthographicSize = defaultCamSize;

        adManager.ShowInterstitialVideoAd("travel");


        yield return new WaitForSeconds(switchTime / 2);

        if (!GetComponent<tapManager>().isGardenFocus)
            GetComponent<islandManager>().ShowArrows();

        CheckTuto("goToIsland_camera");


        yield return null;
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// POPUP
    public void ShowOptionsPopup(GameObject selectDeco, int decorationId, int currentState, int purchasePrice, int xpReward)
    {
        //Debug.Log("Show option popup");
        //Debug.Log(" Currently selected: " + selectedDecoration.name);
        //Debug.Log(" Newly selected: " + selectDeco.name);
        ////////////////////////////////////////////////////// ANIMATE CAMERA
        if (!popupIsOpen)
            StartCoroutine(CameraZoom("in"));

        ////////////////////////////////////////////////////// REDO PURCHASE FEEDBACK
        if (selectedDecoration)
            selectedDecoration.GetComponent<gardenDecorationControler>().CheckFeedback();


        ////////////////////////////////////////////////////// PREVIEW ITEM ON MAP        
        if (popupIsOpen)
        {
            int oldState = selectedDecoration.GetComponent<gardenDecorationControler>().currentState;
            if(oldState ==0)
                selectedDecoration.GetComponent<gardenDecorationControler>().ShowOption(oldState);
        }

        ////////////////////////////////////////////////////// HIDE SELECTION ON PREVIOUSLY SELECTED DECO
        if (popupIsOpen)
            selectedDecoration.GetComponent<gardenDecorationControler>().HideOptionsSelection();

        ////////////////////////////////////////////////////// SET SELECTION
        currentlySelectedDecoration = decorationId;
        selectedDecoration = selectDeco;


        ////////////////////////////////////////////////////// SHOW HIDE BUTTONS
        if (currentState == 0)
        {
            purchaseButton.SetActive(true);
            closeButton.SetActive(true);
            selectButton.SetActive(false);
            closeButtonTitle.GetComponent<autoSizeText>().RedoFontSize();
        }

        else
        {
            purchaseButton.SetActive(false);
            closeButton.SetActive(false);
            selectButton.SetActive(true);
            selectButtonTitle.GetComponent<autoSizeText>().RedoFontSize();
        }


        ////////////////////////////////////////////////////// UPDATE VALUES
        /// PRICE
        purchasePriceText.text = purchasePrice.ToString();
        if (currentState == 0)
        {
            // TEXT
            int currentCoins = saveManager.GetSavedInt("currentCoins");
            if (purchasePrice <= currentCoins)
                purchasePriceText.color = Color.white;
            else
                purchasePriceText.color = Color.red;
            // POSITION
            PositionCoin(purchasePrice);
            purchasePriceText.GetComponent<autoSizeText>().RedoFontSize();

        }
        /// XP
        xpRewardText.text = xpReward.ToString();
        xpRewardText.GetComponent<autoSizeText>().RedoFontSize();
        // POSITION
        PositionXp(xpReward);

        /// IMAGES
        //for (int i=0;i< optionImages.Length; i++)
        //    optionImages[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("UI/icons/gardenOptions/option_" + decorationId + "_" + (i+1).ToString());

        ////////////////////////////////////////////////////// ANIMATION
        if (!popupIsOpen)
        {
            bottomPanel.GetComponent<Animation>().Play("bottomPanel_hide");
            optionsPopup.GetComponent<Animation>().Play("a_show");
            optionsPopup.GetComponent<GraphicRaycaster>().enabled = true;

        }
        else
        {
            optionsPopup.GetComponent<Animation>().Play("a_update");
            optionsPopup.GetComponent<GraphicRaycaster>().enabled = true;
        }


        ////////////////////////////////////////////////////// PRESELECT OPTION
        if (currentState == 0)
            currentState = 1;
        currentlySelectedOption = currentState;
        SelectOption(currentState);

        ////////////////////////////////////////////////////// MOVE GARDEN TO FOCUS ON DECORATION
        StartCoroutine(TranslateGarden());


        ////////////////////////////////////////////////////// SHOW THE PROPER SELECTION FEEDBACK
        for (int i = 0; i < optionImagesSelection.Length; i++)
            optionImagesSelection[i].SetActive(false);
        optionImagesSelection[currentState - 1].SetActive(true);

        //// CHECK TUTO
        CheckTuto("showOptions");


        popupIsOpen = true;
    }

    IEnumerator CameraZoom(string zoomType)
    {
        float targetFocus =0;
        if (zoomType == "in")
            targetFocus = focusCamSize;
        else if (zoomType == "out")
            targetFocus = defaultCamSize;

        float startTime = Time.time;
        float startingFocus = Camera.main.orthographicSize;
        float maxSizeDiff = targetFocus - startingFocus;

        yield return new WaitForSeconds(focusDelayIn);

        while(Time.time < startTime + animTimeIn)
        {
            float proportion = (Time.time - startTime) / animTimeIn;
            float evaluation = focusAnimIn.Evaluate(proportion);
            float camSize = startingFocus + (maxSizeDiff * evaluation);
            Camera.main.orthographicSize = camSize;
            yield return null;
        }


    }



    void PositionCoin(int purchasePrice)
    {
        float valueCoin = 0;
        float valueText = 0;

        if (purchasePrice < 100)
        {
            valueCoin = 0.47f;
            valueText = 0.53f;
        }

        else if (purchasePrice < 1000)
        {
            valueCoin = 0.42f;
            valueText = 0.48f;
        }

        else
        {
            valueCoin = 0.35f;
            valueText = 0.38f;
        }

        coinIcon.GetComponent<RectTransform>().anchorMin = new Vector2(0.15f, 0.37f);
        coinIcon.GetComponent<RectTransform>().anchorMax = new Vector2(valueCoin, 0.81f);
        coinIcon.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        coinIcon.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);

        purchasePriceText.GetComponent<RectTransform>().anchorMin = new Vector2(valueText, 0.34f);
        purchasePriceText.GetComponent<RectTransform>().anchorMax = new Vector2(0.89f, 0.85f);
        purchasePriceText.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        purchasePriceText.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);

    }

    void PositionXp(int xpReward)
    {
        float valueXp = 0;
        float valueText = 0;

        if (xpReward < 10)
        {
            valueXp = 0.6f;
            valueText = 0.54f;
        }

        else if (xpReward < 100)
        {
            valueXp = 0.56f;
            valueText = 0.54f;
        }

        else if (xpReward < 1000)
        {
            valueXp = 0.54f;
            valueText = 0.52f;
        }

        else
        {
            valueXp = 0.51f;
            valueText = 0.5f;
        }

        xpIcon.GetComponent<RectTransform>().anchorMin = new Vector2(0.18f, 0f);
        xpIcon.GetComponent<RectTransform>().anchorMax = new Vector2(valueXp, 1f);
        xpIcon.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        xpIcon.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);

        xpRewardText.GetComponent<RectTransform>().anchorMin = new Vector2(valueText, 0f);
        xpRewardText.GetComponent<RectTransform>().anchorMax = new Vector2(0.9f, 1f);
        xpRewardText.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        xpRewardText.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);

    }

    IEnumerator TranslateGarden()
    {

        //////////////////////////////////// MOVE MAP
        float startTime = Time.time;
        Vector3 startPosition = garden.transform.position;
        float diffX = anchorCenter.transform.position.x - selectedDecoration.GetComponent<gardenDecorationControler>().centerViewTransform.position.x;
        float diffY = anchorCenter.transform.position.y - selectedDecoration.GetComponent<gardenDecorationControler>().centerViewTransform.position.y;
        float diffZ = anchorCenter.transform.position.z - selectedDecoration.GetComponent<gardenDecorationControler>().centerViewTransform.position.z;
        Vector3 targetPosition = new Vector3(startPosition.x + diffX, startPosition.y + diffY, startPosition.z + diffZ);

        while (Time.time < startTime + translationTime)
        {
            float proportion = (Time.time - startTime) / translationTime;
            float evaluation = translateAnim.Evaluate(proportion);
            Vector3 position = startPosition + (targetPosition - startPosition) * evaluation;
            garden.transform.position = position;
            gardenMoveMaster.transform.position = position;

            yield return null;
        }


    }

    public void HideOptionsPopup(string closeType)
    {
        ////////////////////// CLOSE TYPES
        /// close -> close button
        /// openSettings
        /// levelup
        /// selectDecoration
        /// selectLockedDecoration
        /// purchase


        bool tutoOk = true;
        int currentTuto = GetComponent<tutorialManager>().currentTuto;
        if (currentTuto == 15 && closeType =="close")
            tutoOk = false;

        if (tutoOk)
        {
            optionsPopup.GetComponent<GraphicRaycaster>().enabled = false;

            /////////////////////////////////////////// ANIMATE THE POPUP
            bottomPanel.GetComponent<Animation>().Play("bottomPanel_slowShow");
            if (closeType == "select" || closeType == "purchase")
                optionsPopup.GetComponent<Animation>().Play("a_select");
            else
                optionsPopup.GetComponent<Animation>().Play("a_close");

            /////////////////////////////////////////// HIDE THE SELECTION
            selectedDecoration.GetComponent<gardenDecorationControler>().HideOptionsSelection();

            /////////////////////////////////////////// put back to previous state
            if (closeType == "selectDecoration" || closeType == "close" || closeType == "openSettings" || closeType == "levelup")
            {
                int currentState = selectedDecoration.GetComponent<gardenDecorationControler>().currentState;
                selectedDecoration.GetComponent<gardenDecorationControler>().ShowOption(currentState);
            }

            /////////////////////////////////////////// REFRESH FEEDBACK
            selectedDecoration.GetComponent<gardenDecorationControler>().CheckFeedback();


            /////////////////////////////////////////// CAMERA ZOOM OUT
            if(closeType != "selectDecoration" || (closeType == "selectDecoration" && popupIsOpen) || (closeType == "selectLockedDecoration" && popupIsOpen) || (closeType == "levelup"))
                StartCoroutine(CameraZoom("out"));

            // BOOL
            StartCoroutine(PopupOpenDelay());
        }

    }

    IEnumerator PopupOpenDelay()
    {
        yield return new WaitForSeconds(0.1f);

        popupIsOpen = false;

        yield return null;
    }

    public void SelectOption(int optionSelected)
    {

        // Show hide the selection feedback
        for (int i = 0; i < optionImagesSelection.Length; i++)
            optionImagesSelection[i].SetActive(false);

        currentlySelectedOption = optionSelected;

        // preview item in map
        selectedDecoration.GetComponent<gardenDecorationControler>().ShowOption(optionSelected);

        if (selectedDecoration.GetComponent<gardenDecorationControler>().currentState != 0)
            ValidateOption();

        optionImagesSelection[optionSelected - 1].SetActive(true);
    }

    public void PurchaseOption()
    {
        CheckTuto("purchase");

        // spend coins
        int currentCoins = saveManager.GetSavedInt("currentCoins");
        int purchasePrice = gardenData.unlockPrice[currentlySelectedDecoration];
        int xpReward = selectedDecoration.GetComponent<gardenDecorationControler>().xpReward;
        if (purchasePrice <= currentCoins)
        {
            selectedDecoration.GetComponent<gardenDecorationControler>().DestroyFeedback();
            GetComponent<coinManager>().SpendCoins(purchasePrice);
            ValidateOption();
            GetComponent<feedbackManager>().CoinSpawn(xpReward, selectedDecoration, 0f, "xp");
            selectedDecoration.GetComponent<gardenDecorationControler>().HideFeedback();
            HideOptionsPopup("purchase");
        }
        else
            GetComponent<necManager>().ShowNec("coins");


    }

    public void ValidateOption()
    {
        // visuals
        selectedDecoration.GetComponent<gardenDecorationControler>().ShowOption(currentlySelectedOption);
        //selectedDecoration.GetComponent<gardenDecorationControler>().HideOptionsSelection();

        // locale data
        selectedDecoration.GetComponent<gardenDecorationControler>().currentState = currentlySelectedOption;

        // save
        SaveDecorationState(currentlySelectedDecoration, currentlySelectedOption);
        //saveManager.SaveInt("decorationState_" + currentlySelectedDecoration.ToString(), currentlySelectedOption);
        //saveManager.SaveDecorationOption(currentlySelectedDecoration, currentlySelectedOption);

    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// FEEDBACK
    public IEnumerator CheckAllFeedbackAndColliders()
    {

        int currentLevel = GetComponent<xpManager>().currentLevel;
        int currentCoins = saveManager.GetSavedInt("currentCoins");
        for (int i = 0; i < decorations.Length; i++)
        {
            int decorationLevelUnlock = decorations[i].GetComponent<gardenDecorationControler>().decorationLevelUnlock;
            int currentState = saveManager.GetSavedInt("decorationState_" + decorations[i].GetComponent<gardenDecorationControler>().decorationId.ToString());
            if (currentLevel == decorationLevelUnlock && currentState == 0)
            {
                yield return new WaitForSeconds(feedbackPopPace);
                decorations[i].CreateFeedback();
                decorations[i].CheckCollider(); 
                if (decorations[i].purchasePrice <= currentCoins)
                    decorations[i].SetPurchasable();

                else
                    decorations[i].SetNotPurchasable();
            }
        }

        yield return null;
    }

    public void CheckPurchasable()
    {
        bool canPurchase = false;
        int currentLevel = GetComponent<xpManager>().currentLevel;
        int currentCoins = saveManager.GetSavedInt("currentCoins");

        for (int i = 0; i < decorations.Length; i++)
        {
            if (decorations[i].currentState == 0)
            {
                if (decorations[i].decorationLevelUnlock <= currentLevel)
                {
                    if (decorations[i].purchasePrice <= currentCoins)
                    {
                        if(!canPurchase)
                        purchasableDecoration = decorations[i].gameObject;
                        decorations[i].SetPurchasable();
                        canPurchase = true;
                    }

                    else
                    {
                        decorations[i].SetNotPurchasable();
                    }
                }
                else
                {
                    decorations[i].SetLocked();
                }
            }
            else
            {
                decorations[i].SetPurchased();

            }
        }


        if (canPurchase && !GetComponent<tapManager>().isGardenFocus)
        {
            FocusViewOnPurchasable();
        }
        else
            purchaseNotification.SetActive(false);


    }

    public void FocusViewOnPurchasable()
    {

        ////////////////////////////////////////////////////// MOVE GARDEN TO FOCUS ON DECORATION
        selectedDecoration = purchasableDecoration;
        purchaseNotification.SetActive(true);
        StartCoroutine(TranslateGarden());
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TUTO
    public void CheckTuto(string source)
    {
        /*
        if (GetComponent<tutorialManager>().currentTuto == 5)
        {
            analyticsManager.ContinueFunnel("mainTutorial", "tapGardenButton");
            GetComponent<tutorialManager>().HideTuto(5);
            GetComponent<tutorialManager>().ShowTuto(6, true);
        }

        else if (GetComponent<tutorialManager>().currentTuto == 6 && source =="showOptions")
        {
            analyticsManager.ContinueFunnel("mainTutorial", "tapDeco");
            GetComponent<tutorialManager>().HideTuto(6);
            GetComponent<tutorialManager>().ShowTuto(15, true);
        }

        
        else if (GetComponent<tutorialManager>().currentTuto == 15 && source == "purchase")
        {
            GetComponent<tutorialManager>().HideTuto(15);
            //analyticsManager.ContinueFunnel("mainTutorial_v2", 18);
            //GetComponent<tutorialManager>().ShowTuto(16, true);
        }
        
        
        else if (GetComponent<tutorialManager>().currentTuto == 16)
        {
            analyticsManager.ContinueFunnel("mainTutorial", "tapIslandButton");
            GetComponent<tutorialManager>().HideTuto(16);
            GetComponent<tutorialManager>().ShowTuto(17, true);
        }

        if(source == "goToIsland_camera")
        {
            if (!GetComponent<tapManager>().isGardenFocus)
            {
                int currentLevel = GetComponent<xpManager>().currentLevel;
                if (currentLevel == 21)
                {
                    if (saveManager.GetSavedInt("islandTutorialCompleted") == 0)
                    {
                        //Debug.Log("Show island tuto");
                        SaveIsland2TutoProgress();
                        GetComponent<tutorialManager>().ShowTuto(19, true);
                    }
                }
            }
        }
        */
        
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    public void SaveDecorationState(int currentlySelectedDecoration, int currentlySelectedOption)
    {
        saveManager.SaveInt("decorationState_" + currentlySelectedDecoration.ToString(), currentlySelectedOption);   // Save decoration state
    }

    void SaveIsland2TutoProgress()
    {
        saveManager.SaveInt("islandTutorialCompleted", 1);
    }

}
