using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTrackWoofar : MonoBehaviour
{
    float scale = 0.003f;
    float time;
    float alpha;
    float alphaControlTime = 0.7f;
    float alphaControlCoefficient = 7f;
    SpriteRenderer woofar;
    public ParticleSystem sRight;
    public ParticleSystem sLeft;
    public ParticleSystem sBack;
    public ParticleSystem sFront;
    public bool onTrack;

    void Start()
    {
        time = 0f;
        alpha = 0.01f;
        woofar = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!onTrack)
        {
            sRight.Play();
            sLeft.Play();
            sBack.Play();
            sFront.Play();
            onTrack = true;
        }

        time += Time.deltaTime;
        float dy = Mathf.Sin(2 * Mathf.PI * 0.4f * time) * scale;
        this.transform.position += new Vector3(0,dy,0);
        FadeIn();
    }

    void FadeIn()
    {
        alpha += Time.deltaTime * alphaControlTime * alpha * alphaControlCoefficient;
        if (alpha >= 1f)
        {
            alpha = 1f;
        }
        var color = woofar.color;
        color.a = alpha;
        woofar.color = color;
    }

    void OnDisable()
    {
        alpha = 0.01f;
    }

    public void trackOff(){
        onTrack = false;
    }
}
