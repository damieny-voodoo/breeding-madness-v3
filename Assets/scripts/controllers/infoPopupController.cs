using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class infoPopupController : MonoBehaviour
{
    itemBalancing itemBalancing;
    tapManager tapManager;
    localizerManager localizerManager;
    [Header("ITEM ID ------------")]
    public int itemTier;
    public string itemFamily;
    public int familyId;
    public int familyMaxTier;
    public int currentMaxUnlocked;

    [Header("OBJECTS ------------")]
    public Image selectedFeedback;
    public Image[] itemImg;
    public GameObject[] arrows;
    public GameObject[] questions;
    public Image[] itemBg;
    public TextMeshProUGUI familyTitle;

    [Header("COLORS ------------")]
    public Color bgLockedColor;
    public Color imgLockedColor;
    public Color arrowLockedColor;


    public Color imgUnlockedColor;
    //public Color[] familyColors;

    [Header("DATA ------------")]
    //string[] familyIds;
    //string[,] familyNames;
    //int[] maxItems;
    //string[] spawners;


    [Header("SCROLL VIEW ------------")]
    public float itemsPerScreen = 2.5f;
    //float widthToHeight = (502 / 364);
    float imgWidth;
    float imgHeight;
    public GameObject[] imgParent;
    public GameObject scrollView;
    public float arrowsProportion = .25f;
    public Vector3 selectedPictureScale;
    public Image itemsBackground;
    public Image itemsBackground_line1;
    public Image itemsBackground_line2;
    public Color[] bgColor;
    public Color[] bgColor_lines;
    public RectTransform scrollContent;
    public float scrollDragDelay;
    public AnimationCurve dragAnimation;
    public float dragMoveTime;

    saveManager saveManager;


    void Start()
    {
        saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
        tapManager = GameObject.Find("gameProperties").GetComponent<tapManager>();
        localizerManager = GameObject.Find("gameProperties").GetComponent<localizerManager>();
        itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
    }

    public void ShowPopup(string family, int tier)
    {
        bool popupOpen = GameObject.Find("gameProperties").GetComponent<tapManager>().popupOpen;
        if (!popupOpen)
        {
            gameObject.SetActive(true);
            GetComponent<GraphicRaycaster>().enabled = true;
            tapManager.OpenPopup();
            GetComponent<Animation>().Play("infoPopup_open");


            /////////////////////////////////////// DATA ABOUT THE ITEM TAPPED
            UpdateItemData(family, tier);


            /////////////////////////////////////// SHOW
            ShowInfo();
        }



    }

    void UpdateItemData(string family, int tier)
    {
        // GET DATA TO SHOW
        itemFamily = family;
        itemTier = tier;
        currentMaxUnlocked = saveManager.GetSavedInt(itemFamily + "_progress");
        familyId = 0;
        bool idPicked = false;
        for (int i = 0; i < itemBalancing.familyNames.Length; i++)
        {
            if (!idPicked)
            {
                if (itemBalancing.familyNames[i] == itemFamily)
                {
                    familyId = i;
                    idPicked = true;
                }
            }
        }
        familyMaxTier = itemBalancing.maxTier[familyId]+1;
        int localKey = itemBalancing.localizationKey[familyId];
        string familyNameString = localizerManager.LocalizedText(localKey);
        familyTitle.text = "- " + familyNameString + " -";

    }

    void ShowInfo()
    {
        GameObject.Find("gameProperties").GetComponent<tutorialManager>().HideInfoTuto();


        // CALCULATE SIZES
        imgWidth = Screen.width / itemsPerScreen;
        scrollView.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        scrollView.GetComponent<RectTransform>().offsetMax = new Vector2(imgWidth * (familyMaxTier+2), 0);

        // SET BG COLOR
        string colorValue = "#" + itemBalancing.familyColors[familyId];
        Color newCol;
        if (ColorUtility.TryParseHtmlString(colorValue, out newCol))
        {
            Color alphaColor = newCol;
            alphaColor.a = 0.5f;
            itemsBackground.color = alphaColor;
            itemsBackground_line1.color = newCol;
            itemsBackground_line2.color = newCol;
        }




        // FOCUS ON ITEM SELECTED
        float contentOffet = -((imgWidth / itemsPerScreen) - ( imgWidth*.15f) + (imgWidth * itemTier));
        StartCoroutine(FocusItem(contentOffet, imgWidth * (familyMaxTier + 2)));



        for (int i = 0; i < itemImg.Length; i++)
        {
            //////// POSITION
            imgParent[i].GetComponent<RectTransform>().offsetMin = new Vector2(imgWidth * i,0);
            imgParent[i].GetComponent<RectTransform>().offsetMax = new Vector2(imgWidth * (i + 1), 0);
            if (i<arrows.Length)
            {
                arrows[i].GetComponent<RectTransform>().offsetMin = new Vector2(imgWidth * (i+1) - (imgWidth* arrowsProportion), 0);
                arrows[i].GetComponent<RectTransform>().offsetMax = new Vector2(imgWidth * (i+1) + (imgWidth * arrowsProportion), 0);
            }


            //////// HIDE 
            if (i > familyMaxTier)
                SetImageState("hidden", i);
            else if (i == (itemTier+1))
                SetImageState("selected", i);

            //////// LOCKED 
            else if (i > (currentMaxUnlocked+1))
                SetImageState("locked", i);
            else
                SetImageState("regular", i);
        }

    }
    IEnumerator FocusItem(float maxOffset, float scrollWidth)
    {
        //Debug.Log("Start coroutine. with offset: "+maxOffset);
        scrollContent.offsetMin = new Vector2(0, 0);
        float posX = 0;
        float startDelay = scrollDragDelay;
        float startTime = Time.time + startDelay;


        yield return new WaitForSeconds(startDelay);


        while (Time.time< startTime+dragMoveTime)
        {
            float proportion = dragAnimation.Evaluate((Time.time - startTime) / dragMoveTime);
            posX = 0 + maxOffset*proportion;
            //Debug.Log(posX);
            scrollContent.offsetMin = new Vector2(posX, 0);
            scrollContent.offsetMax = new Vector2(scrollWidth + posX, 0);

            yield return null;
        }


        //Debug.Log("MyCoroutine is now finished at "+Time.time);
    }


    void SetImageState(string state, int imageId)
    {
        // "hidden" = completely hidden
        // "regular"
        // "locked"

        //////////////////////////////////////////// SPRITE
        Sprite itemSprite = null;
        if (imageId == 0)
            itemSprite = Resources.Load<Sprite>("UI/icons/spawners/spawner_" + itemBalancing.spawners[familyId]);
        else
            itemSprite = Resources.Load<Sprite>("UI/icons/items/" + itemFamily + "_" + (imageId - 1).ToString());

        itemImg[imageId].sprite = itemSprite;

        //////////////////////////////////////////// HIDDEN
        if (state == "hidden")
        {
            imgParent[imageId].SetActive(false);
            arrows[imageId - 1].SetActive(false);
        }

        //////////////////////////////////////////// LOCKED
        else if (state == "locked")
        {
            imgParent[imageId].transform.localScale = new Vector3(1, 1, 1);
            imgParent[imageId].SetActive(true);
            questions[imageId].SetActive(true);
            if (imageId > 0)
                arrows[imageId - 1].SetActive(true);
            float randomRotation = Random.Range(-10, 10);
            questions[imageId].transform.eulerAngles = new Vector3(70, 0, randomRotation);
            itemBg[imageId].color = bgLockedColor;
            itemImg[imageId].color = imgLockedColor;
            if (arrows[imageId - 1])
                arrows[imageId - 1].GetComponent<Image>().color = arrowLockedColor;
        }

        //////////////////////////////////////////// SELECTED
        else if (state == "selected")
        {
            questions[imageId].SetActive(false);

            string colorValue = "#" + itemBalancing.familyColors[familyId];
            Color newCol;
            if (ColorUtility.TryParseHtmlString(colorValue, out newCol))
                itemBg[imageId].color = newCol;
            itemImg[imageId].color = Color.white;
            if (imageId > 0)
                arrows[imageId - 1].GetComponent<Image>().color = Color.white;
            selectedFeedback.transform.SetParent(itemImg[imageId].transform.parent);
            selectedFeedback.transform.SetAsFirstSibling();
            imgParent[imageId].transform.localScale = selectedPictureScale;
            
        }

        //////////////////////////////////////////// REGULAR
        else if (state == "regular")
        {
            imgParent[imageId].transform.localScale = new Vector3(1, 1, 1);
            questions[imageId].SetActive(false);
            itemImg[imageId].transform.parent.gameObject.SetActive(true);
            if (imageId > 0)
                arrows[imageId - 1].SetActive(true);
            //color
            string colorValue = "#" + itemBalancing.familyColors[familyId];
            Color newCol;
            if (ColorUtility.TryParseHtmlString(colorValue, out newCol))
                itemBg[imageId].color = newCol;
            itemImg[imageId].color = Color.white;
            itemImg[imageId].color = Color.white;
            if (imageId>0)
                arrows[imageId - 1].GetComponent<Image>().color = Color.white;
        }


    }



    public void ClosePopup()
    {
        GetComponent<GraphicRaycaster>().enabled = false;
        tapManager.ClosePopup();
        GetComponent<Animation>().Play("infoPopup_close");
    }
}
