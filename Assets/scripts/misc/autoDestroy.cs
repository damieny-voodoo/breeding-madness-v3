using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroy : MonoBehaviour
{
    public float destroyTime;
    float nextDestroy;


    void OnEnable()
    {
        nextDestroy = Time.time + destroyTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextDestroy)
        {
            /// ----- pool section
            ObjectPool.SharedInstance.ReleaseObject(gameObject);
            //Destroy(gameObject);
            /// ----- pool section
        }
    }
}
