using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collectionItemController : MonoBehaviour
{
    [Header("DATA -------------------")]
    public int thisItemOrder;
    public int thisPetUniqueId;
    public string thisPetId;
    public int totalOwned;
    public int unlockState;

    [Header("VISUALS -------------------")]
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descText;
    public Image petImage;
    public GameObject lockedIcon;
    public GameObject unlockPanel;
    public Color hiddenColor;

    [Header("SIZE -------------------")]
    public float heightPercentage = 0.2f;
    float widthPercentage = .3f;

    saveManager saveManager;
    collectionManager collectionManager;
    necManager necManager;

    petBalancing petBalancing;

    private void Awake()
    {
        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        collectionManager = gameProperties.GetComponent<collectionManager>();
        necManager = gameProperties.GetComponent<necManager>();

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
    }

    public void UpdateItem(int m_thisPetUniqueId, int m_thisItemOrder)
    {
        UpdateData(m_thisPetUniqueId, m_thisItemOrder);
        UpdateVisuals();
    }

    void UpdateData(int m_thisPetUniqueId, int m_thisItemOrder)
    {
        // UPDATE DATA
        thisItemOrder = m_thisItemOrder;
        thisPetUniqueId = m_thisPetUniqueId;
        thisPetId = petBalancing.codeName[thisPetUniqueId];
        totalOwned = saveManager.GetSavedInt(thisPetId + "_totalOwned");
        if (totalOwned == 0)
            unlockState = 0;
        else
            unlockState = saveManager.GetSavedInt(thisPetId + "_unlockState");
    }    
    
    void UpdateVisuals()
    {
        // POSITION && HEIGHT
        RectTransform thisRect = GetComponent<RectTransform>();
        float baseOffsetX = transform.parent.GetComponent<RectTransform>().sizeDelta.x / 2;
        float baseOffsetY = transform.parent.GetComponent<RectTransform>().sizeDelta.y / 2;
        float panelHeight = Screen.height * heightPercentage;
        float panelWidth = Screen.width* widthPercentage;
        Vector2 thisCoordinate = new Vector2(thisItemOrder % collectionManager.petPerRow, Mathf.Floor(thisItemOrder/collectionManager.petPerRow));
        float posX = panelWidth * thisCoordinate.x - baseOffsetX;
        float posY = panelHeight * -thisCoordinate.y + baseOffsetY;

        thisRect.sizeDelta = new Vector2(panelWidth, panelHeight);
        thisRect.anchoredPosition = new Vector3(posX, posY);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y,0f) ;

        

        thisRect.localEulerAngles = Vector3.zero;

        // SHOW/HIDE UNLOCK PANEL
        if (unlockState == 1)
        {
            unlockPanel.SetActive(true);
            unlockPanel.GetComponent<Animation>().Stop("collectionItem_unlockPop");
            unlockPanel.GetComponent<Animation>().Play("collectionItem_unlockGlow");
        }
        else
            unlockPanel.SetActive(false);

        // TIP TEXT
        titleText.text = petBalancing.titleText[thisPetUniqueId];
        descText.text = petBalancing.descriptionText[thisPetUniqueId];

        // IMAGE
        Sprite imageLoaded = Resources.Load<Sprite>("UI/icons/pets/" + thisPetId);
        petImage.sprite = imageLoaded;
        if (unlockState == 2)
            petImage.color = Color.white;
        else
            petImage.color = hiddenColor;

        // LOCK IMAGE
        lockedIcon.transform.localEulerAngles = new Vector3(0, 0, Random.Range(-8f, 8f));
        if (unlockState == 2)
            lockedIcon.SetActive(false);
        else
            lockedIcon.SetActive(true);

    }

    void UpdateUnlockVisuals()
    {
        petImage.color = Color.white;
        lockedIcon.SetActive(false);
    }

    public void TapUnlock()
    {
        unlockPanel.GetComponent<Animation>().Stop("collectionItem_unlockGlow");
        unlockPanel.GetComponent<Animation>().Play("collectionItem_unlockPop");
        unlockPanel.GetComponent<Button>().enabled = false;
        SaveUnlockState();
        unlockState = saveManager.GetSavedInt(thisPetId + "_unlockState");
        UpdateUnlockVisuals();

        collectionManager.UpdateProgress("unlockPet");
    }

    public void TapItem()
    {
        necManager.ShowCollectionTooltip("collectionTooltip", petBalancing.descriptionText[thisPetUniqueId]);
    }


    void SaveUnlockState()
    {
        saveManager.SaveInt(thisPetId + "_unlockState", 2);
    }


}
