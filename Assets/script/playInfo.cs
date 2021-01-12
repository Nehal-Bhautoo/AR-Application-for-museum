﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playInfo : MonoBehaviour
{
    GameObject BPlay, BStop, Cube;
    // Start is called before the first frame update
    void Start()
    {

        BPlay = GameObject.Find("InfoPlay");
        BStop = GameObject.Find("InfoStop");
        Cube = GameObject.Find("InfoCube");

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
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "InfoPlay")
                {
                    BPlay.SetActive(false);
                    BStop.SetActive(true);
                    Cube.GetComponent<AudioSource>().Play();


                }
                if (hit.collider.tag == "InfoPlay")
                {
                    BPlay.SetActive(true);
                    BStop.SetActive(false);
                    Cube.GetComponent<AudioSource>().Stop();

                }
            }
        }

    }
}
