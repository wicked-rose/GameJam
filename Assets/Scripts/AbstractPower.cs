using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractPower : MonoBehaviour
{
    protected Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        //position = new Vector3(0, Camera.main.transform.position.y - 600, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Ability() { }

    protected void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLISION");
        if (other.tag == "Player")
        {
            Ability();
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
