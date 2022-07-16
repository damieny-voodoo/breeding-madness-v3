using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDisableObjectAtStart : MonoBehaviour
{
    public GameObject[] objectList;
    void Start()
    {
        foreach(GameObject go in objectList)
        {
            if (go)
            {
                go.SetActive(true);
                go.SetActive(false);

            }
        }
    }


}
