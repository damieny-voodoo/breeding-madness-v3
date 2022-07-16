using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour
{

    float maxX = 30f;
    float smoothing = 1f;
    public float animSpeed = 0f;
    public Vector3 startPos;
    public Vector3 targetPos;

    public void InitBird()
    {
        startPos = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
        targetPos = new Vector3(transform.localPosition.x + maxX, transform.localPosition.y, transform.localPosition.z);
        StartCoroutine(MoveBird(targetPos));

    }


    public void TapBird()
    {

        GameObject instantiatedExplosion = ObjectPool.SharedInstance.GetPooledObject("birdExplosion");
        instantiatedExplosion.SetActive(true);
        instantiatedExplosion.transform.position = transform.position;

        GameObject.Find("gameProperties").GetComponent<feedbackManager>().CoinSpawn(1, gameObject, 0f, "energy");

        ObjectPool.SharedInstance.ReleaseObject(transform.gameObject);

    }



    IEnumerator MoveBird( Vector3 targetPosition)
    {
        while (Vector3.Distance(transform.position, targetPosition) > 0.05f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, smoothing * Time.deltaTime * animSpeed);
            yield return null;
        }

        ObjectPool.SharedInstance.ReleaseObject(transform.gameObject);


        yield return null;

    }
}
