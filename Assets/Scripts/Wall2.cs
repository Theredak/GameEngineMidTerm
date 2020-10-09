using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2 : MonoBehaviour
{
    Vector3 pointA = new Vector3(425, 56, -371);
    Vector3 pointB = new Vector3(450, 56, -371);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
