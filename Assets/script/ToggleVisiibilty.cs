using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisiibilty : MonoBehaviour
{
    public void ToogleObjectVisibilty()
    {
        Renderer render = gameObject.GetComponent<Renderer>();
        if (render.enabled)
        {
            render.enabled = false;
        }
        else {
            render.enabled = true;
        }
    }
}
