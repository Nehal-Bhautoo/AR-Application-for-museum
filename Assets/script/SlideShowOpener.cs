using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideShowOpener : MonoBehaviour
{
    public GameObject Gallery;

    public void OpenSlideShow()
    {
        if (Gallery != null)
        {
            bool isActive = Gallery.activeSelf;
            Gallery.SetActive(!isActive);
        }
    }

}
