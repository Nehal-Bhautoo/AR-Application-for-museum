using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisiibilty : MonoBehaviour
{
    public GameObject gameObjects;

    private void Update()
    {
        ToogleObjectVisibilty();
    }

    public void ToogleObjectVisibilty()
    {
        if(Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Renderer render = gameObjects.GetComponent<Renderer>();
                if (render.enabled)
                {
                    render.enabled = false;
                }
                else
                {
                    render.enabled = true;
                }
            }
        }
        
    }
}
