using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] obstacles;
    private GameObject sprite;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    public Transform target;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnTime, spawnDelay);
    }

    public void SpawnObstacle()
    {
        cameraOffset = new Vector3(Random.Range(-10.0f, 10.0f), -10.0f, 3.0f);
        target.transform.position = Camera.main.transform.position + cameraOffset;
        sprite = Instantiate(obstacles[Random.Range(0, obstacles.Length)], target.position, Quaternion.identity);
        StartCoroutine(selfDestruct());
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(5f);
        //Object.Destroy(sprite);
    }
}
