using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulsatingObject : MonoBehaviour
{
    public float pulsationSpeed = 1.0f; // Скорость пульсации, которую можно настроить в инспекторе
    public float pulsationAmplitude = 0.1f; // Амплитуда пульсации, то насколько объект будет увеличиваться и уменьшаться

    private Vector3 initialScale; // Начальный размер объекта

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        // Используем Mathf.Sin для создания пульсации
        float pulsation = Mathf.Sin(Time.time * pulsationSpeed) * pulsationAmplitude;

        // Применяем пульсацию к размеру объекта
        transform.localScale = initialScale + new Vector3(pulsation, pulsation, 0);
    }
}