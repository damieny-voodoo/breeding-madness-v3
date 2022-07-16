using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemAnimationController : MonoBehaviour
{
    
    public Animation itemAnimation;
    public bool canSell = false;
    public float spawnAnimationTime;
    public float animationTimeEnd;
    public GameObject artObject;
    public bool spawnAnimationPlaying;


    private void Start()
    {
        //Debug.LogWarning("Start");
        itemAnimation = transform.Find("art").gameObject.GetComponentInChildren<Animation>();

        if (itemAnimation)
            SpawnItemAnimation();
    }

    void OnEnable()
    {

        //Debug.LogWarning("Start");
        itemAnimation = transform.Find("art").gameObject.GetComponentInChildren<Animation>();

        if (itemAnimation)
            SpawnItemAnimation();

    }


    public void Update()
    {
        
        if (itemAnimation)
        {
            if (Time.time <= animationTimeEnd)
                spawnAnimationPlaying = true;
            else
                spawnAnimationPlaying = false;
        }

        if (spawnAnimationPlaying)
        {
            itemAnimation.Play("a_spawn");
        }
        else if(canSell)
        {
            itemAnimation.Play("a_canSell");
        }
        else
        {
            itemAnimation.Play("a_idle");
        }

    }



    public void SpawnItemAnimation()
    {
        animationTimeEnd = Time.time + spawnAnimationTime;
    }

}
