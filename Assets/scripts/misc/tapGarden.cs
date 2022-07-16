using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapGarden : MonoBehaviour
{
    public GameObject parentObject;

    // Update is called once per frame
    void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
        transform.parent.gameObject.SetActive(true);
    }

    public void TapCollider()
    {
        parentObject = transform.parent.parent.gameObject;
        parentObject.GetComponent<gardenDecorationControler>().Tap();
    }
}
