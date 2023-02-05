using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAbility : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Nutrients>().star = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            player = other.gameObject;
            StartCoroutine(selfDestruct());
        }
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(7f);
        player.GetComponent<Nutrients>().star = false;
        Object.Destroy(gameObject);
    }
}
