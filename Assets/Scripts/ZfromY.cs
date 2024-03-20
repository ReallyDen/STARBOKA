using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZfromY : MonoBehaviour
{
    // Задаем коэффициент для определения значения Z в зависимости от Y
    public float depthMultiplier = -0.5f;

    void Update()
    {
        // Получаем RectTransform компонент объекта
        RectTransform rectTransform = GetComponent<RectTransform>();

        // Получаем текущие координаты объекта
        Vector3 currentPosition = rectTransform.anchoredPosition3D;

        // Изменяем значение Z в зависимости от Y, используя коэффициент
        currentPosition.z = currentPosition.y * depthMultiplier;

        // Применяем новые координаты
        rectTransform.anchoredPosition3D = currentPosition;
    }
}