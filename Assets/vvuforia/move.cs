using UnityEngine;

public class move : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;

    void start(){
        speedModifier=0.01f;
    }

    void update (){
        if (Input.touchCount >0)
        {
            touch= Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier);
                
            }
        }
    }
}