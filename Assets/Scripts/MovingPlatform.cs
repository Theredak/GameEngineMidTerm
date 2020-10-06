using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

}
