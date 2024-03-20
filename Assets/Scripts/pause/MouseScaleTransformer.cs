using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScaleTransformer : MonoBehaviour
{
    public float maxSizeMultiplier = 1.5f; // Множитель максимального размера
    public float changeSpeed = 5f; // Скорость изменения размера

    private Vector3 initialScale;
    private bool isMouseOver = false;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (isMouseOver)
        {
            // Увеличиваем размер плавно
            float newScaleX = Mathf.Lerp(transform.localScale.x, initialScale.x * maxSizeMultiplier, changeSpeed * Time.deltaTime);
            float newScaleY = Mathf.Lerp(transform.localScale.y, initialScale.y * maxSizeMultiplier, changeSpeed * Time.deltaTime);
            transform.localScale = new Vector3(newScaleX, newScaleY, transform.localScale.z);
        }
        else
        {
            // Возвращаемся к изначальному размеру плавно
            float newScaleX = Mathf.Lerp(transform.localScale.x, initialScale.x, changeSpeed * Time.deltaTime);
            float newScaleY = Mathf.Lerp(transform.localScale.y, initialScale.y, changeSpeed * Time.deltaTime);
            transform.localScale = new Vector3(newScaleX, newScaleY, transform.localScale.z);
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
