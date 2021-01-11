
using UnityEngine;

public class WebURLScript : MonoBehaviour {
public string Url;
public void Open() {
    Application.OpenURL(Url);
}

}
