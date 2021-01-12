using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHistory : MonoBehaviour
{
    GameObject BPlay, BStop, Cube;
    // Start is called before the first frame update
    void Start()
    {

        BPlay = GameObject.Find("HistoryPlay");
        BStop = GameObject.Find("HistoryStop");
        Cube = GameObject.Find("HistoryCube");

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
                if (hit.collider.tag == "HistoryPlay")
                {
                    BPlay.SetActive(false);
                    BStop.SetActive(true);
                    Cube.GetComponent<AudioSource>().Play();


                }
                if (hit.collider.tag == "HistoryStop")
                {
                    BPlay.SetActive(true);
                    BStop.SetActive(false);
                    Cube.GetComponent<AudioSource>().Stop();

                }
            }
        }

    }
}
