using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float dist = 5.0f;
    public float height = 4.0f;
    void LateUpdate()
    {
        transform.position = target.position
                            - (target.forward * dist)
                            + (Vector3.up * height);
        transform.LookAt(target);
    }
}
