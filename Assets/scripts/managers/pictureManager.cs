using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class pictureManager : MonoBehaviour
{

    [Header("MOVING PICTURES")]
    public int currentSeenPicture;
    int newPictureSeen;
    public int pictureCount;

    // AARROWS MOVE
    public Transform arrowLeft;
    public Transform arrowRight;
    public float arrowInMoveTime;
    public AnimationCurve arrowInAnimation;

    public float arrowOutMoveTime;
    public AnimationCurve arrowOutAnimation;


    // PICTURE MOVE
    public RectTransform pictureContainer;
    public AnimationCurve pictureMoveAnim;
    public float moveTime;
    float pictureDisplacement;


    [Header("OBJECTS")]
    public GameObject picturePopup;
    public GameObject[] picturesLocked;
    public GameObject[] picturesUnlocked;

    [Header("PRICES")]
    public pictureBalancing pictureBalancing;
    //public GameObject[] picturePartsCoins;
    //public int[] picturePrice;
    public TextMeshProUGUI[] picturePriceTexts;

    [Header("NOTIF")]
    public GameObject notificationFeedback;

    [Header("MISC")]
    public GameObject[] pictureParts;
    public Image[] pictureButtonsColored;
    public GameObject[] pictureButtons;
    public Color unlockedColor;
    public Color lockedColor;
    public Color unlockedColorText;
    public Color lockedColorText;
    tutorialManager tutoManager;
    analyticsManager analyticsManager;
    saveManager saveManager;

    bool resizeHasBeenDone = false;




    ////////////////////////////////////////////////////////////////////////// INITIATE 
    private void Awake()
    {
        //Debug.LogWarning("Awake");
        tutoManager = GetComponent<tutorialManager>();
        saveManager = GetComponent<saveManager>();
        pictureBalancing = GameObject.Find("balancingData").GetComponent<pictureBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        //InitBalancing();
    }

    void Start()
    {

        InitiatePictures();
        UpdateNotification();


        ///////////////////////////////////////////// SET VALUES FOR PICTURES MOVEMENTS
        currentSeenPicture = 0;
        pictureDisplacement = Screen.width;

    }

    public void InitiatePictures()
    {
        for(int i = 0; i < pictureParts.Length; i++)
        {
            ///////////////////////////////////////////// SET LOCKED/UNLOCKED
            int isUnlocked = saveManager.GetSavedInt("picture_" + i.ToString() + "_isUnlocked");
            if (isUnlocked > 0)
                DisablePicture(i);
            else
                EnablePicture(i);


            //////////////////////////////////////////// SETUP BUTTON COLORS
            int currentCoins = saveManager.GetSavedInt("currentCoins");
            if (currentCoins >= pictureBalancing.picturePrices[i])
                PicturePartSetLock(i, true);
            else
                PicturePartSetLock(i, false);
        }


    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// LOCK 
    public void DisablePicture(int pictureID)
    {

        pictureButtons[pictureID].gameObject.SetActive(false);
        picturesLocked[pictureID].gameObject.SetActive(false);

    }


    void EnablePicture(int pictureID)
    {

        pictureButtons[pictureID].gameObject.SetActive(true);
        picturesLocked[pictureID].gameObject.SetActive(true);

        //Debug.Log("Redo picture price text size");
        picturePriceTexts[pictureID].text = pictureBalancing.picturePrices[pictureID].ToString();
        
        if(!resizeHasBeenDone)
            picturePriceTexts[pictureID].GetComponent<autoSizeText>().RedoFontSize();
        
    }

    public void PicturePartSetLock( int pictureId, bool unlocked)
    {
        if (unlocked)
        {
            pictureButtonsColored[pictureId].color = unlockedColor;
            picturePriceTexts[pictureId].color = unlockedColorText;
        }

        else
        {
            pictureButtonsColored[pictureId].color = lockedColor;
            picturePriceTexts[pictureId].color = lockedColorText;
        }


    }


    public void TryUnlockPicture(int pictureID)
    {

        int isUnlocked = saveManager.GetSavedInt("picture_" + pictureID.ToString() + "_isUnlocked");
        if (isUnlocked == 0)
        {
            int currentCoins = saveManager.GetSavedInt("currentCoins");
            if (currentCoins >= pictureBalancing.picturePrices[pictureID])
            {
                UnlockPicture(pictureID);
                GetComponent<coinManager>().SpendCoins(pictureBalancing.picturePrices[pictureID]);
            }
        }

    }

    public void UnlockPicture(int pictureID)
    {
        PlayerPrefs.SetInt("picture_" + pictureID.ToString() + "_isUnlocked", 1);
        pictureParts[pictureID].GetComponent<Animation>().Play("picture_popup_collect");
        //Debug.Log("Unlock picture" + pictureID);

        CheckTutorial("unlockPicture");

    }


    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TUTORIAL UI
    public void ShowPicture()
    {

        GameObject.Find("gameProperties").GetComponent<tapManager>().popupOpen = true;
        //picturePopup.SetActive(true);
        picturePopup.GetComponent<Animation>().Play("picture_popup_open");
        InitiatePictures();

        CheckTutorial("showPicture");

        resizeHasBeenDone = true;

        if (currentSeenPicture>0)
            arrowLeft.localScale = new Vector3(1, 1, 1);
        else
            arrowLeft.localScale = new Vector3(0, 0, 0);

        if (currentSeenPicture < pictureCount-1)
            arrowRight.localScale = new Vector3(1, 1, 1);
        else
            arrowRight.localScale = new Vector3(0, 0, 0);



    }

    public void ClosePicture()
    {
        if (CloseTutorialOk())
        {
            GameObject.Find("gameProperties").GetComponent<tapManager>().popupOpen = false;
            picturePopup.GetComponent<Animation>().Play("picture_popup_close");
        }

        CheckTutorial("closePicture");


    }




    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// TUTORIAL
    void CheckTutorial(string lastAction)
    {
        if(lastAction == "showPicture")
        {
            //GetComponent<tutorialManager>().HideTuto(5);
            if (pictureBalancing.picturePrices[0] <= PlayerPrefs.GetInt("currentCoins") && PlayerPrefs.GetInt("picture_0_isUnlocked") == 0 && GetComponent<tapManager>().popupOpen)
            {
                /*
                analyticsManager.ContinueFunnel("mainTutorial", 16);
                GetComponent<tutorialManager>().ShowTuto(6, true);
                */
            }
        }

        if (lastAction == "unlockPicture")
        {
           // Debug.Log("check tuto. Picture 1 unlocked ==" + PlayerPrefs.GetInt("picture_1_isUnlocked"));
            int picturesUnlocked = 0;
            for(int i = 0; i < pictureParts.Length; i++)
            {
                if (PlayerPrefs.GetInt("picture_" + i.ToString() + "_isUnlocked") > 0)
                    picturesUnlocked++;
            }


            if (picturesUnlocked ==1)
            {
               // GetComponent<tutorialManager>().HideTuto(6);
                //GetComponent<tutorialManager>().ShowTuto(15, true);
                //GetComponent<tutorialManager>().currentTuto = 0;
                //analyticsManager.ContinueFunnel("mainTutorial_v2", 17);
            }
        }

        if (lastAction == "closePicture")
        {
            /*
            if (PlayerPrefs.GetInt("picture_0_isUnlocked") == 1)
            {
                GetComponent<tutorialManager>().HideTuto(15);
                analyticsManager.CompleteFunnel("mainTutorial");
            }
            */
        }

    }

    bool CloseTutorialOk()
    {
        bool tutorialOk = false;

        int currentTuto = tutoManager.currentTuto;

        if (currentTuto == 5 || currentTuto == 0)
            tutorialOk = true;


        return tutorialOk;


    }




    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// NOTIFICATION
    public void UpdateNotification()
    {
        int currentCoins = GetComponent<coinManager>().currentCoins;
        bool canPurchase = false;
        for (int i = 0; i < pictureParts.Length; i++)
        {
            int isUnlocked = PlayerPrefs.GetInt("picture_" + i.ToString() + "_isUnlocked");
            //Debug.Log("picture manager " + i);
            if (isUnlocked == 0 && currentCoins >= pictureBalancing.picturePrices[i])
            {
                canPurchase = true;
            }

        }

        if (canPurchase)
            notificationFeedback.SetActive(true);
        else
            notificationFeedback.SetActive(false);



    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////ARROWS
    public void TapArrow(string side)
    {

        //Debug.Log("tap arrow right");

        //if(currentSeenPicture<(pictureCount-1))
        if (side == "left")
            MoveArrowLeft();
        else if (side == "right")
            MoveArrowRight();

    }

    void MoveArrowRight()
    {
        StartCoroutine(MovePicture(currentSeenPicture, currentSeenPicture +1 ));
        newPictureSeen = currentSeenPicture + 1;
    }


    void MoveArrowLeft()
    {
        StartCoroutine(MovePicture(currentSeenPicture, currentSeenPicture - 1));
        newPictureSeen = currentSeenPicture - 1;

    }
    IEnumerator MovePicture(float startPicture, float targetPicture)
    {
        /*
        Debug.Log("Start enum move");
        Debug.Log("Width: "+pictureDisplacement);
        */
        float startPos = startPicture * pictureDisplacement;
        float targetPos = targetPicture * pictureDisplacement;
        float startTime = Time.time;

        while (Time.time<startTime + moveTime)
        {
            ////////////////// ANIMATE THE PICTURE PANEL
            float proportion = (Time.time - startTime) / moveTime;
            float evaluation = pictureMoveAnim.Evaluate(proportion);
            float position = startPos + (targetPos - startPos) * evaluation;
            pictureContainer.offsetMin = new Vector2(-position, 0);
            pictureContainer.offsetMax = new Vector2(-position, 0);

            ////////////////// ARROWS
            float arrowProportion = (Time.time - startTime) / arrowOutMoveTime;
            float arrowEvaluation = arrowOutAnimation.Evaluate(arrowProportion);
            float scale = 1f - (1f*evaluation);
            if (currentSeenPicture > 0)
                arrowLeft.localScale = new Vector3(scale, scale, scale);
            if(currentSeenPicture< (pictureCount -1))
                arrowRight.localScale = new Vector3(scale, scale, scale);


            yield return null;

        }
        /*
        Debug.Log("Stop phase 1");
        Debug.Log("Start phase 2");
        */
        ////////////////// ARROWS BACK IN
        startTime = Time.time;
        while (Time.time < startTime + arrowInMoveTime)
        {

            float proportion = (Time.time - startTime) / arrowInMoveTime;
            float evaluation = arrowInAnimation.Evaluate(proportion);
            float scale = 0 + (1f * evaluation);
            if (newPictureSeen > 0)
                arrowLeft.localScale = new Vector3(scale, scale, scale);
            if (newPictureSeen < (pictureCount - 1))
                arrowRight.localScale = new Vector3(scale, scale, scale);


            yield return null;

        }

        currentSeenPicture = newPictureSeen;



    }

}
