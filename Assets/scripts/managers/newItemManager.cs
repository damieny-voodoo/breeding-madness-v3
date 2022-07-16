using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newItemManager : MonoBehaviour
{
    itemBalancing itemBalancing;
    analyticsManager analyticsManager;
    tapManager tapManager;
    adManager adManager;
    public GameObject newItemPopup;
    public Image[] chainImages;
    public Image mainImage;
    public GameObject[] arrows;
    string itemId;

    private void Start()
    {
        itemBalancing = GameObject.Find("balancingData").GetComponent<itemBalancing>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        tapManager = GetComponent<tapManager>();
        adManager = GetComponent<adManager>();
    }

    public void ShowPopup(string family, int familyId, int tier)
    {
        itemId = family + "_" + tier.ToString();

        ///////////////// ANIMATION
        tapManager.OpenPopup();
        newItemPopup.GetComponent<GraphicRaycaster>().enabled = true;
        newItemPopup.SetActive(true);
        newItemPopup.GetComponent<Animation>().Play("newItemPopup_in");
        GetComponent<tapManager>().popupOpen = true;


        ///////////////// MAIN IMAGE
        mainImage.sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_" + (tier).ToString());


        ///////////////// ITEM 0
        if (tier == 0)
        {
            int spawnerId = itemBalancing.spawners[familyId];
            chainImages[0].sprite = GetComponent<spawnerManager>().spawnerImages[spawnerId];
            chainImages[1].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_0");
            chainImages[2].gameObject.SetActive(false);
            arrows[1].SetActive(false);
        }
        else if (tier == 1)
        {
            int spawnerId = itemBalancing.spawners[familyId];
            chainImages[0].sprite = GetComponent<spawnerManager>().spawnerImages[spawnerId];
            chainImages[1].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_0");
            chainImages[2].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_1");
            chainImages[2].gameObject.SetActive(true);
            arrows[1].SetActive(true);

        }
        else
        {
            chainImages[0].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_" + (tier - 2).ToString());
            chainImages[1].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_" + (tier - 1).ToString());
            chainImages[2].sprite = Resources.Load<Sprite>("UI/icons/items/" + family + "_" + (tier).ToString());
            chainImages[2].gameObject.SetActive(true);
            arrows[1].SetActive(true);
        }

    }

    public void ClosePopup()
    {
        StartCoroutine(CloseRoutine());
    }

     IEnumerator CloseRoutine()
    {

        ///////////////// ANIMATION
        tapManager.ClosePopup();
        newItemPopup.GetComponent<GraphicRaycaster>().enabled = false;
        newItemPopup.GetComponent<Animation>().Play("newItemPopup_out");
        GetComponent<tapManager>().popupOpen = false;

        CheckTutorial();

        yield return new WaitForSeconds(47 / 30);

        adManager.ShowInterstitialVideoAd("newItem");

        yield return null;
    }


    void CheckTutorial()
    {
        if(itemId == "carrots_1")
        {
            GameObject boat = GameObject.Find("boatOrder0");
            GameObject item = GameObject.Find("item");
            if (item && boat)
            {
                //GetComponent<tutorialManager>().HideTuto(2);
                analyticsManager.ContinueFunnel("mainTutorial", "newItemConfirm1");
                GetComponent<tutorialManager>().ShowSlowDragTuto(2, item, boat);
            }
        }

        if (itemId == "carrots_2")
        {

            //GetComponent<tutorialManager>().ShowTuto(13, true);
            analyticsManager.ContinueFunnel("mainTutorial", "newItemConfirm2");
        }
    }


}
