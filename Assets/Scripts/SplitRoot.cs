using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitRoot : MonoBehaviour
{
    public GameObject root;
    private Vector3 rootTip;
    private Transform tempPos;
    private Vector3 vector;
   
    void Start()
    {
        rootTip = transform.position;
        vector = new Vector3(0f, 1.0f, 0.0f);
        tempPos.transform.position = rootTip + vector;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if(collision.gameObject.tag == "Player")
        {
            GameObject newRoot = Instantiate(root, tempPos.position, Quaternion.identity);
            //newRoot.transform.position = new Vector3(1.0f, 0.0f, 0.0f);
        }
    }
}
