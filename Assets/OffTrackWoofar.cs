using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrackWoofar : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        SpriteRenderer woofar = GetComponent<SpriteRenderer>();
        var color = woofar.color;
        color.a = 0;
        woofar.color = color;
    }
}
