using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnerManager : MonoBehaviour
{
    public GameObject[] spawnerList;
    public Sprite[] spawnerImages;

    spawnerBalancing spawnerBalancing;


    void Start()
    {
        GetData();

    }

    // Update is called once per frame
    void GetData()
    {

        spawnerBalancing = GameObject.Find("balancingData").GetComponent<spawnerBalancing>();

        spawnerList = new GameObject[spawnerBalancing.spawnerIds.Length];
        spawnerImages = new Sprite[spawnerBalancing.spawnerIds.Length];
        for (int i=0;i< spawnerBalancing.spawnerIds.Length; i++)
        {
            spawnerList[i] = GameObject.Find(spawnerBalancing.spawnerIds[i]);
            spawnerList[i].GetComponent<spawnerController>().spawnerId = i;
            spawnerList[i].GetComponent<spawnerController>().InitData();

            spawnerImages[i] = Resources.Load<Sprite>("UI/icons/spawners/" + spawnerBalancing.spawnerIds[i]);
        }

    }
}
