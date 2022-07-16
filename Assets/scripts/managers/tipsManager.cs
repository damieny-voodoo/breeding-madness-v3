using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tipsManager : MonoBehaviour
{
    [Header("GENERAL")]
    public bool tipIsShowing;
    public Transform[] tipsRects;

    [Header("BALANCING")]
    public int showTipsMaxLevel;
    public int[] showTipsMinLevel;
    public int[] tipTotalCount;
    public int[] maxShowCount;
    public int[] tipShowFrequency;

    [Header("ANIMATION")]
    public float showDelay;
    public float tipOpenTime;
    public AnimationCurve tipOpen;
    public float tipCloseTime;
    public AnimationCurve tipClose;
    public float[] popupWaitTime;




    saveManager saveManager;
    xpManager xpManager;

    /////////////////////////////////////////// TIP IDs
    /// 0 = quick sell
    /// 1 = items must be the same to merge
    /// 2 = selling the wrong item
    /// 3 = destroy item to free up space
    /// 4 = purchase failed

    void Start()
    {
        saveManager = GetComponent<saveManager>();
        InitiateValues();
    }


    void InitiateValues()
    {
        for (int i = 0; i < tipTotalCount.Length; i++)
            tipTotalCount[i] = saveManager.GetSavedInt("tip_" + i.ToString() + "_totalCount");

        saveManager = GetComponent<saveManager>();
        xpManager = GetComponent<xpManager>();

    }

    public void CompleteTip(int tipId)
    {

        tipTotalCount[tipId] = (maxShowCount[tipId] * tipShowFrequency[tipId]);
        Save(tipId);

    }


    public void TriggerTip(int tipId)
    {
        int currentXp = xpManager.currentXp;
        int currentLevel = xpManager.GetLevel(currentXp);
        if(currentLevel>= showTipsMinLevel[tipId] && !tipIsShowing)
        {

            // UPDATE PROGRESS
            tipTotalCount[tipId]++;
            Save(tipId);

            // Show only X times in total
            int thisCount = tipTotalCount[tipId];
            if (thisCount <= (maxShowCount[tipId]*tipShowFrequency[tipId]) || maxShowCount[tipId] ==0)
            {
                // Show only every X times
                int modulo = thisCount % tipShowFrequency[tipId];
                if (modulo == 0)
                    ShowTip(tipId);

            }

        }

    }


    void ShowTip(int tipId)
    {
        //Debug.Log("Show tip " + tipId);

        tipIsShowing = true;
        StartCoroutine(AnimateTip(tipId));
    }


    IEnumerator AnimateTip(int tipId)
    {


        ////////////////// WAIT
        yield return new WaitForSeconds(showDelay);


        ////////////////// SCALE IN
        float startTime = Time.time;
        while (Time.time <= startTime + tipOpenTime)
        {
            float proportion = (Time.time - startTime) / tipOpenTime;
            float evaluation = tipOpen.Evaluate(proportion);
            float scaleY = 1f * evaluation;
            tipsRects[tipId].localScale = new Vector3(1f, scaleY, 1f);


            yield return null;

        }



        ////////////////// WAIT
        yield return new WaitForSeconds(popupWaitTime[tipId]);



        ////////////////// SCALE OUT
        startTime = Time.time;
        while (Time.time <= startTime + tipCloseTime)
        {
            float proportion = (Time.time - startTime) / tipCloseTime;
            float evaluation = tipClose.Evaluate(proportion);
            float scaleY = 1f * evaluation;
            tipsRects[tipId].localScale = new Vector3(1f, scaleY, 1f);


            yield return null;

        }


        tipsRects[tipId].localScale = new Vector3(1f, 0f, 1f);

        tipIsShowing = false;


    }

    void Save(int id)
    {
        saveManager.SaveInt("tip_" + id.ToString() + "_totalCount", tipTotalCount[id]);
    }

}
