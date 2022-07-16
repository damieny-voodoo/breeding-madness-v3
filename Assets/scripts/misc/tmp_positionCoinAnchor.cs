using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tmp_positionCoinAnchor : MonoBehaviour
{
    public float proportionWidth;
    public float proportionHeight;
    public float heightOffset;
    public Vector2 offestBottom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPosition = new Vector3(0, heightOffset, 0);
        Plane plane = new Plane(new Vector3(0, heightOffset, 0), 0);
        float distance;
        float posX =  Screen.safeArea.width * proportionWidth;
        offestBottom = Screen.safeArea.min;
        float posZ = Screen.safeArea.height * proportionHeight + Screen.safeArea.min.y;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posZ, 0));
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
        transform.position = new Vector3(worldPosition.x, heightOffset, worldPosition.z);


        Ray ray2 = Camera.main.ScreenPointToRay(new Vector3(posX, posZ, 0));
        Debug.DrawRay(ray2.origin, ray2.direction * 10, Color.yellow);
    }
}
