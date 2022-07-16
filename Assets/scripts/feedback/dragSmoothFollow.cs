using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragSmoothFollow : MonoBehaviour
{
    public Transform objectToFollow;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime;


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPosition = objectToFollow.position;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
