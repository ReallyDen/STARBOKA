using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel;
    public KeyCode spaceKey;
    public bool paused = false;

    void Update()
    {
        if (Input.GetKeyDown("escape") && !Settings.settingsOpen)
        {

            if (paused)
            {
                Continue();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Pause()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
        paused = true;
    }

    public void Continue()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
}