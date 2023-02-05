using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleItem : MonoBehaviour
{ 
    private Nutrients nutrientLevel;
    public SpriteRenderer sprite;
    public GameObject rootObj;

    // Start is called before the first frame update
    void Start()
    {
        nutrientLevel = FindObjectOfType<Nutrients>();
        //
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            nutrientLevel.DecreaseHealth(10);
            this.gameObject.SetActive(false);
        }
    }
}
