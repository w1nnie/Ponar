using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;

public class OnSteria : MonoBehaviour
{
    GameObject steria;
    float time;
    float alpha;
    float sr;
    public bool isOnSteria;
    void Start()
    {
        time = 0f;
        isOnSteria = false;
        SetParameter(0,0);
        SetParameter(1,0);
    }

    void Update()
    {
        if (!isOnSteria)
        {
            time = 0f;
            SetAlpha(0);
        }
        else
        {
            time += Time.deltaTime;
            if(time < 2.5)
            {
                SetParameter(1,time*400);
            }
            else if(time > 2.5 && time < 3)
            {
                SetParameter(0,(float)(2000*(time-2.5)));
                SetParameter(1,0);
            }
            else if(time > 3 && time < 5.5)
            {
                SetParameter(0,(float)(1000*(5.5-time)));
                FadeIn();
            }
            else if(time >= 5.5)
            {
                SetParameter(0,0);
            }
        }
    }
    void FadeIn(){
        double a = (time - 3) / 2.5;
        SetAlpha((float)a);
    }
    void SetAlpha(float alpha)
    {
        SpriteRenderer srn = GetComponentInChildren<SpriteRenderer>();
        var color = srn.color;
        color.a = alpha;
        srn.color = color;
    }
    void SetParameter(int index,float value)
    {
        VisualEffect vfx = GetComponentsInChildren<VisualEffect>()[index];
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
