using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpRandomizer : MonoBehaviour
{

    public GameObject[] powerUps;
    private GameObject sprite;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Transform target;
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
        sprite = Instantiate(powerUps[Random.Range(0, powerUps.Length)], target.position, Quaternion.identity);
        StartCoroutine(selfDestruct());
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(5f);
        Object.Destroy(sprite);
    }
}