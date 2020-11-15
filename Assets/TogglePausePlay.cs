using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class TogglePausePlay : MonoBehaviour, ITrackableEventHandler
{

    public GameObject videoplayer;
    protected TrackableBehaviour mTrackableBehaviout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        throw new System.NotImplementedException();
    }
}
