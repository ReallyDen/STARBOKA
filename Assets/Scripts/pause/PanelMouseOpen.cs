using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMouse : MonoBehaviour
{
    public GameObject panel; // ������, ������� ����� ������� � ����������

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