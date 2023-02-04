using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will follow the original object, but only the along that object's y. All you need to do is attach the object you would like to track.
public class RootPath : MonoBehaviour
{
    public GameObject Target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(0, Target.transform.position.y, 0);
    }
}
