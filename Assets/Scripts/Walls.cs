using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    Vector3 pointA = new Vector3(420, 56, -472);
    Vector3 pointB = new Vector3(432, 56, -472);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
