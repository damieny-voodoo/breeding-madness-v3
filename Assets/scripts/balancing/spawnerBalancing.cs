using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerBalancing : MonoBehaviour
{
    public int[,] familyDropID;
    public int familyCount;
    public int[] weight;
    public int[,,,] dropWeight;
    public bool[] seedsRequired;
    public int[] seedsNeeded;
    public int[] noSeedTextId;
    public string[] spawnerIds;
    public int[] startId;
    public int[] waterPrice;
    public int[] gridId;
    public int[] sunPrice;
}
