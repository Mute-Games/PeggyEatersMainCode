using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource Source;
    public float Delay;

    bool paused = false;

    void Start()
    {
        Source.time = Delay;
        Source.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                paused = false;
                Source.Play();
            }
            else
            {
                paused = true;
                Source.Pause();
            }
        }
    }
}
