using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadingAnimation : MonoBehaviour
{
    public float rotationSpeed;


   void Update ()
    {
        transform.Rotate(0.0f, 0.0f, rotationSpeed, Space.Self);

    }
}
