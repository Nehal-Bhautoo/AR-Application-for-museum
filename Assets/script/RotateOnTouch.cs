using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnTouch : MonoBehaviour
{
    float rotationSpeed = 0.2f;
    // Update is called once per frame
    void Update()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotaion = Input.GetAxis("Mouse Y") * rotationSpeed;
       
        transform.Rotate(axis: Vector3.down, XaxisRotation);
        transform.Rotate(axis: Vector3.right, YaxisRotaion);
    }
}
