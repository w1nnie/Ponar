using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffSteria : MonoBehaviour
{
    GameObject pixelize;
    OnSteria po;
    // Start is called before the first frame update
    void Start()
    {
        po = GetComponent<OnSteria>();
    }

    // Update is called once per frame
    void Update()
    {
        po.trackOnSteria();
    }
}
