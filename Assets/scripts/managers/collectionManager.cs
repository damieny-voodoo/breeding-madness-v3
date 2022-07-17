using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collectionManager : MonoBehaviour
{
    public int currentArea;
    public int petPerRow = 3;
    public int currentProgressInArea;
    public int currentUnlockablePet;
    public int maxProgressInArea;
    public GameObject collectionPanel;
    List<GameObject> items = new List<GameObject>();
    public RectTransform content;
    List<int> petIds = new List<int>();
    public float itemsDelay;
    public TextMeshProUGUI progressText;

    public Image progressFill;
    public float fillSpeed;

    public GameObject unlockStamp;

    petBalancing petBalancing;
    saveManager saveManager;

    private void Awake()
    {

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();

        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
    }

    public void Start()
    {
        UpdateProgress("init");
    }

    public void UpdateProgress(string source)
    {
        maxProgressInArea = 0;
        currentProgressInArea = 0;
        currentUnlockablePet = 0;
        for (int i = 0; i < petBalancing.id.Length; i++)
        {
            if (petBalancing.areaId[i] == currentArea && petBalancing.isCollectionPet[i])
            {
                maxProgressInArea++;
                string thisPetId = petBalancing.codeName[i];
                if (saveManager.GetSavedInt(thisPetId + "_unlockState") ==2)
                    currentProgressInArea++;
                if (saveManager.GetSavedInt(thisPetId + "_unlockState") == 1)
                    currentUnlockablePet++;
            }
        }


        progressText.text = currentProgressInArea.ToString() + "/" + maxProgressInArea.ToString();

        UpdateTopUi(source);
        UpdateStamp(source);
    }
    

    ////////////////////////////////////////////////////////////////////// COLLECTION POPUP
    public void ShowCollection(int areaId)
    {
        // shortly disable inertia
        content.transform.parent.parent.GetComponent<ScrollRect>().inertia = false;

        UpdateData(areaId);
        ShowAnimation();
    }


    void UpdateData(int areaId)
    {
        currentArea = areaId;

        // REFRESH PROGRESS
        UpdateProgress("showCollection");

        // EMPTY LISTS
        foreach (GameObject g in items)
            ObjectPool.SharedInstance.ReleaseObject(g);
        items = new List<GameObject>();

        // RECREATE THE LIST
        StartCoroutine(ShowCards());


    }

    IEnumerator ShowCards()
    {

        // hide previous cards
        items = new List<GameObject>();
        petIds = new List<int>();


        for (int i = 0; i < petBalancing.areaId.Length; i++)
        {
            if (currentArea == petBalancing.areaId[i] && petBalancing.isCollectionPet[i])
                petIds.Add(petBalancing.id[i]);
        }

        // HANDLE CONTENT SIZE
        int rows = Mathf.CeilToInt((petIds.Count * 1.0f) / (petPerRow * 1.0f));
        float panelHeight = Screen.height * .2f;
        float size = rows * panelHeight + panelHeight * .1f;
        content.sizeDelta = new Vector2(Screen.width*.9f, size);

        //reset content position
        content.transform.localPosition = new Vector3(Screen.width * .9f / 2f, 0f, 0f);

        // Spawn all items
        GameObject spawnedItem = null;
        for (int i = 0; i < petIds.Count; i++)
        {
            spawnedItem = ObjectPool.SharedInstance.GetPooledObject("collectionItem");
            items.Add(spawnedItem);
            spawnedItem.SetActive(true);
            spawnedItem.transform.SetParent(content.transform);
            items[i].GetComponent<collectionItemController>().UpdateItem(petIds[i], i);
            yield return new WaitForSeconds(itemsDelay);
        }

        // re-enable inertia
        content.transform.parent.parent.GetComponent<ScrollRect>().inertia = true;

        yield return null;
    }

    void ShowAnimation()
    {

        // OPEN POPUP
        GetComponent<tapManager>().OpenPopup();
        collectionPanel.GetComponent<GraphicRaycaster>().enabled = true;
        collectionPanel.GetComponent<Animation>().Play("collection_popup_open");

    }

    public void ClosePopup()
    {

        // Close popup
        GetComponent<tapManager>().ClosePopup();
        collectionPanel.GetComponent<GraphicRaycaster>().enabled = false;
        collectionPanel.GetComponent<Animation>().Play("collection_popup_close");

    }




    ////////////////////////////////////////////////////////////////////// PROGRESS UI
    public void UpdateTopUi(string source)
    {
        int tmp_currentProgressInArea = 0;
        for (int i = 0; i < petBalancing.id.Length; i++)
        {
            if (petBalancing.areaId[i] == currentArea && petBalancing.isCollectionPet[i])
            {
                string thisPetId = petBalancing.codeName[i];
                if (saveManager.GetSavedInt(thisPetId + "_unlockState") == 2)
                    tmp_currentProgressInArea++;
            }
        }


        if(currentProgressInArea < tmp_currentProgressInArea)
            StartCoroutine(UpdateFiller(source, tmp_currentProgressInArea));
        else if(source =="init")
            progressFill.fillAmount = (currentProgressInArea * 1.0f) / (maxProgressInArea * 1.0f);

        currentProgressInArea = tmp_currentProgressInArea;
    }

    IEnumerator UpdateFiller(string source, int targetProgress)
    {

        float targetProportion = (targetProgress * 1.0f) / (maxProgressInArea * 1.0f);
        float speed = fillSpeed;

        while (targetProportion - progressFill.fillAmount > 0.01f)
        {
            progressFill.fillAmount = Mathf.Lerp(progressFill.fillAmount, targetProportion, speed * Time.deltaTime);
            yield return null;
        }

        yield return null;
    }


    ////////////////////////////////////////////////////////////////////// UPDATE STAMP
    public void UpdateStamp(string source)
    {
        if(source != "init")
        {
            currentUnlockablePet = 0;
            for (int i = 0; i < petBalancing.id.Length; i++)
            {
                if (petBalancing.areaId[i] == currentArea && petBalancing.isCollectionPet[i])
                {
                    string thisPetId = petBalancing.codeName[i];
                    if (saveManager.GetSavedInt(thisPetId + "_unlockState") == 1)
                        currentUnlockablePet++;
                }
            }
        }


        if (currentUnlockablePet > 0)
            unlockStamp.SetActive(true);
        else
            unlockStamp.SetActive(false);
    }

}
