using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class startupManager : MonoBehaviour
{

    [Header("RELOAD GAME ------------")]
    //public int focusCount;
    //public int focusCountBeforeReload;
    //public GameObject reloadFilter;
    //public int lastClosedTime;
    //public int timeDelay;
    public bool isWatchingAd;
    public TextMeshProUGUI description;
    //public int[] loadingDescIds;

    [Header("RESTART ------------")]
    //public GameObject restartPopup;
    public GameObject forceRestartPopup;
    public GameObject restartConfirmationPopup;


    [Header("FORCE UPDATE ------------")]
    public float playerVersion;
    public float latestVersion;
    public bool forceUpdate;
    public bool popupIsOpen;

    public GameObject forceUpdatePopup;

    technicalData technicalData;
    saveManager saveManager;
    localizationData localizationData;

    private void Awake()
    {
        saveManager = GetComponent<saveManager>();

        CheckIslandMigration();
    }

    /////////////////////////////////////////////////////////////////////////////////////////// MIGRATIONS



    void CheckIslandMigration()
    {
        if (saveManager.GetSavedInt("tutorialCompleted") == 1 && saveManager.GetSavedInt("islandMigrationDone") == 0)
            MigrateIsland();

        else if(saveManager.GetSavedInt("tutorialCompleted") == 0)
            SaveMigrateIsland();

    }

    void MigrateIsland()
    {

        for (int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                string id = "tile_" + i.ToString() + "_" + j.ToString();
                string newId = "tile_0_" + i.ToString() + "_" + j.ToString();
                // TILE STATE
                int oldPurchased = saveManager.GetSavedInt(id + "_isPurchased");
                SaveTilePurchase(newId, oldPurchased);
                // ITEM
                string oldFamily = saveManager.GetSavedString(id + "_family");
                int oldId = saveManager.GetSavedInt(id + "_familyID");
                int oldTier = saveManager.GetSavedInt(id + "_tier");
                SaveTile(newId, oldFamily, oldId, oldTier);                
            }
        }

        SaveMigrateIsland();
    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// SAVE
    void SaveTile(string tileName, string itemFamily, int itemFamilyID, int itemTier)
    {
        saveManager.SaveString(tileName + "_family", itemFamily);                                   // Save family name on tile 
        saveManager.SaveInt(tileName + "_familyID", itemFamilyID);                                  // Save family ID on tile 
        saveManager.SaveInt(tileName + "_tier", itemTier);                                          // Save item tier on tile
    }

    void SaveTilePurchase(string newId, int oldPurchased)
    {
        saveManager.SaveInt(newId + "_isPurchased", oldPurchased); // save if tile has been purchased
    }

    void SaveMigrateIsland()
    {
        saveManager.SaveInt("islandMigrationDone", 1);
    }

}
