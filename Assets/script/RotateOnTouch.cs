using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnTouch : MonoBehaviour
{
    public float rotateSpeed = 10f;
    private float _startingPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            switch(touch.phase)
            {
                case TouchPhase.Began:
                    _startingPosition = touch.position.x;
                    break;
                case TouchPhase.Moved:
                    if(_startingPosition > touch.position.x)
                    {
                        transform.Rotate(Vector3.back, -rotateSpeed * Time.deltaTime);
                    }
                    else if(_startingPosition < touch.position.x)
                    {
                        transform.Rotate(Vector3.back, rotateSpeed * Time.deltaTime);
                    }
                    break;
                case TouchPhase.Ended:
                    break;
            }
        }
    }
}
