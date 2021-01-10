using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAllardInfo : MonoBehaviour
{
    public GameObject CarInfo;
    public GameObject GalleryIcon;
    public GameObject PlayIcon;
    public GameObject StopIcon;


    public void OpenAllardInfo()
    {
        if (CarInfo != null)
        {
            bool isActive = CarInfo.activeSelf;
            bool isGallery = GalleryIcon.activeSelf;
            bool isSound = PlayIcon.activeSelf;
            CarInfo.SetActive(!isActive);
            GalleryIcon.SetActive(!isGallery);
            PlayIcon.SetActive(!isSound);
            StopIcon.SetActive(!isSound);

        }
    }
}


