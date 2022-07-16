using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class petBehavior : MonoBehaviour
{
    [Header("MOVE ------------")]
    public bool isMoving = false;
    public float moveSpeed = 1f;
    public float maxMoveDuration = .5f;


    [Header("EAT ------------")]
    public bool isEating = false;

    public float minEatTime = 3f;
    public float maxEatTime = 4f;


    [Header("JUMP ------------")]
    public bool isJumping = false;
    public float jumpTime = 0f;
    public float jumpLoopDelay = 1f;
    public float rotateSpeed = 1f;

    [Header("IDLE ------------")]
    public float minWaitTime = 1f;
    public float maxWaitTime = 2f;


    petController petController;
    petManager petManager;
    saveManager saveManager;

    GameObject spawnedArt;


    private void Awake()
    {

        GameObject gameProperties = GameObject.Find("gameProperties");
        petManager = gameProperties.GetComponent<petManager>();
        saveManager = gameProperties.GetComponent<saveManager>();

        petController = GetComponent<petController>();

        GetSpawnedArt();

        GetJumpTime();
    }

    void Start()
    {
        if( !isJumping && !isEating)
        StartIdle();
    }
    void GetSpawnedArt()
    {
        if (petController.spawnedArt)
            spawnedArt = petController.spawnedArt;
    }

    void GetJumpTime()
    {
        if (spawnedArt)
        {
            AnimationClip[] clips = spawnedArt.GetComponent<Animator>().runtimeAnimatorController.animationClips;
            foreach (AnimationClip clip in clips)
            {
                if (clip.name == "Jump")
                    jumpTime = clip.length;
            }

        }
    }

    public void StartIdle()
    {
        StartCoroutine(StartIdleBehavior());
    }

    IEnumerator StartIdleBehavior()
    {
        // IDLE ANIM
        petController.spawnedArt.GetComponent<Animator>().SetInteger("animation", 0);

        // PAUSE
        float randomWait = Random.Range(minWaitTime, maxWaitTime);
        yield return new WaitForSeconds(randomWait);

        if (!petController.isEgg && saveManager.GetSavedInt("tutorialCompleted") == 1)
        {
            // DO ACTION
            int randomAction = Random.Range(0, 2);
            if (randomAction == 0)
                StartCoroutine(DoEat());
            else if (randomAction == 1)
                StartCoroutine(MoveTo());

        }

        yield return null;
    }

    IEnumerator DoEat()
    {
        // EAT ANIM
        petController.spawnedArt.GetComponent<Animator>().SetInteger("animation", 4);
        isEating = true;

        // WAIT FOR ANIM TO BE DONE
        float randomWait = Random.Range(minEatTime, maxEatTime);
        yield return new WaitForSeconds(randomWait);

        isEating = false;
        StartIdle();

        yield return null;
    }

    IEnumerator MoveTo()
    {
        // POSITION
        float randomX = Random.Range(0, petManager.petRandX);
        float randomZ = Random.Range(0, petManager.petRandZ);
        float posX = randomX + petController.associatedTile.localPosition.x;
        float posZ = randomZ + petController.associatedTile.localPosition.z;
        Vector3 targetPosition = new Vector3(posX, 0, posZ);

        // LOOK
        Vector3 direction = (targetPosition - transform.localPosition).normalized;
        float angle = transform.localEulerAngles.y + Vector3.SignedAngle(transform.forward, direction, transform.up);
        petController.artObject.localEulerAngles = new Vector3( 0, angle, 0);

        // ANIM
        petController.spawnedArt.GetComponent<Animator>().SetInteger("animation",2);

        // MOVE TIME MAX
        float maxMoveTime = Time.time + maxMoveDuration;

        // MOVE
        while (Vector3.Distance(transform.localPosition, targetPosition) > 0.1f && Time.time < maxMoveTime)
        {
            isMoving = true;
            transform.localPosition = Vector3.Lerp(transform.localPosition, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }

        isMoving = false;
        StartIdle();
        yield return null;
    }


    public void DoJump(int repeats)
    {

        StartCoroutine(Jump(repeats));

    }
    IEnumerator Jump(int repeats)
    {
        isJumping = true;

        if (!spawnedArt)
            GetSpawnedArt();

        if (jumpTime == 0)
            GetJumpTime();

        for (int i = 0; i < repeats; i++)
        {

            // JUMP ANIM
            spawnedArt.GetComponent<Animator>().SetInteger("animation", 3);

            // WAIT FOR ANIM TO BE DONE
            yield return new WaitForSeconds(jumpTime);

            // PAUSE
            petController.spawnedArt.GetComponent<Animator>().SetInteger("animation", 0);
            yield return new WaitForSeconds(jumpLoopDelay);
        }


        // END
        isJumping = false;
        StartIdle();
        yield return null;

    }


    public void StopAll()
    {
        StopAllCoroutines();
        isMoving = false;
        isEating = false;
        isJumping = false;
    }
}
