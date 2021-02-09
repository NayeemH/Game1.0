using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellixScript : MonoBehaviour
{

    private bool movable = true;
    private float angle;
    private float lastdeltaAngle, lastTouchX;
    // Update is called once per frame
    void Update()
    {
        if(movable && Touch.Ispressing())
        {
            float mouseX = this.GetMouseX();
            lastdeltaAngle = lastTouchX
        }
    }

    private float GetMouseX()
    {
        return Input.mousePosition.x / (float)Screen.width;
    }
}
