using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MagnetAbility : MonoBehaviour
{
    GameObject player;
    bool active = false;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            GameObject[] gems = GameObject.FindGameObjectsWithTag("Gem");
            foreach(GameObject gem in gems)
            {
                gem.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            active = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(selfDestruct());
        }
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(2f);
        active = false;
        Object.Destroy(gameObject);
    }
}
