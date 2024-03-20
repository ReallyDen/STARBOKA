using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPanel : MonoBehaviour
{
    public GameObject panel;
    public KeyCode spaceKey;
    public bool opened = false;

    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {

            if (opened)
            {
                StarPanelOff();
            }
            else
            {
                StarPanelOn();
            }

        }
    }

    public void StarPanelOn()
    {
        panel.SetActive(true);
        opened = true;
    }

    public void StarPanelOff()
    {
        panel.SetActive(false);
        opened = false;
    }
}