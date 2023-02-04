using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Camera.main.transform.position.y, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 veiwPos = transform.position;
        veiwPos.x = Mathf.Clamp(veiwPos.x, screenBounds.x, screenBounds.x * -1);
        //veiwPos.y = Mathf.Clamp(veiwPos.y, screenBounds.y, screenBounds.y * -1);

        if (transform.position.x >= Mathf.Abs(veiwPos.x))
            transform.position = veiwPos;
    }
}
