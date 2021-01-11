using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisiibilty : MonoBehaviour
{
    public GameObject gameObjects;
   
    public void ToogleObjectVisibilty()
    {
        Renderer render = gameObjects.GetComponent<Renderer>();
        if (render.enabled)
        {
            render.enabled = false;
        }
        else {
            render.enabled = true;
        }
    }
}
