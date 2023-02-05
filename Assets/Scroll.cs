using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Scroll : MonoBehaviour
{
    public float speed = 0.5f;
    public float distance = 0f;
    public Texture Transition;
    public float TransistionDuration = 3;
    public Texture [] bg;
    public float whenToTransition = .30f;
    public float multiplier = 2f;

    private float start = 0;
    private float end = 1;

    public bool Reverse = false;
    public float Scale = 1f;
    public float loc = 1.0f;
    public GameObject mouseSpeed;

    //private void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime;
        float prevDist =30;
        if (distance > 30 && distance < 50)
        {
            float ratio = (distance - 35) / (35 - prevDist);
            gameObject.GetComponent<Renderer>().material.SetFloat("_FlipFlop", Mathf.SmoothStep(start, end, ratio));
        }

        if (distance > 50 && distance < 70)
        {
             gameObject.GetComponent<Renderer>().material.SetTexture("_FirstTexture", bg[1]);
             gameObject.GetComponent<Renderer>().material.SetTexture("_SecondTexture", bg[2]);
             gameObject.GetComponent<Renderer>().material.SetFloat("_FlipFlop", 0);
             prevDist = distance;

        }
        if(distance > 70 && distance < 130)
        {
            start = 0;
            end = 1;
            float ratio = (distance-75) / (75 - prevDist);
            gameObject.GetComponent<Renderer>().material.SetFloat("_FlipFlop", Mathf.SmoothStep(start, end, ratio));
            loc = 1.5f;
            gameObject.GetComponent<Renderer>().material.SetFloat("_Scale", loc);
            mouseSpeed.GetComponent<MouseFollow>().speed = 10;
        }
        if (distance > 130 && distance < 180)
        {
            gameObject.GetComponent<Renderer>().material.SetTexture("_FirstTexture", bg[2]);
            gameObject.GetComponent<Renderer>().material.SetTexture("_SecondTexture", bg[3]);
            prevDist = distance;
        }
        if(distance > 180)
        {
            float ratio = (distance - 185) / (185 - prevDist);
            gameObject.GetComponent<Renderer>().material.SetFloat("_FlipFlop", Mathf.SmoothStep(start, end, ratio));
            loc = 2f;
            gameObject.GetComponent<Renderer>().material.SetFloat("_Scale", loc);
            mouseSpeed.GetComponent<MouseFollow>().speed = 20;
        }


        if (!Reverse)
        {
            gameObject.GetComponent<Renderer>().material.SetFloat("_Scale", Scale);
            Debug.Log("DONT Reverse!");
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.SetFloat("_Scale", -4f);
            Debug.Log("Reverse!");
        }


    }
    
}
