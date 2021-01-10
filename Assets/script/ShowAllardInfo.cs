using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAllardInfo : MonoBehaviour
{
    public GameObject CarInfo;

    public void OpenSlideShow()
    {
        if (CarInfo != null)
        {
            bool isActive = CarInfo.activeSelf;
            CarInfo.SetActive(!isActive);
        }
    }
}


