using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscriptionMouse : MonoBehaviour
{
    public float hoverTime = 1.5f; // Время задержки, после которого панель включится

    private float hoverTimer = 0f;
    private bool isMouseOver = false;
    private bool panelActive = false;

    public GameObject panel; // Панель, которую нужно включить/выключить

    void Update()
    {
        if (isMouseOver)
        {
            hoverTimer += Time.deltaTime;
            if (hoverTimer >= hoverTime && !panelActive)
            {
                panel.SetActive(true);
                panelActive = true;
            }
        }
        else
        {
            hoverTimer = 0f;
            if (panelActive)
            {
                panel.SetActive(false);
                panelActive = false;
            }
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