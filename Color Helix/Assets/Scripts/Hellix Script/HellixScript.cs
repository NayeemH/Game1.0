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
            lastdeltaAngle = lastTouchX - mouseX;
            angle += lastdeltaAngle * 360 * 1.7f;
            lastTouchX = mouseX;
        }
        else if(lastdeltaAngle != 0)
        {
            lastdeltaAngle -= lastdeltaAngle * 5 * Time.deltaTime;
            angle += lastdeltaAngle * 360 * 1.7f;
        }
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    private float GetMouseX()
    {
        return Input.mousePosition.x / (float)Screen.width;
    }
}
