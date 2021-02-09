using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private static float z;
    private float height = 0.58f, speed = 6;
    private bool move;
    // Start is called before the first frame update
    void Start()
    {
        move = false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Touch.Ispressing()) // checking if we touched the screen or not
        {
            move = true;
        }

        if (move)
        {
            z += speed * 0.025f;//if touched let's increase the z
        }

        transform.position = new Vector3(0, height, z); //changing the position of ball according to the increase of z 
    }

    public static float GetZ()
    {
        return Ball.z;
    }
}
