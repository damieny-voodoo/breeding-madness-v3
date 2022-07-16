using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraAnimation : MonoBehaviour
{
    public float zoomInZFactor;
    public float zoomInZStart;
    public float zoomInSmoothing;
    Camera thisCamera;

    public float targetFocus;
    public float zoomTime;

    public float xOffset;

    public AnimationCurve focusAnim;

    Vector3 defaultPos;
    float defaultFocus =5;

    private void Start()
    {
        thisCamera = GetComponent<Camera>();
        defaultPos = transform.position;
    }


    public void ZoomIn(Transform petTarget, bool overrideX,  float overideXoffSet)
    {
        StopAllCoroutines();
        StartCoroutine(ZoomInSequence(petTarget, overrideX, overideXoffSet));
    }
    public void ZoomOut()
    {
        StartCoroutine(ZoomOutSequence());
    }

    public IEnumerator ZoomInSequence(Transform petTarget, bool overrideX, float overideXoffSet)
    {
        if (Camera.main.GetComponent<Animation>().isPlaying)
            Camera.main.GetComponent<Animation>().Stop();

        // POS
        float zOffset = zoomInZStart + (zoomInZFactor * petTarget.localPosition.z);
        float xTarget = petTarget.position.x + xOffset;
        if (overrideX)
            xTarget = petTarget.position.x + overideXoffSet;
        Vector3 startPos = transform.position;
        Vector3 targetPos = new Vector3(xTarget, startPos.y, zOffset);
        Vector3 maxPosDiff = targetPos - startPos;

        // FOCUS
        float startTime = Time.time;
        float startingFocus = Camera.main.orthographicSize;
        float maxSizeDiff = targetFocus - startingFocus;

        while (Time.time < startTime + zoomTime)
        {
            float proportion = (Time.time - startTime) / zoomTime;
            float evaluation = focusAnim.Evaluate(proportion);

            // ZOOM
            float camSize = startingFocus + (maxSizeDiff * evaluation);
            Camera.main.orthographicSize = camSize;

            // POS X
            Vector3 pos = startPos + (maxPosDiff * evaluation);
            transform.position = pos;
            yield return null;
        }

        Debug.Log("Zoom in done");

        yield return null;
    }    
    
    
    public IEnumerator ZoomOutSequence()
    {
        // POS
        Vector3 startPos = transform.position;
        Vector3 maxPosDiff = defaultPos - startPos;

        // FOCUS
        float startTime = Time.time;
        float startingFocus = Camera.main.orthographicSize;
        float maxSizeDiff = defaultFocus - startingFocus;

        while (Time.time < startTime + zoomTime)
        {
            float proportion = (Time.time - startTime) / zoomTime;
            float evaluation = focusAnim.Evaluate(proportion);

            // ZOOM
            float camSize = startingFocus + (maxSizeDiff * evaluation);
            Camera.main.orthographicSize = camSize;

            // POS X
            Vector3 pos = startPos + (maxPosDiff * evaluation);
            transform.position = pos;
            yield return null;
        }

        Debug.Log("Zoom out done");

        yield return null;
    }
}
