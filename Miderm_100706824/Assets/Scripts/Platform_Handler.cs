using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Handler : MonoBehaviour
{
    public Vector3 p1;
    public Vector3 p2;
    private Vector3 temp;

    public float platformSpeed;

    private static float t = 0.0f;

    //private const float STOP_TIMER 3.0f;
    //private float current_Timer = 3.0f;

    void Start()
    {
        transform.position = p1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(p1, p2, t);

        t += 0.2f * Time.deltaTime;

        if(t > 1.6f)
        {
            temp = p2;
            p2 = p1;
            p1 = temp;

            t = 0.0f;
        }
    }
}
