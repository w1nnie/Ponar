using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;


public class OnSteria : MonoBehaviour
{
    GameObject steria;
    VisualEffect pixelize;
    float spawnRate;
    public bool isOnSteria;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 0;
        SetParameter(spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetParameter(float value)
    {
        VisualEffect vfx = pixelize.GetComponent<VisualEffect>();
        vfx.SetFloat("swawnRate", value);
    }
}
