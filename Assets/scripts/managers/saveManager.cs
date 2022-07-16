using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saveManager : MonoBehaviour
{



    ////////////////////////////////////////////////////////////// LANGUAGE
    private void Awake()
    {
        if (GetSavedInt("firstStart") == 0)
        {
            SetupDefaultLanguage();
            SaveInt("firstStart", 1);
        }
    }
    void SetupDefaultLanguage()
    {
        if (Application.systemLanguage == SystemLanguage.French)
            SaveInt("currentLanguage", 0);
        else if (Application.systemLanguage == SystemLanguage.English)
            SaveInt("currentLanguage", 1);
        else
            SaveInt("currentLanguage", 1);
    }


    ////////////////////////////////////////////////////////////// CLEAR
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("loading");
    }
    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }


    ////////////////////////////////////////////////////////////// SAVE
    public void SaveString(string param, string value)
    {
        PlayerPrefs.SetString(param, value);
    }

    public void SaveInt(string param, int value)
    {
        //Debug.Log("Save Int");
        PlayerPrefs.SetInt(param, value);
    }

    ////////////////////////////////////////////////////////////// GET
    public int GetSavedInt(string param)
    {
        //Debug.Log("Get Int");
        return PlayerPrefs.GetInt(param);
    }
    public string GetSavedString(string param)
    {
        //Debug.Log("Get String");
        return PlayerPrefs.GetString(param);
    }
    
}
