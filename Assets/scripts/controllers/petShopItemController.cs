using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class petShopItemController : MonoBehaviour
{
    [Header("ID ------------")]
    public int thisPetId;                   // 0, 1, 2, etc

    [Header("IAMGe ------------")]
    public Image petIcon;

    [Header("NAME ------------")]
    public string petName;                  // Dalmadog, hat dog, etc
    public string petCodeName;              // dog0, dog1, etc
    public TextMeshProUGUI petNameText;

    [Header("STATS ------------")]
    public int[] stats;
    public GameObject[] statPanels;

    [Header("PRICE ------------")]
    public int price;
    public TextMeshProUGUI priceText;
    public Color priceColorOn;
    public Color priceColorOff;

    public GameObject buyButtonOn;
    public GameObject buyButtonOff;



    saveManager saveManager;
    necManager necManager;
    petManager petManager;
    petShopManager petShopManager;
    coinManager coinManager;

    petShopBalancing petShopBalancing;
    petStatsBalancing petStatsBalancing;
    petBalancing petBalancing;


    private void Awake()
    {

        GameObject gameProperties = GameObject.Find("gameProperties");
        saveManager = gameProperties.GetComponent<saveManager>();
        necManager = gameProperties.GetComponent<necManager>();
        petManager = gameProperties.GetComponent<petManager>();
        petShopManager = gameProperties.GetComponent<petShopManager>();
        coinManager = gameProperties.GetComponent<coinManager>();


        GameObject balancingData = GameObject.Find("balancingData");
        petShopBalancing = balancingData.GetComponent<petShopBalancing>();
        petBalancing = balancingData.GetComponent<petBalancing>();
        petStatsBalancing = balancingData.GetComponent<petStatsBalancing>();

        stats = new int[petBalancing.totalStats];
    }


    public void UpdateCard(int currentCount, bool m_newShop)
    {
        int slotPicked = 0;

        if (m_newShop)
        {
            bool slotFound = false;
            List<int> possibleOptions = new List<int>();

            for (int i = 0; i < petShopBalancing.forcedSlot.Length; i++)
            {
                // CHECK FORCED OPTIONS
                if (petShopBalancing.forcedSlot[i] == currentCount)
                {
                    slotPicked = i;
                    slotFound = true;
                }
                // IF NOT, ADD TO POSSIBLE OPTIONS
                else
                {
                    if (petShopBalancing.randomAppearance[i])
                        possibleOptions.Add(i);
                }
            }

            // PICK RANDOM IF NO SLOT FOUND
            if (!slotFound)
            {
                int randomPick = Random.Range(0, possibleOptions.Count);
                slotPicked = possibleOptions[randomPick];
            }

            //SAVE
            SaveSlot(currentCount, slotPicked);
        }
        else
        {
            slotPicked = saveManager.GetSavedInt("petShopItem" + currentCount.ToString());
        }


        // ASSIGN
        AssignPet(slotPicked);

    }

    void AssignPet(int m_id)
    {
        // ID
        thisPetId = petShopBalancing.petId[m_id];

        // NAME
        petCodeName = petBalancing.codeName[thisPetId];
        petName = petBalancing.titleText[thisPetId];
        petNameText.text = petName;

        // IMAGE
        Sprite imageLoaded = Resources.Load<Sprite>("UI/icons/pets/" + petCodeName);
        petIcon.sprite = imageLoaded;

        // STATS
        for (int i = 0; i < stats.Length; i++)
            stats[i] = petShopBalancing.petStats[m_id, i];

        for (int i = 0; i < statPanels.Length; i++)
        {

            int currentCount = 1;
            foreach (Transform g in statPanels[i].transform)
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
        price = petShopBalancing.price[m_id];
        priceText.text = price.ToString();

        int currentCoins = saveManager.GetSavedInt("currentCoins");
        if ( currentCoins >= price)
        {
            priceText.color = priceColorOn;
            buyButtonOn.SetActive(true);
            buyButtonOff.SetActive(false);
        }
        else
        {
            priceText.color = priceColorOff;
            buyButtonOn.SetActive(false);
            buyButtonOff.SetActive(true);
        }


    }


    public void TryPurchasePet()
    {
        Debug.Log("TRY PRUCHASE PET");
        int currentCoins = saveManager.GetSavedInt("currentCoins");
        if (currentCoins >= price)
        {
            int currentOwnedPets = saveManager.GetSavedInt("currentOwnedPets");
            int maxPets = petStatsBalancing.maxPets;
            if (currentOwnedPets <= maxPets)
            {
                StartCoroutine(PurchaseSequence());
            }
            else
            {
                Debug.Log("TRY PRUCHASE PET - Too many pets");
                petManager.ShowError_MaxPets();
            }
        }

        else
        {
            Debug.Log("TRY PRUCHASE PET - Not Enough Coins");
            necManager.ShowNec("coins");
        }

    }

    IEnumerator PurchaseSequence()
    {
        // CLOSE
        petShopManager.ClosePopup();

        // PAUSE
        yield return new WaitForSeconds(1f);

        // GET THE PET
        int currentPetCount = saveManager.GetSavedInt("totalPetCount");
        petManager.GetNewPet(thisPetId, stats, stats, currentPetCount, false, 0, "");

        // SPEND COINS
        coinManager.SpendCoins(price);


        yield return null;
    }


    void SaveSlot(int slotId, int petId)
    {
        saveManager.SaveInt("petShopItem" + slotId.ToString(), petId);
    }
}
