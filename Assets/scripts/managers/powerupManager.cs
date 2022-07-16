using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupManager : MonoBehaviour
{
    [Header("CURRENT ------------")]
    public int currentPowerup;
    public int powerupLeft;

    saveManager saveManager;

    private void Start()
    {
        saveManager = GetComponent<saveManager>();

        GetData();
    }


    void GetData()
    {
        
    }

    public void UsePowerUp()
    {

    }

    void FinishPowerup()
    {

    }


}
