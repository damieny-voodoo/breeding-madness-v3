using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_positionAnim : MonoBehaviour
{
    public Transform coin;

    [Header("TYPE")]
    public string type;
    public bool toCollect;

    [Header("TIMINGS")]
    public float startDelay;
    public Vector2 onTileTime;
    public Vector2 waitTime;
    public Vector2 outTime;
    public float destroyTimeRatio;


    [Header("ANIMATIONS")]
    public AnimationCurve onTileAnimation;
    public Vector2 maxHeight;
    public AnimationCurve onTileHeightAnimation;
    public AnimationCurve onTileRotationAnimation;
    public AnimationCurve onTileScaleAnimation;
    public AnimationCurve outAnimationPosition;


    [Header("POSITION")]
    public Vector2 dispersionX;
    public Vector2 dispersionZ;
    public Vector3 startPosition;
    public Vector3 targetPosition;
    public Vector3 outTargetPosition;

    [Header("ROTATION")]
    public float idleRotationSpeed;
    public float mainRotationSpeed;
    public float maxRotationSpeed;
    public float outRotationSpeed;

    [Header("Other")]
    public int coinsAssociated;
    public GameObject itemLine;
    float currWaitTime;
    float currOnTileTime;
    float currOutTime;
    float startTime;
    float randomX;
    float randomZ;
    float randomHeight;

    float step1Time;
    float step2Time;
    float step3Time;
    float step4Time;
    float step5Time;




    // Start is called before the first frame update
    void Start()
    {
        //StartPop();
    }


    public void StartPop()
    {
        //Debug.Log("StartPop");
        toCollect = true;

        startPosition = transform.localPosition;
        randomX = startPosition.x + Random.Range(dispersionX.x, dispersionX.y);
        randomZ = startPosition.z + Random.Range(dispersionZ.x, dispersionZ.y);
        targetPosition = new Vector3(randomX, 0, randomZ);
        randomHeight = Random.Range(maxHeight.x, maxHeight.y);
        startTime = Time.time;
        currOnTileTime = Random.Range(onTileTime.x, onTileTime.y);
        currWaitTime = Random.Range(waitTime.x, waitTime.y);
        currOutTime = Random.Range(outTime.x, outTime.y);

        // Coin Final position
        Vector3 worldPosition = new Vector3(0, .001f, 0);
        Plane plane = new Plane(new Vector3(0, .001f, 0), 0);

        // TARGET POSITION
        float distance;
        float posX = 0;
        float posZ = 0;
        if (type == "coins")
        {
            posX = Screen.safeArea.width * .05f;
            posZ = Screen.safeArea.height * .96f + Screen.safeArea.min.y;
        }
        else if (type == "xp")
        {
            posX = Screen.safeArea.width * .5f;
            posZ = Screen.safeArea.height * .96f + Screen.safeArea.min.y;
        }

        else if (type == "energy")
        {
            posX = Screen.safeArea.width * .6f;
            posZ = Screen.safeArea.height * .96f + Screen.safeArea.min.y;
        }

        else if (type == "water")
        {
            posX = Screen.safeArea.width * .05f;
            posZ = Screen.safeArea.height * .94f + Screen.safeArea.min.y;
        }
        else if (type == "sun")
        {
            posX = Screen.safeArea.width * .05f;
            posZ = Screen.safeArea.height * .92f + Screen.safeArea.min.y;
        }

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posZ, 0));
        if (plane.Raycast(ray, out distance))
            worldPosition = ray.GetPoint(distance);
        outTargetPosition = new Vector3(worldPosition.x, .001f, worldPosition.z);



        //////////////////////////////////// TIMINGS
        //wait
        step1Time = startTime + startDelay;
        //pop
        step2Time = step1Time + currOnTileTime;
        //idle
        step3Time = step2Time + currWaitTime;
        //go out
        step4Time = step3Time + currOutTime;
        //kill
        step5Time = step3Time + currOutTime * destroyTimeRatio;

    }


    // Update is called once per frame
    void Update()
    {
        if (type == "xp")
        {
            Vector3 worldPosition = new Vector3(0, .001f, 0);
            float distance;
            float posX ;
            float posZ ;
            Plane plane = new Plane(new Vector3(0, .001f, 0), 0);
            posX = Screen.safeArea.width * .5f;
            posZ = Screen.safeArea.height * .96f + Screen.safeArea.min.y;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posZ, 0));
            if (plane.Raycast(ray, out distance))
                worldPosition = ray.GetPoint(distance);
            outTargetPosition = new Vector3(worldPosition.x, .001f, worldPosition.z);
            Vector3 relativePosition = transform.parent.InverseTransformPoint(outTargetPosition);
            outTargetPosition = relativePosition;
        }

        if (Time.time < step2Time)
            OnTileAnimation();

        else if (Time.time < step3Time)
            IdleAnimation();

        else if (Time.time > step4Time)
        {
            if (toCollect)
            {
                toCollect = false;

                if (type == "coins")
                    GameObject.Find("gameProperties").GetComponent<coinManager>().AddCoins(coinsAssociated);
                else if (type == "xp")
                    GameObject.Find("gameProperties").GetComponent<xpManager>().AddXp(coinsAssociated);
                else if (type == "energy")
                    GameObject.Find("gameProperties").GetComponent<resourcesManager>().AddEnergy(coinsAssociated);
                else if (type == "water")
                    GameObject.Find("gameProperties").GetComponent<resourcesManager>().AddWater(coinsAssociated);
                else if (type == "sun")
                    GameObject.Find("gameProperties").GetComponent<resourcesManager>().AddSun(coinsAssociated);
            }
            
            
            
            /// ----- pool section
            ObjectPool.SharedInstance.ReleaseObject(itemLine);
            ObjectPool.SharedInstance.ReleaseObject(gameObject);
            /// ----- pool section
        }


        else if (Time.time < step5Time)
            OutPosition();



    }

    void OnTileAnimation()
    {
        //Debug.Log(" Pop animation");
        float currentProgress = (Time.time - startTime - startDelay) / currOnTileTime;

        // HIEGHT
        float currHeight = onTileHeightAnimation.Evaluate(currentProgress) * randomHeight + startPosition.y;

        // X AND Y
        float posX = startPosition.x + onTileAnimation.Evaluate(currentProgress) * (targetPosition.x - startPosition.x);
        float posZ = startPosition.z + onTileAnimation.Evaluate(currentProgress) * (targetPosition.z - startPosition.z);

        // POSITION
        transform.localPosition = new Vector3(posX, currHeight, posZ);

        // ROTATION
        float currRotationSpeed = mainRotationSpeed + onTileRotationAnimation.Evaluate(currentProgress) * maxRotationSpeed;
        coin.Rotate(0.0f, 0.0f, currRotationSpeed, Space.Self);

        // SCALE
        float currScale = onTileScaleAnimation.Evaluate(currentProgress);
        transform.localScale = new Vector3(currScale, currScale, currScale);


    }


    void IdleAnimation()
    {
        //Debug.Log(" Idle animation");
        coin.Rotate(0.0f, 0.0f, idleRotationSpeed, Space.Self);

    }


    void OutPosition()
    {
        //Debug.Log(" Out animation");
        // X AND Y
        float currentProgress = (Time.time - step3Time) / (step4Time - step3Time);
        //Debug.Log(currentProgress);
        float posX = targetPosition.x + outAnimationPosition.Evaluate(currentProgress) * (outTargetPosition.x - targetPosition.x);
        float posY = targetPosition.y + outAnimationPosition.Evaluate(currentProgress) * (outTargetPosition.y - targetPosition.y);
        float posZ = targetPosition.z + outAnimationPosition.Evaluate(currentProgress) * (outTargetPosition.z - targetPosition.z);


        // POSITION
        transform.localPosition = new Vector3(posX, posY, posZ);

        // ROTATION
        coin.Rotate(0.0f, 0.0f, outRotationSpeed, Space.Self);



    }


}
