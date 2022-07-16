using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GameAnalyticsSDK;

public class analyticsStarter : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        analyticsManager analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
        //GameAnalytics.Initialize();
        yield return new WaitForSeconds(0);

        //GameAnalytics.SetCustomId(SystemInfo.deviceUniqueIdentifier);
        yield return new WaitForSeconds(0);

        analyticsManager.isInitialized = true;
        yield return new WaitForSeconds(0);

        analyticsManager.InitA();
        yield return new WaitForSeconds(0);

    }

}
