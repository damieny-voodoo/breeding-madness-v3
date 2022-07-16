using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionAnimation : MonoBehaviour
{

    public AnimationCurve animCurve;

    private float startTime;
    public float animationDelay;
    public float timeMin;
    public float timeMax;
    private float timeFinal;

    public float heightMin;
    public float heightMax;
    private float heightStart;
    private float heightFinal;

    private void Start()
    {
        Debug.LogWarning("Start");
        StartAnimation(Time.time);
    }
    public void StartAnimation( float timeStarted)
    {
        timeFinal = Random.Range(timeMin, timeMax);
        heightFinal = heightStart+ Random.Range(heightMin, heightMax);
        startTime = timeStarted + animationDelay;
        heightStart = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float currentCurveValue = animCurve.Evaluate((Time.time - startTime)/ timeFinal);
        float currentHeight = heightStart + ((heightFinal - heightStart) * currentCurveValue);
        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
    }
}
