using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnTouch : MonoBehaviour
{
    public float rotationSpeed;
    // Update is called once per frame
    void Update()
    {
       
        float XaxisRotation = Input.GetTouch(0).position.x * rotationSpeed;
        float YaxisRotaion = Input.GetTouch(0).position.y * rotationSpeed;
        
        transform.RotateAround(axis: Vector3.down, XaxisRotation);
        transform.RotateAround(axis: Vector3.right, YaxisRotaion);
        
    } 
}
