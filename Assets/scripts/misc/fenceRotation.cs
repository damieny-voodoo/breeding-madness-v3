using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceRotation : MonoBehaviour
{
    public GameObject fence;
    public Vector2 randomRotation;
    void OnEnable()
    {
        RandomizeRotation();
    }

    // Update is called once per frame
    void RandomizeRotation()
    {
        float newRotation = Random.Range(randomRotation.x, randomRotation.y);
        fence.transform.eulerAngles = new Vector3(newRotation, fence.transform.eulerAngles.y, fence.transform.eulerAngles.z);

    }
}
