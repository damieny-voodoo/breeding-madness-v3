using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cheatManager : MonoBehaviour
{
    //public bool cheatEnabled;
    [Header("POPUP ---------------------------------------------")]
    public int tapCount;
    public int tapNeeded = 5;
    public GameObject cheatPopup;
    float lastTap = 0;
    public float tapDelay;


    [Header("ORDERS ---------------------------------------------")]
    public TMP_InputField orderIdInputField;

    [Header("ENERGY ---------------------------------------------")]
    public TMP_InputField energyInputField;

    [Header("COINS ---------------------------------------------")]
    public TMP_InputField coinsInputField;

    [Header("WATER ---------------------------------------------")]
    public TMP_InputField waterInputField;

    [Header("SUN ---------------------------------------------")]
    public TMP_InputField sunInputField;

    [Header("DIAMONDS ---------------------------------------------")]
    public TMP_InputField diamondsInputField;

    [Header("XP ---------------------------------------------")]
    public TMP_InputField xpInputField;
    public TMP_InputField levelInputField;



    // Update is called once per frame
    public void TapCheat()
    {
        technicalData technicalData = GameObject.Find("balancingData").GetComponent<technicalData>();

        if (technicalData.cheatEnabled || Application.isEditor)
        {
            if (Time.time < (lastTap + tapDelay))
            {
                tapCount++;
                if (tapCount >= tapNeeded)
                    OpenCheat();
            }
            else
                tapCount = 0;

            lastTap = Time.time;

        }

    }

    void OpenCheat()
    {
        tapCount = 0;
        if (GetComponent<tapManager>())
            GetComponent<tapManager>().popupOpen = true;
        cheatPopup.SetActive(true);

    }

    public void CloseCheat()
    {
        if(GetComponent<tapManager>())
            GetComponent<tapManager>().popupOpen = false;
        cheatPopup.SetActive(false);

    }

    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
    }
    ///////////////////////////////////////////////////////// PETS
    public void CheatPet()
    {
        GetComponent<petManager>().CheatPet();
    }

    ///////////////////////////////////////////////////////// ORDERS
    public void CheatSellOrder()
    {
        GameObject order = GameObject.Find("boatOrder" + orderIdInputField.text);
        GetComponent<orderManager>().SellOrder(order);
    }

    ///////////////////////////////////////////////////////// ENERGY
    public void CheatEnergyAdd()
    {
        string inputText = energyInputField.text;
        GetComponent<resourcesManager>().AddEnergy(int.Parse(inputText));
    }
    public void CheatEnergySpend()
    {
        GetComponent<resourcesManager>().SpendEnergy();
    }


    ///////////////////////////////////////////////////////// COINS
    public void CheatCoinsAdd()
    {
        string inputText = coinsInputField.text;
        GetComponent<coinManager>().AddCoins(int.Parse(inputText));
    }
    public void CheatCoinSpend()
    {
        string inputText = coinsInputField.text;
        GetComponent<coinManager>().SpendCoins(int.Parse(inputText));
    }
    public void CheatCoinSet()
    {
        string inputText = coinsInputField.text;
        int coinsToSet = int.Parse(inputText);
        int currentCoins = GetComponent<saveManager>().GetSavedInt("currentCoins");

        if(coinsToSet > currentCoins)
            GetComponent<coinManager>().AddCoins(coinsToSet-currentCoins);
        else
            GetComponent<coinManager>().SpendCoins(currentCoins-coinsToSet);
    }


    ///////////////////////////////////////////////////////// WATER
    public void CheatWaterAdd()
    {
        string inputText = waterInputField.text;
        GetComponent<resourcesManager>().AddWater(int.Parse(inputText));
    }
    public void CheatWaterSpend()
    {
        string inputText = waterInputField.text;
        GetComponent<resourcesManager>().SpendWater(int.Parse(inputText));
    }
    public void CheatWaterSet()
    {
        string inputText = waterInputField.text;
        int waterToSet = int.Parse(inputText);
        int currentWater = GetComponent<saveManager>().GetSavedInt("currentWater");

        if(waterToSet > currentWater)
            GetComponent<resourcesManager>().AddWater(waterToSet - currentWater);
        else
            GetComponent<resourcesManager>().SpendWater(currentWater - waterToSet);
    }


    ///////////////////////////////////////////////////////// SUN
    public void CheatSunAdd()
    {
        string inputText = sunInputField.text;
        GetComponent<resourcesManager>().AddSun(int.Parse(inputText));
    }
    public void CheatSunSpend()
    {
        string inputText = sunInputField.text;
        GetComponent<resourcesManager>().SpendSun(int.Parse(inputText));
    }
    public void CheatSunSet()
    {
        string inputText = sunInputField.text;
        int sunToSet = int.Parse(inputText);
        int currentSun = GetComponent<saveManager>().GetSavedInt("currentSun");

        if(sunToSet > currentSun)
            GetComponent<resourcesManager>().AddSun(sunToSet - currentSun);
        else
            GetComponent<resourcesManager>().SpendSun(currentSun - sunToSet);
    }

    ///////////////////////////////////////////////////////// DIAMONDS
    public void CheatDiamondsAdd()
    {
        string inputText = diamondsInputField.text;
        GetComponent<resourcesManager>().AddDiamonds(int.Parse(inputText), "cheat");
    }
    public void CheatDiamondsSpend()
    {
        string inputText = diamondsInputField.text;
        GetComponent<resourcesManager>().SpendDiamonds("cheat", int.Parse(inputText));
    }
    public void CheatDiamondsSet()
    {
        string inputText = diamondsInputField.text;
        int diamondsToSet = int.Parse(inputText);
        int currentDiamonds = GetComponent<saveManager>().GetSavedInt("currentDiamonds");

        if(diamondsToSet > currentDiamonds)
            GetComponent<resourcesManager>().AddDiamonds(diamondsToSet - currentDiamonds, "cheat");
        else
            GetComponent<resourcesManager>().SpendDiamonds("cheat", currentDiamonds - diamondsToSet);
    }

    ///////////////////////////////////////////////////////// XP
    public void CheatXpAdd()
    {
        string inputText = xpInputField.text;
        GetComponent<xpManager>().AddXp(int.Parse(inputText));
    }
    public void CheatLevelSet()
    {
        string inputText = levelInputField.text;
        int levelToSet = int.Parse(inputText)-1;
        int currentXp = GetComponent<saveManager>().GetSavedInt("currentXp");

        xpBalancing xpBalancing = GameObject.Find("balancingData").GetComponent<xpBalancing>();
        int targetXp = xpBalancing.xpRequirements[levelToSet];

        GetComponent<xpManager>().AddXp(targetXp - currentXp);
    }

    ///////////////////////////////////////////////////////// SPAWNERS
    public void CheatRefillSpawners()
    {
        GetComponent<resourcesManager>().RefillAllSeeds();
    }

    ///////////////////////////////////////////////////////// GARDEN
    public void CheatUnlockAll()
    {
        gardenManager gardenManager = GetComponent<gardenManager>();
        gardenDecorationControler[] decorations = gardenManager.decorations;
        int maxLevel = 0;

        for (int i=0;i< decorations.Length;i++)
        {
            decorations[i].ShowOption(1);
            gardenManager.SaveDecorationState(i, 1);
            if (i == decorations.Length - 1)
                maxLevel = decorations[i].decorationLevelUnlock;
        }

        levelInputField.text = maxLevel.ToString();
        CheatLevelSet();
    }
    ///////////////////////////////////////////////////////// TUTORIAL
    public void CheatSkipTutorial()
    {

        saveManager saveManager = GetComponent<saveManager>();
        saveManager.SaveInt("tutorialCompleted", 1);
        saveManager.SaveInt("bottomPanelOpen", 1);

        tutorialManager tutorialManager = GetComponent<tutorialManager>();
        tutorialManager.OpenBottomPanel();
    }

}
