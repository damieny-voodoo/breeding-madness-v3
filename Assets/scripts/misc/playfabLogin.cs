using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PlayFab;
//using PlayFab.ClientModels;
using TMPro;
using UnityEngine.SceneManagement;

public class playfabLogin : MonoBehaviour
{
    /*
    public TextMeshProUGUI logText;
    public string playerId;
    public bool dataFetched = false;
    public bool loginComplete = false;
    public bool playfabOn;

    private void Start()
    {
        //DontDestroyOnLoad(gameObject);

        if (!logText)
            logText = GameObject.Find("logText").GetComponent<TextMeshProUGUI>();

        if(playfabOn)
            Login();
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////// LOGIN TO PLAYFAB
    void Login()
    {
        if (PlayerPrefs.GetInt("tutorialCompleted") == 1)
        {
            ///////////////////////////////// LOGIN WITH EDITOR
            if (Application.isEditor)
            {
                var editorRequest = new LoginWithCustomIDRequest
                {
                    CustomId = SystemInfo.deviceUniqueIdentifier,
                    CreateAccount = true
                };
                PlayFabClientAPI.LoginWithCustomID(editorRequest, OnLoginSuccess, OnError);
            }

            ///////////////////////////////// LOGIN WITH ANDROID
            else if (Application.platform == RuntimePlatform.Android)
            {
                logText.text += "android login\n";
                LoginWithAndroidDeviceIDRequest androidRequest = new LoginWithAndroidDeviceIDRequest
                {
                    AndroidDeviceId = SystemInfo.deviceUniqueIdentifier,
                    CreateAccount = true
                };
                PlayFabClientAPI.LoginWithAndroidDeviceID(androidRequest, OnLoginSuccess, OnError);
            }

        }
        else
            loginComplete = true;
    }


    void OnError(PlayFabError error)
    {
        logText.text += error.GenerateErrorReport();
        logText.text += "\n";
        Debug.Log("Data not sent");
        //playerId = error.GenerateErrorReport();
        Debug.Log(error.GenerateErrorReport());

        loginComplete = true;

        //ReloadData();
    }

    void OnLoginSuccess(LoginResult result)
    {
        logText.text += "login success \n";
        PlayerPrefs.SetString("playerId", result.PlayFabId);

        CheckValuesOverride();

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////// VALUES OVERRIDE
    void CheckValuesOverride()
    {
        logText.text += "check values override";
        logText.text += "\n";
        //Debug.Log("Check Values override");
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataReceived, OnError);
    }

    void OnDataReceived(GetUserDataResult result)
    {
        logText.text += "data received";
        logText.text += "\n";
        if (result.Data != null && (result.Data.ContainsKey("SetValueInt") || result.Data.ContainsKey("SetValueString") || result.Data.ContainsKey("AddValueInt")))
            OverrideData(result);
        else
            loginComplete = true;
    }


    void OverrideData(GetUserDataResult result)
    {
        logText.text += "override Data";
        logText.text += "\n";
        if (result.Data.ContainsKey("SetValueInt"))
        {
            string dataString = result.Data["SetValueInt"].Value.Trim();
            string[] stringSplit = dataString.Split(',');
            for (int i = 0; i < stringSplit.Length; i++)
            {
                string[] thisString = stringSplit[i].Split('|');
                string key = thisString[0];
                int value = int.Parse(thisString[1]);
                Debug.Log("Set value " + key + " to " + value);
                PlayerPrefs.SetInt(key, value);
            }
        }
        if (result.Data.ContainsKey("SetValueString"))
        {
            string dataString = result.Data["SetValueString"].Value.Trim();
            string[] stringSplit = dataString.Split(',');
            for (int i = 0; i < stringSplit.Length; i++)
            {
                string[] thisString = stringSplit[i].Split('|');
                string key = thisString[0];
                string value = thisString[1];
                Debug.Log("Set value " + key + " to " + value);
                PlayerPrefs.SetString(key, value);
            }
        }
        if (result.Data.ContainsKey("AddValueInt"))
        {
            string dataString = result.Data["AddValueInt"].Value.Trim();
            string[] stringSplit = dataString.Split(',');
            for (int i = 0; i < stringSplit.Length; i++)
            {
                string[] thisString = stringSplit[i].Split('|');
                string key = thisString[0];
                int value = int.Parse(thisString[1]) + PlayerPrefs.GetInt(key);
                Debug.Log("Add " + value + " " + key);
                PlayerPrefs.SetInt(key, value);
            }

        }

        ClearPlayerData();
    }

    void ClearPlayerData()
    {
        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>
            {
                {"SetValueInt", null },
                {"SetValueString", null },
                {"AddValueInt", null }
            }
        };
        PlayFabClientAPI.UpdateUserData(request, OnDataSent, OnError);

    }

    void OnDataSent(UpdateUserDataResult result)
    {

        loginComplete = true;
    }

    private void Update()
    {
        if((loginComplete || !playfabOn) && dataFetched)
            SceneManager.LoadScene("main");
    }
    */
}
