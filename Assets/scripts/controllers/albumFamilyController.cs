using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class albumFamilyController : MonoBehaviour
{
    public string familyId;
    public string familyName;
    public int familyMaxTier;

    public Color itemLockedColor;
    public Color itemLockedColorBg;
    public Color itemUnlockedColorBg;

    public GameObject[] items;
    public TextMeshProUGUI title;
    public Image[] itemIcons;
    public TextMeshProUGUI[] itemsLockedTexts;
    public Image[] itemBackgroundImg;

    public GameObject progressObject;
    public Image progressBar;
    public TextMeshProUGUI progressText;
    public TextMeshProUGUI progressTextComplete;  ////////  to change to TMPro

    public Color familyColor;
    public Color progressBarProgress;
    public Color progressBarComplete;

    public GameObject collectablePanel;
    public GameObject mainPanel;
    public TextMeshProUGUI energyRewardText;  ////////  to change to TMPro


    public int collectState;
    public int collectEnergyReward;
    saveManager saveManager;


    void OnEnable()
    {
        for (int i = 0; i < items.Length; i++)
        {
            saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();
            int randomAnim = Random.Range(1, 5);
            items[i].GetComponent<Animation>().Play("albumPicture_anim" + randomAnim.ToString());
        }


    }
    

    public void InitiateFamily(string m_famlyId, string m_familyName, int m_totalItems, Color m_familyColor)
    {
        familyId = m_famlyId;
        familyName = m_familyName;
        familyColor = m_familyColor;

       // title.GetComponent<Shadow>().effectColor = familyColor;
        energyRewardText.text = collectEnergyReward.ToString();

        for (int i =0; i < items.Length; i++)
        {
            //////////////// SHOW PICTURE
            if (i < m_totalItems)
            {
                itemIcons[i].sprite = Resources.Load<Sprite>("UI/icons/items/" + familyId + "_" + i);
                items[i].SetActive(true);
            }
            //////////////// HIDE PICTURE
            else
                items[i].SetActive(false);
        }



    }


    public void UpdateFamily(string m_famlyId, string m_familyName, int m_totalItems)
    {

        //////////////////////////////////////////////// BASE DATA
        familyId = m_famlyId;
        familyName = m_familyName;

        familyMaxTier = saveManager.GetSavedInt(familyId + "_progress");
        //Debug.Log("Update " + m_famlyId + " progress: "+ familyMaxTier);

        //////////////////////////////////////////////// FAMILY NAME
        if (familyMaxTier == 0)
            title.text = "???";
        else
            title.text = "- " + familyName + " -";

        //////////////////////////////////////////////// LOCK 
        for (int i = 0; i < items.Length; i++)
        {
            // If not locked
            if (i < familyMaxTier)
            {
                itemIcons[i].color = Color.white;
                itemBackgroundImg[i].color = itemUnlockedColorBg;
                itemsLockedTexts[i].text = "";
            }
            // if locked
            else
            {
                itemIcons[i].color = itemLockedColor;
                itemBackgroundImg[i].color = itemLockedColorBg;
                itemsLockedTexts[i].text = "?";
            }
        }

        //////////////////////////////////////////////// ANIMATE THE PICTURES 
        for (int i = 0; i < items.Length; i++)
        {
            int randomAnim = Random.Range(1, 5);
            items[i].GetComponent<Animation>().Play("albumPicture_anim" + randomAnim.ToString());
        }

        //////////////////////////////////////////////// PROGRESS 
        UpdateProgress(m_totalItems);
        CheckCollectable(m_totalItems);
        

    }

    void CheckCollectable(int m_totalItems)
    {
        int totalItems = m_totalItems;

        if(familyMaxTier == totalItems && collectState ==1)
        {
            collectablePanel.SetActive(true);
            mainPanel.SetActive(false);
        }
        else
        {
            collectablePanel.SetActive(false);
            mainPanel.SetActive(true);
        }


    }


    public void UpdateProgress(int m_totalItems)
    {

        familyMaxTier = saveManager.GetSavedInt(familyId + "_progress");
        int totalItems = m_totalItems;


        if (familyMaxTier > 0)
            progressObject.SetActive(true);
        else
            progressObject.SetActive(false);

        // TEXT
        if (familyMaxTier > 0)
            progressText.text = familyMaxTier + "/" + totalItems;

        /// PROGRESS BAR
        float progressPercent = (familyMaxTier * 1f)/(totalItems * 1f);
        progressBar.fillAmount = progressPercent;
        if(progressPercent == 1)
        {
            familyMaxTier = saveManager.GetSavedInt(familyId + "_progress");
            progressBar.color = progressBarComplete;
            progressText.gameObject.SetActive(false);
            progressTextComplete.gameObject.SetActive(true);
        }
        else
        {
            progressBar.color = progressBarProgress;
            progressText.gameObject.SetActive(true);
            progressTextComplete.gameObject.SetActive(false);
        }


    }


}
