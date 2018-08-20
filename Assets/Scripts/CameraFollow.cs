using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public float SmoothSpeed = 0.3f;
     
    private Vector3 _CurrPos;

    void LateUpdate()
    {
        if (Target.position.y > transform.position.y)
        {
            var newPos = new Vector3(transform.position.x, Target.position.y, transform.position.z);
//            transform.position = Vector3.SmoothDamp(transform.position, newPos, ref _CurrPos, SmoothSpeed * Time.deltaTime);
            transform.position = newPos;
        } 
    }
}
