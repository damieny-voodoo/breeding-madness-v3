using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDisableAtStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Enable " + gameObject.name);
        //gameObject.SetActive(true);
        gameObject.SetActive(false);

        //Debug.Log("Disable " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
