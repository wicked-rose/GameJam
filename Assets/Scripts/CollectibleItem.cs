using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private CollectibleManager cManager;

    // Start is called before the first frame update
    void Start()
    {
        cManager = FindObjectOfType<CollectibleManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cManager.Collected(1);
            this.gameObject.SetActive(false);
        }
    }
}
