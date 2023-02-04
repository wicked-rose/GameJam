using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This program is set to the object that you want to have follow the mouse. It just grabs the mouse position and applies it to the x of the transform.
public class MouseFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 pos = new Vector3(mousePosition.x, transform.position.y - 0.05f, transform.position.z);
        transform.position = pos;
    }
}
