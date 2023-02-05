using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This program is set to the object that you want to have follow the mouse. It just grabs the mouse position and applies it to the x of the transform.
public class MouseFollow : MonoBehaviour
{
    public float moveTime;
    Vector3 mag;
    public bool canMove = true, star = false;
    void Start()
    {
        moveTime = 0f;
        mag = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float msSinceLastFrame = Time.deltaTime;
        if (canMove) {
            if (moveTime > .05f)
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mag = new Vector3(mousePos.x, 0, 0);
                moveTime = 0f;
            }

            Vector3 move = new Vector3(mag.x, transform.position.y - (5.0f * msSinceLastFrame), transform.position.z);
            transform.position = move;

            moveTime += Time.deltaTime;
        }
    }
}
