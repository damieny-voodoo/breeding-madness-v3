using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followObject : MonoBehaviour
{
    public Transform objectToFollow;
    public Transform objectFollowing;

    public void StartTrail(Transform obj)
    {
        objectToFollow = obj;
        /*
        transform.position = objectToFollow.position;

        if (objectFollowing && objectToFollow)
            objectFollowing.position = objectToFollow.position;
            */
    }


    void Update()
    {
        if (objectFollowing && objectToFollow)
            objectFollowing.position = objectToFollow.position;
        else
        {
            /// ----- pool section
            //Destroy(gameObject);
            ObjectPool.SharedInstance.ReleaseObject(gameObject);
            /// ----- pool section
        }
    }
}
