using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float speed = 0.5f;
    public float distance = 0f; 
    public Material [] bg;
    public float FirstChange = 5;
    public float BackgroundChangeMultiplier = 1.5f;
    public float scaleS = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime;
        Vector2 offset = new Vector2(0, - Time.time * (speed * scaleS));
        gameObject.GetComponent<Renderer>().material.mainTextureOffset = offset;

       // for(int i = 1; i <= bg.Length; i++)
         //   if (distance > FirstChange && distance <= FirstChange*i*1.5 ) 
           //     changedBackground(i-1);
 
    }

    void changedBackground(int index)
    {
        //Resources.Load("Assets/scenes/");
        gameObject.GetComponent<Renderer>().material = bg[index];
    }
}
