using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speed = 0.5f;
    float distance = 0f; 
    public Material [] bg;
    public float FirstChange = 20;
    public float BackgroundChangeMultiplier = 1.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime;
        //Vector2 offset = new Vector2(Time.time * speed, 0);
        Vector2 offset = new Vector2(0, - Time.time * speed);
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = offset;

    }

    void changedBackground(int index)
    {
        gameObject.GetComponent<Renderer>().material = bg[index];
    }
}
