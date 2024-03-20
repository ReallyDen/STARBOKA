using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenByF : MonoBehaviour
{
    private bool isFullscreen = false; // Флаг для отслеживания режима экрана

    void Update()
    {
        // Проверяем нажатие клавиши F
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Переключаемся между полноэкранным и оконным режимами
            if (isFullscreen)
            {
                // Если в полноэкранном режиме, переключаемся в оконный
                Screen.fullScreen = false;
                isFullscreen = false;
            }
            else
            {
                // Если в оконном режиме, переключаемся в полноэкранный
                Screen.fullScreen = true;
                isFullscreen = true;
            }
        }
    }
}