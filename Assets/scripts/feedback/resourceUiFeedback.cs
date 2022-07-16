using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resourceUiFeedback : MonoBehaviour
{
    [Header("MANAGERS -----------")]
    public resourcesManager resourcesManager;
    public string resourceType;
    public int rewardAmount;

    [Header("SIZE -----------")]
    public RectTransform self;
    public float refSize;
    public float screenRefSize;
    public Vector2 imageSize;

    [Header("DELAY -----------")]
    public float popDelay;
    public float startDelay;
    public float startTime;
    public Vector2 startPosition;

    [Header("STEP 1 -----------")]
    public Vector2 step1PosVariation;
    public float step1Time;
    public AnimationCurve step1Scale;
    public AnimationCurve step1AnimX;
    public AnimationCurve step1AnimY;
    public Vector2 step1Position;

    [Header("PAUSE -----------")]
    public float pauseTime;


    [Header("STEP 2 -----------")]
    public float step2Time;
    public Vector2 targetPosition;
    public AnimationCurve animScale;
    public int randomAnim;
    public AnimationCurve[] animX;
    public AnimationCurve[] animY;




    public void LaunchFeedback(string type, Vector2 startPos, int rAmount, float index, string source)
    {
        // FIND OBJECTS
        self = GetComponent<RectTransform>();
        resourcesManager = GameObject.Find("gameProperties").GetComponent<resourcesManager>();

        // Random Anims
        randomAnim = Random.Range(0, animX.Length);

        // REWARD
        rewardAmount = rAmount;

        // TYPE
        resourceType = type;

        // TIMER
        startDelay = index * popDelay;
        pauseTime = pauseTime *Random.Range(.9f, 1.1f);


        // Start Pos
        startPosition = startPos;
        // Step 1 Pos
        float rX = startPos.x + Random.Range(-step1PosVariation.x, step1PosVariation.x);
        float rY = startPos.y + Random.Range(-step1PosVariation.y, step1PosVariation.y);
        step1Position = new Vector3(rX, rY, 0);
        // Final Pos
        if (resourceType == "energy")
            targetPosition = new Vector2(.63f, .97f);
        else if (resourceType == "fertilizer")
            targetPosition = new Vector2(.05f, .9f);
        else if (resourceType == "diamonds")
            targetPosition = new Vector2(.25f, .97f);



        // ICON
        Sprite ico = Resources.Load<Sprite>("UI/icons/common/ICO_" + resourceType);
        GetComponent<Image>().sprite = ico;

        // IMAGE SIZE
        float newSize = refSize *(Screen.width/ screenRefSize);
        imageSize = new Vector2(newSize, newSize);

        // RESET VALUES
        self.rotation = new Quaternion(0, 0, 0, 0);
        self.localPosition = new Vector3(0, 0, 0);

        // GO
        StartCoroutine(AnimateIcon(source));


    }


    IEnumerator AnimateIcon(string source)
    {
        float stepStartTime;

        /////////////////////////////// DELAY
        yield return new WaitForSeconds(startDelay);


        /////////////////////////////// STEP 1
        stepStartTime = Time.time;
        while (Time.time < (stepStartTime + step1Time))
        {

            float timeProportion = (Time.time - stepStartTime) / step1Time;

            // POSITION X
            float xEval = step1AnimX.Evaluate(timeProportion);
            float xValue = startPosition.x + ((step1Position.x - startPosition.x) * xEval);
            // POSITION Y
            float yEval = step1AnimY.Evaluate(timeProportion);
            float yValue = startPosition.y + ((step1Position.y - startPosition.y) * yEval);
            // SCALE
            float scaleEval = step1Scale.Evaluate(timeProportion);
            float scaleValue = scaleEval;


            // Apply
            self.anchorMin = new Vector2(xValue, yValue);
            self.anchorMax = new Vector2(xValue, yValue);
            self.offsetMin = new Vector2(-imageSize.x / 2, -imageSize.y / 2);
            self.offsetMax = new Vector2(imageSize.x / 2, imageSize.y / 2);
            self.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

            yield return null;

        }
        /////////////////////////////// PAUSE
        yield return new WaitForSeconds(pauseTime);



        /////////////////////////////// STEP 2
        stepStartTime = Time.time;
        while ( Time.time < (stepStartTime + step2Time))
        {

            float timeProportion = (Time.time - stepStartTime) / step2Time;

            // POSITION X
            float xEval = animX[randomAnim].Evaluate(timeProportion);
            float xValue = step1Position.x + ((targetPosition.x - step1Position.x) * xEval);
            // POSITION Y
            float yEval = animY[randomAnim].Evaluate(timeProportion);
            float yValue = step1Position.y + ((targetPosition.y - step1Position.y) * yEval);
            // SCALE
            float scaleEval = animScale.Evaluate(timeProportion);
            float scaleValue = scaleEval;


            // Apply
            self.anchorMin = new Vector2(xValue, yValue);
            self.anchorMax = new Vector2(xValue, yValue);
            self.offsetMin = new Vector2(-imageSize.x / 2, -imageSize.y / 2);
            self.offsetMax = new Vector2(imageSize.x / 2, imageSize.y / 2);
            self.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

            yield return null;

        }


        // FINISH
        GiveReward(source);
        Destroy(gameObject);




    }

    void GiveReward(string source)
    {
        if (resourceType == "energy")
            resourcesManager.AddEnergy(rewardAmount);
        else if (resourceType == "fertilizer")
            resourcesManager.AddFertilizer(rewardAmount);
        else if (resourceType == "diamonds")
            resourcesManager.AddDiamonds(rewardAmount, source);

    }




}
