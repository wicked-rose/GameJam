using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMoAbility : AbstractPower
{
    public float scale;
   // public float BackgroundChangeMultiplier = 1.5f;
    bool slow = false;
    public GameObject player;
    public GameObject quad;
    MouseFollow playerScript;
    bool active = false;
    float timeA = 0.0f;

    // Start is called before the first frame update

    void Start()
    {
        scale = 1.0f;
        playerScript = player.GetComponent<MouseFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            scale = .2f;
            timeA += Time.deltaTime;
        }

        if(timeA > 8.0f)
        {
            timeA = 0.0f;
            active = false;
            scale = 1.0f;
            StartCoroutine(selfDestruct());
        }

        playerScript.scaleY = scale;
        quad.GetComponent<Scroll>().scaleS = scale;
    }

    protected override void Ability()
    {
        slow = true;
    }

    new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        active = true;
    }

    IEnumerator selfDestruct()
    {
        yield return new WaitForSeconds(1f);
        Object.Destroy(gameObject);
    }
}

