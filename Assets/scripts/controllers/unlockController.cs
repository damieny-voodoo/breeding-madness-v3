using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class unlockController : MonoBehaviour
{
    public bool isLocked;
    public int levelUnlock;
    public GameObject lockObject;
    public GameObject unlockObject;
    public GameObject unlockCard;
    public TextMeshPro levelLock;
    public TextMeshProUGUI levelLockUI;
    public GameObject unlockFx;
    public GameObject lockTapFeedback;
    public bool disableColliderOnUnlock;

    public bool unlockDone;
    public bool isNewUnlock = false;
    public bool isUnlockable = false;
    public float startUnlockTime;
    public float unlockDelay = 1f;

    saveManager saveManager;

    private void OnMouseDown()
    {

        ShowLockedFeedback();

    }


    public void InitiateLock()        
    {
        saveManager = GameObject.Find("gameProperties").GetComponent<saveManager>();

        int currentXp = saveManager.GetSavedInt("currentXp");
        int currentLevel = GameObject.Find("gameProperties").GetComponent<xpManager>().GetLevel(currentXp);


        /////////////////////////////////////////////////////////////////////////// GET OBJECTS
        //Debug.Log("Set object lock values: " + gameObject.name);
        isLocked = false;
        Transform[] childrenList = gameObject.GetComponentsInChildren<Transform>();
        {
            foreach(Transform t in childrenList)
            {
                if (t.name == "locked")
                    lockObject = t.gameObject;
                if (t.name == "unlocked")
                    unlockObject = t.gameObject;
                if (t.name == "lockedCard")
                    unlockCard = t.gameObject;
                if (t.name == "unlockLevel")
                    levelLock = t.GetComponent<TextMeshPro>();
                if (t.name == "unlockLevelUI")
                    levelLockUI = t.GetComponent<TextMeshProUGUI>();
                if (t.name == "unlock_tapFeedback")
                    lockTapFeedback = t.gameObject;

            }
        }

        if (lockObject.GetComponent<Button>())
        {
            lockObject.GetComponent<Button>().onClick.AddListener(ShowLockedFeedback);
        }

        unlockFx = Resources.Load<GameObject>("/feedback/unlock/FX/feedback_unlock");
        unlockDone = false;
        isNewUnlock = false;
        isUnlockable = false;
        startUnlockTime = 0;
        unlockDelay = 1.5f;


        /////////////////////////////////////////////////////////////////////////// MAKE SURE IT IS UNLOCKED AT GAME START
        if (currentLevel >= levelUnlock)
        {
            if(lockObject)
                lockObject.SetActive(false);
            if (unlockObject)
                unlockObject.SetActive(true);
            if(unlockCard)
                unlockCard.SetActive(false);
            if (lockTapFeedback)
                lockTapFeedback.SetActive(false);

            if (GetComponent<Collider>() && disableColliderOnUnlock)
                GetComponent<Collider>().enabled = false;
        }
        else
            LockItem();

    }


    public void LockItem()
    {

        //Debug.Log("Lock " +gameObject.name+". Unlock level: "+ levelUnlock);
        isLocked = true;
            if(lockObject)
        lockObject.SetActive(true);
        if (unlockObject)
            unlockObject.SetActive(false);

        if (levelLock)
            levelLock.text = levelUnlock.ToString();
        else if (levelLockUI)
            levelLockUI.text = levelUnlock.ToString();
    }



    public void UnlockItem (bool newUnlock)
    {
        startUnlockTime = Time.time;
        isNewUnlock = newUnlock;
        unlockDone = false;
        isUnlockable = true;
    }


    private void Update()
    {
        if(!unlockDone && isUnlockable && Time.time > startUnlockTime + unlockDelay)
        {
            DoUnlock();
            unlockDone = true;
        }

    }

    public void ShowLockedFeedback()
    {
        if (!GameObject.Find("gameProperties").GetComponent<tapManager>().popupOpen)
        {
            if (lockTapFeedback && isLocked)
            {
                lockTapFeedback.SetActive(true);
                lockTapFeedback.GetComponent<Animation>().Play("a_lockedFeedback");
            }

        }


    }

    void DoUnlock()
    {
        //Debug.Log("Unlock " + gameObject.name);
        isLocked = false;

        lockObject.SetActive(false);
        unlockObject.SetActive(true);

        if (lockTapFeedback)
            lockTapFeedback.SetActive(false);

        if (GetComponent<Collider>() && disableColliderOnUnlock)
            GetComponent<Collider>().enabled = false;

        if (isNewUnlock)
        {

            GameObject newFx = ObjectPool.SharedInstance.GetPooledObject("feedback_unlock");
            newFx.SetActive(true);
            newFx.transform.position = transform.position;
        }

        if (unlockCard)
            unlockCard.SetActive(false);


    }

}
