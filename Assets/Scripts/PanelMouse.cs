using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMouseOpen : MonoBehaviour
{
    public GameObject panel; // Панель, которую нужно указать в инспекторе

    private bool isMouseOver;

    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (isMouseOver)
        {
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }

    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }
}