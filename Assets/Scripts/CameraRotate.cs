using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float rotatespeed = 10f;
    private float mStartingPosition;

    void Update()
    {
#if UNITY_EDITOR
        MouseRotation();
#else
        TouchRotation();
#endif  
    }


    private void MouseRotation()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mStartingPosition = Input.mousePosition.x;
        }
        else if(Input.GetMouseButton(0))
        {
            if (mStartingPosition > Input.mousePosition.x)
            {
                transform.Rotate(Vector3.up, -rotatespeed * Time.deltaTime);
            }
            else if (mStartingPosition < Input.mousePosition.x)
            {
                transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
            }
        }
    }
    private void TouchRotation()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    mStartingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if (mStartingPosition > touch.position.x)
                    {
                        transform.Rotate(Vector3.up, -rotatespeed * Time.deltaTime);
                    }
                    else if (mStartingPosition < touch.position.x)
                    {
                        transform.Rotate(Vector3.up, rotatespeed * Time.deltaTime);
                    }
                    break;
                case TouchPhase.Ended:
                    Debug.Log("Touch Phase Ended.");
                    break;
            }
        }
    }
}
