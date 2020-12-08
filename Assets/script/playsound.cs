using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    GameObject BPlay, BStop,Cube;
    // Start is called before the first frame update
    void Start()
    {
        
        BPlay = GameObject.Find("Play");
        BStop = GameObject.Find("Stop");
        Cube = GameObject.Find("Cube");

        BPlay.SetActive(true);
        BStop.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.tag == "Play")
                {
                    BPlay.SetActive(false);
                    BStop.SetActive(true);
                    Cube.GetComponent<AudioSource>().Play();


                }
                if (hit.collider.tag == "Stop")
                {
                    BPlay.SetActive(true);
                    BStop.SetActive(false);
                    Cube.GetComponent<AudioSource>().Stop();

                }
            }
        }
        
    }
}
