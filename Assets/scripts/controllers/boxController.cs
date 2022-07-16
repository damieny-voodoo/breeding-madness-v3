using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{

    /// /////////////////////////////////////////////////////////// OBSOLETE ///////////////////////////////////////////////////////////
    /// 
    /*

    public float startHeight;
    public Transform boxChild;
    public float minX;
    public float maxX;
    public float destroyHeight;
    int waterReward;

    public string resourceType;

    int[] dropChances;
    public GameObject tutorialObject;


    void Start()
    {
        InitBalancing();
        StartPosition();
        PickWaterAmount();
    }

    // Update is called once per frame
    void StartPosition()
    {
        float spawnX = Random.Range(minX, maxX);
        boxChild.transform.localPosition = new Vector3(spawnX, 0f, 0f);
        GetComponent<Animation>()["a_box"].speed = Random.Range(.9f, 1.1f);
    }

    void PickWaterAmount()
    {
        int dropLength = dropChances.Length;
        int simulationsToDo = 1;
        for( int i=0; i < simulationsToDo; i++)
        {
            int randomDrop = Random.Range(0, dropLength);
            waterReward = dropChances[randomDrop];
        }

    }

    void Update()
    {
        if(transform.position.y <= destroyHeight)
            DestroyBox();
    }

    public void TapBox()
    {
        DestroyBox();
    }

    void DestroyBox()
    {

        ///////////////// GIVE WATER
        Debug.Log("Box destroyed");

        ///////////////// GIVE WATER
        GameObject.Find("gameProperties").GetComponent<feedbackManager>().CoinSpawn(waterReward, boxChild.gameObject, 0f, resourceType);


        ///////////////// DESTROY
        /// ----- pool section
        //Destroy(transform.gameObject);
        ObjectPool.SharedInstance.ReleaseObject(gameObject);
        /// ----- pool section

        ///////////////// SAVE
        int currentBoxesCollected = PlayerPrefs.GetInt("current_" + resourceType + "_collected");
        GameObject.Find("gameProperties").GetComponent<saveManager>().SaveBoxesCollected(resourceType, currentBoxesCollected+1);

        ///////////////// CHECK TUTORIAL
        Checktutorial();

    }

    public void ShowTuto()
    {
        tutorialObject.SetActive(true);
    }

    void Checktutorial()
    {
        int currentBoxesCollected = PlayerPrefs.GetInt("current_" + resourceType + "_collected");
        Debug.Log("Boxes collected: "+ currentBoxesCollected);
        /*
        if (currentBoxesCollected == 1)
            GameObject.Find("gameProperties").GetComponent<tutorialManager>().ShowTuto(9, true);
            
    }


    void InitBalancing()
    {
        dropChances = new int[]
        {
            4,
            4,
            5,
            5,
            5,
            6,
            6,
            6,
        };




    }
    */
}
