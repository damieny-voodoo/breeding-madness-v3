using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class breedingOptionController : MonoBehaviour
{
    [Header("OWNER ------------")]
    public string ownerName;
    public TextMeshProUGUI ownerText;

    [Header("PET TYPE ------------")]
    public int petId;
    public string thisPetId;
    Sprite imageLoaded;
    public Image petIcon;

    [Header("STATS ------------")]
    public int[] stats;
    public int totalStats;
    public TextMeshProUGUI statCount;

    public GameObject[] statPanels;

    [Header("PRICE ------------")]
    public int price;
    public TextMeshProUGUI priceText;
    public GameObject freePanel;
    public GameObject notFreePanel;
    public Color priceColorOk;
    public Color priceColorNotOk;


    petBalancing petBalancing;
    saveManager saveManager;


    private void Start()
    {

        GameObject balancingData = GameObject.Find("balancingData");
        petBalancing = balancingData.GetComponent<petBalancing>();
        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();

        stats = new int[petBalancing.totalStats];
    }

    public void RefreshUi()
    {
        // NAME
        ownerText.text = "Owner: "+ownerName;

        // ICON
        imageLoaded = Resources.Load<Sprite>("UI/icons/pets/" + thisPetId);
        petIcon.sprite = imageLoaded;

        // STATS
        /*
        totalStats = 0;
        for (int i = 0; i < stats.Length; i++)
            totalStats += stats[i];
        statCount.text = totalStats.ToString();
        */
        for (int i = 0; i < statPanels.Length; i++)
        {

            int currentCount = 1;
            foreach ( Transform g in statPanels[i].transform)
            {
                g.gameObject.SetActive(false);
                if (currentCount == stats[i])
                {
                    g.gameObject.SetActive(true);
                }
                currentCount++;
            }
        }


        // PRICE
        if (price == 0)
        {
            freePanel.SetActive(false);
            notFreePanel.SetActive(false);
        }
        else
        {
            freePanel.SetActive(false);
            notFreePanel.SetActive(true);
            priceText.text = price.ToString();
            int currentCoins = saveManager.GetSavedInt("currentCoins");
            if (currentCoins >= price)
                priceText.color = priceColorOk;
            else
                priceText.color = priceColorNotOk;
        }

    }

    public void ShowCard(float showDelay)
    {
        StartCoroutine(ShowCardSequence(showDelay));
    }
    public IEnumerator ShowCardSequence(float showDelay)
    {
        transform.localScale = Vector3.zero;
        yield return new WaitForSeconds(showDelay);
        GetComponent<Animation>().Play("albumPicture_anim");

        yield return null;
    }


}
