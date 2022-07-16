using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class loading : MonoBehaviour
{

    public TextMeshProUGUI loadingText;
    public TextMeshProUGUI loadingDesc;
    public Image loadingBar;

    public int[] descriptionsIds;
    public bool textsLoaded = false;
    public float loadingTextTime;
   // float startTime;
    float nextTime;

    localizationData localizationData;

    private void Start()
    {
        localizationData = GameObject.Find("balancingData").GetComponent<localizationData>();
    }

    public void ActivateLoadingTexts()
    {
        textsLoaded = true;
        //startTime = Time.time;
        nextTime = Time.time + loadingTextTime;
        //ChangeText();
    }


    void ChangeText()
    {

        //nextTime = Time.time + loadingTextTime;
        //Debug.Log(nextTime);
        int randomText = Random.Range(0, descriptionsIds.Length);
        int randomId = descriptionsIds[randomText];
        int currentLanguage = PlayerPrefs.GetInt("currentLanguage");

        //loadingDesc.text = localizationData.localizationsKeys[randomId, currentLanguage];
        //loadingDesc.GetComponent<autoSizeText>().RedoFontSize();

    }


}
