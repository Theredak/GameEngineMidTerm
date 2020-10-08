using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2 : MonoBehaviour
{
    Vector3 pointA = new Vector3(433, 56, -390);
    Vector3 pointB = new Vector3(448, 56, -390);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
