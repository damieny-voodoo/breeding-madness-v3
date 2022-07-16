using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orderBalancing : MonoBehaviour
{
    public float priceVariation;
    public float[,] startingPrices;
    public float[] tierMultiplier;
    public int[,] itemCountWeight;
    public float[] sellTime;
    public int[,] minTier;
    public int[,] maxTier;
    public int[,,] rewardDropRate;
    public int[] ordersUnlock;
    public float[] coinMultiplier;
    public int[] boatOrderIsland;

    public int[] forcedOrderId;
    public int[] forcedOrderItemCount;
    public string[,] forcedOrderFamilyPicked;
    public int[,] forcedOrderTierPicked;
    public int[] forcedOrderPrice;




}
