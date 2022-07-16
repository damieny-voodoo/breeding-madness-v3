using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adBalancing : MonoBehaviour
{
    // FORCED ADS
    public int forcedAdMinLevel;
    public int forcedAdTime;

    public bool forcedAdActive;
    public bool forcedAdNewItemActive;
    public bool forcedAdTravelActive;
    public bool forcedAdUnlockActive;



    // REWARDED ADS - ENERGY 
    public bool energyAdRefillActive;
    public int energyAdRefillAmount;


    // REWARDED ADS - SEED
    public bool seedAdRefillActive;
    public int[] seedAdRefillAmount;


    // REWARDED ADS - COLLECTION
    public bool energyAdCollectionActive;

    // REWARDED ADS - COLLECTION
    public bool energyAdShopActive;

    // IDLE ADS
    public bool idleAdActive;
    public int idleAdTime;


}
