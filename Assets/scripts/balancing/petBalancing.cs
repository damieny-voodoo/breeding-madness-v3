using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petBalancing : MonoBehaviour
{
    public int[] id;
    public string[] family;
    public string[] codeName;
    public int[] locaId;
    public int totalStats;
    public int[,] defaultStats;

    public int[,,] itemId;
    public int[,] itemMinTier;
    public int[,] itemMaxTier;

    public int[,] happyChance;

    public int[] maxBreed;

    public int[,] breedPrice;
    public int[,] sellPrice;

    public int[,] offspringOptions;
    public int[] offspringChance;
    public int[,] offspringTotalStatsRequired;
    public int[,] offspringMinStatRequired;

    public string[] descriptionText;
    public string[] titleText;

    public int[] areaId;

    public int[] maxLevel;

    public int[,] minHappinessRequirement;
    public int[,] happinessIncrease;

    public int possibleFoodOptions;
    public int[] petTier;

}
