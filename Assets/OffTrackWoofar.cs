using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrackWoofar : MonoBehaviour
{
    public OnTrackWoofar onTrackWoofar;
    SpriteRenderer woofar;
    // Start is called before the first frame update
    void Update()
    {
        woofar = GetComponent<SpriteRenderer>();
        var color = woofar.color;
        color.a = 0;
        woofar.color = color;
    }
}
