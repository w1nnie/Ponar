using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffTrackWoofar : MonoBehaviour
{
    SpriteRenderer woofar;
    OnTrackWoofar po;


    void Start()
    {
        po = GetComponent<OnTrackWoofar>();
    }

    void Update()
    {
        po.trackOff();
        woofar = GetComponent<SpriteRenderer>();
        var color = woofar.color;
        color.a = 0;
        woofar.color = color;
    }
}
