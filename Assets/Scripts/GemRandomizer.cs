using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRandomizer : MonoBehaviour
{

    public GameObject gem;
    public Transform target;
    //private Vector3 xPos;
    private Vector3 cameraOffset;
  
    

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = new Vector3(Random.Range(-10.0f, 10.0f), -10.0f, 3.0f);
        target.transform.position = Camera.main.transform.position + cameraOffset;
        GameObject sprite = Instantiate(gem, target.position, Quaternion.identity);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
