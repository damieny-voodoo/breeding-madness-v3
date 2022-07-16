using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class islandManager : MonoBehaviour
{
    public int currentIsland;
    public GameObject islandParent;
    public GameObject welcomeBanner;
    public GameObject lockBanner;
    float islandOffset = 10;
    public TextMeshProUGUI welcomeText;
    public TextMeshProUGUI lockText;

    public GameObject[] arrows = new GameObject[2];
    public bool[] arrowShown = new bool[2];

    public float lockBannerOutTime;
    public float arrowOutTime;
    public float islandMoveTime;
    public float welcomeShowTime;
    public float arrowShowTime;

    public AnimationCurve islandMoveAnim;

    bool currentIslandIsLocked = false;

    int maxIsland;

    islandBalancing islandBalancing;
    saveManager saveManager;
    tutorialManager tutorialManager;
    localizerManager localizerManager;

    private void Start()
    {
        InitIslands();
        ShowArrows();
    }

    void InitIslands()
    {
        saveManager = GetComponent<saveManager>();
        tutorialManager = GetComponent<tutorialManager>();
        localizerManager = GetComponent<localizerManager>();
        islandBalancing = GameObject.Find("balancingData").GetComponent<islandBalancing>();
        maxIsland = islandBalancing.islandCount - 1;
        currentIsland = 0;
        arrowShown[0] = false;
        arrowShown[1] = true;
    }

    public void TapArrow(string direction)
    {
        
        if(GetComponent<tapManager>().popupOpen ==false)
            StartCoroutine(SwitchIsland(direction));
    }

    IEnumerator SwitchIsland(string direction)
    {
        //////////////////////////////////////////////////////////// Data
        int newIsland = currentIsland;
        if (direction == "right")
            newIsland++;
        else
            newIsland--;



        //////////////////////////////////////////////////////////// Hide Arrows
        HideArrows();
        yield return new WaitForSeconds(arrowOutTime);



        //////////////////////////////////////////////////////////// Hide Lock banner if needed
        if (currentIslandIsLocked)
        {
            lockBanner.GetComponent<Animation>().Play("islandLock_hide");
            currentIslandIsLocked = false;
            yield return new WaitForSeconds(lockBannerOutTime);
        }


        //////////////////////////////////////////////////////////// Move
        float startTime = Time.time;
        float startPosition = -currentIsland * islandOffset;
        float targetPosition = -newIsland * islandOffset;
        while (Time.time < startTime + islandMoveTime)
        {
            float proportion = (Time.time - startTime) / islandMoveTime;
            float evaluation = islandMoveAnim.Evaluate(proportion);
            islandParent.transform.position = new Vector3( startPosition + ((targetPosition-startPosition) * evaluation),0,0);
            yield return null;
        }
        currentIsland = newIsland;



        //////////////////////////////////////////////////////////// Show LOCK if needed
        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GetComponent<xpManager>().GetLevel(currentXp);
        int islandLevelLock = islandBalancing.islandLevelUnlock[currentIsland];
        if (currentLevel < islandLevelLock)
        {
            currentIslandIsLocked = true;
            int textId = islandBalancing.lockText[currentIsland];
            lockText.text = localizerManager.LocalizedText(textId);
            lockText.GetComponent<autoSizeText>().RedoFontSize();
            lockBanner.GetComponent<Animation>().Play("islandLock_show");
        }



        //////////////////////////////////////////////////////////// Show welcome if needed
        else if (currentIsland != 0 && saveManager.GetSavedInt("islandWelcomeShown_"+ currentIsland.ToString()) == 0)
        {
            welcomeBanner.GetComponent<Animation>().Play("welcomeBanner_show");
            int textId = islandBalancing.islandWelcomeTextId[currentIsland];
            welcomeText.text = localizerManager.LocalizedText(textId);
            lockText.GetComponent<autoSizeText>().RedoFontSize();
            SaveIslandWelcomeCount(currentIsland);
            yield return new WaitForSeconds(welcomeShowTime);

            //////////////////////////////////////////////////////////// Show Tuto
            //tutorialManager.ShowTuto(20, false);

        }



        //////////////////////////////////////////////////////////// Show Arrows
        arrowShown[0] = true;
        arrowShown[1] = true;
        if (currentIsland == 0)
            arrowShown[0] = false;
        if (currentIsland == maxIsland)
            arrowShown[01] = false;

        ShowArrows();

        yield return new WaitForSeconds(arrowShowTime);




        yield return null;
    }



    public void ShowArrows()
    {
        if(saveManager.GetSavedInt("tutorialCompleted") == 1)
        {
            if (arrowShown[0])
                arrows[0].GetComponent<Animation>().Play("arrow_show");
            if (arrowShown[1])
                arrows[1].GetComponent<Animation>().Play("arrow_show");
        }

    }

    public void HideArrows()
    {

        if (arrowShown[0])
            arrows[0].GetComponent<Animation>().Play("arrow_hide");

        if (arrowShown[1])
            arrows[1].GetComponent<Animation>().Play("arrow_hide");

    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveIslandWelcomeCount(int islandId)
    {
        int currentCount = saveManager.GetSavedInt("islandWelcomeShown_" + islandId);
        saveManager.SaveInt("islandWelcomeShown_" + islandId, currentCount + 1);
    }
}
