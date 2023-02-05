using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpAbility : MonoBehaviour
{
    GameObject[] objects;
    float timeA;
    bool warp = false;
    GameObject player;
    GameObject quad;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        quad = GameObject.FindGameObjectWithTag("LSV");
    }

    // Update is called once per frame
    void Update()
    {
        if (warp)
        {
            objects = GameObject.FindGameObjectsWithTag("Gem");
            foreach (GameObject obj in objects)
            {
                obj.gameObject.transform.position -= new Vector3(0, .025f, 0);
            }

            objects = GameObject.FindGameObjectsWithTag("Item");
            foreach (GameObject obj in objects)
            {
                obj.gameObject.transform.position -= new Vector3(0, .025f, 0);
            }

            player.GetComponent<MouseFollow>().canMove = false;
            quad.GetComponent<Scroll>().Reverse = true;

            timeA += Time.deltaTime;
        }

        if (timeA > 3.0f)
        {
            warp = false;
            player.GetComponent<MouseFollow>().canMove = true;
            quad.GetComponent<Scroll>().Reverse = false;
            StartCoroutine(selfDestruct());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            warp = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(1f);
        Object.Destroy(gameObject);
    }
}