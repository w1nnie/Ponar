﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;

public class OnSteria_2 : MonoBehaviour
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
        SetVFXParameter(0,0);
        SetVFXParameter(1,0);
        SetVFXParameter(2,100);
    }

    void Update()
    {
        if (!isOnSteria)
        {
            time = 0f;
            SetSpriteAlpha(0,0);
            SetSpriteAlpha(1,0);
            SetVFXParameter(0,0);
            SetVFXParameter(2,100);
        }
        else
        {
            time += Time.deltaTime;
            textAnimation(time);
            pixelizeAnimation(time);
            pixelartAnimation(time);
            detectAnimation(time);
            completeAnimation(time);
        }
        if(time < 3.5f)
        {
            VisualEffect vfx = GetComponentsInChildren<VisualEffect>()[2];
            vfx.Play();
        }
    }
    void textAnimation(float time)
    {
        if(time < 3)
        {
            float f = Mathf.Sin((float)(2 * Mathf.PI * time / (3 * 3) * 4));
            SetSpriteAlpha(1, Mathf.Abs(f));
        }
        else if(time > 3 && time < 3.5)
        {
            SetSpriteAlpha(1,1);
        }
        else if(time > 3.5)
        {
            SetSpriteAlpha(1,0);
        }
    }
    void pixelizeAnimation(float time)
    {
        if(time < 4)
        {
            SetVFXParameter(0,time);
        }
        else if(time < 5)
        {
            float alpha = 4f - (time - 4f)*4;
            SetVFXParameter(0,alpha);
        }
        else{
            SetVFXParameter(0,-1);
        }
    }
    void pixelartAnimation(float time)
    {
        if(time > 3 && time < 4.8)
        {
            pixelartFadeIn(0);
        }
    }
    void detectAnimation(float time)
    {
        if(time < 4.7f)
        {
            SetVFXParameter(1,time);
        }
    }

    void completeAnimation(float time)
    {
        if(time < 4)
        {
            SetVFXParameter(2,100);
        }
        else
        {
            SetVFXParameter(2,0);
        }

    }
    void pixelartFadeIn(int index)
    {
        double a = (time - 3) / 1.8;
        SetSpriteAlpha(index, (float)a);
    }
    void SetSpriteAlpha(int index, float alpha)
    {
        SpriteRenderer srn = GetComponentsInChildren<SpriteRenderer>()[index];
        var color = srn.color;
        color.a = alpha;
        srn.color = color;
    }
    void SetVFXParameter(int index,float value)
    {
        VisualEffect vfx = GetComponentsInChildren<VisualEffect>()[index];
        vfx.SetFloat("onTrackTime", value);
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
