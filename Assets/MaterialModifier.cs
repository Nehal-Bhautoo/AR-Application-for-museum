using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialModifier : MonoBehaviour {

    public MeshRenderer material;
    public Slider red;
    public Slider green;
    public Slider blue;

    // Update is called once per frame
    public void onEdit()
    {
        Color color = material.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        material.material.color = color;
        material.material.SetColor("_EmissionColor", color);
    }
}
