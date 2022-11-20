using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector timeline;

    // Start is called before the first frame update
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            timeline.Play();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            timeline.Pause();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            timeline.Stop();
        }
    }

    public void ActivateTimeline()
    {
        timeline.Play();
    }

    public void PauseTimeline()
    {
        timeline.Pause();
    }

    public void DeactivateTimeline()
    {
        timeline.Stop();
    }
}
