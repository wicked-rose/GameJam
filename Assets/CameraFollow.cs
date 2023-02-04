using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //location of game object
    public Transform target;
    public float smoothSpeed = 0.125f;
    //Where is the camera start
    public Vector3 offset;

    //Run after update
    void LateUpdate()
    {
        Vector3 deisedPosiont = target.position + offset;
        Vector3 smoothPosisiton = Vector3.Lerp(transform.position,deisedPosiont, smoothSpeed);
        transform.position = smoothPosisiton;

        transform.LookAt(offset);
    }
}
