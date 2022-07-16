using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class progressiveReveal : MonoBehaviour
{
    public int[] tutorialProgress;
    public GameObject[] itemToReveal;
    public int currentProgress;

    private void Start()
    {
        Debug.Log(gameObject.name);
    }

}
