using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contextualTutorial_drag : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public AnimationCurve moveAnimation;
    public float moveTime;
    float moveStart;
    float loopedProportion;
    public float animationTime;
    bool hasStarted;
    Animation anim;
    public float proportion;
    public string animationName;



    public void StartAnimation(Vector3 item1, Vector3 item2)
    {
        moveStart = Time.time;
        anim = GetComponent<Animation>();
        startPosition = item1;
        endPosition = item2;
        // Debug.Log(animationName);
        anim[animationName].speed = 1 / (moveTime/ animationTime);

    }



    private void Update()
    {
        if(moveStart> 0)
        {            
            proportion = (Time.time - moveStart);
            int ceil = Mathf.CeilToInt(proportion/moveTime) - 1;
            loopedProportion = (proportion - (moveTime* ceil))/moveTime;
            transform.position = startPosition + ((endPosition-startPosition)*moveAnimation.Evaluate(loopedProportion));
        }
    }
}
