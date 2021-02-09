using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{

    private static bool pressing;

    public static bool Ispressing()
    {
        if (pressing)
        {
            Debug.Log("Pressing");
        }
        else
        {
            Debug.Log("Not Pressing");
        }
        return pressing;
    }

    // Start is called before the first frame update
   public void OnPointerDown(PointerEventData data)
    {
        pressing = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        pressing = false;
    }
}
