using UnityEngine;
using System.Collections;

public class birdManager : MonoBehaviour
{
    public birdBalancing birdBalancing;
    public tapManager tapManager;
    public GameObject birdPrefab;
    //public GameObject gameProperties;

    public Vector2 posZ;
    public Vector2 animationSpeed;
    public float minDispersion;
    public float maxDispersion;

    float tickRate = .5f;
    float nextTick;
    public float currentProgress;

    public bool debugOn;

    public float birdsSpeed;


    void Start()
    {

        birdBalancing = GameObject.Find("balancingData").GetComponent<birdBalancing>();
        tapManager = GetComponent<tapManager>();
        currentProgress = 0;
        nextTick = Time.time + tickRate;

        StartCoroutine(ContinueProgress());

    }

    IEnumerator ContinueProgress()
    {
        yield return new WaitForSeconds(tickRate);

        if (!tapManager.isGardenFocus)
        {
            AddProgress();

            if (currentProgress >= 1000)
            {
                currentProgress = 0;
                CreateBirds();
            }
        }


        StartCoroutine(ContinueProgress());

    }

    /*

    private void Update()
    {
        ///////////////////////// ADD PROGRESS
        if(Time.time > nextTick)
        {
            nextTick = Time.time + tickRate;
            if (!tapManager.isGardenFocus)
                AddProgress();
        }

        if (currentProgress >= 1000)
        {
            currentProgress = 0;
            if (!tapManager.isGardenFocus)
                CreateBirds();
        }
    }
    */

    void AddProgress()
    {
        int currentEnergy = GameObject.Find("gameProperties").GetComponent<resourcesManager>().currentEnergy;
        bool amountPicked = false;

        for (int i=0;i< birdBalancing.energyThresholds.Length; i++)
        {
            if (currentEnergy <= birdBalancing.energyThresholds[i] && !amountPicked)
            {
                currentProgress += birdBalancing.progressToAdd[i];
                amountPicked = true;
            }
        }
    }

    void CreateBirds()
    {

        int randomBird = Random.Range(1, birdBalancing.maxBirds+1);
        float m_posZ = Random.Range(posZ.x, posZ.y);


        for (int i =0;i< randomBird; i++)
        {
            GameObject instantiatedBird = ObjectPool.SharedInstance.GetPooledObject("bird");
            instantiatedBird.SetActive(true);

            m_posZ = m_posZ + Random.Range(minDispersion, maxDispersion);
            instantiatedBird.transform.position = new Vector3(-3.27f, 4.01f, m_posZ);

            float m_speed = Random.Range(animationSpeed.x, animationSpeed.y);
            instantiatedBird.GetComponent<Animation>()["a_bird_fly"].speed = m_speed;
            instantiatedBird.GetComponent<birdController>().animSpeed = m_speed * birdsSpeed;
            instantiatedBird.GetComponent<birdController>().InitBird();
            
        }


    }

}
