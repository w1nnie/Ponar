using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnTrackMove : MonoBehaviour
{
    float scale = 0.003f;
    float time;
    float alpha;
    float alphaControlTime = 0.7f;
    float alphaControlCoefficient = 7f;
    SpriteRenderer image;

    void Start()
    {
        time = 0;
        alpha = 0.01f;
        image = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += 0.02f;
        float dy = Mathf.Sin(2 * Mathf.PI * 0.7f * time) * scale;
        this.transform.position += new Vector3(0,dy,0);
        Debug.Log(time);
        FadeIn();
        
    }

    void FadeIn()
    {
        alpha += Time.deltaTime * alphaControlTime * alpha * alphaControlCoefficient;
        if (alpha >= 1f)
        {
            alpha = 1f;
        }
        var color = image.color;
        color.a = alpha;
        image.color = color;

    }
}
