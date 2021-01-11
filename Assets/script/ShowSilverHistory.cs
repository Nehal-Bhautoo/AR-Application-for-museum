using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSilverHistory : MonoBehaviour
{
    public GameObject CarInfo;
    


    public void OpenAllardInfo()
    {
        if (CarInfo != null)
        {
            bool isActive = CarInfo.activeSelf;
            CarInfo.SetActive(!isActive);

        }
    }
}
