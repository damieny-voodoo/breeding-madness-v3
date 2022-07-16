using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridController : MonoBehaviour
{
    public int gridId;
    //public GameObject tile;
    public GameObject[] tileList;
    //public Color[] tilesColors;
    //public Color[] tilesColorsLocked;

    //public int[] gridSize;
    //public Vector2 defaultUnlockedMin;
    //public Vector2 defaultUnlockedMax;

    private void Awake()
    {
        gameObject.name = "grid" + gridId.ToString();
        GetTiles();
    }

    void GetTiles()
    {
        for (int i = 0; i < tileList.Length; i++)
            tileList[i] = transform.Find("tile"+ gridId.ToString()+"_" + i.ToString()).gameObject;


    }

    public void CheckTilesPrices()
    {
        for (int i = 0; i < tileList.Length; i++)
        {
            tileController controller = tileList[i].GetComponent<tileController>();
            if (!controller.isPurchased)
            {
                if (controller.isOpen)
                {
                    if (controller.isUnlocked)
                        controller.CheckState(false);
                }
            }
        }

    }

    public void CheckTilesLock(int newLevel)
    {
        for (int i = 0; i < tileList.Length; i++)
        {
            tileController controller = tileList[i].GetComponent<tileController>();
            if (!controller.isPurchased)
            {
                if (controller.isOpen)
                {
                    if (controller.unlockLevel == newLevel)
                        controller.CheckState(false);
                }
            }
        }

    }
}
