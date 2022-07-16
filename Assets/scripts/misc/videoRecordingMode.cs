using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoRecordingMode : MonoBehaviour
{
    public bool recordingOn;
    public Texture2D cursorTexture;
    public Texture2D cursorTexturePressed;
    public Vector2 cursorOffset;


    // Update is called once per frame
    void Update()
    {
        if (recordingOn)
        {
            Texture2D thisCursor = cursorTexture;
            if (Input.GetMouseButton(0))
                thisCursor = cursorTexturePressed;
            Cursor.SetCursor(thisCursor, cursorOffset, CursorMode.ForceSoftware);
        }


    }
}
