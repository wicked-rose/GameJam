using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoAbility : MonoBehaviour
{
    public float scale;
   // public float BackgroundChangeMultiplier = 1.5f;
    public GameObject quad;
    MouseFollow playerScript;
    bool active = false;
    float timeA = 0.0f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Time.timeScale = 0.2f;
            Invoke("resetTime", 3);
        }
    }
    public void resetTime()
    {
        Time.timeScale = 1.0f;
        selfDestruct();
        return;
    }
    public void selfDestruct()
    {
        Object.Destroy(gameObject);
        return;
    }
}

