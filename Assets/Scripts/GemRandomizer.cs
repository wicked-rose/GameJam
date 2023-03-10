using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GemRandomizer : MonoBehaviour
{

    public GameObject gemSpriteObjectThing;
    private GameObject sprite;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Transform target;
    //private Vector3 xPos;
    private Vector3 cameraOffset;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnGem", spawnTime, spawnDelay);
    }
    public void SpawnGem()
    {
        cameraOffset = new Vector3(Random.Range(-10.0f, 10.0f), -10.0f, 3.0f);
        target.transform.position = Camera.main.transform.position + cameraOffset;
        sprite = Instantiate(gemSpriteObjectThing, target.position, Quaternion.identity);
    }
    
}
