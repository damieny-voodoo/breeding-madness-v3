using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localizerManager : MonoBehaviour
{
    public int currentLanguage;
    public bool languageChanged;
   // public string[,] allTexts;
    public localizationManager[] textList;
    public localizationManager[] specialTexts;
    public localizationData localizationData;
    public saveManager saveManager;

    void Start()
    {
        localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();
        saveManager = GetComponent<saveManager>();
        //InitData();
        UpdateAllTexts();

    }

    public void UpdateAllTexts()
    {

        // get language
        currentLanguage = saveManager.GetSavedInt("currentLanguage");
        //Debug.Log(currentLanguage);

        // update regular texts
        foreach ( localizationManager te in textList)
        {
            if (te)
            {
                int thisTextId = te.textId;
                string thisText = LocalizedText(thisTextId);
                te.UpdateThisText(thisText);
            }

        }

        // update special texts
        GetComponent<resourcesManager>().currentLanguage =  currentLanguage;

    }


    // Update is called once per frame
    public void SelectLanaguage(int languageSelected)
    {


        if (currentLanguage != languageSelected)
        {
            SaveLanguage(languageSelected);
            currentLanguage = saveManager.GetSavedInt("currentLanguage");
            UpdateAllTexts();
        }


    }

    public string LocalizedText(int textKey)
    {
        string outText= "";
        if(!localizationData)
            localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();


        //Debug.Log(textKey);
        if (currentLanguage == 0)
            outText = localizationData.localizationsKeys_fr[textKey];
        else if (currentLanguage == 1)
            outText = localizationData.localizationsKeys_en[textKey];

        return outText;


    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    public void SaveLanguage(int languageSaved)
    {
        saveManager.SaveInt("currentLanguage", languageSaved); // save language
    }


}
