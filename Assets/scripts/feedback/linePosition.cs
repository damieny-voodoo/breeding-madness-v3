using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linePosition : MonoBehaviour
{

    public Transform[] positionGuides;

       
    public void ResetLinePosition()
    {

        for (int i = 0; i < positionGuides.Length; i++)
        {
            positionGuides[i].position = transform.position;
            GetComponent<LineRenderer>().SetPosition(i, transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i< positionGuides.Length; i++) 
        {
            GetComponent<LineRenderer>().SetPosition(i, positionGuides[i].position);
        }


    }
}
