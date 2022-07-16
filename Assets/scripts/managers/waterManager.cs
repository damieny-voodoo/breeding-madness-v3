using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class waterManager : MonoBehaviour
{
    public int currentWater;
    public TextMeshProUGUI waterText;
    public GameObject waterFX;
    public GameObject topPanel;

    saveManager saveManager;

    void Start()
    {
        //Debug.LogWarning("Start");

        /////////// GET COMPONENTS
        GameObject properties = GameObject.Find("gameProperties");
        saveManager = properties.GetComponent<saveManager>();

        /////////// INITIALIZE
        AddWater(0);

    }

    public void CheatWater()
    {
        AddWater(10);
    }

    public void AddWater(int waterToAdd)
    {
        int waterSaved = saveManager.GetSavedInt("currentWater");
        currentWater = waterToAdd + waterSaved;
        Save(currentWater);
        //saveManager.SaveWater(currentWater);

        // UI
        UpdateUI();

        // CHECK NOTIFICATION
       // GetComponent<pictureManager>().UpdateNotification();

        // FX
        if (waterToAdd > 0)
        {
            GameObject instantiatedFeedback = Instantiate(waterFX, topPanel.transform.position, topPanel.transform.rotation) as GameObject;
            instantiatedFeedback.transform.SetParent(topPanel.transform);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            instantiatedFeedback.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
        }

        // ANIM
        waterText.GetComponent<Animation>().Stop("rewardText_anim");
        waterText.GetComponent<Animation>().Play("rewardText_anim");

    }


    public void SpendWater(int waterSpent)
    {
        int waterSaved = saveManager.GetSavedInt("currentWater");
        currentWater = waterSaved - waterSpent;
        Save(currentWater);
        //saveManager.SaveWater(currentWater);

        // UI
        UpdateUI();

    }

    void UpdateUI()
    {

        waterText.text = currentWater.ToString();

    }

    void Save(int currentWater)
    {
        saveManager.SaveInt("currentWater", currentWater);
    }

}
