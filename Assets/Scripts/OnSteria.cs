using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;

public class OnSteria : MonoBehaviour
{
    GameObject pixelize;
    float time;
    float sr;
    public bool isOnSteria;
    void Start()
    {
        time = 0f;
        isOnSteria = false;
        SetParameter(0);
    }

    void Update()
    {
        if (!isOnSteria)
        {
            time = 0f;
        }
        else
        {
            time += Time.deltaTime;
            Debug.Log(isOnSteria);
            if(time > 3 && time < 5.5)
            {
                SetParameter((float)(1000*(5.5-time)));
            }
            else if(time >= 3.5)
            {
                SetParameter(0);
            }
        }
    }
    public void SetParameter(float value)
    {
        VisualEffect vfx = GetComponent<VisualEffect>();
        vfx.SetFloat("spawnRate", value);
    }
    public void trackOnSteria()
    {
        isOnSteria = true;
    }
    public void trackOffSteria()
    {
        isOnSteria = false;
    }
}
