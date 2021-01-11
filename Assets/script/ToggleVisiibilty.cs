using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisiibilty : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;

    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;

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
                Renderer render = gameObject1.GetComponent<Renderer>();
                Renderer render2 = gameObject2.GetComponent<Renderer>();
                Renderer render3 = gameObject3.GetComponent<Renderer>();

                Renderer render4 = gameObject4.GetComponent<Renderer>();
                Renderer render5 = gameObject5.GetComponent<Renderer>();
                Renderer render6 = gameObject6.GetComponent<Renderer>();
                if (render.enabled)
                {
                    render.enabled = false;
                    render2.enabled = false;
                    render3.enabled = false;

                    render4.enabled = false;
                    render5.enabled = false;
                    render6.enabled = false;
                }
                else
                {
                    render.enabled = true;
                    render2.enabled = true;
                    render3.enabled = true;

                    render4.enabled = true;
                    render5.enabled = true;
                    render6.enabled = true;
                }
            }
        }
        
    }
}
