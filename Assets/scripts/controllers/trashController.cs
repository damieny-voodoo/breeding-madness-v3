using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashController : MonoBehaviour
{
    public GameObject bomb;
    saveManager saveManager;

    private void Start()
    {
        //Debug.LogWarning("Start");
        GameObject properties = GameObject.Find("gameProperties");
        saveManager = properties.GetComponent<saveManager>();

        if (saveManager.GetSavedInt("tutorialCompleted") == 1)
            CreateNewBomb();
    }


    public void CreateNewBomb()
    {

        GameObject newBomb = ObjectPool.SharedInstance.GetPooledObject("item_bomb");
        newBomb.SetActive(true);

        newBomb.transform.parent = transform;
        newBomb.transform.localPosition = Vector3.zero;
        newBomb.GetComponent<itemController>().associatedTrash = gameObject;

    }
}
