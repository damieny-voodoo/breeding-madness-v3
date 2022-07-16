using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayRotate : MonoBehaviour
{
    public Vector2 rotationSpeed;
    float r_rotationSpeed;
    public bool clockWise;
    void Start()
    {
        if (clockWise)
            r_rotationSpeed = Random.Range(rotationSpeed.x, rotationSpeed.y);
        else
            r_rotationSpeed = Random.Range(-rotationSpeed.x, -rotationSpeed.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, r_rotationSpeed);
    }
}
