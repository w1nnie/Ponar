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
        SetParameter(0);
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
            if(time > 2.5 && time < 3)
            {
                SetParameter((float)(2000*(time-2.5)));
            }
            else if(time > 3 && time < 5.5)
            {
                SetParameter((float)(1000*(5.5-time)));
                FadeIn();
            }
            else if(time >= 3.5)
            {
                SetParameter(0);
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
    void SetParameter(float value)
    {
        VisualEffect vfx = GetComponentInChildren<VisualEffect>();
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
