using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenByF : MonoBehaviour
{
    private bool isFullscreen = false; // ���� ��� ������������ ������ ������

    void Update()
    {
        // ��������� ������� ������� F
        if (Input.GetKeyDown(KeyCode.F))
        {
            // ������������� ����� ������������� � ������� ��������
            if (isFullscreen)
            {
                // ���� � ������������� ������, ������������� � �������
                Screen.fullScreen = false;
                isFullscreen = false;
            }
            else
            {
                // ���� � ������� ������, ������������� � �������������
                Screen.fullScreen = true;
                isFullscreen = true;
            }
        }
    }
}