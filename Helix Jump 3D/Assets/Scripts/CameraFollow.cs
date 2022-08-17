using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.04f;

    void Start()
    {
        offset = transform.position - target.position;

    }

    void LateUpdate()
    {
       Vector3 newPosition = Vector3.Lerp(transform.position,target.position + offset, smoothSpeed);
        transform.position = newPosition;
    }
}
