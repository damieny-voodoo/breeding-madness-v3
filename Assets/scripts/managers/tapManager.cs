using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tapManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("ISLAND")]
    public Transform draggingObject;
    public bool popupOpen = false;
    public Transform stopDragObject;

    [Header("GARDEN")]
    public TextMeshProUGUI logText;
    public bool isGardenFocus = false;
    public bool isZooming = false;
    public float bottomMargin;
    public float tapHeight;

    public GameObject decorationTapped;
    public float tapDecoTiming;
    float gardenLastTap;
    public float gardenTotalTapTime;
    public float distanceSensibility;
    float tapDistance;
    Vector2 startTapPosition;
    Vector2 releaseTapPosition;


    [Header("TIME")]
    float lastTap;
    public float lastTapTime;
    bool isTapping;

    [Header("POPUPS")]
    public GraphicRaycaster[] popupList;
    public GraphicRaycaster[] mainMenuCanvas;




    // MISC
    analyticsManager analyticsManager;
    gardenManager gardenManager;
    tutorialManager tutorialManager;
    saveManager saveManager;

    private void Start()
    {
        tutorialManager = GetComponent<tutorialManager>();
        saveManager = GetComponent<saveManager>();
        gardenManager = GetComponent<gardenManager>();
        analyticsManager = GameObject.Find("analyticsManager").GetComponent<analyticsManager>();
    }


    void Update()
    {

        if (!popupOpen)
        {
            if (Application.isEditor)
                MouseControls();

            else
                TapControls();
        }

        ///////////// CALCULATE LAST TAP
        if (isTapping && isGardenFocus)
            gardenTotalTapTime = Time.time - gardenLastTap;
        if(isTapping || popupOpen || Time.time <5f)
            lastTapTime = 0;
        else
            lastTapTime = Time.time - lastTap;
    }

    //////////////////////////////////////////////////////////////////////// POPUP
    public void OpenPopup()
    {

        // DEACTIVATE MAIN UI
        foreach (GraphicRaycaster g in mainMenuCanvas)
            g.enabled = false;

        // STOP TAP
        popupOpen = true;

    }
    public void ClosePopup()
    {

        // ACTIVATE MAIN UI
        foreach (GraphicRaycaster g in mainMenuCanvas)
            g.enabled = true;

        // ENABLE TAP
        popupOpen = false;
    }



    void MouseControls()
    {

        //////////////////////////////////////////////////////////////////////// START TAPPING
        if (Input.GetMouseButtonDown(0))
        {
            CheckTuto();

            isTapping = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
                TapObject(hit);

        }

        //////////////////////////////////////////////////////////////////////// TAPPING
        else if (Input.GetMouseButton(0) && ( draggingObject || isGardenFocus))
            Tapping();

        //////////////////////////////////////////////////////////////////////// STOP TAPPING
        else if (Input.GetMouseButtonUp(0))
        {
            isTapping = true;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            isTapping = false;
            lastTap = Time.time;


            releaseTapPosition = Input.mousePosition;
            tapDistance = Vector2.Distance(startTapPosition, releaseTapPosition);

            if (draggingObject || isGardenFocus)
            {
                if (Physics.Raycast(ray, out hit))
                    StopTap(hit);
                else
                    StopTap(hit);
            }
        }


    }

    void TapControls()
    {

        int i = 0;
        while (i < Input.touchCount)
        {
            logText.text += ", touch pos Y = " + Input.GetTouch(0).position.y;
            //////////////////////////////////////////////////////////////////////// START TAPPING
            isTapping = true;
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                CheckTuto();

                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                if (Physics.Raycast(ray, out hit))
                    TapObject(hit);
            }

            //////////////////////////////////////////////////////////////////////// TAPPING
            else if (Input.GetTouch(i).phase == TouchPhase.Moved && (draggingObject || isGardenFocus))
            {
                if (Input.touchCount > 1 && !isZooming)
                {
                    isZooming = true;
                    //gardenManager.StartZoom(Input.GetTouch(0).position, Input.GetTouch(1).position);
                }


                Tapping();
            }

            //////////////////////////////////////////////////////////////////////// STOP TAPPING
            else if (Input.GetTouch(i).phase == TouchPhase.Ended)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                isTapping = false;
                isZooming = false;
                lastTap = Time.time;
                
                releaseTapPosition = Input.GetTouch(i).position;
                tapDistance = Vector2.Distance(startTapPosition, releaseTapPosition);

                if ( draggingObject || isGardenFocus)
                {
                    if(Physics.Raycast(ray, out hit))
                        StopTap(hit);
                    else
                        StopTap(hit);
                }
            }

            ++i;
        }

    }

    void TapObject(RaycastHit hit)
    {
        if (hit.collider != null)
        {


            /////////////////////////////////// TAP ITEM
            if (hit.collider.tag == "item")
            {
                draggingObject = hit.collider.transform;
                draggingObject.GetComponent<Collider>().enabled = false;
                Debug.Log("draggingObject: "+draggingObject.name);
                //GameObject.Find("gameProperties").GetComponent<feedbackManager>().DragFeedbackStart(draggingObject);
                //GameObject.Find("gameProperties").GetComponent<feedbackManager>().CreatePremergeFeedabck(draggingObject.gameObject);
            }

            /////////////////////////////////// TAP BIRD
            else if (hit.collider.tag == "bird")
            {
                hit.collider.transform.parent.parent.gameObject.GetComponent<birdController>().TapBird();
            }

            /////////////////////////////////// TAP TILE
            else if (hit.collider.tag == "tile" && hit.collider.gameObject.name != "trash")
            {
                //Debug.Log("Tap tile:" + hit.collider.gameObject.name);
                //hit.collider.gameObject.GetComponent<tileController>().TryPurchase();
            }

            /////////////////////////////////// TAP DECO
            else if(hit.collider.tag == "decoration")
            {
                decorationTapped = hit.collider.gameObject;
            }

        }
    }


    void Tapping ()
    {
        draggingObject.GetComponent<itemController>().MoveItem();
    }

    void StopTap(RaycastHit stopObject)
    {
        Debug.Log("Stop dragging");
        if(stopObject.collider)
            Debug.Log("Stop tap with object: " + stopObject.collider.gameObject.name);
        GameObject.Find("gameProperties").GetComponent<feedbackManager>().DragFeedbackStop();
        draggingObject.GetComponent<itemController>().StopMoving(stopObject);
        draggingObject.GetComponent<Collider>().enabled = true;
        draggingObject = null;
        GameObject.Find("gameProperties").GetComponent<feedbackManager>().StopPremergeFeedback();

    }


    void CheckTuto()
    {
        if (tutorialManager.currentTuto == 8)
        {
            tutorialManager.HideTuto(8);
            tutorialManager.ShowTuto(9, true);
        }
    }

}
