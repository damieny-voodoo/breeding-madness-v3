using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class timeNowManager : MonoBehaviour
{
    public int timeNow;
    bool getTime;
    float updateTime = 1f;

    void Awake()
    {
        getTime = true;
        StartCoroutine(TimeNowRoutine());
    }


    IEnumerator TimeNowRoutine()
    {
        while(getTime)
        {
            var newUnixTime = (System.DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
            int unixTimeInt = Convert.ToInt32(newUnixTime);
            timeNow = unixTimeInt;

            yield return new WaitForSeconds(updateTime);
        }

        yield return null;
    }
}
