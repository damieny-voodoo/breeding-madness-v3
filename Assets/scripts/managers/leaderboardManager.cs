using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using TMPro;


public class leaderboardManager : MonoBehaviour
{

    /*
    string playerName;
    public TextMeshProUGUI[] playerNames;
    public TextMeshProUGUI[] playerLevels;
    public GameObject[] playerCards;
    public TextMeshProUGUI[] rankTexts;
    public GameObject popupLeaderboard;
    public GameObject popupNamePick;
    */
    public GameObject popupComingSoon;
    /*
    public GameObject confirmNameButton_ok;
    public GameObject confirmNameButton_notOk;
    public GameObject nameErrorText;
    public GameObject nameTooShortText;
    public GameObject nameTooLongText;
    bool nameIsValid = false;
    public TMP_InputField nameField;
    public Color yourNameColor;

    public GameObject loadingFeedback;
    */
    //LeaderboardAPI leaderboard;


    /*
    void Start()
    {
        /*
        //leaderboard = new LeaderboardAPI(new Uri("http://api.andrea.abidon.io:7080/"));
        leaderboard = new LeaderboardAPI(new Uri("http://82.65.117.13:7080/leaderboard"));
        playerName = PlayerPrefs.GetString("playerName");
        Preload();
        

    }

*/
    public void TapLeaderboardButton()
    {

        OpenComingSoon();
        /*
        if (playerName == "")
            OpenNamePick();
        else
            OpenLeaderboard();
    */

    }

    void OpenComingSoon()
    {
        popupComingSoon.GetComponent<Animation>().Play("comingSoon_open");
        popupComingSoon.GetComponent<GraphicRaycaster>().enabled = true;
        GetComponent<tapManager>().OpenPopup();


    }
    public void CloseComingSoon()
    {
        popupComingSoon.GetComponent<Animation>().Play("comingSoon_close"); 
        popupComingSoon.GetComponent<GraphicRaycaster>().enabled = false;
        GetComponent<tapManager>().ClosePopup();
    }

    /*
    void Preload()
    {

        //UpdateLeaderboard();        
        leaderboard.CheckPlayerNameAvailability("aaa", (isAvailable) =>
        {
            //Debug.Log("Name preload done");
        },
        (exception) => {
            //Debug.LogError(exception);
        });

    }



    ///////////////////////////////////////////////////////////////////////////////////////////// NAME


    void OpenNamePick()
    {
        nameField.text = "";
        GetComponent<tapManager>().popupOpen = true;
        popupNamePick.transform.localScale = new Vector3(1,1,1);
        popupNamePick.GetComponent<Animation>().Play("namePick_open");
    }
    public void CloseNamePick()
    {
        GetComponent<tapManager>().popupOpen = false;
        //popupNamePick.SetActive(false);
        popupNamePick.GetComponent<Animation>().Play("namePick_close");


    }

    public void CheckName()
    {
        string nameToCheck = nameField.text;
        //Debug.Log(nameToCheck+ " - Check name, Length: "+ nameToCheck.Length);
        if (nameToCheck.Length < 3)
        {
            //Debug.Log(nameToCheck + " - Name too short");
            SetNameAvailabiilty(true, true, false);
        }
        else if (nameToCheck.Length >8)
        {
            //Debug.Log(nameToCheck + " - Name too short");
            SetNameAvailabiilty(true, false, true);
        }
        else
        {
            leaderboard.CheckPlayerNameAvailability(nameToCheck, (isAvailable) =>
            {
                if (isAvailable)
                {
                    //Debug.Log(nameToCheck+ "set available: true");
                    SetNameAvailabiilty(true, false, false);
                }
                else
                {
                    //Debug.Log(nameToCheck + " - set available: false");
                    SetNameAvailabiilty(false, false, false);
                }
            },
            (exception) => {
                Debug.LogError(nameToCheck + " - exception found: "+ exception);
            });

        }
        nameField.textComponent.GetComponent<autoSizeText>().RedoFontSize();
    }

    void SetNameAvailabiilty( bool nameAvailable, bool lengthTooShort, bool lengthTooLong)
    {
        string nameToCheck = nameField.text;

        if (nameAvailable && !lengthTooShort && !lengthTooLong)
            nameIsValid = true;
        else
            nameIsValid = false;


        if (lengthTooShort)
        {
            nameTooShortText.transform.localScale = new Vector3(1,1,1);
            nameTooLongText.transform.localScale = new Vector3(0,0,0);
            nameErrorText.transform.localScale = new Vector3(0,0,0);
        }
        else if (lengthTooLong)
        {
            nameTooShortText.transform.localScale = new Vector3(0, 0, 0);
            nameTooLongText.transform.localScale = new Vector3(1, 1, 1);
            nameErrorText.transform.localScale = new Vector3(0, 0, 0);
        }
        else if (!nameAvailable)
        {
            nameTooShortText.transform.localScale = new Vector3(0, 0, 0);
            nameTooLongText.transform.localScale = new Vector3(0, 0, 0);
            nameErrorText.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            nameTooShortText.transform.localScale = new Vector3(0, 0, 0);
            nameTooLongText.transform.localScale = new Vector3(0, 0, 0);
            nameErrorText.transform.localScale = new Vector3(0, 0, 0);
        }

        confirmNameButton_ok.SetActive(nameIsValid);
        confirmNameButton_notOk.SetActive(!nameIsValid);

        //Debug.Log(nameToCheck + " - Name availability:" + nameAvailable);
    }
   
    public void FinalizeName()
    {
        CheckName();
        if (nameIsValid)
        {
            string playerNameSet = nameField.text;
            GetComponent<saveManager>().SavePlayerName(playerNameSet);
            playerName = PlayerPrefs.GetString("playerName");
            CloseNamePick();
            OpenLeaderboard();
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////// SHOW
    void OpenLeaderboard()
    {
        GetComponent<tapManager>().popupOpen = true;
        popupLeaderboard.SetActive(true);
        popupLeaderboard.GetComponent<Animation>().Play("leaderboard_open");
        UpdateLeaderboard();
    }

    public void CloseLeaderboard()
    {

        GetComponent<tapManager>().popupOpen = false;
        popupLeaderboard.GetComponent<Animation>().Play("leaderboard_close");
    }

    void UpdateLeaderboard()
    {
        //Debug.Log("Start getting leaderboard");
        leaderboard.GetLeaderboard(Leaderboard, OnError);
    }

    private void Leaderboard(PlayerInfo[] leaderboard)
    {

        loadingFeedback.SetActive(false);

        int leaderboardLength = leaderboard.Length;
        Debug.Log("Show Leaderboard with length " + leaderboardLength);

        for (var i = 0; i < playerCards.Length; ++i)
        {
            if (i > (leaderboardLength-1))
            {
                playerCards[i].SetActive(false);
            }
            else
            {
                playerCards[i].SetActive(true);
                // level
                int thisPlayerLevel = GetComponent<xpManager>().GetLevel( leaderboard[i].score);
                playerLevels[i].text = thisPlayerLevel.ToString();
                // name
                playerNames[i].text = Uri.UnescapeDataString(leaderboard[i].player);
                // color
                if (playerNames[i].text == playerName)
                {
                    playerNames[i].color = yourNameColor;
                    rankTexts[i].color = yourNameColor;
                }
                else
                {
                    playerNames[i].color = Color.white;
                    rankTexts[i].color = Color.white;
                }

            }
            //playerNames[i].GetComponent<autoSizeText>().RedoFontSize();

        }

    }

    string YourName()
    {

        int currentLanguage = PlayerPrefs.GetInt("currentLanguage");
        string[] yourNameStrings = new string[]
        {
        "Toi", "You"
        };

        string nameReturn = yourNameStrings[currentLanguage];
        return nameReturn;

    }


    ///////////////////////////////////////////////////////////////////////////////////////////// SUBMIT
    public void SubmitScore()
    {
        playerName = PlayerPrefs.GetString("playerName");
        uint currentScore = (uint)PlayerPrefs.GetInt("currentXp");

        //Debug.Log($"Submit score for {playerName} with score {currentScore}");
        leaderboard.SubmitScore(playerName, currentScore, null, OnError);
    }

    ///////////////////////////////////////////////////////////////////////////////////////////// FLUSH
    public void FlushLeaderboard()
    {

        var leaderboard = new LeaderboardAPI(new Uri("http://api.andrea.abidon.io:7080/"));
        leaderboard.FlushLeaderboard(null, null);
        Debug.Log("Leaderboard flushed");

    }



    private void OnError(Exception exc)
    {
        Debug.LogException(exc);
    }
*/
}
