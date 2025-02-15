using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseScripts : MonoBehaviour
{
    public bool GameStop;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameStop)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    public void Play()
    {
        UIManager.Instance.HidePausepanel();
        Time.timeScale = 1;
        GameStop = false ;
    }

    public void Stop()
    {
        UIManager.Instance.ShowPausePanel();
        Time.timeScale = 0;
        GameStop = true ;
    }
}
