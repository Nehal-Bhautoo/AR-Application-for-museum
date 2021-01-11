using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ARScene()
    {
        SceneManager.LoadScene("ARScene");
    }

    public void MobileScene()
    {
        SceneManager.LoadScene("MobileUI");
    }

    public void MuseumScene()
    {
        SceneManager.LoadScene("Museum");
    }
}
