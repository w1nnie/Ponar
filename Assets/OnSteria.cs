using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;


public class OnSteria : MonoBehaviour
{
    GameObject steria;
    float spawnRate;
    public bool isOnSteria;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 0;
        // diffusion.SpawnRate = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SetParameter(float value)
    {
        VisualEffect vfx = steria.GetComponent<VisualEffect>();
        vfx.SetFloat("paramName", value);
    }
}
