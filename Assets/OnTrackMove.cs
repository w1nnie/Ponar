using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrackMove : MonoBehaviour
{
    float direction = 40.0f;
    float speed = 5.0f;
    Vector2 v;

    // Update is called once per frame
    void Update()
    {

        v.x = 0;
        v.y = 1;

        Rigidbody2D rd = GetComponent<Rigidbody2D>();
        rd.velocity = v;
    }
}
